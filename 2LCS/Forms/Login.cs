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
            webBrowser1.Navigate($"{URIHandler.LCS_URL}/Logon/AdLogon");
        }

        private void WebBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            if (e.Url.ToString().StartsWith($"{URIHandler.LCS_URL}/v2"))
            {
                Cancelled = false;
                Close();
            }
        }
    }
}