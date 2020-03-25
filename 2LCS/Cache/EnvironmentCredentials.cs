using System.Collections.Generic;

namespace LCS.Cache
{
    class EnvironmentCredentials
    {
        public string EnvironmentId { get; set; }
        public Dictionary<string, string> Credentials { get; set; }

        public EnvironmentCredentials()
        {

        }
    }
      
}
