using System.Windows.Forms;

namespace LCS
{
    public class ExtendedWebBrowser : WebBrowser
    {
        private bool _renavigating;

        public ExtendedWebBrowser()
        {
            DocumentCompleted += SetupBrowser;

            //this will cause SetupBrowser to run (we need a document object)
            Navigate("about:blank");
        }

        public string UserAgent { get; set; }

        private void BeforeNavigate(object pDisp, ref object url, ref object flags, ref object targetFrameName,
            ref object postData, ref object headers, ref bool cancel)
        {
            if (!string.IsNullOrEmpty(UserAgent))
            {
                if (!_renavigating)
                {
                    headers += $"User-Agent: {UserAgent}\r\n";
                    _renavigating = true;
                    cancel = true;
                    Navigate((string)url, (string)targetFrameName, (byte[])postData, (string)headers);
                }
                else
                {
                    _renavigating = false;
                }
            }
        }

        private void PageLoaded(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
        }

        private void SetupBrowser(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            DocumentCompleted -= SetupBrowser;
            SHDocVw.WebBrowser xBrowser = (SHDocVw.WebBrowser)ActiveXInstance;
            xBrowser.BeforeNavigate2 += BeforeNavigate;
            DocumentCompleted += PageLoaded;
        }
    }
}