using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace LCS.Forms
{
    public partial class PowerShell : Form
    {
        public Dictionary<string, string> CredentialsDict { get; set; }

        public PowerShell()
        {
            InitializeComponent();
        }

        private void PowerShell_Load(object sender, EventArgs e)
        {
            var sbv1 = new StringBuilder();
            var sbv2 = new StringBuilder();

            sbv1.AppendLine("$params = @{}");
            sbv2.AppendLine("$params = @{");

            foreach (var item in CredentialsDict)
            {
                if(item.Key.ToString().Contains("\\"))
                {
                    continue;
                }

                var splitIndex = item.Key.ToString().LastIndexOf("-") +1 ;
                var name = item.Key.ToString().Substring(splitIndex , item.Key.ToString().Length - splitIndex);
                var value = item.Value;

                sbv1.AppendLine($"$params.{name} = \"{value}\"");
                sbv2.AppendLine($"{name} = \"{value}\";");
            }

            sbv2.AppendLine("}");

            textBox1.Text = sbv1.ToString();
            textBox1.Text += "\r\n\r\n#Or like this\r\n\r\n";
            textBox1.Text += sbv2.ToString();
        }
    }
}
