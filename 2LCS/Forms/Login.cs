using System;
using System.Windows.Forms;

namespace LCS.Forms
{
    public partial class Login : Form
    {
        internal bool Cancelled { get; private set; }
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Cancelled = true;
            webBrowser1.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/63.0.3239.132 Safari/537.36";
            webBrowser1.Navigate("https://lcs.dynamics.com");
        }

        private void WebBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            if (e.Url.ToString().StartsWith("https://lcs.dynamics.com/v2"))
            {
                Cancelled = false;
                Close();
            }
        }
    }
}
