﻿using HtmlAgilityPack;
using LCS.Cache;
using LCS.JsonObjects;
using LCS.Utils;
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
        private bool _disposed;
        private StringContent _stringContent;

        internal HttpClientHelper(CookieContainer cookieContainer)
        {
            //Use Tls1.2 as default transport layer
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            CookieContainer = cookieContainer;
            var httpClientHandler = new HttpClientHandler
            {
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
            _httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3872.0 Safari/537.36 Edg/78.0.244.0");
            _httpClient.DefaultRequestHeaders.Add("X-Requested-With", "XMLHttpRequest");
            _httpClient.DefaultRequestHeaders.Add("cache-control", "no-cache");
            _httpClient.DefaultRequestHeaders.Add("TimezoneOffset", GetTimeZoneOffsetInMinutes());
        }

        public CookieContainer CookieContainer { get; }
        public string LcsDiagUrl { get; set; }
        public string LcsProjectId { get; set; }
        public string LcsUpdateUrl { get; set; }
        public string LcsUrl { get; set; }
        public ProjectType LcsProjectTypeId { get; set; }

        public void ChangeLcsProjectId(string value)
        {
            LcsProjectId = value;
            var cookiesLcs = CookieContainer.GetCookies(new Uri(LcsUrl));
            var cookiesUpdateLcs = CookieContainer.GetCookies(new Uri(LcsUpdateUrl));
            foreach (Cookie cookie in cookiesLcs)
            {
                if (cookie.Name == "lcspid")
                {
                    cookie.Expired = true;
                }
            }
            foreach (Cookie cookie in cookiesUpdateLcs)
            {
                if (cookie.Name == "lcspid")
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

        /// <summary>
        /// Dispose
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public string GetEnvironmentDetailsUrl(CloudHostedInstance instance)
        {
            return $"{LcsUrl}/V2/EnvironmentDetailsV3New/{LcsProjectId}?EnvironmentId={instance.EnvironmentId}&IsDiagnosticsEnabledEnvironment={instance.IsDiagnosticsEnabledEnvironment}";
        }

        public void SetRequestVerificationToken(string url)
        {
            if (!_httpClient.DefaultRequestHeaders.Contains("__RequestVerificationToken"))
            {
                var getResponse = _httpClient.GetAsync(url).Result;
                getResponse.EnsureSuccessStatusCode();
                var html = getResponse.Content.ReadAsStringAsync().Result;
                HtmlDocument doc = new HtmlDocument();
                doc.LoadHtml(html);
                var node = doc.DocumentNode.SelectSingleNode("//input[@name='__RequestVerificationToken']");
                if (node == null) return;
                var token = node.Attributes["value"].Value;
                _httpClient.DefaultRequestHeaders.Add("__RequestVerificationToken", token);
            }
        }

        internal async Task<bool> AddNsgRule(CloudHostedInstance instance, string ruleName, string ipOrCidr)
        {
            string parameters, url;
            if(GetDeploymentEnvironmentTypeInfo(instance.EnvironmentId) == DeploymentEnvironmentType.MicrosoftManagedServiceFabric)
            {
                parameters = $"lcsEnvironmentId={instance.EnvironmentId}&newRuleName={ruleName}&newRuleIpOrCidr={ipOrCidr}&newRuleService=AzureSQL";
                url = $"{LcsUrl}/EnvironmentServicingV2/SFAddNetworkSecurityRule/{LcsProjectId}";
            }
            else
            {
                parameters = $"lcsEnvironmentId={instance.EnvironmentId}&newRuleName={ruleName}&newRuleIpOrCidr={ipOrCidr}&newRuleService=RDP";
                url = $"{LcsUrl}/Environment/AddNetworkSecurityRule/{LcsProjectId}";
            }
            using (_stringContent = new StringContent(parameters, Encoding.UTF8, "application/x-www-form-urlencoded"))
            {
                SetRequestVerificationToken($"{LcsUrl}/V2");
                var result = await _httpClient.PostAsync(url, _stringContent);
                result.EnsureSuccessStatusCode();
                var responseBody = result.Content.ReadAsStringAsync().Result;
                var response = JsonConvert.DeserializeObject<Response>(responseBody);
                return response.Success;
            }
        }

        internal string ApplyPackage(CloudHostedInstance instance, DeployablePackage package)
        {
            StringBuilder log = new StringBuilder();
            package.LcsEnvironmentId = instance.EnvironmentId;
            var validationResponse = ValidateSandboxServicing(package);

            if (validationResponse.Success && !string.IsNullOrEmpty(validationResponse.Data.ToString()))
            {
                string platformRelease;
                try
                {
                    var releaseVersion = JsonConvert.DeserializeObject<ValidateSandboxServicingData>(validationResponse.Data.ToString());
                    platformRelease = releaseVersion.PlatformRelease;
                }
                catch
                {
                    platformRelease = validationResponse.Data.ToString();
                }
                log.AppendLine($"{instance.DisplayName}: Package deployment validation successful.");
                var deploymentResponse = StartSandboxServicing(package, platformRelease);
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

        internal async Task<bool> DeleteEnvironment(CloudHostedInstance instance)
        {
            var parameters = $"delete=&ActivityId={instance.ActivityId}&ProductName={WebUtility.UrlEncode(instance.ProductName)}&TopologyName={instance.TopologyName}&TopologyInstanceId={instance.InstanceId}&AzureSubscriptionId={instance.AzureSubscriptionId}&EnvironmentGroup=0&EnvironmentId={instance.EnvironmentId}&PreserveCustomerSignOff=false";
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

        internal async Task<string> DeleteNsgRule(CloudHostedInstance instance, string rule)
        {
            string url;
            if(GetDeploymentEnvironmentTypeInfo(instance.EnvironmentId) == DeploymentEnvironmentType.MicrosoftManagedServiceFabric)
            {
                url = $"{LcsUrl}/EnvironmentServicingV2/SFDeleteNetworkSecurityRules/{LcsProjectId}";
            }
            else
            {
                url = $"{LcsUrl}/Environment/DeleteNetworkSecurityRules/{LcsProjectId}";
            }
            var parameters = $"lcsEnvironmentId={instance.EnvironmentId}&rulesToDelete%5B%5D={rule}";
            using (_stringContent = new StringContent(parameters, Encoding.UTF8, "application/x-www-form-urlencoded"))
            {
                SetRequestVerificationToken($"{LcsUrl}/V2");
                var result = await _httpClient.PostAsync(url, _stringContent);
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

        internal async Task<List<LcsProject>> GetAllProjectsAsync()
        {
            const int numberOfProjectsRequested = 50;
            int numberOfProjectReturned;
            var allProjects = new List<LcsProject>();
            var pageNumber = 0;
            SetRequestVerificationToken($"{LcsUrl}/V2");
            do
            {
                pageNumber++;
                var pagingParams = new PagingParameters()
                {
                    DynamicPaging = new DynamicPaging()
                    {
                        StartPosition = pageNumber * numberOfProjectsRequested - numberOfProjectsRequested,
                        ItemsRequested = numberOfProjectsRequested
                    }
                };
                var pagingParamsJson = JsonConvert.SerializeObject(pagingParams, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });

                using (_stringContent = new StringContent(pagingParamsJson, Encoding.UTF8, "application/json"))
                {
                    var result = await _httpClient.PostAsync($"{LcsUrl}/RainierProject/AllProjectsList", _stringContent);
                    result.EnsureSuccessStatusCode();

                    var responseBody = await result.Content.ReadAsStringAsync();
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

        internal List<ProjectUser> GetAllProjectUsers()
        {
            const int numberOfUsersRequested = 50;
            int numberOfUsersReturned;
            var allUsers = new List<ProjectUser>();
            var pageNumber = 0;
            SetRequestVerificationToken($"{LcsUrl}/V2");
            do
            {
                pageNumber++;
                var pagingParams = new PagingParameters()
                {
                    DynamicPaging = new DynamicPaging()
                    {
                        StartPosition = pageNumber * numberOfUsersRequested - numberOfUsersRequested,
                        ItemsRequested = numberOfUsersRequested
                    }
                };
                var pagingParamsJson = JsonConvert.SerializeObject(pagingParams, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });

                using (_stringContent = new StringContent(pagingParamsJson, Encoding.UTF8, "application/json"))
                {
                    var result = _httpClient.PostAsync($"{LcsUrl}/RainierProjectUser/RetrieveProjectUsers/{LcsProjectId}", _stringContent).Result;
                    result.EnsureSuccessStatusCode();

                    var responseBody = result.Content.ReadAsStringAsync().Result;
                    var response = JsonConvert.DeserializeObject<Response>(responseBody);
                    if (response.Success && response.Data != null)
                    {
                        var users = JsonConvert.DeserializeObject<ProjectUsersData>(response.Data.ToString()).Results;
                        numberOfUsersReturned = users.Count;
                        allUsers.AddRange(users);
                    }
                    else
                    {
                        numberOfUsersReturned = 0;
                    }
                }
            }
            while (numberOfUsersReturned == numberOfUsersRequested);
            return allUsers;
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
                    kb.Url = $"{URIHandler.LCS_FIX_URL}/Issue/Details/{LcsProjectId}?kb={kb.KBNumber}&bugId={kb.BugNumber}";
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

        internal async Task<List<CloudHostedInstance>> GetCheInstancesAsync()
        {
            var result = await _httpClient.GetAsync($"{LcsUrl}/DeploymentPortal/GetDeployementDetails/{LcsProjectId}?_={DateTimeOffset.Now.ToUnixTimeSeconds()}");
            var list = new List<CloudHostedInstance>();
            if (!result.IsSuccessStatusCode) return list;
            result.EnsureSuccessStatusCode();

            var responseBody = await result.Content.ReadAsStringAsync();
            responseBody = responseBody.TrimStart('(');
            responseBody = responseBody.TrimEnd(')');

            try
            {
                var cloudHostedInstancesUnsorted = JsonConvert.DeserializeObject<Dictionary<string, CloudHostedInstance>>(responseBody);
                if (cloudHostedInstancesUnsorted != null)
                {
                    list.AddRange(cloudHostedInstancesUnsorted.Values.OrderBy(x => x.InstanceId));
                }
            }
            catch
            {
                return list;
            }
            return list;
        }

        internal async Task<List<CloudHostedInstance>> GetCheInstancesV2Async()
        {
            var result = await _httpClient.GetAsync($"{LcsUrl}/DeploymentPortal/GetAllCheDeploymentsMetadata/{LcsProjectId}?filterBy=null&filterValue=null&?_={DateTimeOffset.Now.ToUnixTimeSeconds()}");
            result.EnsureSuccessStatusCode();

            var responseBody = await result.Content.ReadAsStringAsync();
            var response = JsonConvert.DeserializeObject<Response>(responseBody);

            var list = new List<CloudHostedInstance>();
            if (response.Success)
            {
                if (response.Data == null) return list;

                var settings = new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    MissingMemberHandling = MissingMemberHandling.Ignore
                };
                var cloudHostedInstancesUnsorted = JsonConvert.DeserializeObject<Dictionary<string, CloudHostedInstance>>(response.Data.ToString(), settings);
                if (cloudHostedInstancesUnsorted != null)
                {
                    list.AddRange(cloudHostedInstancesUnsorted.Values.OrderBy(x => x.InstanceId));
                }
                return list;
            }
            return list;
        }

        internal Dictionary<string, string> GetCredentials(string environmentId, string itemName)
        {
            Dictionary<string, string> credentialsDic;

            if (CacheUtil.IsCachingEnabled())
            {
                credentialsDic = CredentialsCacheHelper.GetCredentialsCache(environmentId);

                if (credentialsDic != null)
                    return credentialsDic;
            }

            var result = _httpClient.GetAsync($"{LcsUrl}/DeploymentPortal/GetCredentials/{LcsProjectId}?environmentId={environmentId}&deploymentItemName={itemName}&_={DateTimeOffset.Now.ToUnixTimeSeconds()}").Result;
            result.EnsureSuccessStatusCode();
            var responseBody = result.Content.ReadAsStringAsync().Result;
            var response = JsonConvert.DeserializeObject<Response>(responseBody);

            if (response.Success && response.Data != null)
            {
                credentialsDic = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Data.ToString());

                if (CacheUtil.IsCachingEnabled())
                    CredentialsCacheHelper.AddCredentialsCache(environmentId, credentialsDic);

                return credentialsDic;
            }

            return null;
        }

        internal string GetDiagEnvironmentId(CloudHostedInstance instance)
        {
            var result = _httpClient.GetAsync($"{LcsUrl}/Environment/GetDiagEnvironmentId/{LcsProjectId}?environmentId={instance.EnvironmentId}&_={DateTimeOffset.Now.ToUnixTimeSeconds()}").Result;
            result.EnsureSuccessStatusCode();
            var responseBody = result.Content.ReadAsStringAsync().Result;
            var response = JsonConvert.DeserializeObject<Response>(responseBody);
            return response.Success && response.Data != null ? response.Data.ToString() : null;
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

        internal string GetEnvironmentBuildInfoDetailsUrl(CloudHostedInstance instance, string environmentId)
        {
            return $"{LcsDiagUrl}/BuildInfo/GetEnvironmentBuildInfoDetails/{LcsProjectId}?lcsEnvironmentId={instance.EnvironmentId}&environmentId={environmentId}&_={DateTimeOffset.Now.ToUnixTimeSeconds()}";
        }

        internal string GetEnvironmentBuildInfoIdUrl(CloudHostedInstance instance)
        {
            return $"{LcsDiagUrl}/BuildInfo/GetEnvironments/{LcsProjectId}?lcsEnvironmentId={instance.EnvironmentId}&environmentId=0&_={DateTimeOffset.Now.ToUnixTimeSeconds()}";
        }

        internal NetworkSecurityGroup GetNetworkSecurityGroup(CloudHostedInstance instance)
        {
            try
            {
                string url;
                if(GetDeploymentEnvironmentTypeInfo(instance.EnvironmentId) == DeploymentEnvironmentType.MicrosoftManagedServiceFabric)
                {
                    url = $"{LcsUrl}/EnvironmentServicingV2/SFGetNetworkSecurityGroup/{LcsProjectId}?lcsEnvironmentId={instance.EnvironmentId}&_={DateTimeOffset.Now.ToUnixTimeSeconds()}";
                }
                else
                {
                    url = $"{LcsUrl}/Environment/GetNetworkSecurityGroup/{LcsProjectId}?lcsEnvironmentId={instance.EnvironmentId}&_={DateTimeOffset.Now.ToUnixTimeSeconds()}";
                }
                
                var result = _httpClient.GetAsync(url).Result;
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
                var pagingParams = new PagingParameters()
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

        internal ProjectData GetProject(string projectId)
        {
            var result = _httpClient.GetAsync($"{LcsUrl}/RainierProject/GetProject/{projectId}?_={DateTimeOffset.Now.ToUnixTimeSeconds()}").Result;
            result.EnsureSuccessStatusCode();

            var responseBody = result.Content.ReadAsStringAsync().Result;
            var response = JsonConvert.DeserializeObject<Response>(responseBody);
            return !response.Success
                ? null
                : response.Data == null ? null : JsonConvert.DeserializeObject<ProjectData>(response.Data.ToString());
        }

        internal async Task<CloudHostedInstance> GetHostedDeploymentDetailAsync(HostedDeploymentInstance instance)
        {
            if (instance.DeploymentEnvironmentType != DeploymentEnvironmentType.MicrosoftManagedServiceFabric)
            {
                return await GetHostedDeploymentDetailAsync(await _httpClient.GetAsync($"{LcsUrl}/SaaSDeployment/GetDeploymentDetail/{LcsProjectId}/?environmentId={instance.EnvironmentId}&_={DateTimeOffset.Now.ToUnixTimeSeconds()}"));
            }
            else
            {
                return await GetHostedDeploymentDetailAsync(await _httpClient.GetAsync($"{LcsUrl}/ServiceFabricDeployment/GetEnvironmentDetails/{LcsProjectId}/?environmentId={instance.EnvironmentId}&_={DateTimeOffset.Now.ToUnixTimeSeconds()}"));
            }
        }

        private async Task<CloudHostedInstance> GetHostedDeploymentDetailAsync(HttpResponseMessage result)
        {
            result.EnsureSuccessStatusCode();

            var responseBody = await result.Content.ReadAsStringAsync();
            var response = JsonConvert.DeserializeObject<Response>(responseBody);
            return !response.Success
                ? null
                : response.Data == null ? null : JsonConvert.DeserializeObject<CloudHostedInstance>(response.Data.ToString());
        }

        internal async Task<List<CloudHostedInstance>> GetHostedInstancesAsync()
        {
            if (LcsProjectTypeId != ProjectType.ServiceFabricImplementation)
            {
                return await GetHostedInstancesAsync(await _httpClient.GetAsync($"{LcsUrl}/SaasDeployment/GetDeploymentSummary/{LcsProjectId}?_={DateTimeOffset.Now.ToUnixTimeSeconds()}"));
            }
            else
            {
                return await GetHostedInstancesAsync(await _httpClient.GetAsync($"{LcsUrl}/ServiceFabricDeployment/GetDeploymentSummary/{LcsProjectId}?_={DateTimeOffset.Now.ToUnixTimeSeconds()}"));
            }
        }

        private async Task<List<CloudHostedInstance>> GetHostedInstancesAsync(HttpResponseMessage result)
        {
            result.EnsureSuccessStatusCode();

            var responseBody = await result.Content.ReadAsStringAsync();
            var response = JsonConvert.DeserializeObject<Response>(responseBody);
            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore
            };
            var list = new List<CloudHostedInstance>();
            if (!response.Success) return list;
            {
                if (response.Data == null) return list;
                var instances = JsonConvert.DeserializeObject<List<HostedInstance>>(response.Data.ToString(), settings);
                if (instances == null) return list;

                instances = instances.OrderBy(x => x.DisplayOrder).ToList();//Sort according to display order
                
                foreach (var item in instances)
                {
                    foreach (var instance in item.DeploymentInstances)
                    {
                        if (!instance.IsDeployed) continue;
                        var details = await GetHostedDeploymentDetailAsync(instance);
                        if (details != null)
                        {
                            list.Add(details);
                        }
                    }
                }
            }
            return list;
        }

        internal Response StartSandboxServicing(DeployablePackage package, string platformVersion)
        {
            var parameters = $"package[PackageId]={package.PackageId}&package[Name]={package.Name}&package[Description]={package.Description}&package[packageType]={package.PackageType}&package[ModifiedDate]={package.ModifiedDate}&package[ModifiedBy]={package.ModifiedBy}&package[Publisher]={package.Publisher}&package[Scope]={package.Scope}&package[LcsEnvironmentActionId]={package.LcsEnvironmentActionId}&package[LcsEnvironmentId]={package.LcsEnvironmentId}&package[FileAssetDisplayVersion]={package.FileAssetDisplayVersion}&package[PlatformVersion]={package.PlatformVersion}&package[AppVersion]={package.AppVersion}&package[EstimatedDuration]={package.EstimatedDuration}&platformReleaseName={platformVersion}";
            using (_stringContent = new StringContent(parameters, Encoding.UTF8, "application/x-www-form-urlencoded"))
            {
                SetRequestVerificationToken($"{LcsUrl}/V2");
                var result = _httpClient.PostAsync($"{LcsUrl}/Environment/StartSandboxServicing/{LcsProjectId}", _stringContent).Result;
                result.EnsureSuccessStatusCode();
                var responseBody = result.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<Response>(responseBody);
            }
        }

        internal async Task<bool> StartStopDeployment(CloudHostedInstance instance, string action)
        {
            var parameters = $"{action}=&ActivityId={instance.ActivityId}&ProductName={WebUtility.UrlEncode(instance.ProductName)}&TopologyName={instance.TopologyName}&TopologyInstanceId={instance.InstanceId}&AzureSubscriptionId={instance.AzureSubscriptionId}&EnvironmentGroup=0";
            using (_stringContent = new StringContent(parameters, Encoding.UTF8, "application/x-www-form-urlencoded"))
            {
                SetRequestVerificationToken($"{LcsUrl}/V2");
                var result = await _httpClient.PostAsync($"{LcsUrl}/DeploymentPortal/StartStopDeployment/{LcsProjectId}", _stringContent);
                result.EnsureSuccessStatusCode();
                var responseBody = result.Content.ReadAsStringAsync().Result;
                return responseBody == "true";
            }
        }

        internal Response ValidateSandboxServicing(DeployablePackage package)
        {
            var parameters = $"package[PackageId]={package.PackageId}&package[Name]={package.Name}&package[Description]={package.Description}&package[packageType]={package.PackageType}&package[ModifiedDate]={package.ModifiedDate}&package[ModifiedBy]={package.ModifiedBy}&package[Publisher]={package.Publisher}&package[Scope]={package.Scope}&package[LcsEnvironmentActionId]={package.LcsEnvironmentActionId}&package[LcsEnvironmentId]={package.LcsEnvironmentId}&package[FileAssetDisplayVersion]={package.FileAssetDisplayVersion}&package[PlatformVersion]={package.PlatformVersion}&package[AppVersion]={package.AppVersion}&package[EstimatedDuration]={package.EstimatedDuration}";
            using (_stringContent = new StringContent(parameters, Encoding.UTF8, "application/x-www-form-urlencoded"))
            {
                SetRequestVerificationToken($"{LcsUrl}/V2");
                var result = _httpClient.PostAsync($"{LcsUrl}/Environment/ValidateSandboxServicing/{LcsProjectId}", _stringContent).Result;
                result.EnsureSuccessStatusCode();
                var responseBody = result.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<Response>(responseBody);
            }
        }

        private static string RemoveUnwantedTags(string data)
        {
            if (string.IsNullOrEmpty(data)) return string.Empty;

            var document = new HtmlDocument();
            document.LoadHtml(data);
            var acceptableTags = new string[] { };// { "strong", "em", "u"};
            var nodes = new Queue<HtmlNode>(document.DocumentNode.SelectNodes("./*|./text()"));
            while (nodes.Count > 0)
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

        internal PlanData RetrieveTenantPlans()
        {
            var result = _httpClient.GetAsync($"{LcsUrl}/RainierProject/RetrieveTenantPlans/{LcsProjectId}?_={DateTimeOffset.Now.ToUnixTimeSeconds()}").Result;
            result.EnsureSuccessStatusCode();

            var responseBody = result.Content.ReadAsStringAsync().Result;
            var response = JsonConvert.DeserializeObject<Response>(responseBody);
            return !response.Success
                ? null
                : response.Data == null ? null : JsonConvert.DeserializeObject<PlanData>(response.Data.ToString());
        }

        internal async Task<List<UpcomingCalendarViewModels>> GetUpcomingCalendarsAsync()
        {
            try
            {
                var result = await _httpClient.GetAsync($"{LcsUrl}/RainierSettings/GetUpcomingCalendars/{LcsProjectId}/?id={LcsProjectId}&_={DateTimeOffset.Now.ToUnixTimeSeconds()}");
                result.EnsureSuccessStatusCode();

                var responseBody = await result.Content.ReadAsStringAsync();
                dynamic response = JsonConvert.DeserializeObject<Response>(responseBody);
                return !response.Success
                    ? null
                    : response.Data == null ? null : JsonConvert.DeserializeObject<List<UpcomingCalendarViewModels>>(response.Data.UpcomingCalendarViewModels.ToString());
            }
            catch
            {
                return null;
            }
        }

        internal string GetTimeZoneOffsetInMinutes()
        {
            var offset = -TimeZoneInfo.Local.GetUtcOffset(DateTime.Now);//reverse sign
            return offset.TotalMinutes.ToString();
        }

        internal DeploymentEnvironmentType GetDeploymentEnvironmentTypeInfo(string environmentId)
        {
            var result = _httpClient.GetAsync($"{LcsUrl}/Environment/GetDeploymentEnvironmentTypeInfo/{LcsProjectId}?environmentId={environmentId}&_={DateTimeOffset.Now.ToUnixTimeSeconds()}").Result;
            result.EnsureSuccessStatusCode();
            var responseBody = result.Content.ReadAsStringAsync().Result;
            var response = JsonConvert.DeserializeObject<Response>(responseBody);
            if (response.Success && response.Data != null)
            {
                Enum.TryParse(response.Data.ToString(), out DeploymentEnvironmentType envType);
                return envType;
            }
            else
            {
                return DeploymentEnvironmentType.MicrosoftManagedIaas;
            }
        }

        internal List<ServiceToRestart> GetServicesToRestart()
        {
            var result = _httpClient.GetAsync($"{LcsUrl}/EnvironmentServicingV2/GetServicesToRestart/{LcsProjectId}?_={DateTimeOffset.Now.ToUnixTimeSeconds()}").Result;
            result.EnsureSuccessStatusCode();
            var responseBody = result.Content.ReadAsStringAsync().Result;
            var response = JsonConvert.DeserializeObject<Response>(responseBody);
            return !response.Success
                    ? null
                    : response.Data == null ? null : JsonConvert.DeserializeObject<List<ServiceToRestart>>(response.Data.ToString());
        }

        internal ServiceRestartResponseData RestartService(CloudHostedInstance instance, string serviceTorestart)
        {
            var parameters = $"lcsEnvironmentId={instance.EnvironmentId}&axServiceName={serviceTorestart}";
            using (_stringContent = new StringContent(parameters, Encoding.UTF8, "application/x-www-form-urlencoded"))
            {
                SetRequestVerificationToken($"{LcsUrl}/V2");
                var result = _httpClient.PostAsync($"{LcsUrl}/EnvironmentServicingV2/RestartService/{LcsProjectId}", _stringContent).Result;
                result.EnsureSuccessStatusCode();
                var responseBody = result.Content.ReadAsStringAsync().Result;
                var response = JsonConvert.DeserializeObject<Response>(responseBody);
                return !response.Success
                    ? null
                    : response.Data == null ? null : JsonConvert.DeserializeObject<ServiceRestartResponseData>(response.Data.ToString());
            }
        }

        internal async Task<ActionDetails> GetOngoingActionDetailsAsync(CloudHostedInstance instance)
        {
            var result = await _httpClient.GetAsync($"{LcsUrl}/Environment/GetOngoingActionDetails/{LcsProjectId}?environmentId={instance.EnvironmentId}");
            result.EnsureSuccessStatusCode();
            var responseBody = await result.Content.ReadAsStringAsync();
            var response = JsonConvert.DeserializeObject<Response>(responseBody);
            return !response.Success
                    ? null
                    : response.Data == null ? null : JsonConvert.DeserializeObject<ActionDetails>(response.Data.ToString());
        }

        internal async Task<List<ActionDetails>> GetEnvironmentHistoryDetailsAsync(CloudHostedInstance instance)
        {
            const int historyItemsCount = 40;

            var pagingParams = new PagingParameters()
            {
                DynamicPaging = new DynamicPaging()
                {
                    StartPosition = 0,
                    ItemsRequested = historyItemsCount
                }
            };
            var pagingParamsJson = JsonConvert.SerializeObject(pagingParams, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });

            using (_stringContent = new StringContent(pagingParamsJson, Encoding.UTF8, "application/json"))
            {
                SetRequestVerificationToken($"{LcsUrl}/V2");
                var result = await _httpClient.PostAsync($"{LcsUrl}/Environment/GetEnvironmentHistoryDetails/{LcsProjectId}?environmentId={instance.EnvironmentId}&_={DateTimeOffset.Now.ToUnixTimeSeconds()}", _stringContent);
                result.EnsureSuccessStatusCode();
                var settings = new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    MissingMemberHandling = MissingMemberHandling.Ignore
                };

                var responseBody = await result.Content.ReadAsStringAsync();
                var response = JsonConvert.DeserializeObject<Response>(responseBody);
                if (response.Success)
                {
                    var data = JsonConvert.DeserializeObject<EnvironmentHistoryDetailsData>(response.Data.ToString(), settings);
                    if (data != null)
                    {
                        return data.Results;
                    }
                }
                return null;
            }
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