using LCS.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Caching;
using Newtonsoft.Json;

namespace LCS.Cache
{
    class CredentialsCacheHelper
    {
        public static void AddCredentialsCache(string environmentId, Dictionary<string, string> credentialDict)
        {
            CacheUtil.Add(environmentId, credentialDict);
        }

        public static Dictionary<string, string> GetCredentialsCache(string environmentId)
        {
            return CacheUtil.Get<Dictionary<string, string>>(environmentId);
        }

        public static void SaveCredentialsOffline()
        {
            var EnvironmentCredentialCache = new CredentialsStore();

            MemoryCache.Default.ToList().ForEach(c =>
            {
                EnvironmentCredentialCache.EnvironmentCredentials.Add(new EnvironmentCredentials
                {
                    EnvironmentId = c.Key,
                    Credentials = (Dictionary<string, string>)c.Value
                });
            });

            var tempFile = Properties.Settings.Default.cachingStore;

            if (string.IsNullOrEmpty(tempFile))
            {
                tempFile = Path.GetTempFileName();

                try
                {
                    using var creationStream = File.Create(tempFile);

                    Properties.Settings.Default.cachingStore = tempFile;
                    Properties.Settings.Default.Save();
                }
                catch (Exception)
                {
                    throw;
                }
            }

            if(File.Exists(tempFile))
            {
                using(var writer = new StreamWriter(tempFile))
                {
                    writer.Write(JsonConvert.SerializeObject(EnvironmentCredentialCache));
                }
            }
        }

        public static void LoadOffLineCredentials()
        {
            CredentialsStore store;

            var tempFile = Properties.Settings.Default.cachingStore;

            if (string.IsNullOrEmpty(tempFile))
                return;

            if (!File.Exists(tempFile))
                return;

            try
            {
                using (var reader = new StreamReader(tempFile))
                {
                    var cache = reader.ReadToEnd();

                    store = JsonConvert.DeserializeObject<CredentialsStore>(cache);

                    store.RebuildMemCache();
                }
            }
            catch (Exception)
            {
                //deal with corrupted cache
                DisableCache();
                ClearCache();
            }
        }

        public static void DisableCache()
        {
            Properties.Settings.Default.cachingEnabled = false;
            Properties.Settings.Default.keepCache = false;
            Properties.Settings.Default.cachingStore = "";
            Properties.Settings.Default.Save();
        }


        public static string ClearCache()
        {
            var tempFile = Properties.Settings.Default.cachingStore;

            if (string.IsNullOrEmpty(tempFile))
                return null;

            try
            {
                File.Delete(tempFile);
                Properties.Settings.Default.cachingStore = "";
                Properties.Settings.Default.Save();
                
                return null;
            }
            catch (Exception ex)
            {
                DisableCache();
                return ex.Message;
            }
        }

    }
}
