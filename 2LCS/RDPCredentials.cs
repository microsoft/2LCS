using System;
using System.Diagnostics;
using System.Threading;

namespace LCS
{
    internal class RDPCredentials : IDisposable
    {
        private string Host { get; }

        public RDPCredentials(string Host, string UserName, string Password)
        {
            this.Host = Host;
            var cmdkey = new Process
            {
                StartInfo =
                {
                    FileName = Environment.ExpandEnvironmentVariables(@"%SystemRoot%\system32\cmdkey.exe"),
                    Arguments = $@"/generic:TERMSRV/{Host} /user:{UserName} /pass:{Password}",
                    WindowStyle = ProcessWindowStyle.Hidden
                }
            };
            cmdkey.Start();
        }

        private void DeleteEntry()
        {
            Thread.Sleep(10000);//Give it time before deleting credentials
            var cmdkey = new Process
            {
                StartInfo =
                {
                    FileName = Environment.ExpandEnvironmentVariables(@"%SystemRoot%\system32\cmdkey.exe"),
                    Arguments = $@"/delete:TERMSRV/{Host}",
                    WindowStyle = ProcessWindowStyle.Hidden
                }
            };
            cmdkey.Start();
        }

        public void Dispose()
        {
            if (Host != null)
            {
                var task = new Thread(DeleteEntry) ;
                task.Start() ;
            }
        }
    }
}
