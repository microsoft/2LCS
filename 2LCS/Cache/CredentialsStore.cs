using System.Collections.Generic;
using System.Linq;

namespace LCS.Cache
{
    class CredentialsStore
    {
            public List<EnvironmentCredentials> EnvironmentCredentials { get; set; }

            public CredentialsStore()
            {
                EnvironmentCredentials = new List<EnvironmentCredentials>();
            }

            public void RebuildMemCache()
            {
                if (EnvironmentCredentials == null)
                    return;

                if (!EnvironmentCredentials.Any())
                    return;

                foreach (var cachedCredential in EnvironmentCredentials)
                {
                    CredentialsCacheHelper.AddCredentialsCache(cachedCredential.EnvironmentId, cachedCredential.Credentials);
                }
            }
    }
}
