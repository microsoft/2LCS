using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Caching;

namespace LCS.Utils
{
    public class CacheUtil
    {
        public static void Add(string key, object o)
        {
            if (o == null)
                return;

            MemoryCache.Default.Add(key, o, new CacheItemPolicy { AbsoluteExpiration = DateTimeOffset.Now.AddDays(30) });
        }

        public static T Get<T>(string key)
        {
            return (T)MemoryCache.Default.Get(key);
        }
    }
}
