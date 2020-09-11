using System;
using System.Windows.Forms;

namespace LCS.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        internal bool Cancelled { get; private set; }

        private void Login_Load(object sender, EventArgs e)
        {
            Cancelled = true;
            webBrowser1.Navigate("https://lcs.dynamics.com/Logon/AdLogon");
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