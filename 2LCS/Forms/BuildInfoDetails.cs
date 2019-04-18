using LCS.JsonObjects;
using System;
using System.Linq;
using System.Linq.Dynamic;
using System.Windows.Forms;

namespace LCS.Forms
{
    public partial class BuildInfoDetailsForm : Form
    {
        public BuildInfoDetails BuildInfo;
        private bool _sortAscending;
        readonly BindingSource _buildInfoSource = new BindingSource();

        public BuildInfoDetailsForm()
        {
            InitializeComponent();
        }

        private void BuildInfoDetails_Load(object sender, EventArgs e)
        {
            buildInfoDetailsDataGridView.AutoGenerateColumns = false;
            if (!SystemInformation.TerminalServerSession)
            {
                var dgvType = buildInfoDetailsDataGridView.GetType();
                var pi = dgvType.GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
                if (pi != null) pi.SetValue(buildInfoDetailsDataGridView, true, null);
            }
            buildInfoDetailsDataGridView.Columns["InstalledDate"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";
            buildInfoDetailsDataGridView.DataSource = _buildInfoSource;
            _buildInfoSource.DataSource = BuildInfo.BuildInfoTreeView.OrderBy(f => f.ParentId).ThenBy(i => i.ModelName);
        }

        private void BuildInfoDetailsDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (buildInfoDetailsDataGridView.DataSource == null) return;
            _buildInfoSource.DataSource = _sortAscending ? BuildInfo.BuildInfoTreeView.OrderBy(buildInfoDetailsDataGridView.Columns[e.ColumnIndex].DataPropertyName).ToList() : BuildInfo.BuildInfoTreeView.OrderBy(buildInfoDetailsDataGridView.Columns[e.ColumnIndex].DataPropertyName).Reverse().ToList();
            _sortAscending = !_sortAscending;
        }
    }
}
