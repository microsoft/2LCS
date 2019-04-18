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
        private bool _sortAscending;
        readonly BindingSource _hotfixesSource = new BindingSource();

        public AvailableKBs()
        {
            InitializeComponent();
        }

        private void AvailableKBs_Load(object sender, EventArgs e)
        {
            availableKBsDataGridView.AutoGenerateColumns = false;
            if (!SystemInformation.TerminalServerSession)
            {
                var dgvType = availableKBsDataGridView.GetType();
                var pi = dgvType.GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
                if (pi != null) pi.SetValue(availableKBsDataGridView, true, null);
            }
            availableKBsDataGridView.Columns["ReleasedDate"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";
            availableKBsDataGridView.DataSource = _hotfixesSource;
            _hotfixesSource.DataSource = Hotfixes.OrderBy(f => f.ReleasedDate).ThenBy(i => i.KBNumber).Reverse();
        }

        private void AvailableKBsDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (availableKBsDataGridView.DataSource == null) return;
            _hotfixesSource.DataSource = _sortAscending ? Hotfixes.OrderBy(availableKBsDataGridView.Columns[e.ColumnIndex].DataPropertyName).ToList() : Hotfixes.OrderBy(availableKBsDataGridView.Columns[e.ColumnIndex].DataPropertyName).Reverse().ToList();
            _sortAscending = !_sortAscending;
        }
    }
}
