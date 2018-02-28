using LCS.JsonObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System.Windows.Forms;

namespace LCS.Forms
{
    public partial class AvailableKBs : Form
    {
        public List<Hotfix> Hotfixes;
        internal HttpClientHelper HttpClientHelper { get; set; }

        private bool sortAscending = false;
        BindingSource hotfixesSource = new BindingSource();

        public AvailableKBs()
        {
            InitializeComponent();
        }

        private void AvailableKBs_Load(object sender, EventArgs e)
        {
            availableKBsDataGridView.AutoGenerateColumns = false;
            if (!SystemInformation.TerminalServerSession)
            {
                Type dgvType = availableKBsDataGridView.GetType();
                System.Reflection.PropertyInfo pi = dgvType.GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
                pi.SetValue(availableKBsDataGridView, true, null);
            }
            availableKBsDataGridView.DataSource = hotfixesSource;
            hotfixesSource.DataSource = Hotfixes.OrderBy(f => f.ReleasedDate).ThenBy(i => i.KBNumber).Reverse();
        }

        private void DataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (availableKBsDataGridView.DataSource != null)
            {
                if (sortAscending)
                    hotfixesSource.DataSource = Hotfixes.OrderBy(availableKBsDataGridView.Columns[e.ColumnIndex].DataPropertyName).ToList();
                else
                    hotfixesSource.DataSource = Hotfixes.OrderBy(availableKBsDataGridView.Columns[e.ColumnIndex].DataPropertyName).Reverse().ToList();
                sortAscending = !sortAscending;
            }
        }
    }
}
