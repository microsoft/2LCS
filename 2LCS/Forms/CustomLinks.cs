using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System.Windows.Forms;

namespace LCS.Forms
{
    public partial class CustomLinks : Form
    {
        private const int CpNocloseButton = 0x200;
        private readonly BindingSource _linksSource = new BindingSource();
        private List<JsonObjects.CustomLink> _linksList;
        private bool _sortAscending = true;

        public CustomLinks()
        {
            InitializeComponent();
        }

        internal bool Cancelled { get; private set; }

        protected override CreateParams CreateParams
        {
            get
            {
                var myCp = base.CreateParams;
                myCp.ClassStyle |= CpNocloseButton;
                return myCp;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.links = JsonConvert.SerializeObject(_linksList, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });
            Properties.Settings.Default.Save();
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Cancelled = true;
            Close();
        }

        private void CustomLinks_Load(object sender, EventArgs e)
        {
            linksDataGridView.AutoGenerateColumns = false;
            if (!SystemInformation.TerminalServerSession)
            {
                var dgvType = linksDataGridView.GetType();
                var pi = dgvType.GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
                if (pi != null) pi.SetValue(linksDataGridView, true, null);
            }
            _linksList = JsonConvert.DeserializeObject<List<JsonObjects.CustomLink>>(Properties.Settings.Default.links) ??
                         new List<JsonObjects.CustomLink>();
            _linksSource.DataSource = _linksList;
            linksDataGridView.DataSource = _linksSource;
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var count = linksDataGridView.SelectedRows.Count;
            if (count <= 0) return;
            for (var i = 0; i < count; i++)
            {
                if (!linksDataGridView.SelectedRows[0].IsNewRow)
                {
                    linksDataGridView.Rows.RemoveAt(linksDataGridView.SelectedRows[0].Index);
                }
            }
        }

        private void LinksDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (linksDataGridView.DataSource == null || _linksList == null) return;
            _linksSource.DataSource = _sortAscending ? _linksList.OrderBy(linksDataGridView.Columns[e.ColumnIndex].DataPropertyName).ToList() : _linksList.OrderBy(linksDataGridView.Columns[e.ColumnIndex].DataPropertyName).Reverse().ToList();
            _sortAscending = !_sortAscending;
            linksDataGridView.ClearSelection();
        }

        private void LinksDataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = linksDataGridView.HitTest(e.X, e.Y);
                if (hti.RowIndex >= 0 && linksDataGridView.Rows[hti.RowIndex].Selected != true)
                {
                    linksDataGridView.ClearSelection();
                    linksDataGridView.Rows[hti.RowIndex].Selected = true;
                }
            }
        }
    }
}