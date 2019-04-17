using HtmlAgilityPack;
using LCS.JsonObjects;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LCS
{
    internal sealed class HttpClientHelper : IDisposable
    {
        private readonly HttpClient _httpClient;
        public string LcsUrl { private get; set; }
        public string LcsUpdateUrl { private get; set; }
        public string LcsDiagUrl { private get; set; }

        public CookieContainer CookieContainer { get; }
        public string LcsProjectId { private get; set; }
        private bool _disposed;
        private StringContent _stringContent;

        internal HttpClientHelper(CookieContainer cookieContainer)
        {
            //Use Tls1.2 as default transport layer
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            CookieContainer = cookieContainer;
            var httpClientHandler = new HttpClientHandler {
                CookieContainer = CookieContainer,
                AllowAutoRedirect = true,
                UseCookies = true,
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate
            };

            _httpClient = new HttpClient(httpClientHandler)
            {
                Timeout = TimeSpan.FromMinutes(5)
            };

            _httpClient.DefaultRequestHeaders.Add("Accept", "*/*");
            _httpClient.DefaultRequestHeaders.Add("Accept-Encoding", "gzip, deflate, br");
            _httpClient.DefaultRequestHeaders.Add("Accept-Language", "en-US,en;q=0.9");
            _httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/63.0.3239.132 Safari/537.36");
            _httpClient.DefaultRequestHeaders.Add("X-Requested-With", "XMLHttpRequest");
            _httpClient.DefaultRequestHeaders.Add("cache-control", "no-cache");
        }

        public void ChangeLcsProjectId(string value)
        {
            LcsProjectId = value;
            var cookiesLcs = CookieContainer.GetCookies(new Uri(LcsUrl));
            var cookiesUpdateLcs = CookieContainer.GetCookies(new Uri(LcsUpdateUrl));
            foreach (Cookie cookie in cookiesLcs)
            {
                if(cookie.Name == "lcspid")
                {
                    cookie.Expired = true;
                }
            }
            foreach (Cookie cookie in cookiesUpdateLcs)
            {
                if(cookie.Name == "lcspid")
                {
                    cookie.Expired = true;
                }
            }

            if (string.IsNullOrEmpty(LcsProjectId)) return;
            CookieContainer.Add(new Uri(LcsUrl), new Cookie("lcspid", LcsProjectId));
            CookieContainer.Add(new Uri(LcsUpdateUrl), new Cookie("lcspid", LcsProjectId));
            Properties.Settings.Default.cookie = CookieContainer.GetCookieHeader(new Uri(LcsUrl)).Replace(';', ',');
            Properties.Settings.Default.Save();
        }

        internal List<CloudHostedInstance> GetCheInstances()
        {
            var result = _httpClient.GetAsync($"{LcsUrl}/DeploymentPortal/GetDeployementDetails/{LcsProjectId}?_={DateTimeOffset.Now.ToUnixTimeSeconds()}").Result;
            var list = new List<CloudHostedInstance>();
            if (!result.IsSuccessStatusCode) return list;
            result.EnsureSuccessStatusCode();

            var responseBody = result.Content.ReadAsStringAsync().Result;
            responseBody = responseBody.TrimStart('(');
            responseBody = responseBody.TrimEnd(')');

            var cloudHostedInstancesUnsorted = JsonConvert.DeserializeObject<Dictionary<string, CloudHostedInstance>>(responseBody);
            if (cloudHostedInstancesUnsorted != null)
            {
                list.AddRange(cloudHostedInstancesUnsorted.Values.OrderBy(x => x.InstanceId));
            }
            return list;
        }

        internal List<CloudHostedInstance> GetCheInstancesV2()
        {
            var result = _httpClient.GetAsync($"{LcsUrl}/DeploymentPortal/GetAllCheDeploymentsMetadata/{LcsProjectId}?filterBy=null&filterValue=null&?_={DateTimeOffset.Now.ToUnixTimeSeconds()}").Result;
            result.EnsureSuccessStatusCode();

            var responseBody = result.Content.ReadAsStringAsync().Result;
            var response = JsonConvert.DeserializeObject<Response>(responseBody);

            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore
            };
            var list = new List<CloudHostedInstance>();
            if (response.Success)
            {
                if (response.Data == null) return list;

                var cloudHostedInstancesUnsorted = JsonConvert.DeserializeObject<Dictionary<string, CloudHostedInstance>>(response.Data.ToString(), settings);
                if (cloudHostedInstancesUnsorted != null)
                {
                    list.AddRange(cloudHostedInstancesUnsorted.Values.OrderBy(x => x.InstanceId));
                }
                return list;
            }
            return list;
        }

        internal List<CloudHostedInstance> GetSaasInstances()
        {
            var result = _httpClient.GetAsync($"{LcsUrl}/SaasDeployment/GetDeploymentSummary/{LcsProjectId}?_={DateTimeOffset.Now.ToUnixTimeSeconds()}").Result;
            result.EnsureSuccessStatusCode();

            var responseBody = result.Content.ReadAsStringAsync().Result;
            var response = JsonConvert.DeserializeObject<Response>(responseBody);
            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore
            };
            var list = new List<CloudHostedInstance>();
            if (!response.Success) return list.OrderBy(x => x.InstanceId).ToList();
            {
                if (response.Data == null) return list.OrderBy(x => x.InstanceId).ToList();
                var instances = JsonConvert.DeserializeObject<List<SaasInstance>>(response.Data.ToString(), settings);
                if (instances == null) return list.OrderBy(x => x.InstanceId).ToList();
                foreach (var item in instances)
                {
                    foreach (var instance in item.DeploymentInstances)
                    {
                        if (!instance.IsDeployed) continue;
                        var details = GetSaasDeploymentDetail(instance.EnvironmentId);
                        if (details != null)
                        {
                            list.Add(details);
                        }
                    }
                }
            }
            return list.OrderBy(x => x.InstanceId).ToList();
        }

        internal CloudHostedInstance GetSaasDeploymentDetail(string environmentId)
        {
            var result = _httpClient.GetAsync($"{LcsUrl}/SaaSDeployment/GetDeploymentDetail/{LcsProjectId}/?environmentId={environmentId}&_={DateTimeOffset.Now.ToUnixTimeSeconds()}").Result;
            result.EnsureSuccessStatusCode();

            var responseBody = result.Content.ReadAsStringAsync().Result;
            var response = JsonConvert.DeserializeObject<Response>(responseBody);
            return !response.Success
                ? null
                : response.Data == null ? null : JsonConvert.DeserializeObject<CloudHostedInstance>(response.Data.ToString());
        }

        internal List<RDPConnectionDetails> GetRdpConnectionDetails(CloudHostedInstance instance)
        {
            var list = new List<RDPConnectionDetails>();

            //check RDP availability
            foreach (var vm in instance.Instances)
            {
                var result = _httpClient.GetAsync($"{LcsUrl}/DeploymentPortal/IsRdpResourceAvailable/{LcsProjectId}/?topologyInstanceId={instance.InstanceId}&virtualMachineInstanceName={vm.MachineName}&deploymentItemName={vm.ItemName}&azureSubscriptionId={instance.AzureSubscriptionId}&group=0&isARMTopology={instance.IsARMTopology}&nsgWarningDisplayed=true&_={DateTimeOffset.Now.ToUnixTimeSeconds()}").Result;
                result.EnsureSuccessStatusCode();
                var responseBody = result.Content.ReadAsStringAsync().Result;
                var rdpPresentResponse = JsonConvert.DeserializeObject<Response>(responseBody);
                if (!rdpPresentResponse.Success) continue;
                _httpClient.DefaultRequestHeaders.Remove("Accept");
                _httpClient.DefaultRequestHeaders.Remove("X-Requested-With");
                _httpClient.DefaultRequestHeaders.Add("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8");
                _httpClient.DefaultRequestHeaders.Add("Upgrade-Insecure-Requests", "1");

                result = _httpClient.GetAsync($"{LcsUrl}/DeploymentPortal/IsRdpResourceAvailable/{LcsProjectId}/?topologyInstanceId={instance.InstanceId}&virtualMachineInstanceName={vm.MachineName}&deploymentItemName={vm.ItemName}&azureSubscriptionId={instance.AzureSubscriptionId}&group=0&isARMTopology={instance.IsARMTopology}&nsgWarningDisplayed=true&_={DateTimeOffset.Now.ToUnixTimeSeconds()}&isDownloadEnabled=True").Result;
                result.EnsureSuccessStatusCode();
                responseBody = result.Content.ReadAsStringAsync().Result;
                var line1 = responseBody.Split('\r', '\n').FirstOrDefault();
                if (line1 == null) continue;
                var splited = line1.Split(':');

                _httpClient.DefaultRequestHeaders.Remove("Accept");
                _httpClient.DefaultRequestHeaders.Add("Accept", "*/*");
                _httpClient.DefaultRequestHeaders.Add("X-Requested-With", "XMLHttpRequest");
                _httpClient.DefaultRequestHeaders.Remove("Upgrade-Insecure-Requests");

                vm.Credentials = GetCredentials(instance.EnvironmentId, vm.ItemName);

                var localAdmin = vm.Credentials.Where(x => x.Key.Contains("Local admin")).ToDictionary(x => x.Key, x => x.Value);
                if (localAdmin.Count == 1)
                {
                    var adminUsername = localAdmin.First().Key.Split('\\')[1];
                    var adminDomain = localAdmin.First().Key.Split('\\')[0].Split('-')[2];
                    var adminPassword = localAdmin.First().Value;
                    var rdp = new RDPConnectionDetails
                    {
                        Address = splited[2],
                        Port = splited[3],
                        Domain = adminDomain,
                        Username = adminUsername,
                        Password = adminPassword,
                        Machine = vm.MachineName
                    };
                    list.Add(rdp);
                }
                var localUser = vm.Credentials.Where(x => x.Key.Contains("Local user")).ToDictionary(x => x.Key, x => x.Value);
                if (localUser.Count == 1)
                {
                    var userUsername = localUser.First().Key.Split('\\')[1];
                    var userDomain = localUser.First().Key.Split('\\')[0].Split('-')[2];
                    var userPassword = localUser.First().Value;
                    var rdp = new RDPConnectionDetails
                    {
                        Address = splited[2],
                        Port = splited[3],
                        Domain = userDomain,
                        Username = userUsername,
                        Password = userPassword,
                        Machine = vm.MachineName
                    };
                    list.Add(rdp);
                }
            }
            return list;
        }

        internal async Task<string> DeleteNsgRule(CloudHostedInstance instance, string rule)
        {
            var parameters =  $"lcsEnvironmentId={instance.EnvironmentId}&rulesToDelete%5B%5D={rule}";
            using (_stringContent = new StringContent(parameters, Encoding.UTF8, "application/x-www-form-urlencoded"))
            {
                SetRequestVerificationToken($"{LcsUrl}/V2");
                var result = await _httpClient.PostAsync($"{LcsUrl}/Environment/DeleteNetworkSecurityRules/{LcsProjectId}", _stringContent);
                result.EnsureSuccessStatusCode();
                var responseBody = result.Content.ReadAsStringAsync().Result;
                var response = JsonConvert.DeserializeObject<Response>(responseBody);
                if (response.Success)
                {
                    return $"Successfully deleted firewall rule {rule} for instance {instance.DisplayName}";
                }
                else
                {
                    return $"Could not delete firewall rule {rule} for instance {instance.DisplayName}";
                }
            }
        }

        internal async Task<bool> StartStopDeployment(CloudHostedInstance instance, string action)
        {
            var parameters =  $"{action}=&ActivityId={instance.ActivityId}&ProductName={WebUtility.UrlEncode(instance.ProductName)}&TopologyName={instance.TopologyName}&TopologyInstanceId={instance.InstanceId}&AzureSubscriptionId={instance.AzureSubscriptionId}&EnvironmentGroup=0";
            using (_stringContent = new StringContent(parameters, Encoding.UTF8, "application/x-www-form-urlencoded"))
            {
                SetRequestVerificationToken($"{LcsUrl}/V2");
                var result = await _httpClient.PostAsync($"{LcsUrl}/DeploymentPortal/StartStopDeployment/{LcsProjectId}", _stringContent);
                result.EnsureSuccessStatusCode();
                var responseBody = result.Content.ReadAsStringAsync().Result;
                return responseBody == "true";
            }
        }

        internal async Task<bool> DeleteEnvironment(CloudHostedInstance instance)
        {
            var parameters =  $"delete=&ActivityId={instance.ActivityId}&ProductName={WebUtility.UrlEncode(instance.ProductName)}&TopologyName={instance.TopologyName}&TopologyInstanceId={instance.InstanceId}&AzureSubscriptionId={instance.AzureSubscriptionId}&EnvironmentGroup=0&EnvironmentId={instance.EnvironmentId}&PreserveCustomerSignOff=false";
            using (_stringContent = new StringContent(parameters, Encoding.UTF8, "application/x-www-form-urlencoded"))
            {
                SetRequestVerificationToken($"{LcsUrl}/V2");
                var result = await _httpClient.PostAsync($"{LcsUrl}/Environment/DeleteEnvironment/{LcsProjectId}", _stringContent);
                result.EnsureSuccessStatusCode();
                var responseBody = result.Content.ReadAsStringAsync().Result;
                var response = JsonConvert.DeserializeObject<Response>(responseBody);
                return response.Success;
            }
        }

        public void SetRequestVerificationToken(string url)
        {
            if (!_httpClient.DefaultRequestHeaders.Contains("__RequestVerificationToken"))
            {
                var getResponse = _httpClient.GetAsync(url).Result;
                var html = getResponse.Content.ReadAsStringAsync().Result;
                HtmlDocument doc = new HtmlDocument();
                doc.LoadHtml(html);
                var node = doc.DocumentNode.SelectSingleNode("//input[@name='__RequestVerificationToken']");
                if (node == null) return;
                var token = node.Attributes["value"].Value;
                _httpClient.DefaultRequestHeaders.Add("__RequestVerificationToken", token);
            }
        }

        public string GetEnvironmentDetailsUrl(CloudHostedInstance instance)
        {
            return $"{LcsUrl}/V2/EnvironmentDetailsV3New/{LcsProjectId}?EnvironmentId={instance.EnvironmentId}&IsDiagnosticsEnabledEnvironment={instance.IsDiagnosticsEnabledEnvironment}";
        }

        internal async Task<bool> AddNsgRule(CloudHostedInstance instance, string ruleName, string ipOrCidr)
        {
            var parameters =  $"lcsEnvironmentId={instance.EnvironmentId}&newRuleName={ruleName}&newRuleIpOrCidr={ipOrCidr}&newRuleService=RDP";
            using (_stringContent = new StringContent(parameters, Encoding.UTF8, "application/x-www-form-urlencoded"))
            {
                SetRequestVerificationToken($"{LcsUrl}/V2");
                var result = await _httpClient.PostAsync($"{LcsUrl}/Environment/AddNetworkSecurityRule/{LcsProjectId}", _stringContent);
                result.EnsureSuccessStatusCode();
                var responseBody = result.Content.ReadAsStringAsync().Result;
                var response = JsonConvert.DeserializeObject<Response>(responseBody);
                return response.Success;
            }
        }

        internal Dictionary<string, string> GetCredentials(string environmentId, string itemName)
        {
            var result = _httpClient.GetAsync($"{LcsUrl}/DeploymentPortal/GetCredentials/{LcsProjectId}?environmentId={environmentId}&deploymentItemName={itemName}&_={DateTimeOffset.Now.ToUnixTimeSeconds()}").Result;
            result.EnsureSuccessStatusCode();
            var responseBody = result.Content.ReadAsStringAsync().Result;
            var response = JsonConvert.DeserializeObject<Response>(responseBody);
            return response.Success && response.Data != null
                ? JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Data.ToString())
                : null;
        }

        internal List<Hotfix> GetAvailableHotfixes(string envId, int hotfixesType)
        {
            try
            {
                var result = _httpClient.GetAsync($"{LcsUpdateUrl}/cloudupdate/Results/{LcsProjectId}?query=&countries=&industries=&configKeys=&modules=&e={envId}&page=&t={hotfixesType}&_={DateTimeOffset.Now.ToUnixTimeSeconds()}").Result;
                result.EnsureSuccessStatusCode();
                var responseBody = result.Content.ReadAsStringAsync().Result;
                var response = JsonConvert.DeserializeObject<Response>(responseBody);
                if (!response.Success || response.Data == null) return null;
                var jObject = JObject.Parse(response.Data.ToString());
                var allResults = jObject.SelectToken("AllResults");
                var kbs = JsonConvert.DeserializeObject<List<Hotfix>>(allResults.ToString());
                foreach (var kb in kbs)
                {
                    kb.Url = $"https://fix.lcs.dynamics.com/Issue/Details/{LcsProjectId}?kb={kb.KBNumber}&bugId={kb.BugNumber}";
                    kb.Solution = RemoveUnwantedTags(kb.Solution);
                    kb.Title = RemoveUnwantedTags(kb.Title);
                }
                return kbs;
            }
            catch
            {
                return null;
            }
        }

        private static string RemoveUnwantedTags(string data)
        {
            if(string.IsNullOrEmpty(data)) return string.Empty;

            var document = new HtmlDocument();
            document.LoadHtml(data);
            var acceptableTags = new string[] { };// { "strong", "em", "u"};
            var nodes = new Queue<HtmlNode>(document.DocumentNode.SelectNodes("./*|./text()"));
            while(nodes.Count > 0)
            {
                var node = nodes.Dequeue();
                var parentNode = node.ParentNode;
                if (acceptableTags.Contains(node.Name) || node.Name == "#text") continue;
                var childNodes = node.SelectNodes("./*|./text()");
                if (childNodes != null)
                {
                    foreach (var child in childNodes)
                    {
                        nodes.Enqueue(child);
                        parentNode.InsertBefore(child, node);
                    }
                }
                parentNode.RemoveChild(node);
            }
            var result = document.DocumentNode.InnerHtml;
            result = Regex.Replace(result, @"&nbsp;|\r\n|\t|\n|\r", " ");
            result = Regex.Replace(result, @"&quot;", "\"");
            return result;
        }

        internal string GetDiagEnvironmentId(CloudHostedInstance instance)
        {
            var result = _httpClient.GetAsync($"{LcsUrl}/Environment/GetDiagEnvironmentId/{LcsProjectId}?environmentId={instance.EnvironmentId}&_={DateTimeOffset.Now.ToUnixTimeSeconds()}").Result;
            result.EnsureSuccessStatusCode();
            var responseBody = result.Content.ReadAsStringAsync().Result;
            var response = JsonConvert.DeserializeObject<Response>(responseBody);
            return response.Success && response.Data != null ? response.Data.ToString() : null;
        }

        internal List<LcsProject> GetAllProjects()
        {
            const int numberOfProjectsRequested = 50;
            int numberOfProjectReturned;
            var allProjects = new List<LcsProject>();
            var pageNumber = 0;
            SetRequestVerificationToken($"{LcsUrl}/V2");
            do
            {
                pageNumber++;
                var pagingParams = new ProjectsPaging()
                {
                    DynamicPaging = new DynamicPaging()
                    {
                        StartPosition = pageNumber * numberOfProjectsRequested - numberOfProjectsRequested,
                        ItemsRequested = numberOfProjectsRequested
                    }
                };
                var pagingParamsJson = JsonConvert.SerializeObject(pagingParams, new JsonSerializerSettings {TypeNameHandling = TypeNameHandling.Auto});

                using (_stringContent = new StringContent(pagingParamsJson, Encoding.UTF8, "application/json"))
                {
                    var result = _httpClient.PostAsync($"{LcsUrl}/RainierProject/AllProjectsList", _stringContent).Result;
                    result.EnsureSuccessStatusCode();

                    var responseBody = result.Content.ReadAsStringAsync().Result;
                    var response = JsonConvert.DeserializeObject<Response>(responseBody);
                    if (response.Success && response.Data != null)
                    {
                        var projects = JsonConvert.DeserializeObject<ProjectsData>(response.Data.ToString()).Results;
                        numberOfProjectReturned = projects.Count;
                        allProjects.AddRange(projects);
                    }
                    else
                    {
                        numberOfProjectReturned = 0;
                    }
                }
            }
            while (numberOfProjectReturned == numberOfProjectsRequested);
            return allProjects;
        }

        internal string GetEnvironmentBuildInfoDetailsUrl(CloudHostedInstance instance, string environmentId)
        {
            return $"{LcsDiagUrl}/BuildInfo/GetEnvironmentBuildInfoDetails/{LcsProjectId}?lcsEnvironmentId={instance.EnvironmentId}&environmentId={environmentId}&_={DateTimeOffset.Now.ToUnixTimeSeconds()}";
        }

        internal string GetEnvironmentBuildInfoIdUrl(CloudHostedInstance instance)
        {
            return $"{LcsDiagUrl}/BuildInfo/GetEnvironments/{LcsProjectId}?lcsEnvironmentId={instance.EnvironmentId}&environmentId=0&_={DateTimeOffset.Now.ToUnixTimeSeconds()}";
        }

        internal int GetBuildInfoEnvironmentId(CloudHostedInstance instance)
        {
            var result = _httpClient.GetAsync(GetEnvironmentBuildInfoIdUrl(instance)).Result;
            result.EnsureSuccessStatusCode();
            var responseBody = result.Content.ReadAsStringAsync().Result;
            var environments = JsonConvert.DeserializeObject<List<BuildInfoEnvironment>>(responseBody);
            if (environments != null && environments.Count > 0)
            {
                return environments.First().Value;
            }
            else
            {
                return 0;
            }
        }

        internal BuildInfoDetails GetEnvironmentBuildInfoDetails(CloudHostedInstance instance, string environmentId)
        {
            var result = _httpClient.GetAsync(GetEnvironmentBuildInfoDetailsUrl(instance, environmentId.ToString())).Result;
            result.EnsureSuccessStatusCode();
            var responseBody = result.Content.ReadAsStringAsync().Result;
            var response = JsonConvert.DeserializeObject<BuildInfoDetails>(responseBody);
            if (response != null)
            {
                response.BuildInfoTreeView.RemoveAll(x => x.ParentId == null);
            }
            return response;
        }

        internal List<DeployablePackage> GetPagedDeployablePackageList(CloudHostedInstance instance)
        {
            const int numberOfPackagesRequested = 50;
            int numberOfPackagesReturned;
            var packageList = new List<DeployablePackage>();
            var pageNumber = 0;
            SetRequestVerificationToken($"{LcsUrl}/V2");
            do
            {
                pageNumber++;
                var pagingParams = new ProjectsPaging()
                {
                    DynamicPaging = new DynamicPaging()
                    {
                        StartPosition = pageNumber * numberOfPackagesRequested - numberOfPackagesRequested,
                        ItemsRequested = numberOfPackagesRequested
                    }
                };
                var pagingParamsJson = JsonConvert.SerializeObject(pagingParams, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });

                using (_stringContent = new StringContent(pagingParamsJson, Encoding.UTF8, "application/json"))
                {
                    var result = _httpClient.PostAsync(GetPagedDeployablePackageListUrl(instance), _stringContent).Result;
                    result.EnsureSuccessStatusCode();

                    var responseBody = result.Content.ReadAsStringAsync().Result;
                    var response = JsonConvert.DeserializeObject<Response>(responseBody);
                    if (response.Success && response.Data != null)
                    {
                        var packages = JsonConvert.DeserializeObject<PackagesData>(response.Data.ToString()).Results;
                        numberOfPackagesReturned = packages.Count;
                        packageList.AddRange(packages);
                    }
                    else
                    {
                        numberOfPackagesReturned = 0;
                    }
                }
            }
            while (numberOfPackagesReturned == numberOfPackagesRequested);
            return packageList;
        }
        internal string GetPagedDeployablePackageListUrl(CloudHostedInstance instance)
        {
            return $"{LcsUrl}/Environment/GetPagedDeployablePackageList/{LcsProjectId}?lcsEnvironmentActionId=2&lcsEnvironmentId={instance.EnvironmentId}";
        }

        internal Response ValidateSandboxServicing(DeployablePackage package)
        {
            var parameters = $"package[PackageId]={package.PackageId}&package[Name]={package.Name}&package[Description]={package.Description}&package[packageType]={package.PackageType}&package[ModifiedDate]={package.ModifiedDate}&package[ModifiedBy]={package.ModifiedBy}&package[Publisher]={package.Publisher}&package[LcsEnvironmentActionId]={package.LcsEnvironmentActionId}&package[LcsEnvironmentId]={package.LcsEnvironmentId}&package[FileAssetDisplayVersion]={package.FileAssetDisplayVersion}&package[PlatformVersion]={package.PlatformVersion}";
            using (_stringContent = new StringContent(parameters, Encoding.UTF8, "application/x-www-form-urlencoded"))
            {
                SetRequestVerificationToken($"{LcsUrl}/V2");
                var result = _httpClient.PostAsync($"{LcsUrl}/Environment/ValidateSandboxServicing/{LcsProjectId}", _stringContent).Result;
                result.EnsureSuccessStatusCode();
                var responseBody = result.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<Response>(responseBody);
            }
        }
        internal Response StartSandboxServicing(DeployablePackage package, string platformVersion)
        {
            var parameters = $"package[PackageId]={package.PackageId}&package[Name]={package.Name}&package[Description]={package.Description}&package[packageType]={package.PackageType}&package[ModifiedDate]={package.ModifiedDate}&package[ModifiedBy]={package.ModifiedBy}&package[Publisher]={package.Publisher}&package[LcsEnvironmentActionId]={package.LcsEnvironmentActionId}&package[LcsEnvironmentId]={package.LcsEnvironmentId}&package[FileAssetDisplayVersion]={package.FileAssetDisplayVersion}&package[PlatformVersion]={package.PlatformVersion}&platformReleaseName={platformVersion}";
            using (_stringContent = new StringContent(parameters, Encoding.UTF8, "application/x-www-form-urlencoded"))
            {
                SetRequestVerificationToken($"{LcsUrl}/V2");
                var result = _httpClient.PostAsync($"{LcsUrl}/Environment/StartSandboxServicing/{LcsProjectId}", _stringContent).Result;
                result.EnsureSuccessStatusCode();
                var responseBody = result.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<Response>(responseBody);
            }
        }

        internal string ApplyPackage(CloudHostedInstance instance, DeployablePackage package)
        {
            StringBuilder log = new StringBuilder();
            package.LcsEnvironmentId = instance.EnvironmentId;
            var validationResponse = ValidateSandboxServicing(package);
            if (validationResponse.Success && !string.IsNullOrEmpty(validationResponse.Data.ToString()))
            {
                log.AppendLine($"{instance.DisplayName}: Package deployment validation successful.");
                var deploymentResponse = StartSandboxServicing(package, validationResponse.Data.ToString());
                log.AppendLine($"{instance.DisplayName}: {deploymentResponse.Message}");
                log.AppendLine();
            }
            else
            {
                log.AppendLine($"{instance.DisplayName}: Package deployment validation failed.");
                log.AppendLine($"{instance.DisplayName}: {validationResponse.Message}");
                log.AppendLine();
            }
            return log.ToString();
        }

        internal NetworkSecurityGroup GetNetworkSecurityGroup(CloudHostedInstance instance)
        {
            try
            {
                var result = _httpClient.GetAsync($"{LcsUrl}/Environment/GetNetworkSecurityGroup/{LcsProjectId}?lcsEnvironmentId={instance.EnvironmentId}&_={DateTimeOffset.Now.ToUnixTimeSeconds()}").Result;
                result.EnsureSuccessStatusCode();
                var responseBody = result.Content.ReadAsStringAsync().Result;
                var response = JsonConvert.DeserializeObject<Response>(responseBody);
                if (!response.Success || response.Data == null) return null;
                var settings = new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    MissingMemberHandling = MissingMemberHandling.Ignore
                };
                var NSG = JsonConvert.DeserializeObject<NetworkSecurityGroup>(response.Data.ToString(), settings);
                return NSG;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Dispose
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Dispose
        /// </summary>
        /// <param name="disposing">enable dispose</param>
        private void Dispose(bool disposing)
        {
            if (_disposed) return;
            _disposed = true;
            if (disposing)
            {
                _httpClient?.Dispose();
            }
        }
    }
}