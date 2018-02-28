using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LCS.Forms
{
    public partial class Credentials : Form
    {
        public Dictionary<string, string>CredentialsDict { get; set; }
        public string Caption { get; set; }
        public Credentials()
        {
            InitializeComponent();
        }

        private void Credentials_Load(object sender, EventArgs e)
        {
            Text = Caption;
            BindingSource bs = new BindingSource
            {
                DataSource = CredentialsDict
            };
            ;
            dataGridView1.DataSource = bs;
            dataGridView1.Columns[0].HeaderText = "Login";
            dataGridView1.Columns[1].HeaderText = "Password";
            bs.ResetBindings(false);
        }
    }
}
