using System;
using System.Windows.Forms;

namespace LCS.Forms
{
    public partial class DeleteNsg : Form
    {
        public string Rule { get; set; }
        public bool Cancelled { get; private set; }

        private const int CpNocloseButton = 0x200;

        public DeleteNsg()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                var myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CpNocloseButton;
                return myCp;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!ValidateRule())
            {
                Cancelled = true;
            }
            Close();
        }

        private bool ValidateRule()
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Rule name is empty.");
                return false;
            }
            Rule = textBox1.Text;
            return true;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Cancelled = true;
            Close();
        }
    }
}
