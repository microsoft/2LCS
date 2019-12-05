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
        public List<LcsProject> Projects;
        private const int CpNocloseButton = 0x200;
        private readonly BindingSource _projectsSource = new BindingSource();
        private bool _sortAscending;

        public ChooseProject()
        {
            InitializeComponent();
        }

        internal bool Cancelled { get; private set; }
        internal HttpClientHelper HttpClientHelper { get; set; }
        internal LcsProject LcsProject { get; private set; }

        protected override CreateParams CreateParams
        {
            get
            {
                var myCp = base.CreateParams;
                myCp.ClassStyle |= CpNocloseButton;
                return myCp;
            }
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
            if (Projects != null)
            {
                _projectsSource.DataSource = Projects.OrderBy(f => f.Favorite).ThenBy(i => i.Id).Reverse();
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (projectsDataGridView.SelectedRows.Count > 0)
            {
                LcsProject = (LcsProject)projectsDataGridView.SelectedRows[0].DataBoundItem;
                if (LcsProject.RequestPending == true)
                {
                    MessageBox.Show($"Invitation to the project {LcsProject.Name} has not been completed yet for your user account.\n\nVisit LCS and accept invitation first!", "Warning! Action needed.");
                    return;
                }
                UpdateProjectLinks();
            }
            else
            {
                Cancelled = true;
            }
            Close();
        }

        private void ProjectsDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (projectsDataGridView.SelectedRows.Count > 0)
            {
                LcsProject = (LcsProject)projectsDataGridView.SelectedRows[0].DataBoundItem;
                if (LcsProject.RequestPending == true)
                {
                    MessageBox.Show($"Invitation to the project {LcsProject.Name} has not been completed yet for your user account.\n\nVisit LCS and accept invitation first!", "Warning! Action needed.");
                    return;
                }
                UpdateProjectLinks();
            }
            else
            {
                Cancelled = true;
            }
            Close();
        }

        private void ProjectsDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (projectsDataGridView.DataSource == null) return;
            _projectsSource.DataSource = _sortAscending ? Projects.OrderBy(projectsDataGridView.Columns[e.ColumnIndex].DataPropertyName).ToList() : Projects.OrderBy(projectsDataGridView.Columns[e.ColumnIndex].DataPropertyName).Reverse().ToList();
            _sortAscending = !_sortAscending;
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            var favoritesSaved = new List<LcsProject>();
            if (Projects != null)
            {
                favoritesSaved = Projects.Where(x => x.Favorite == true).ToList();
            }
            Projects = HttpClientHelper.GetAllProjects();
            foreach (var savedProject in favoritesSaved)
            {
                Projects.Where(newProject => newProject.Id == savedProject.Id)
                    .Select(newProject => { newProject.Favorite = true; return newProject; })
                        .ToList();
            }
            _projectsSource.DataSource = Projects.OrderBy(f => f.Favorite).ThenBy(i => i.Id).Reverse();
            _projectsSource.ResetBindings(false);
        }

        private void UpdateProjectLinks()
        {
            var projectDetails = HttpClientHelper.GetProject(LcsProject.Id.ToString());
            if (projectDetails != null)
            {
                var project = Projects.FirstOrDefault(prj => prj.Id == LcsProject.Id);
                project.SharepointSite = projectDetails.Settings.SharepointSite;
                project.TfsServerSite = projectDetails.Settings.TfsServerSite;
                project.TfsProjectName = projectDetails.Settings.TfsProjectName;
                Properties.Settings.Default.projects = JsonConvert.SerializeObject(Projects, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });
                Properties.Settings.Default.Save();

                LcsProject.SharepointSite = projectDetails.Settings.SharepointSite;
                LcsProject.TfsServerSite = projectDetails.Settings.TfsServerSite;
                LcsProject.TfsProjectName = projectDetails.Settings.TfsProjectName;
            }
        }
    }
}