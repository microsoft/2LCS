using System;
using System.Windows.Forms;

namespace LCS.Forms
{
    public partial class RDPDetails : Form
    {
        public string Caption { get; set; }
        public string Details { get; set; }
        public RDPDetails()
        {
            InitializeComponent();
        }

        private void Credentials_Load(object sender, EventArgs e)
        {
            textBox1.Text = Details;
        }
    }
}
