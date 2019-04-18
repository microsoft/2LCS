using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LCS.Forms
{
    public partial class Credentials : Form
    {
        public Dictionary<string, string>CredentialsDict { get; set; }
        public Credentials()
        {
            InitializeComponent();
        }

        private void Credentials_Load(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource
            {
                DataSource = CredentialsDict
            };
            credentialsDataGridView.DataSource = bs;
            credentialsDataGridView.Columns[0].HeaderText = "Login";
            credentialsDataGridView.Columns[1].HeaderText = "Password";
            bs.ResetBindings(false);
        }
    }
}
