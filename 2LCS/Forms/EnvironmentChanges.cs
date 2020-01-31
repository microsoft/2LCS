using LCS.JsonObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System.Windows.Forms;

namespace LCS.Forms
{
    public partial class EnvironmentChanges : Form
    {
        public List<ActionDetails> ActionDetails;
        private readonly BindingSource _actionDetailsSource = new BindingSource();
        private bool _sortAscending;

        public EnvironmentChanges()
        {
            InitializeComponent();
        }

        private void EnvironmentChanges_Load(object sender, EventArgs e)
        {
            environmentChangesDataGridView.AutoGenerateColumns = false;
            if (!SystemInformation.TerminalServerSession)
            {
                var dgvType = environmentChangesDataGridView.GetType();
                var pi = dgvType.GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
                if (pi != null) pi.SetValue(environmentChangesDataGridView, true, null);
            }
            //environmentChangesDataGridView.Columns["ReleasedDate"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";
            environmentChangesDataGridView.DataSource = _actionDetailsSource;
            _actionDetailsSource.DataSource = ActionDetails;//.OrderBy(f => f.ReleasedDate).ThenBy(i => i.KBNumber).Reverse();
        }

        private void EnvironmentChangesDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (environmentChangesDataGridView.DataSource == null) return;
            _actionDetailsSource.DataSource = _sortAscending ? ActionDetails.OrderBy(environmentChangesDataGridView.Columns[e.ColumnIndex].DataPropertyName).ToList() : ActionDetails.OrderBy(environmentChangesDataGridView.Columns[e.ColumnIndex].DataPropertyName).Reverse().ToList();
            _sortAscending = !_sortAscending;
        }
    }
}