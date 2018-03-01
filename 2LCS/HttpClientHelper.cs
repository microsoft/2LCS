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
using System.Threading.Tasks;

namespace LCS
{
    internal class HttpClientHelper : IDisposable
    {
        private readonly HttpClient _httpClient;
        private readonly HttpClientHandler _httpClientHandler;
        public string LcsUrl { get; set; }
        public string LcsUpdateUrl { get; set; }

        public CookieContainer CookieContainer { get; private set; }
        public string LcsProjectId { get; set; }
        private bool disposed;
        private StringContent _stringContent;

        internal HttpClientHelper(CookieContainer cookieContainer)
        {
            //Use Tls1.2 as default transport layer
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            CookieContainer = cookieContainer;
            _httpClientHandler = new HttpClientHandler {
                CookieContainer = CookieContainer,
                AllowAutoRedirect = true,
                UseCookies = true,
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate
            };

            _httpClient = new HttpClient(_httpClientHandler)
            {
                Timeout = TimeSpan.FromMinutes(1)
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
            if (!String.IsNullOrEmpty(LcsProjectId))
            {
                CookieContainer.Add(new Uri(LcsUrl), new Cookie("lcspid", LcsProjectId));
                CookieContainer.Add(new Uri(LcsUpdateUrl), new Cookie("lcspid", LcsProjectId));
                Properties.Settings.Default.cookie = CookieContainer.GetCookieHeader(new Uri(LcsUrl)).Replace(';', ',');
                Properties.Settings.Default.Save();
            }
        }

        internal List<CloudHostedInstance> GetCheInstances()
        {
            var result = _httpClient.GetAsync($"{LcsUrl}/DeploymentPortal/GetDeployementDetails/{LcsProjectId}?_={DateTimeOffset.Now.ToUnixTimeSeconds()}").Result;
            result.EnsureSuccessStatusCode();

            var responseBody = result.Content.ReadAsStringAsync().Result;
            responseBody = responseBody.TrimStart('(');
            responseBody = responseBody.TrimEnd(')');

            var cloudHostedInstancesUnsorted = JsonConvert.DeserializeObject<Dictionary<string, CloudHostedInstance>>(responseBody);

            List<CloudHostedInstance> list = new List<CloudHostedInstance>();
            if(cloudHostedInstancesUnsorted != null)
            {
                list.AddRange( cloudHostedInstancesUnsorted.Values.OrderBy(x => x.InstanceId));
            }
            return list;
        }

        internal List<CloudHostedInstance> GetSaasInstances()
        {
            var result = _httpClient.GetAsync($"{LcsUrl}/SAASDeployment/GetDeploymentSummary/{LcsProjectId}?_={DateTimeOffset.Now.ToUnixTimeSeconds()}").Result;
            result.EnsureSuccessStatusCode();

            var responseBody = result.Content.ReadAsStringAsync().Result;
            var response = JsonConvert.DeserializeObject<Response>(responseBody);

            //Not all LCS will have deployed their MS hosted environments. JsonConvert.DeserializeObject doesn't tolerate nulls be default.
            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore
            };

            if (response.Success)
            {
                if (response.Data != null)
                {
                    //Not all LCS will have deployed their MS hosted environments. JsonConvert.DeserializeObject doesn't tolerate nulls be default.
                    var instances = JsonConvert.DeserializeObject<List<SAASInstance>>(response.Data.ToString(), settings);

                    if (instances != null)
                    {
                        List<CloudHostedInstance> list = new List<CloudHostedInstance>();
                        foreach (var item in instances)
                        {
                            foreach (var instance in item.DeploymentInstances)
                            {
                                if (instance.IsDeployed == true)
                                {
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
                }
            }
            return null;
        }

        internal CloudHostedInstance GetSaasDeploymentDetail(string environmentId)
        {
            var result = _httpClient.GetAsync($"{LcsUrl}/SaaSDeployment/GetDeploymentDetail/{LcsProjectId}/?environmentId={environmentId}&_={DateTimeOffset.Now.ToUnixTimeSeconds()}").Result;
            result.EnsureSuccessStatusCode();

            var responseBody = result.Content.ReadAsStringAsync().Result;
            var response = JsonConvert.DeserializeObject<Response>(responseBody);
            if (response.Success)
            {
                if(response.Data == null)
                {
                    return null; ;
                }
                return JsonConvert.DeserializeObject<CloudHostedInstance>(response.Data.ToString());
            }
            else return null;
        }

        internal List<RDPConnectionDetails> GetRDPConnectionDetails(CloudHostedInstance instance)
        {
            List<RDPConnectionDetails> list = new List<RDPConnectionDetails>();

            //check RDP availability
            foreach (var vm in instance.Instances)
            {
                var result = _httpClient.GetAsync($"{LcsUrl}/DeploymentPortal/IsRdpResourceAvailable/{LcsProjectId}/?topologyInstanceId={instance.InstanceId}&virtualMachineInstanceName={vm.MachineName}&deploymentItemName={vm.ItemName}&azureSubscriptionId={instance.AzureSubscriptionId}&group=0&isARMTopology={instance.IsARMTopology}&nsgWarningDisplayed=false&_={DateTimeOffset.Now.ToUnixTimeSeconds()}").Result;
                result.EnsureSuccessStatusCode();
                var responseBody = result.Content.ReadAsStringAsync().Result;
                var rdpPresentResponse = JsonConvert.DeserializeObject<Response>(responseBody);
                if (rdpPresentResponse.Success == true)
                {
                    _httpClient.DefaultRequestHeaders.Remove("Accept");
                    _httpClient.DefaultRequestHeaders.Remove("X-Requested-With");
                    _httpClient.DefaultRequestHeaders.Add("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8");
                    _httpClient.DefaultRequestHeaders.Add("Upgrade-Insecure-Requests", "1");

                    result = _httpClient.GetAsync($"{LcsUrl}/DeploymentPortal/IsRdpResourceAvailable/{LcsProjectId}/?topologyInstanceId={instance.InstanceId}&virtualMachineInstanceName={vm.MachineName}&deploymentItemName={vm.ItemName}&azureSubscriptionId={instance.AzureSubscriptionId}&group=0&isARMTopology={instance.IsARMTopology}&nsgWarningDisplayed=false&_={DateTimeOffset.Now.ToUnixTimeSeconds()}&isDownloadEnabled=True").Result;
                    result.EnsureSuccessStatusCode();
                    responseBody = result.Content.ReadAsStringAsync().Result;
                    var line1 = responseBody.Split(new[] { '\r', '\n' }).FirstOrDefault();
                    var splited = line1.Split(new[] { ':' });

                    _httpClient.DefaultRequestHeaders.Remove("Accept");
                    _httpClient.DefaultRequestHeaders.Add("Accept", "*/*");
                    _httpClient.DefaultRequestHeaders.Add("X-Requested-With", "XMLHttpRequest");
                    _httpClient.DefaultRequestHeaders.Remove("Upgrade-Insecure-Requests");

                    vm.Credentials = GetCredentials(instance.EnvironmentId, vm.ItemName);

                    var localAdmin = vm.Credentials.Where(x => x.Key.Contains("Local admin")).ToDictionary(x => x.Key, x => x.Value);

                    var username = localAdmin.First().Key.Split(new[] { '\\' });
                    var domain = username[0].Split(new[] { '-' })[2];

                    RDPConnectionDetails rdp = new RDPConnectionDetails
                    {
                        Address = splited[2],
                        Port = splited[3],
                        Domain = domain,
                        Username = username[1],
                        Password = localAdmin.First().Value,
                        Machine = vm.MachineName
                    };
                    list.Add(rdp);
                }
            }
            return list;
        }

        internal async Task<bool> DeleteNSGRule(CloudHostedInstance instance, string rule)
        {
            var parameters =  $"lcsEnvironmentId={instance.EnvironmentId}&rulesToDelete%5B%5D={rule}";
            using (_stringContent = new StringContent(parameters, Encoding.UTF8, "application/x-www-form-urlencoded"))
            {
                SetRequestVerificationToken($"{LcsUrl}/V2/EnvironmentDetailsV3New/{LcsProjectId}?EnvironmentId={instance.EnvironmentId}&IsDiagnosticsEnabledEnvironment={instance.IsDiagnosticsEnabledEnvironment}");
                var result = await _httpClient.PostAsync($"{LcsUrl}/Environment/DeleteNetworkSecurityRules/{LcsProjectId}", _stringContent);
                result.EnsureSuccessStatusCode();
                _httpClient.DefaultRequestHeaders.Remove("__RequestVerificationToken");
                var responseBody = result.Content.ReadAsStringAsync().Result;
                var response = JsonConvert.DeserializeObject<Response>(responseBody);
                return response.Success;
            }
        }

        internal async Task<bool> StartStopDeployment(CloudHostedInstance instance, string action)
        {
            var parameters =  $"{action}=&ActivityId={instance.ActivityId}&ProductName={WebUtility.UrlEncode(instance.ProductName)}&TopologyName={instance.TopologyName}&TopologyInstanceId={instance.InstanceId}&AzureSubscriptionId={instance.AzureSubscriptionId}&EnvironmentGroup=0";
            using (_stringContent = new StringContent(parameters, Encoding.UTF8, "application/x-www-form-urlencoded"))
            {
                SetRequestVerificationToken($"{LcsUrl}/V2/EnvironmentDetailsV3New/{LcsProjectId}?EnvironmentId={instance.EnvironmentId}&IsDiagnosticsEnabledEnvironment={instance.IsDiagnosticsEnabledEnvironment}");
                var result = await _httpClient.PostAsync($"{LcsUrl}/DeploymentPortal/StartStopDeployment/{LcsProjectId}", _stringContent);
                result.EnsureSuccessStatusCode();
                _httpClient.DefaultRequestHeaders.Remove("__RequestVerificationToken");
                var responseBody = result.Content.ReadAsStringAsync().Result;
                return responseBody == "true";
            }
        }

        internal async Task<bool> DeleteEnvironment(CloudHostedInstance instance)
        {
            var parameters =  $"delete=&ActivityId={instance.ActivityId}&ProductName={WebUtility.UrlEncode(instance.ProductName)}&TopologyName={instance.TopologyName}&TopologyInstanceId={instance.InstanceId}&AzureSubscriptionId={instance.AzureSubscriptionId}&EnvironmentGroup=0&EnvironmentId={instance.EnvironmentId}&PreserveCustomerSignOff=false";
            using (_stringContent = new StringContent(parameters, Encoding.UTF8, "application/x-www-form-urlencoded"))
            {
                SetRequestVerificationToken($"{LcsUrl}/V2/EnvironmentDetailsV3New/{LcsProjectId}?EnvironmentId={instance.EnvironmentId}&IsDiagnosticsEnabledEnvironment={instance.IsDiagnosticsEnabledEnvironment}");
                var result = await _httpClient.PostAsync($"{LcsUrl}/Environment/DeleteEnvironment/{LcsProjectId}", _stringContent);
                result.EnsureSuccessStatusCode();
                _httpClient.DefaultRequestHeaders.Remove("__RequestVerificationToken");
                var responseBody = result.Content.ReadAsStringAsync().Result;
                var response = JsonConvert.DeserializeObject<Response>(responseBody);
                return response.Success;
            }
        }

        private void SetRequestVerificationToken(string url)
        {
            var getResponse = _httpClient.GetAsync(url).Result;
            var html = getResponse.Content.ReadAsStringAsync().Result;
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(html);
            var node = doc.DocumentNode.SelectSingleNode("//input[@name='__RequestVerificationToken']");
            if (node != null)
            {
                var token =  node.Attributes["value"].Value;
                _httpClient.DefaultRequestHeaders.Add("__RequestVerificationToken", token);
            }
        }

        public string GetEnvironmentDetailsUrl(CloudHostedInstance instance)
        {
            return $"{LcsUrl}/V2/EnvironmentDetailsV3New/{LcsProjectId}?EnvironmentId={instance.EnvironmentId}&IsDiagnosticsEnabledEnvironment={instance.IsDiagnosticsEnabledEnvironment}";
        }

        internal async Task<bool> AddNSGRule(CloudHostedInstance instance, string ruleName, string ipOrCidr)
        {
            var parameters =  $"lcsEnvironmentId={instance.EnvironmentId}&newRuleName={ruleName}&newRuleIpOrCidr={ipOrCidr}&newRuleService=RDP";
            using (_stringContent = new StringContent(parameters, Encoding.UTF8, "application/x-www-form-urlencoded"))
            {
                SetRequestVerificationToken(GetEnvironmentDetailsUrl(instance));
                var result = await _httpClient.PostAsync($"{LcsUrl}/Environment/AddNetworkSecurityRule/{LcsProjectId}", _stringContent);
                result.EnsureSuccessStatusCode();
                _httpClient.DefaultRequestHeaders.Remove("__RequestVerificationToken");
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
            if (response.Success == true && response.Data != null)
            {
                return JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Data.ToString());
            }
            else
                return null;
        }

        internal List<Hotfix> GetAvailableHotfixes(string envId, int hotfixesType)
        {
            try
            {
                var result = _httpClient.GetAsync($"{LcsUpdateUrl}/cloudupdate/Results/{LcsProjectId}?query=&countries=&industries=&configKeys=&modules=&e={envId}&page=&t={hotfixesType}&_={DateTimeOffset.Now.ToUnixTimeSeconds()}").Result;
                result.EnsureSuccessStatusCode();
                var responseBody = result.Content.ReadAsStringAsync().Result;
                var response = JsonConvert.DeserializeObject<Response>(responseBody);
                if (response.Success == true && response.Data != null)
                {
                    var jObject = JObject.Parse(response.Data.ToString());
                    var allResults = jObject.SelectToken("AllResults");
                    var kbs = JsonConvert.DeserializeObject<List<Hotfix>>(allResults.ToString());
                    foreach (var kb in kbs)
                    {
                        kb.Url = $"https://fix.lcs.dynamics.com/Issue/Details/{LcsProjectId}?kb={kb.KBNumber}&bugId={kb.BugNumber}";
                        kb.Solution = RemoveUnwantedTags(kb.Solution);
                    }
                    return kbs;
                }
                else
                    return null;
            }
            catch
            {
                return null;
            }
        }

        internal static string RemoveUnwantedTags(string data)
        {
            if(string.IsNullOrEmpty(data)) return string.Empty;

            var document = new HtmlDocument();
            document.LoadHtml(data);
            var acceptableTags = new String[] { };// { "strong", "em", "u"};
            var nodes = new Queue<HtmlNode>(document.DocumentNode.SelectNodes("./*|./text()"));
            while(nodes.Count > 0)
            {
                var node = nodes.Dequeue();
                var parentNode = node.ParentNode;
                if(!acceptableTags.Contains(node.Name) && node.Name != "#text")
                {
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
            }
            return document.DocumentNode.InnerHtml;
        }

        internal string GetDiagEnvironmentId(CloudHostedInstance instance)
        {
            var result = _httpClient.GetAsync($"{LcsUrl}/Environment/GetDiagEnvironmentId/{LcsProjectId}?environmentId={instance.EnvironmentId}&_={DateTimeOffset.Now.ToUnixTimeSeconds()}").Result;
            result.EnsureSuccessStatusCode();
            var responseBody = result.Content.ReadAsStringAsync().Result;
            var response = JsonConvert.DeserializeObject<Response>(responseBody);
            if (response.Success == true && response.Data != null)
            {
                return response.Data.ToString();
            }
            else
                return null;
        }

        internal List<LcsProject> GetAllProjects()
        {
            var pagingParams = new ProjectsPaging()
            {
                DynamicPaging = new DynamicPaging()
                {
                    StartPosition = 0,
                    ItemsRequested = 50
                }
            };
            string pagingParamsJson = JsonConvert.SerializeObject(pagingParams, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });

            var projects = new List<LcsProject>();
            using (_stringContent = new StringContent(pagingParamsJson, Encoding.UTF8, "application/json"))
            {
                SetRequestVerificationToken($"{LcsUrl}/V2");
                var result = _httpClient.PostAsync($"{LcsUrl}/RainierProject/AllProjectsList", _stringContent).Result;
                result.EnsureSuccessStatusCode();

                var responseBody = result.Content.ReadAsStringAsync().Result;
                var response = JsonConvert.DeserializeObject<Response>(responseBody);
                if (response.Success)
                {
                    if(response.Data == null)
                    {
                        return null; ;
                    }
                    projects = JsonConvert.DeserializeObject<ProjectsData>(response.Data.ToString()).Results;
                }
            }
            _httpClient.DefaultRequestHeaders.Remove("__RequestVerificationToken");
            return projects;
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
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                disposed = true;
                if (disposing)
                {
                    if (_httpClient != null)
                    {
                        _httpClient.Dispose();
                    }
                }
            }
        }
    }
}