using LCS.JsonObjects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System.Windows.Forms;

namespace LCS.Forms
{
    public partial class ChooseProject : Form
    {
        internal bool Cancelled { get; private set; }
        public List<LcsProject> Projects;
        internal LcsProject LcsProject { get; private set; }
        internal HttpClientHelper HttpClientHelper { get; set; }
        private bool _sortAscending;
        readonly BindingSource _projectsSource = new BindingSource();

        private const int CpNocloseButton = 0x200;

        public ChooseProject()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                var myCp = base.CreateParams;
                myCp.ClassStyle |= CpNocloseButton;
                return myCp;
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.projects = JsonConvert.SerializeObject(Projects, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });
            Properties.Settings.Default.Save();
            if (projectsDataGridView.SelectedRows.Count > 0)
            {
                LcsProject = (LcsProject)projectsDataGridView.SelectedRows[0].DataBoundItem;
            }
            else
            {
                Cancelled = true;
            }
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Cancelled = true;
            Close();
        }

        private void ChooseProject_Load(object sender, EventArgs e)
        {
            projectsDataGridView.AutoGenerateColumns = false;
            if (!SystemInformation.TerminalServerSession)
            {
                var dgvType = projectsDataGridView.GetType();
                var pi = dgvType.GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
                if (pi != null) pi.SetValue(projectsDataGridView, true, null);
            }
            projectsDataGridView.DataSource = _projectsSource;
            Projects = JsonConvert.DeserializeObject<List<LcsProject>>(Properties.Settings.Default.projects);
            if(Projects != null)
            {
                _projectsSource.DataSource = Projects.OrderBy(f => f.Favorite).ThenBy(i => i.Id).Reverse();
            }
        }

        private void ProjectsDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (projectsDataGridView.DataSource == null) return;
            _projectsSource.DataSource = _sortAscending ? Projects.OrderBy(projectsDataGridView.Columns[e.ColumnIndex].DataPropertyName).ToList() : Projects.OrderBy(projectsDataGridView.Columns[e.ColumnIndex].DataPropertyName).Reverse().ToList();
            _sortAscending = !_sortAscending;
        }

        private void ProjectsDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Properties.Settings.Default.projects = JsonConvert.SerializeObject(Projects, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });
            Properties.Settings.Default.Save();
            if (projectsDataGridView.SelectedRows.Count > 0)
            {
                LcsProject = (LcsProject)projectsDataGridView.SelectedRows[0].DataBoundItem;
            }
            else
            {
                Cancelled = true;
            }
            Close();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            var favoritesSaved = new List<LcsProject>();
            if(Projects != null)
            {
                favoritesSaved = Projects.Where(x => x.Favorite == true).ToList();
            }
            Projects = HttpClientHelper.GetAllProjects();
            foreach(var savedProject in favoritesSaved)
            {
                Projects.Where(newProject => newProject.Id == savedProject.Id)
                    .Select(newProject => { newProject.Favorite = true; return newProject;} )
                        .ToList();
            }
            _projectsSource.DataSource = Projects.OrderBy(f => f.Favorite).ThenBy(i => i.Id).Reverse();
            _projectsSource.ResetBindings(false);
        }
    }
}
