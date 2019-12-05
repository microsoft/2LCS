using System;
using System.Diagnostics;
using System.Threading;

namespace LCS
{
    internal class RdpCredentials : IDisposable
    {
        public RdpCredentials(string host, string userName, string password)
        {
            Host = host;
            var cmdkey = new Process
            {
                StartInfo =
                {
                    FileName = Environment.ExpandEnvironmentVariables(@"%SystemRoot%\system32\cmdkey.exe"),
                    Arguments = $@"/generic:TERMSRV/{host} /user:{userName} /pass:{password}",
                    WindowStyle = ProcessWindowStyle.Hidden
                }
            };
            cmdkey.Start();
        }

        private string Host { get; }

        public void Dispose()
        {
            if (Host != null)
            {
                var task = new Thread(DeleteEntry);
                task.Start();
            }
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
    }
}