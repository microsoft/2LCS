using CsvHelper;
using LCS.JsonObjects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Dynamic;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Document.NET;
using Xceed.Words.NET;
using static LCS.NativeMethods;

namespace LCS.Forms
{
    public partial class MainForm : Form
    {
        private const int GW_HWNDPREV = 3;
        private const int InternetCookieHttponly = 0x2000;
        private const string _lcsDiagUrl = "https://diag.lcs.dynamics.com";
        private const string _lcsUpdateUrl = "https://update.lcs.dynamics.com";
        private const string _lcsUrl = "https://lcs.dynamics.com";
        private readonly BindingSource _cheInstancesSource = new BindingSource();
        private readonly BindingSource _saasInstancesSource = new BindingSource();
        private List<CloudHostedInstance> _cheInstancesList;
        private bool _cheSortAscending = true;
        private CookieContainer _cookies;
        private HttpClientHelper _httpClientHelper;
        private FormWindowState _previousState;
        private List<CloudHostedInstance> _saasInstancesList;
        private bool _saasSortAscending = true;
        private LcsProject _selectedProject;
        private List<ProjectInstance> Instances;
        private List<CustomLink> Links;
        private List<LcsProject> Projects;

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private DataGridView SelectedDataGridView => tabControl.SelectedTab == tabControl.TabPages["cheTabPage"] ? cheDataGridView : saasDataGridView;

        public static RDPConnectionDetails ChooseRdpLogonUser(List<RDPConnectionDetails> rdpList)
        {
            Form form = new Form();
            Button button_OK = new Button() { Text = "OK", Location = new Point(60, 30) };
            Button button_Cancel = new Button() { Text = "Cancel", Location = new Point(140, 30) };
            button_OK.DialogResult = DialogResult.OK;
            button_Cancel.DialogResult = DialogResult.Cancel;
            FlowLayoutPanel panel = new FlowLayoutPanel();
            panel.Dock = DockStyle.Fill;

            form.Text = "Choose user";
            form.ClientSize = new Size(280, 60);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.AcceptButton = button_OK;
            form.CancelButton = button_Cancel;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.ControlBox = false;

            form.Controls.AddRange(new Control[] { button_OK, button_Cancel });
            var i = 1;
            foreach (var rdpEntry in rdpList.OrderBy(x => x.Username))
            {
                if (i == 1)
                {
                    panel.Controls.Add(new RadioButton() { Text = rdpEntry.Username, Checked = true });
                }
                else
                {
                    panel.Controls.Add(new RadioButton() { Text = rdpEntry.Username });
                }
                i++;
            }
            form.Controls.Add(panel);

            DialogResult dialogResult = form.ShowDialog();

            if (dialogResult == DialogResult.Cancel)
                return null;

            RadioButton rbSelected = panel.Controls
                         .OfType<RadioButton>()
                         .FirstOrDefault(r => r.Checked);

            return rdpList.FirstOrDefault(x => x.Username.Equals(rbSelected.Text));
        }

        public static bool IsOverlapped(IWin32Window window)
        {
            if (window == null)
                throw new ArgumentNullException(nameof(window));
            if (window.Handle == IntPtr.Zero)
                throw new InvalidOperationException("Window does not yet exist");
            if (!IsWindowVisible(window.Handle))
                return false;

            IntPtr hWnd = window.Handle;
            HashSet<IntPtr> visited = new HashSet<IntPtr> { hWnd };
            _ = new RECT();
            GetWindowRect(hWnd, out RECT thisRect);

            while ((hWnd = GetWindow(hWnd, GW_HWNDPREV)) != IntPtr.Zero && !visited.Contains(hWnd))
            {
                visited.Add(hWnd);
                _ = new RECT();
                if (IsWindowVisible(hWnd) && GetWindowRect(hWnd, out RECT testRect) && IntersectRect(out _, ref thisRect, ref testRect))
                {
                    return true;
                }
            }
            return false;
        }

        public void SetLoginButtonEnabled()
        {
            loginToLcsMenuItem.Enabled = true;
        }

        private static CookieContainer GetUriCookieContainer()
        {
            CookieContainer cookies = null;
            var datasize = 8192 * 16;
            var cookieData = new StringBuilder(datasize);
            if (!InternetGetCookieEx(_lcsUrl, null, cookieData, ref datasize, InternetCookieHttponly, IntPtr.Zero))
            {
                if (datasize < 0)
                    return null;
                cookieData = new StringBuilder(datasize);
                if (!InternetGetCookieEx(
                    _lcsUrl,
                    null, cookieData,
                    ref datasize,
                    InternetCookieHttponly,
                    IntPtr.Zero))
                    return null;
            }
            if (cookieData.Length > 0)
            {
                cookies = new CookieContainer();
                Properties.Settings.Default.cookie = cookieData.ToString().Replace(';', ',');
                Properties.Settings.Default.Save();
                cookies.SetCookies(new Uri(_lcsUrl), Properties.Settings.Default.cookie);
                cookies.SetCookies(new Uri(_lcsUpdateUrl), Properties.Settings.Default.cookie);
                cookies.SetCookies(new Uri(_lcsDiagUrl), Properties.Settings.Default.cookie);
            }
            return cookies;
        }

        private void AssetLibraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start($"https://lcs.dynamics.com/V2/AssetLibrary/{_selectedProject.Id}");
        }

        private void ChangeProjectMenuItem_Click(object sender, EventArgs e)
        {
            using var form = new ChooseProject
            {
                HttpClientHelper = _httpClientHelper
            };
            form.ShowDialog();
            if (!form.Cancelled && (form.LcsProject != null))
            {
                Projects = form.Projects;
                if (_selectedProject == null || form.LcsProject.Id != _selectedProject.Id)
                {
                    _cheInstancesSource.DataSource = null;
                    _cheInstancesSource.ResetBindings(false);
                    _saasInstancesSource.DataSource = null;
                    _saasInstancesSource.ResetBindings(false);
                    _selectedProject = form.LcsProject;

                    if (!Instances.Exists(x => x.LcsProjectId == _selectedProject.Id))
                    {
                        var instance = new ProjectInstance()
                        {
                            LcsProjectId = _selectedProject.Id,
                        };
                        Instances.Add(instance);
                    }
                }
                refreshMenuItem.Enabled = true;
                exportToolStripMenuItem.Enabled = true;
                _httpClientHelper.ChangeLcsProjectId(_selectedProject.Id.ToString());
                _httpClientHelper.LcsProjectTypeId = _selectedProject.ProjectTypeId;
                _cookies = _httpClientHelper.CookieContainer;
                GetLcsProjectFromCookie();
                SetLcsProjectText();
                CreateProjectLinksMenuItems();
                EnableDisableMenuItems();
                RefreshChe(Properties.Settings.Default.autorefresh);
                RefreshSaas(Properties.Settings.Default.autorefresh);
            }
        }

        private void CheDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            var selectedRow = SelectedDataGridView.SelectedCells[0].RowIndex;
            var row = SelectedDataGridView.Rows[selectedRow];

            if (row.DataBoundItem != null)
            {
                var rdpList = _httpClientHelper.GetRdpConnectionDetails((CloudHostedInstance)row.DataBoundItem);
                RDPConnectionDetails rdpEntry;
                if (rdpList.Count > 1)
                {
                    rdpEntry = ChooseRdpLogonUser(rdpList);
                }
                else
                {
                    rdpEntry = rdpList.First();
                }
                if (rdpEntry != null)
                {
                    using (new RdpCredentials(rdpEntry.Address, $"{rdpEntry.Domain}\\{rdpEntry.Username}", rdpEntry.Password))
                    {
                        var rdcProcess = new Process
                        {
                            StartInfo =
                        {
                            FileName = Environment.ExpandEnvironmentVariables(@"%SystemRoot%\system32\mstsc.exe"),
                            Arguments = "/v " + $"{rdpEntry.Address}:{rdpEntry.Port}"
                        }
                        };
                        rdcProcess.Start();
                    }
                }
            }
            Cursor = Cursors.Default;
        }

        private void CheDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (cheDataGridView.DataSource == null || _cheInstancesList == null) return;
            _cheInstancesSource.DataSource = _cheSortAscending ? _cheInstancesList.OrderBy(cheDataGridView.Columns[e.ColumnIndex].DataPropertyName).ToList() : _cheInstancesList.OrderBy(cheDataGridView.Columns[e.ColumnIndex].DataPropertyName).Reverse().ToList();
            _cheSortAscending = !_cheSortAscending;
            cheDataGridView.ClearSelection();
        }

        private void CheExportRDCManConnectionsMenuItem_Click(object sender, EventArgs e)
        {
            if (_cheInstancesList == null) return;
            Cursor = Cursors.WaitCursor;
            var sb = new StringBuilder();
            sb.Append(
                @"<?xml version=""1.0"" encoding=""utf-8""?>
<RDCMan schemaVersion=""1"">
    <version>2.2</version>
    <file>
        <properties>
            <name>CHE instances exported with LCS!</name>
            <expanded>True</expanded>
            <comment />
            <logonCredentials inherit=""FromParent"" />
            <connectionSettings inherit=""FromParent"" />
            <gatewaySettings inherit=""FromParent"" />
            <remoteDesktop inherit=""FromParent"" />
            <localResources inherit=""FromParent"" />
            <securitySettings inherit=""FromParent"" />
            <displaySettings inherit=""FromParent"" />
        </properties>");

            foreach (var instance in _cheInstancesList)
            {
                var rdpList = _httpClientHelper.GetRdpConnectionDetails(instance);
                foreach (var rdpEntry in rdpList)
                {
                    sb.Append(
                        $@"
        <server>
            <name>{rdpEntry.Address}:{rdpEntry.Port}</name>
            <displayName>{instance.InstanceId}-{rdpEntry.Machine}</displayName>
            <comment />
            <logonCredentials inherit=""None"">
                <userName>{rdpEntry.Username}</userName>
                <domain>{rdpEntry.Domain}</domain>
                <password storeAsClearText=""True"">{rdpEntry.Password}</password>
            </logonCredentials>
            <connectionSettings inherit=""FromParent"" />
            <gatewaySettings inherit=""FromParent"" />
            <remoteDesktop inherit=""FromParent"" />
            <localResources inherit=""FromParent"" />
            <securitySettings inherit=""FromParent"" />
            <displaySettings inherit=""FromParent"" />
        </server>");
                }
            }
            sb.Append(
                @"
    </file>
</RDCMan>");
            var savefile = new SaveFileDialog
            {
                FileName = "CHE-Exported.rdg",
                Filter = "RDCMan file (*.rdg)|*.rdg|All files (*.*)|*.*",
                DefaultExt = "rdg",
                AddExtension = true
            };
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using StreamWriter sw = new StreamWriter(savefile.FileName);
                sw.Write(sb);
            }
            Cursor = Cursors.Default;
        }

        private void CheExportRDMConnectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_cheInstancesList == null) return;
            Cursor = Cursors.WaitCursor;
            var sb = new StringBuilder();
            sb.Append(
                @"<?xml version=""1.0"" encoding=""utf-8""?>
<ArrayOfConnection>");

            foreach (var instance in _cheInstancesList)
            {
                var rdpList = _httpClientHelper.GetRdpConnectionDetails(instance);
                foreach (var rdpEntry in rdpList)
                {
                    sb.Append($@"
    <Connection>
        <RDP>
            <KeyboardLayoutText>Default</KeyboardLayoutText>
            <NetworkLevelAuthentication>true</NetworkLevelAuthentication>
            <UserName>{rdpEntry.Domain}\{rdpEntry.Username}</UserName>
        </RDP>
        <ConnectionType>RDPConfigured</ConnectionType>
        <ID>{Guid.NewGuid().ToString()}</ID>
        <Name>{instance.InstanceId}-{rdpEntry.Machine}</Name>
        <OpenEmbedded>true</OpenEmbedded>
        <Url>{rdpEntry.Address}:{rdpEntry.Port}</Url>
        <UserName>{rdpEntry.Domain}\{rdpEntry.Username}</UserName>
    </Connection>");
                }
            }

            sb.Append(
                @"
    </ArrayOfConnection>");

            var savefile = new SaveFileDialog
            {
                FileName = "CHE-Exported.rdm",
                Filter = "RDM file (*.rdm)|*.rdm|All files (*.*)|*.*",
                DefaultExt = "rdm",
                AddExtension = true
            };
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using StreamWriter sw = new StreamWriter(savefile.FileName);
                sw.Write(sb);
            }
            Cursor = Cursors.Default;
        }

        private void CheShowPasswordsMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in cheDataGridView.SelectedRows)
            {
                var instance = (CloudHostedInstance)row.DataBoundItem;
                foreach (var vm in instance.Instances)
                {
                    var form = new Credentials
                    {
                        CredentialsDict = _httpClientHelper.GetCredentials(instance.EnvironmentId, vm.ItemName),
                        Text = $"Instance: {instance.InstanceId}, VM: {vm.MachineName}"
                    };
                    form.Show();
                }
            }
        }

        private void CheShowPasswordsPowershellMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = cheDataGridView.SelectedRows[0];
            var instance = (CloudHostedInstance)row.DataBoundItem;
            foreach (var vm in instance.Instances)
            {
                var form = new PowerShell
                {
                    CredentialsDict = _httpClientHelper.GetCredentials(instance.EnvironmentId, vm.ItemName),
                    Text = $"Instance: {instance.InstanceId}, VM: {vm.MachineName}"
                };
                form.Show();
            }
        }

        private void CookieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var form = new CookieEdit();
            form.ShowDialog();
            if (form.Cancelled || string.IsNullOrEmpty(form.Cookie)) return;
            if (form.Cookie == Properties.Settings.Default.cookie) return;
            Properties.Settings.Default.cookie = form.Cookie;
            Properties.Settings.Default.projects = "";
            Properties.Settings.Default.instances = "";
            Properties.Settings.Default.Save();
            MessageBox.Show("Application will now restart", "Message", MessageBoxButtons.OK);
            Application.Restart();
        }

        private void CreateCustomLinksMenuItems()
        {
            Links = JsonConvert.DeserializeObject<List<CustomLink>>(Properties.Settings.Default.links);
            if (Links == null || Links.Count == 0)
                return;

            var cheCustomLinksMenuItem = new ToolStripMenuItem("Custom links")
            {
                Name = "cheCustomLinksMenuItem"
            };
            var saasCustomLinksMenuItem = new ToolStripMenuItem("Custom links")
            {
                Name = "saasCustomLinksMenuItem"
            };

            cheInstanceContextMenu.Items.Add(cheCustomLinksMenuItem);
            saasInstanceContextMenu.Items.Add(saasCustomLinksMenuItem);

            foreach (var link in Links)
            {
                ToolStripItem cheSubItem = new ToolStripMenuItem(link.LinkLabel)
                {
                    ToolTipText = link.Link
                };
                ToolStripItem saasSubItem = new ToolStripMenuItem(link.LinkLabel)
                {
                    ToolTipText = link.Link
                };
                cheSubItem.Click += CustomLinkClicked;
                saasSubItem.Click += CustomLinkClicked;
                cheCustomLinksMenuItem.DropDownItems.Add(cheSubItem);
                saasCustomLinksMenuItem.DropDownItems.Add(saasSubItem);
            }
        }

        private void CreateProjectLinksMenuItems()
        {
            foreach (var menuItem in cheLcsProjectLinksToolStripMenuItem.DropDownItems.Find("cheSharepointSiteMenuItem", false))
            {
                cheLcsProjectLinksToolStripMenuItem.DropDownItems.Remove(menuItem);
            }
            foreach (var menuItem in cheLcsProjectLinksToolStripMenuItem.DropDownItems.Find("cheDevOpsSiteMenuItem", false))
            {
                cheLcsProjectLinksToolStripMenuItem.DropDownItems.Remove(menuItem);
            }
            foreach (var menuItem in saasLcsProjectLinksToolStripMenuItem.DropDownItems.Find("saasSharepointSiteMenuItem", false))
            {
                saasLcsProjectLinksToolStripMenuItem.DropDownItems.Remove(menuItem);
            }
            foreach (var menuItem in saasLcsProjectLinksToolStripMenuItem.DropDownItems.Find("saasDevOpsSiteMenuItem", false))
            {
                saasLcsProjectLinksToolStripMenuItem.DropDownItems.Remove(menuItem);
            }

            if (_selectedProject != null && _selectedProject.SharepointSite != null)
            {
                var cheSharepointSiteMenuItem = new ToolStripMenuItem("Sharepoint site")
                {
                    Name = "cheSharepointSiteMenuItem",
                    ToolTipText = _selectedProject.SharepointSite
                };
                var saasSharepointSiteMenuItem = new ToolStripMenuItem("Sharepoint site")
                {
                    Name = "saasSharepointSiteMenuItem",
                    ToolTipText = _selectedProject.SharepointSite
                };
                cheSharepointSiteMenuItem.Click += ProjectLinkClicked;
                saasSharepointSiteMenuItem.Click += ProjectLinkClicked;
                cheLcsProjectLinksToolStripMenuItem.DropDownItems.Add(cheSharepointSiteMenuItem);
                saasLcsProjectLinksToolStripMenuItem.DropDownItems.Add(saasSharepointSiteMenuItem);
            }

            if (_selectedProject != null && _selectedProject.TfsServerSite != null)
            {
                var cheDevOpsSiteMenuItem = new ToolStripMenuItem("Azure DevOps site")
                {
                    Name = "cheDevOpsSiteMenuItem",
                    ToolTipText = _selectedProject.TfsServerSite + "/" + _selectedProject.TfsProjectName
                };
                var saasDevOpsSiteMenuItem = new ToolStripMenuItem("Azure DevOps site")
                {
                    Name = "saasDevOpsSiteMenuItem",
                    ToolTipText = _selectedProject.TfsServerSite + "/" + _selectedProject.TfsProjectName
                };
                cheDevOpsSiteMenuItem.Click += ProjectLinkClicked;
                saasDevOpsSiteMenuItem.Click += ProjectLinkClicked;
                cheLcsProjectLinksToolStripMenuItem.DropDownItems.Add(cheDevOpsSiteMenuItem);
                saasLcsProjectLinksToolStripMenuItem.DropDownItems.Add(saasDevOpsSiteMenuItem);
            }
        }

        private void CustomLinkClicked(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            foreach (DataGridViewRow row in SelectedDataGridView.SelectedRows)
            {
                var item = (CloudHostedInstance)row.DataBoundItem;
                var link = ParseCustomLink(((ToolStripMenuItem)sender).ToolTipText, item);
                Process.Start(link);
            }
            Cursor = Cursors.Default;
        }

        private void CustomLinksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var form = new CustomLinks();
            form.ShowDialog();
            if (form.Cancelled) return;
            RemoveCustomLinksMenuItems();
            CreateCustomLinksMenuItems();
        }

        private void DataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            var hti = SelectedDataGridView.HitTest(e.X, e.Y);
            if (hti.RowIndex < 0 || SelectedDataGridView.Rows[hti.RowIndex].Selected) return;
            SelectedDataGridView.ClearSelection();
            SelectedDataGridView.Rows[hti.RowIndex].Selected = true;
        }

        private void DataPackagesHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            foreach (DataGridViewRow row in SelectedDataGridView.SelectedRows)
            {
                var item = (CloudHostedInstance)row.DataBoundItem;
                Process.Start($"https://lcs.dynamics.com/V2/ConfigurationAndDataManagementHistory/{_selectedProject.Id}?environmentId={item.EnvironmentId}");
            }
            Cursor = Cursors.Default;
        }

        private void DeallocateMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            var tasks = new List<Task>();
            foreach (DataGridViewRow row in SelectedDataGridView.SelectedRows)
            {
                var instance = (CloudHostedInstance)row.DataBoundItem;
                if (MessageBox.Show($"Deallocation is the step before deletion. Do you really want to deallocate {instance.DisplayName} instance?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    tasks.Add(Task.Run(() => new HttpClientHelper(_cookies) { LcsUrl = _lcsUrl, LcsUpdateUrl = _lcsUpdateUrl, LcsDiagUrl = _lcsDiagUrl, LcsProjectId = _selectedProject.Id.ToString() }.StartStopDeployment(instance, "deallocate")));
                }
            }
            Task.WhenAll(tasks).Wait();
            Cursor = Cursors.Default;
        }

        private void DeleteMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            var tasks = new List<Task>();
            foreach (DataGridViewRow row in SelectedDataGridView.SelectedRows)
            {
                var instance = (CloudHostedInstance)row.DataBoundItem;
                if (MessageBox.Show($"Deletion cannot be cancelled or rolled back. Do you really want to delete {instance.DisplayName} instance?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    tasks.Add(Task.Run(() => new HttpClientHelper(_cookies) { LcsUrl = _lcsUrl, LcsUpdateUrl = _lcsUpdateUrl, LcsDiagUrl = _lcsDiagUrl, LcsProjectId = _selectedProject.Id.ToString() }.DeleteEnvironment(instance)));
                }
            }
            Task.WhenAll(tasks).Wait();
            Cursor = Cursors.Default;
        }

        private void DeployPackageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            DeployablePackage package = null;
            StringBuilder log = new StringBuilder();
            foreach (DataGridViewRow row in SelectedDataGridView.SelectedRows)
            {
                var instance = (CloudHostedInstance)row.DataBoundItem;
                if (package == null)
                {
                    var packages = _httpClientHelper.GetPagedDeployablePackageList(instance);
                    using var form = new ChoosePackage
                    {
                        Packages = packages
                    };
                    form.ShowDialog();
                    if (!form.Cancelled && (form.DeployablePackage != null))
                    {
                        package = form.DeployablePackage;
                        log.AppendLine($"Chosen package name: {package.Name}");
                        log.AppendLine($"Chosen package description: {package.Description}");
                        log.AppendLine($"Chosen package platform version: {package.PlatformVersion}");
                        log.AppendLine();
                    }
                    else
                    {
                        break;
                    }
                }
                if (package != null)
                {
                    var applyLog = _httpClientHelper.ApplyPackage(instance, package);
                    log.AppendLine(applyLog);
                }
            }
            if (log.Length != 0)
            {
                var form = new LogDisplay
                {
                    LogEntries = log.ToString(),
                    Text = $"Deployment log for package: {package.Name}"
                };
                form.Show();
            }
            Cursor = Cursors.Default;
        }

        private void DetailedBuildInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            foreach (DataGridViewRow row in SelectedDataGridView.SelectedRows)
            {
                var instance = (CloudHostedInstance)row.DataBoundItem;
                var environmentId = _httpClientHelper.GetBuildInfoEnvironmentId(instance);
                var buildInfo = _httpClientHelper.GetEnvironmentBuildInfoDetails(instance, environmentId.ToString());
                if (buildInfo == null || buildInfo.BuildInfoTreeView.Count == 0)
                {
                    MessageBox.Show($"Request to get build info details. Please try again later.");
                    continue;
                }
                using var form = new BuildInfoDetailsForm
                {
                    BuildInfo = buildInfo,
                    Text = $"Instance: {instance.InstanceId}, Build version: {buildInfo.BuildVersion}, Platform build: {buildInfo.InstalledPlatformBuild}"
                };
                form.ShowDialog();
            }
            Cursor = Cursors.Default;
        }

        private void DetailedVersionInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            foreach (DataGridViewRow row in SelectedDataGridView.SelectedRows)
            {
                var item = (CloudHostedInstance)row.DataBoundItem;
                Process.Start($"https://diag.lcs.dynamics.com/BuildInfo/Index/{_selectedProject.Id}?lcsEnvironmentId={item.EnvironmentId}");
            }
            Cursor = Cursors.Default;
        }

        private void EnvironmentChangeHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            foreach (DataGridViewRow row in SelectedDataGridView.SelectedRows)
            {
                var item = (CloudHostedInstance)row.DataBoundItem;
                Process.Start($"https://lcs.dynamics.com/V2/EnvironmentHistory/{_selectedProject.Id}?LcsEnvironmentName={item.DisplayName}&EnvironmentId={item.EnvironmentId}&EnvironmentType={item.SaasEnvironmentType}");
            }
            Cursor = Cursors.Default;
        }

        private void EnvironmentMonitoringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            foreach (DataGridViewRow row in SelectedDataGridView.SelectedRows)
            {
                var item = (CloudHostedInstance)row.DataBoundItem;
                Process.Start($"https://diag.lcs.dynamics.com/Monitoring/Index/{_selectedProject.Id}?environmentId={item.EnvironmentId}");
            }
            Cursor = Cursors.Default;
        }

        private void ExportListOfInstancesForAllProjects(LCSEnvironments _LCSEnvironments)
        {
            notifyIcon.BalloonTipText = $"Exporting list of {_LCSEnvironments} instances for all LCS projects. Please wait...";
            notifyIcon.BalloonTipTitle = $"Exporting list of {_LCSEnvironments} instances";

            notifyIcon.ShowBalloonTip(2000); //This setting might be overruled by the OS

            Cursor = Cursors.WaitCursor;
            var previousProject = _selectedProject;
            var exportedInstances = new List<ExportedInstance>();

            Projects = _httpClientHelper.GetAllProjects();
            Projects = ExcludeProjectsForOrganization(Projects); //remove all internal projects for export.

            foreach (var _project in Projects)
            {
                if (_project.RequestPending == true) continue;
                _selectedProject = _project;
                _httpClientHelper.ChangeLcsProjectId(_project.Id.ToString());
                _httpClientHelper.LcsProjectTypeId = _project.ProjectTypeId;
                SetLcsProjectText();
                RefreshChe();
                RefreshSaas();

                if (_LCSEnvironments == LCSEnvironments.ALL || _LCSEnvironments == LCSEnvironments.SAAS)
                    if (_saasInstancesList != null && _saasInstancesList.Count > 0)
                    {
                        foreach (var _instance in _saasInstancesList)
                        {
                            var exportedInstance = new ExportedInstance
                            {
                                ProjectId = _project.Id.ToString(),
                                ProjectName = _project.Name,
                                Organization = _project.OrganizationName,
                                InstanceName = _instance.DisplayName,
                                EnvironmentId = _instance.EnvironmentId,
                                CurrentApplicationBuildVersion = _instance.CurrentApplicationBuildVersion,
                                CurrentApplicationReleaseName = _instance.CurrentApplicationReleaseName,
                                CurrentPlatformReleaseName = _instance.CurrentPlatformReleaseName,
                                CurrentPlatformVersion = _instance.CurrentPlatformVersion,
                                BuildInfo = _instance.BuildInfo,
                                TopologyType = _instance.TopologyType,
                                TopologyVersion = _instance.TopologyVersion,
                                TopologyName = _instance.TopologyName,
                                DeploymentStatus = _instance.DeploymentStatus,
                                HostingType = "MS hosted"
                            };
                            exportedInstances.Add(exportedInstance);
                        }
                    }

                if (_LCSEnvironments == LCSEnvironments.ALL || _LCSEnvironments == LCSEnvironments.CHE)
                    if (_cheInstancesList != null && _cheInstancesList.Count > 0)
                    {
                        foreach (var _instance in _cheInstancesList)
                        {
                            var exportedInstance = new ExportedInstance
                            {
                                ProjectId = _project.Id.ToString(),
                                ProjectName = _project.Name,
                                Organization = _project.OrganizationName,
                                InstanceName = _instance.DisplayName,
                                EnvironmentId = _instance.EnvironmentId,
                                CurrentApplicationBuildVersion = _instance.CurrentApplicationBuildVersion,
                                CurrentApplicationReleaseName = _instance.CurrentApplicationReleaseName,
                                CurrentPlatformReleaseName = _instance.CurrentPlatformReleaseName,
                                CurrentPlatformVersion = _instance.CurrentPlatformVersion,
                                BuildInfo = _instance.BuildInfo,
                                TopologyType = _instance.TopologyType,
                                TopologyVersion = _instance.TopologyVersion,
                                TopologyName = _instance.TopologyName,
                                DeploymentStatus = _instance.DeploymentStatus,
                                HostingType = "Cloud hosted"
                            };
                            exportedInstances.Add(exportedInstance);
                        }
                    }
            }
            SaveFileDialog savefile = new SaveFileDialog
            {
                FileName = $"D365FO {_LCSEnvironments} instances - 2LCS generated.csv",
                Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*"
            };

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using StreamWriter sw = new StreamWriter(savefile.FileName, false, Encoding.Unicode);
                    var csv = new CsvWriter(sw);
                    csv.WriteRecords(exportedInstances);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            _selectedProject = previousProject;
            _httpClientHelper.ChangeLcsProjectId(_selectedProject.Id.ToString());
            _httpClientHelper.LcsProjectTypeId = _selectedProject.ProjectTypeId;
            SetLcsProjectText();
            RefreshChe(false);
            RefreshSaas(false);
        }

        private void ExportProjectDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshMenuItem_Click(null, null);
            var projectUsers = _httpClientHelper.GetAllProjectUsers();

            notifyIcon.BalloonTipText = $"Exporting data for {_selectedProject.Name} project. Please wait...";
            notifyIcon.BalloonTipTitle = "Exporting LCS project data";

            notifyIcon.ShowBalloonTip(2000); //This setting might be overruled by the OS

            Cursor = Cursors.WaitCursor;

            using (var document = DocX.Create(_selectedProject.Name + " - 2LCS generated.docx"))
            {
                document.InsertParagraph(_selectedProject.Name).CapsStyle(CapsStyle.caps).FontSize(40d).SpacingBefore(50d).SpacingAfter(20d);
                document.InsertParagraph("Project Id: " + _selectedProject.Id).FontSize(14d).SpacingAfter(100d);
                document.InsertParagraph(_selectedProject.OrganizationName).CapsStyle(CapsStyle.caps).FontSize(30d).InsertPageBreakAfterSelf();

                Hyperlink link2LCS = document.AddHyperlink("2LCS", new Uri("https://github.com/Microsoft/2LCS"));
                document.AddFooters();
                document.AddHeaders();
                document.DifferentFirstPage = true;
                document.Footers.Odd.InsertParagraph("Generated with ").AppendHyperlink(link2LCS);

                var toc = document.InsertTableOfContents("Table of Contents",
                    TableOfContentsSwitches.O // use paragraphs with built in heading styles
                    | TableOfContentsSwitches.U  // build the toc by using paragraph outline level
                    | TableOfContentsSwitches.Z  // hide tba leader in web layout
                    | TableOfContentsSwitches.H  // use hyperlinks
                    | TableOfContentsSwitches.W  // preserve tabs
                    | TableOfContentsSwitches.X);// preserve new line characters

                var tocParagraph = document.InsertParagraph();
                tocParagraph.InsertPageBreakAfterSelf();

                //Subscriptions info
                var plans = _httpClientHelper.RetrieveTenantPlans();
                if (plans != null)
                {
                    var subsHeader = document.InsertParagraph("Subscriptions available").Heading(HeadingType.Heading1).FontSize(20d);
                    subsHeader.SpacingAfter(40d);
                    var tenantNameHeader = document.InsertParagraph("Tenant name: " + plans.TenantName).FontSize(14d);
                    tenantNameHeader.SpacingAfter(10d);
                    var tenantIdHeader = document.InsertParagraph("Tenant ID: " + plans.TenantId).FontSize(14d);
                    tenantIdHeader.SpacingAfter(10d);
                    if (plans.Plans.Count > 0)
                    {
                        //plans table
                        var plansColumnWidths = new float[] { 200f, 200f, 60f, 40f, 40f };
                        var plansDetailsTable = document.AddTable(1, plansColumnWidths.Length);
                        plansDetailsTable.SetWidths(plansColumnWidths);
                        plansDetailsTable.Design = TableDesign.LightListAccent6;
                        plansDetailsTable.Alignment = Alignment.left;
                        plansDetailsTable.AutoFit = AutoFit.Contents;
                        //headers
                        plansDetailsTable.Rows[0].Cells[0].Paragraphs[0].Append("Service plan name");
                        plansDetailsTable.Rows[0].Cells[1].Paragraphs[0].Append("Service plan ID");
                        plansDetailsTable.Rows[0].Cells[2].Paragraphs[0].Append("Assigned date");
                        plansDetailsTable.Rows[0].Cells[3].Paragraphs[0].Append("Quantity");
                        plansDetailsTable.Rows[0].Cells[4].Paragraphs[0].Append("Status");

                        foreach (var plan in plans.Plans)
                        {
                            var row = plansDetailsTable.InsertRow();
                            row.Cells[0].Paragraphs[0].Append(plan.ServicePlanName);
                            row.Cells[1].Paragraphs[0].Append(plan.ServicePlanId);
                            row.Cells[2].Paragraphs[0].Append(plan.DisplayAssignedDate);
                            row.Cells[3].Paragraphs[0].Append(plan.PrepaidUnitsEnabled.ToString());
                            row.Cells[4].Paragraphs[0].Append(plan.PlanStatus);
                        }
                        tenantIdHeader.InsertTableAfterSelf(plansDetailsTable);
                        document.InsertParagraph().InsertPageBreakAfterSelf();
                    }
                }

                if (projectUsers != null && projectUsers.Count > 0)
                {
                    var projectUsersHeader = document.InsertParagraph("Project users").Heading(HeadingType.Heading1).FontSize(20d);
                    projectUsersHeader.SpacingAfter(40d);
                    //users table
                    var usersColumnWidths = new float[] { 40f, 40f, 40f, 40f, 40f, 40f, 40f, 40f, 40f, 40f };
                    var usersDetailsTable = document.AddTable(1, usersColumnWidths.Length);
                    usersDetailsTable.SetWidths(usersColumnWidths);
                    usersDetailsTable.Design = TableDesign.LightListAccent3;
                    usersDetailsTable.Alignment = Alignment.left;
                    usersDetailsTable.AutoFit = AutoFit.Contents;
                    //headers
                    usersDetailsTable.Rows[0].Cells[0].Paragraphs[0].Append("Name");
                    usersDetailsTable.Rows[0].Cells[1].Paragraphs[0].Append("Email");
                    usersDetailsTable.Rows[0].Cells[2].Paragraphs[0].Append("Organization");
                    usersDetailsTable.Rows[0].Cells[3].Paragraphs[0].Append("Project role");
                    usersDetailsTable.Rows[0].Cells[4].Paragraphs[0].Append("User role");
                    usersDetailsTable.Rows[0].Cells[5].Paragraphs[0].Append("Allow service provider to contact");
                    usersDetailsTable.Rows[0].Cells[6].Paragraphs[0].Append("Added by");
                    usersDetailsTable.Rows[0].Cells[7].Paragraphs[0].Append("Added by organization");
                    usersDetailsTable.Rows[0].Cells[8].Paragraphs[0].Append("Created date");
                    usersDetailsTable.Rows[0].Cells[9].Paragraphs[0].Append("Status");

                    foreach (var user in projectUsers)
                    {
                        var row = usersDetailsTable.InsertRow();
                        if (user.UserProfile != null)
                        {
                            row.Cells[0].Paragraphs[0].Append(user.UserProfile.DisplayName);
                            row.Cells[1].Paragraphs[0].Append(user.UserProfile.Email);
                            row.Cells[2].Paragraphs[0].Append(user.UserProfile.Organization.Name);
                        }
                        else
                        {
                            row.Cells[1].Paragraphs[0].Append(user.InvitationEmail);
                        }
                        row.Cells[3].Paragraphs[0].Append(user.UserRoleDisplayText);
                        row.Cells[4].Paragraphs[0].Append(user.FunctionalRoleDisplayText);
                        row.Cells[5].Paragraphs[0].Append(user.AllowContactByMicrosoft.ToString());
                        row.Cells[6].Paragraphs[0].Append(user.InvitedBy.DisplayName);
                        row.Cells[7].Paragraphs[0].Append(user.InvitedBy.Organization.Name);
                        row.Cells[8].Paragraphs[0].Append(user.CreatedDate); //Todo ?.ToString("yyyy-MM-dd H:mm"));
                        row.Cells[9].Paragraphs[0].Append(user.InvitationStatusDisplayText);
                    }
                    projectUsersHeader.InsertTableAfterSelf(usersDetailsTable);
                    document.InsertParagraph().InsertPageBreakAfterSelf();
                }
                if (_saasInstancesList != null && _saasInstancesList.Count > 0)
                {
                    var instancesHeader = document.InsertParagraph("Microsoft managed instances").Heading(HeadingType.Heading1).FontSize(20d);
                    instancesHeader.SpacingAfter(40d);

                    foreach (var saasInstance in _saasInstancesList)
                    {
                        //instance header
                        var instanceHeader = document.InsertParagraph(saasInstance.DisplayName).CapsStyle(CapsStyle.caps).Heading(HeadingType.Heading2).FontSize(16d);
                        instanceHeader.SpacingAfter(10d);

                        //instance table
                        var instanceColumnWidths = new float[] { 200f, 400f };
                        var instanceDetailsTable = document.AddTable(11, instanceColumnWidths.Length);
                        instanceDetailsTable.SetWidths(instanceColumnWidths);
                        instanceDetailsTable.Design = TableDesign.LightListAccent2;
                        instanceDetailsTable.Alignment = Alignment.left;
                        instanceDetailsTable.Rows[0].Cells[0].Paragraphs[0].Append("Name");
                        instanceDetailsTable.Rows[0].Cells[1].Paragraphs[0].Append(saasInstance.DisplayName);
                        instanceDetailsTable.Rows[1].Cells[0].Paragraphs[0].Append("Environment Id");
                        instanceDetailsTable.Rows[1].Cells[1].Paragraphs[0].Append(saasInstance.EnvironmentId);
                        instanceDetailsTable.Rows[2].Cells[0].Paragraphs[0].Append("Topology");
                        instanceDetailsTable.Rows[2].Cells[1].Paragraphs[0].Append(saasInstance.TopologyDisplayName);
                        instanceDetailsTable.Rows[3].Cells[0].Paragraphs[0].Append("Deployed on");
                        instanceDetailsTable.Rows[3].Cells[1].Paragraphs[0].Append(saasInstance.DeployedOn); //Todo ?.ToString("yyyy-MM-dd H:mm"));
                        instanceDetailsTable.Rows[4].Cells[0].Paragraphs[0].Append("Deployed by");
                        instanceDetailsTable.Rows[4].Cells[1].Paragraphs[0].Append(saasInstance.DeployedBy);
                        instanceDetailsTable.Rows[5].Cells[0].Paragraphs[0].Append("Environment admin");
                        instanceDetailsTable.Rows[5].Cells[1].Paragraphs[0].Append(saasInstance.EnvironmentAdmin);
                        instanceDetailsTable.Rows[6].Cells[0].Paragraphs[0].Append("Current application build version");
                        instanceDetailsTable.Rows[6].Cells[1].Paragraphs[0].Append(saasInstance.CurrentApplicationBuildVersion);
                        instanceDetailsTable.Rows[7].Cells[0].Paragraphs[0].Append("Current application release name");
                        instanceDetailsTable.Rows[7].Cells[1].Paragraphs[0].Append(saasInstance.CurrentApplicationReleaseName);
                        instanceDetailsTable.Rows[8].Cells[0].Paragraphs[0].Append("Current platform release name");
                        instanceDetailsTable.Rows[8].Cells[1].Paragraphs[0].Append(saasInstance.CurrentPlatformReleaseName);
                        instanceDetailsTable.Rows[9].Cells[0].Paragraphs[0].Append("Current platform version");
                        instanceDetailsTable.Rows[9].Cells[1].Paragraphs[0].Append(saasInstance.CurrentPlatformVersion);
                        instanceDetailsTable.Rows[10].Cells[0].Paragraphs[0].Append("Number of virtual machines");
                        instanceDetailsTable.Rows[10].Cells[1].Paragraphs[0].Append(saasInstance.VirtualMachineCount.ToString());
                        //Navigation links
                        foreach (var link in saasInstance.NavigationLinks)
                        {
                            Hyperlink navLink = document.AddHyperlink(link.NavigationUri, new Uri(link.NavigationUri));
                            var r = instanceDetailsTable.InsertRow();
                            r.Cells[0].Paragraphs[0].Append(link.DisplayName);
                            r.Cells[1].Paragraphs[0].AppendHyperlink(navLink);
                        }

                        instanceHeader.InsertTableAfterSelf(instanceDetailsTable);

                        var rdpList = _httpClientHelper.GetRdpConnectionDetails(saasInstance);
                        if (rdpList.Count > 0)
                        {
                            var vms = document.InsertParagraph("RDP connections: " + saasInstance.DisplayName.ToUpper()).FontSize(14d);
                            vms.SpacingBefore(20d);
                            vms.SpacingAfter(10d);
                            foreach (var rdpEntry in rdpList)
                            {
                                //RDP details table
                                var columnWidths = new float[] { 300f, 400f };
                                var rdpTable = document.AddTable(4, columnWidths.Length);
                                rdpTable.SetWidths(columnWidths);
                                rdpTable.Design = TableDesign.LightListAccent1;
                                rdpTable.Alignment = Alignment.left;
                                rdpTable.AutoFit = AutoFit.Contents;
                                rdpTable.Rows[0].Cells[0].Paragraphs[0].Append("Machine name");
                                rdpTable.Rows[0].Cells[1].Paragraphs[0].Append(rdpEntry.Machine);
                                rdpTable.Rows[1].Cells[0].Paragraphs[0].Append("RDP address");
                                rdpTable.Rows[1].Cells[1].Paragraphs[0].Append(rdpEntry.Address + ":" + rdpEntry.Port);
                                rdpTable.Rows[2].Cells[0].Paragraphs[0].Append("User name");
                                rdpTable.Rows[2].Cells[1].Paragraphs[0].Append(rdpEntry.Domain + "\\" + rdpEntry.Username);
                                rdpTable.Rows[3].Cells[0].Paragraphs[0].Append("Password");
                                rdpTable.Rows[3].Cells[1].Paragraphs[0].Append(rdpEntry.Password);
                                document.InsertTable(rdpTable);
                                document.InsertParagraph();
                            }
                        }
                        foreach (var vm in saasInstance.Instances)
                        {
                            var CredentialsDict = _httpClientHelper.GetCredentials(saasInstance.EnvironmentId, vm.ItemName);
                            if (CredentialsDict.Count > 0)
                            {
                                var credentialsParagraph = document.InsertParagraph("Credentials for " + vm.MachineName).FontSize(14d);
                                credentialsParagraph.SpacingBefore(20d);
                                credentialsParagraph.SpacingAfter(10d);
                                // CHE credentials table
                                var columnWidths = new float[] { 150f, 150f };
                                var credentialsTable = document.AddTable(1, columnWidths.Length);
                                credentialsTable.SetWidths(columnWidths);
                                credentialsTable.Design = TableDesign.LightListAccent3;
                                credentialsTable.Alignment = Alignment.left;
                                credentialsTable.AutoFit = AutoFit.Contents;
                                credentialsTable.Rows[0].Cells[0].Paragraphs[0].Append("User name");
                                credentialsTable.Rows[0].Cells[1].Paragraphs[0].Append("Password");

                                foreach (var credential in CredentialsDict)
                                {
                                    var r = credentialsTable.InsertRow();
                                    r.Cells[0].Paragraphs[0].Append(credential.Key
                                        .Replace("Dev-Local admin-", "")
                                        .Replace("Dev-Local user-", "")
                                        .Replace("Dev-Sql server login-", "")
                                        .Replace("Build-Local user-", "")
                                        .Replace("Build-Sql server login-", "")
                                        .Replace("AOS-Local admin-", "")
                                        .Replace("BI-Local admin-", "")
                                        .Replace("AD-AosServiceUser-", "")
                                        .Replace("AD-SqlServiceUser-", "")
                                        .Replace("AD-DynamicsInstallUser-", "")
                                        .Replace("AD-SPServiceUser-", "")
                                        .Replace("AD-BCProxyUser-", "")
                                        .Replace("AD-Local admin-", ""));
                                    r.Cells[1].Paragraphs[0].Append(credential.Value);
                                }
                                credentialsParagraph.InsertTableAfterSelf(credentialsTable);
                            }
                        }
                        document.InsertParagraph().InsertPageBreakAfterSelf();
                    }
                }

                if (_cheInstancesList != null && _cheInstancesList.Count > 0)
                {
                    var instancesHeader = document.InsertParagraph("Cloud hosted instances").Heading(HeadingType.Heading1).FontSize(20d);
                    instancesHeader.SpacingAfter(40d);

                    foreach (var instance in _cheInstancesList)
                    {
                        //instance header
                        var instanceHeader = document.InsertParagraph(instance.DisplayName).CapsStyle(CapsStyle.caps).Heading(HeadingType.Heading2).FontSize(16d);
                        instanceHeader.SpacingAfter(10d);

                        //instance table
                        var instanceColumnWidths = new float[] { 200f, 400f };
                        var instanceDetailsTable = document.AddTable(10, instanceColumnWidths.Length);
                        instanceDetailsTable.SetWidths(instanceColumnWidths);
                        instanceDetailsTable.Design = TableDesign.LightListAccent2;
                        instanceDetailsTable.Alignment = Alignment.left;
                        instanceDetailsTable.Rows[0].Cells[0].Paragraphs[0].Append("Name");
                        instanceDetailsTable.Rows[0].Cells[1].Paragraphs[0].Append(instance.DisplayName);
                        instanceDetailsTable.Rows[1].Cells[0].Paragraphs[0].Append("Environment Id");
                        instanceDetailsTable.Rows[1].Cells[1].Paragraphs[0].Append(instance.EnvironmentId);
                        instanceDetailsTable.Rows[2].Cells[0].Paragraphs[0].Append("Topology");
                        instanceDetailsTable.Rows[2].Cells[1].Paragraphs[0].Append(instance.TopologyDisplayName);
                        instanceDetailsTable.Rows[3].Cells[0].Paragraphs[0].Append("Deployed on");
                        instanceDetailsTable.Rows[3].Cells[1].Paragraphs[0].Append(instance.DeployedOn); //Todo ?.ToString("yyyy-MM-dd H:mm"));
                        instanceDetailsTable.Rows[4].Cells[0].Paragraphs[0].Append("Deployed by");
                        instanceDetailsTable.Rows[4].Cells[1].Paragraphs[0].Append(instance.DeployedBy);
                        instanceDetailsTable.Rows[5].Cells[0].Paragraphs[0].Append("Environment admin");
                        instanceDetailsTable.Rows[5].Cells[1].Paragraphs[0].Append(instance.EnvironmentAdmin);
                        instanceDetailsTable.Rows[6].Cells[0].Paragraphs[0].Append("Current application build version");
                        instanceDetailsTable.Rows[6].Cells[1].Paragraphs[0].Append(instance.CurrentApplicationBuildVersion);
                        instanceDetailsTable.Rows[7].Cells[0].Paragraphs[0].Append("Current application release name");
                        instanceDetailsTable.Rows[7].Cells[1].Paragraphs[0].Append(instance.CurrentApplicationReleaseName);
                        instanceDetailsTable.Rows[8].Cells[0].Paragraphs[0].Append("Current platform release name");
                        instanceDetailsTable.Rows[8].Cells[1].Paragraphs[0].Append(instance.CurrentPlatformReleaseName);
                        instanceDetailsTable.Rows[9].Cells[0].Paragraphs[0].Append("Current platform version");
                        instanceDetailsTable.Rows[9].Cells[1].Paragraphs[0].Append(instance.CurrentPlatformVersion);
                        //Navigation links
                        foreach (var link in instance.NavigationLinks)
                        {
                            Hyperlink navLink = document.AddHyperlink(link.NavigationUri, new Uri(link.NavigationUri));
                            var r = instanceDetailsTable.InsertRow();
                            r.Cells[0].Paragraphs[0].Append(link.DisplayName);
                            r.Cells[1].Paragraphs[0].AppendHyperlink(navLink);
                        }

                        instanceHeader.InsertTableAfterSelf(instanceDetailsTable);
                        var rdpList = _httpClientHelper.GetRdpConnectionDetails(instance);
                        if (rdpList.Count > 0)
                        {
                            var vms = document.InsertParagraph("RDP connections: " + instance.DisplayName.ToUpper()).FontSize(14d);
                            vms.SpacingBefore(20d);
                            vms.SpacingAfter(10d);
                            foreach (var rdpEntry in rdpList)
                            {
                                //RDP details table
                                var columnWidths = new float[] { 300f, 400f };
                                var rdpTable = document.AddTable(3, columnWidths.Length);
                                rdpTable.SetWidths(columnWidths);
                                rdpTable.Design = TableDesign.LightListAccent1;
                                rdpTable.Alignment = Alignment.left;
                                rdpTable.AutoFit = AutoFit.Contents;
                                rdpTable.Rows[0].Cells[0].Paragraphs[0].Append("RDP address");
                                rdpTable.Rows[0].Cells[1].Paragraphs[0].Append(rdpEntry.Address + ":" + rdpEntry.Port);
                                rdpTable.Rows[1].Cells[0].Paragraphs[0].Append("User name");
                                rdpTable.Rows[1].Cells[1].Paragraphs[0].Append(rdpEntry.Domain + "\\" + rdpEntry.Username);
                                rdpTable.Rows[2].Cells[0].Paragraphs[0].Append("Password");
                                rdpTable.Rows[2].Cells[1].Paragraphs[0].Append(rdpEntry.Password);
                                document.InsertTable(rdpTable);
                                document.InsertParagraph();
                            }
                        }
                        foreach (var vm in instance.Instances)
                        {
                            var CredentialsDict = _httpClientHelper.GetCredentials(instance.EnvironmentId, vm.ItemName);
                            if (CredentialsDict.Count > 0)
                            {
                                var credentialsParagraph = document.InsertParagraph("Credentials").FontSize(14d);
                                credentialsParagraph.SpacingBefore(20d);
                                credentialsParagraph.SpacingAfter(10d);
                                // CHE credentials table
                                var columnWidths = new float[] { 150f, 150f };
                                var credentialsTable = document.AddTable(1, columnWidths.Length);
                                credentialsTable.SetWidths(columnWidths);
                                credentialsTable.Design = TableDesign.LightListAccent3;
                                credentialsTable.Alignment = Alignment.left;
                                credentialsTable.AutoFit = AutoFit.Contents;
                                credentialsTable.Rows[0].Cells[0].Paragraphs[0].Append("User name");
                                credentialsTable.Rows[0].Cells[1].Paragraphs[0].Append("Password");

                                foreach (var credential in CredentialsDict)
                                {
                                    var r = credentialsTable.InsertRow();
                                    r.Cells[0].Paragraphs[0].Append(credential.Key
                                        .Replace("Dev-Local admin-", "")
                                        .Replace("Dev-Local user-", "")
                                        .Replace("Dev-Sql server login-", "")
                                        .Replace("Build-Local user-", "")
                                        .Replace("Build-Sql server login-", "")
                                        .Replace("AOS-Local admin-", "")
                                        .Replace("BI-Local admin-", "")
                                        .Replace("AD-AosServiceUser-", "")
                                        .Replace("AD-SqlServiceUser-", "")
                                        .Replace("AD-DynamicsInstallUser-", "")
                                        .Replace("AD-SPServiceUser-", "")
                                        .Replace("AD-BCProxyUser-", "")
                                        .Replace("AD-Local admin-", ""));
                                    r.Cells[1].Paragraphs[0].Append(credential.Value);
                                }
                                credentialsParagraph.InsertTableAfterSelf(credentialsTable).InsertPageBreakAfterSelf();
                            }
                        }
                    }
                }

                var savefile = new SaveFileDialog
                {
                    FileName = _selectedProject.Name + " - 2LCS generated.docx",
                    Filter = "Word document (*.docx)|*.docx|All files (*.*)|*.*",
                    DefaultExt = "docx",
                    AddExtension = true
                };
                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        document.SaveAs(savefile.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            Cursor = Cursors.Default;
        }

        private LcsProject GetLcsProjectFromCookie()
        {
            var cookies = _cookies.GetCookies(new Uri(_lcsUrl));
            foreach (Cookie cookie in cookies)
            {
                if (cookie.Name == "lcspid")
                {
                    return Projects.FirstOrDefault(x => x.Id.Equals(int.Parse(cookie.Value)));
                }
            }
            return null;
        }

        private void HotfixesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            var menuItem = (sender as ToolStripMenuItem);
            HotfixesType hotfixesType;
            string label;
            switch (menuItem.Name)
            {
                case "cheMetadataHotfixesToolStripMenuItem":
                case "saasApplicationMetadataHotfixesToolStripMenuItem":
                    hotfixesType = HotfixesType.Metadata;
                    label = "application metadata updates";
                    break;

                case "cheApplicationBinaryHotfixesToolStripMenuItem":
                case "saasApplicationBinaryHotfixesToolStripMenuItem":
                    hotfixesType = HotfixesType.ApplicationBinary;
                    label = "application binary hotfixes";
                    break;

                case "chePlatformHotfixesToolStripMenuItem":
                case "saasPlatformBinaryHotfixesToolStripMenuItem":
                    hotfixesType = HotfixesType.PlatformBinary;
                    label = "platform binary hotfixes";
                    break;

                default:
                    //case "saasCriticalMetadataHotfixesToolStripMenuItem":
                    hotfixesType = HotfixesType.CriticalMetadata;
                    label = "critical metadata hotfixes";
                    break;
            }

            foreach (DataGridViewRow row in SelectedDataGridView.SelectedRows)
            {
                var diagId = _httpClientHelper.GetDiagEnvironmentId((CloudHostedInstance)row.DataBoundItem);
                var kbs = _httpClientHelper.GetAvailableHotfixes(diagId, (int)hotfixesType);
                if (kbs == null)
                {
                    MessageBox.Show($"Request to get available updates failed. Please try again later.");
                    continue;
                }
                if (kbs.Count == 0)
                {
                    MessageBox.Show($"There are no {label} available for {((CloudHostedInstance)row.DataBoundItem).DisplayName} instance.");
                    continue;
                }
                using var form = new AvailableKBs
                {
                    Hotfixes = kbs,
                    Text = $"{kbs.Count} {label} available for {((CloudHostedInstance)row.DataBoundItem).DisplayName} instance."
                };
                form.ShowDialog();
            }
            Cursor = Cursors.Default;
        }

        private void InstanceContextMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var mousepos = MousePosition;
            if (!(sender is ContextMenuStrip cms)) return;
            var relMousePos = cms.PointToClient(mousepos);
            if (cms.ClientRectangle.Contains(relMousePos))
            {
                var dgvRelMousePos = SelectedDataGridView.PointToClient(mousepos);
                var hti = SelectedDataGridView.HitTest(dgvRelMousePos.X, dgvRelMousePos.Y);
                if (hti.RowIndex == -1)
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void InstanceDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            foreach (DataGridViewRow row in SelectedDataGridView.SelectedRows)
            {
                var item = (CloudHostedInstance)row.DataBoundItem;
                Process.Start(_httpClientHelper.GetEnvironmentDetailsUrl(item));
            }
            Cursor = Cursors.Default;
        }

        private void LoginToLCSMenuItem_Click(object sender, EventArgs e)
        {
            WebBrowserHelper.FixBrowserVersion();
            using var form = new Login();
            form.ShowDialog();
            if (form.Cancelled) return;
            _cookies = GetUriCookieContainer();
            if (_cookies == null) return;
            _httpClientHelper = new HttpClientHelper(_cookies)
            {
                LcsUrl = _lcsUrl,
                LcsUpdateUrl = _lcsUpdateUrl,
                LcsDiagUrl = _lcsDiagUrl
            };
            if (_selectedProject != null)
            {
                _httpClientHelper.ChangeLcsProjectId(_selectedProject.Id.ToString());
                _httpClientHelper.LcsProjectTypeId = _selectedProject.ProjectTypeId;
            }
            changeProjectMenuItem.Enabled = true;
            cheInstanceContextMenu.Enabled = true;
            saasInstanceContextMenu.Enabled = true;
            logoutToolStripMenuItem.Enabled = true;
            loginToLcsMenuItem.Enabled = false;
            ChangeProjectMenuItem_Click(null, null);
        }

        private void LogonToApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            foreach (DataGridViewRow row in SelectedDataGridView.SelectedRows)
            {
                var item = (CloudHostedInstance)row.DataBoundItem;
                foreach (var link in item.NavigationLinks)
                {
                    if (link.DisplayName == "Log on to environment")
                    {
                        Process.Start(link.NavigationUri);
                        break;
                    }
                }
            }
            Cursor = Cursors.Default;
        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                    $"When you log off, all locally saved information about your projects and instances will be deleted. You will need to refresh data from LCS.{Environment.NewLine}{Environment.NewLine}Application will restart.{Environment.NewLine}{Environment.NewLine}Do you want to proceed?",
                    "Confirmation", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            Properties.Settings.Default.projects = "";
            Properties.Settings.Default.instances = "";
            Properties.Settings.Default.cookie = "";
            Properties.Settings.Default.Save();
            Application.Restart();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SetInitialGridSettings();

            Instances = JsonConvert.DeserializeObject<List<ProjectInstance>>(Properties.Settings.Default.instances) ??
                        new List<ProjectInstance>();
            Projects = JsonConvert.DeserializeObject<List<LcsProject>>(Properties.Settings.Default.projects) ?? new List<LcsProject>();

            if (!string.IsNullOrEmpty(Properties.Settings.Default.cookie))
            {
                _cookies = new CookieContainer();
                _cookies.SetCookies(new Uri(_lcsUrl), Properties.Settings.Default.cookie);
                _cookies.SetCookies(new Uri(_lcsUpdateUrl), Properties.Settings.Default.cookie);
                _cookies.SetCookies(new Uri(_lcsDiagUrl), Properties.Settings.Default.cookie);
                _httpClientHelper = new HttpClientHelper(_cookies)
                {
                    LcsUrl = _lcsUrl,
                    LcsUpdateUrl = _lcsUpdateUrl,
                    LcsDiagUrl = _lcsDiagUrl
                };

                changeProjectMenuItem.Enabled = true;
                cheInstanceContextMenu.Enabled = true;
                saasInstanceContextMenu.Enabled = true;
                loginToLcsMenuItem.Enabled = false;
                logoutToolStripMenuItem.Enabled = true;

                _selectedProject = GetLcsProjectFromCookie();
                if (_selectedProject != null)
                {
                    SetLcsProjectText();
                    refreshMenuItem.Enabled = true;
                    exportToolStripMenuItem.Enabled = true;
                    _httpClientHelper.ChangeLcsProjectId(_selectedProject.Id.ToString());
                    _httpClientHelper.LcsProjectTypeId = _selectedProject.ProjectTypeId;
                    var projectInstance = Instances.FirstOrDefault(x => x.LcsProjectId.Equals(_selectedProject.Id));
                    if (projectInstance != null)
                    {
                        if (projectInstance.CheInstances != null)
                        {
                            _cheInstancesSource.DataSource = _cheInstancesList = projectInstance.CheInstances;
                        }
                        if (projectInstance.SaasInstances != null)
                        {
                            _saasInstancesSource.DataSource = _saasInstancesList = projectInstance.SaasInstances;
                        }
                    }
                }
            }
            CreateCustomLinksMenuItems();
            CreateProjectLinksMenuItems();
            EnableDisableMenuItems();
        }

        private void EnableDisableMenuItems()
        {
            if (_selectedProject != null)
            {
                saasOpenRdpConnectionToolStripMenuItem.Visible = (_selectedProject.ProjectTypeId != ProjectType.ServiceFabricImplementation || _selectedProject.ProjectTypeId != ProjectType.OnPremImplementation);
                saasRdpAndPasswordsToolStripMenuItem.Visible = (_selectedProject.ProjectTypeId != ProjectType.ServiceFabricImplementation || _selectedProject.ProjectTypeId != ProjectType.OnPremImplementation);
            }
        }

        private void NotifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Normal || WindowState == FormWindowState.Maximized)
            {
                if (IsOverlapped(this))
                {
                    Activate();
                }
                else
                {
                    _previousState = WindowState;
                    WindowState = FormWindowState.Minimized;
                }
            }
            else if (WindowState == FormWindowState.Minimized)
            {
                WindowState = _previousState;
            }
        }

        private void OpenRDPConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            foreach (DataGridViewRow row in SelectedDataGridView.SelectedRows)
            {
                var rdpList = _httpClientHelper.GetRdpConnectionDetails((CloudHostedInstance)row.DataBoundItem);
                RDPConnectionDetails rdpEntry;
                if (rdpList.Count == 0)
                {
                    Cursor = Cursors.Default;
                    MessageBox.Show($"Cannot retrieve RDP connection details. This instance is not accessible through RDP or you do not have access to see those details. Check if you have Environment Manager role.");
                    return;
                }
                else if(rdpList.Count > 1)
                {
                    rdpEntry = ChooseRdpLogonUser(rdpList);
                }
                else
                {
                    rdpEntry = rdpList.First();
                }
                if (rdpEntry != null)
                {
                    using (new RdpCredentials(rdpEntry.Address, $"{rdpEntry.Domain}\\{rdpEntry.Username}", rdpEntry.Password))
                    {
                        var rdcProcess = new Process
                        {
                            StartInfo =
                        {
                            FileName = Environment.ExpandEnvironmentVariables(@"%SystemRoot%\system32\mstsc.exe"),
                            Arguments = "/v " + $"{rdpEntry.Address}:{rdpEntry.Port}"
                        }
                        };
                        rdcProcess.Start();
                    }
                }
            }
            Cursor = Cursors.Default;
        }

        private void OpenWorkItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start($"https://lcs.dynamics.com/V2/WorkItemsManagement/{_selectedProject.Id}");
        }

        private void ParametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var form = new Parameters();
            form.ShowDialog();
        }

        private string ParseCustomLink(string template, CloudHostedInstance instance)
        {
            var replacements = new Dictionary<string, string>();
            foreach (var prop in instance.GetType().GetProperties())
            {
                var value = "";
                var val = prop.GetValue(instance, null);
                if (val != null)
                {
                    value = val.ToString();
                }
                replacements.Add(prop.Name, value);
            }
            //Add navigation links
            replacements.Add("AosUrl", instance.NavigationLinks[0].NavigationUri.ToString());
            replacements.Add("PosUrl", instance.NavigationLinks[1].NavigationUri.ToString());
            replacements.Add("RetailStorefront", instance.NavigationLinks[2].NavigationUri.ToString());
            replacements.Add("RetailServer", instance.NavigationLinks[3].NavigationUri.ToString());
            return template.FormatPlaceholders(replacements);
        }

        private void ProjectLinkClicked(object sender, EventArgs e)
        {
            var link = ((ToolStripMenuItem)sender).ToolTipText;
            Process.Start(link);
        }

        private void ProjectSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start($"https://lcs.dynamics.com/V2/ProjectSettings/{_selectedProject.Id}");
        }

        private void ProjectUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start($"https://lcs.dynamics.com/V2/ProjectUserManagement/{_selectedProject.Id}");
        }

        private void RefreshChe(bool reloadFromLcs = true)
        {
            Cursor = Cursors.WaitCursor;
            if (reloadFromLcs)
            {
                _cheInstancesList = _httpClientHelper.GetCheInstances();
                if (_cheInstancesList != null)
                {
                    _cheInstancesSource.DataSource = _cheInstancesList;
                    if (Instances.Exists(x => x.LcsProjectId == _selectedProject.Id))
                    {
                        Instances.Where(x => x.LcsProjectId == _selectedProject.Id)
                            .Select(x => { x.CheInstances = _cheInstancesList; return x; })
                                .ToList();
                    }

                    Properties.Settings.Default.instances = JsonConvert.SerializeObject(Instances, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });
                    Properties.Settings.Default.Save();
                }
            }
            else
            {
                var projectInstance = Instances?.FirstOrDefault(x => x.LcsProjectId.Equals(_selectedProject.Id));
                if (projectInstance != null)
                    _cheInstancesSource.DataSource = _cheInstancesList = projectInstance.CheInstances;
            }
            _cheInstancesSource.ResetBindings(false);
            Cursor = Cursors.Default;
        }

        private void RefreshMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon.BalloonTipText = $"Fetching list of environments for project {_selectedProject.Name} from LCS. Please wait...";
            notifyIcon.BalloonTipTitle = "Fetching environments";

            notifyIcon.ShowBalloonTip(2000); //This setting might be overruled by the OS

            if (tabControl.SelectedTab == tabControl.TabPages["cheTabPage"])
            {
                RefreshChe();
                RefreshSaas();
            }
            else if (tabControl.SelectedTab == tabControl.TabPages["saasTabPage"])
            {
                RefreshSaas();
                RefreshChe();
            }
        }

        private void RefreshSaas(bool reloadFromLcs = true)
        {
            Cursor = Cursors.WaitCursor;
            if (reloadFromLcs)
            {
                _saasInstancesList = _httpClientHelper.GetHostedInstances();

                if (_saasInstancesList != null)
                {
                    _saasInstancesSource.DataSource = _saasInstancesList;
                    if (Instances.Exists(x => x.LcsProjectId == _selectedProject.Id))
                    {
                        Instances.Where(x => x.LcsProjectId == _selectedProject.Id)
                            .Select(x => { x.SaasInstances = _saasInstancesList; return x; })
                                .ToList();
                    }

                    Properties.Settings.Default.instances = JsonConvert.SerializeObject(Instances, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });
                    Properties.Settings.Default.Save();
                }
            }
            else
            {
                var projectInstance = Instances?.FirstOrDefault(x => x.LcsProjectId.Equals(_selectedProject.Id));
                if (projectInstance != null)
                    _saasInstancesSource.DataSource = _saasInstancesList = projectInstance.SaasInstances;
            }
            _saasInstancesSource.ResetBindings(false);
            Cursor = Cursors.Default;
        }

        private void RemoveCustomLinksMenuItems()
        {
            cheInstanceContextMenu.Items.RemoveByKey("cheCustomLinksMenuItem");
            saasInstanceContextMenu.Items.RemoveByKey("saasCustomLinksMenuItem");
        }

        private void SaasAddNsgRule_Click(object sender, EventArgs e)
        {
            using var form = new AddNsg();
            form.ShowDialog();
            if (form.Cancelled || (form.Rule == null)) return;
            Cursor = Cursors.WaitCursor;
            var tasks = new List<Task>();
            foreach (DataGridViewRow row in saasDataGridView.SelectedRows)
            {
                tasks.Add(Task.Run(() => new HttpClientHelper(_cookies) { LcsUrl = _lcsUrl, LcsUpdateUrl = _lcsUpdateUrl, LcsDiagUrl = _lcsDiagUrl, LcsProjectId = _selectedProject.Id.ToString() }.AddNsgRule((CloudHostedInstance)row.DataBoundItem, form.Rule.FirstOrDefault().Key, form.Rule.FirstOrDefault().Value)));
            }
            Task.WhenAll(tasks).Wait();
            Cursor = Cursors.Default;
        }

        private void SaasDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (saasDataGridView.DataSource == null || _saasInstancesList == null) return;
            _saasInstancesSource.DataSource = _saasSortAscending ? _saasInstancesList.OrderBy(saasDataGridView.Columns[e.ColumnIndex].DataPropertyName).ToList() : _saasInstancesList.OrderBy(saasDataGridView.Columns[e.ColumnIndex].DataPropertyName).Reverse().ToList();
            _saasSortAscending = !_saasSortAscending;
            saasDataGridView.ClearSelection();
        }

        private void SaasDeleteNsgRule_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            NSGRule nsgRule = null;
            StringBuilder log = new StringBuilder();
            var tasks = new List<Task<string>>();
            foreach (DataGridViewRow row in SelectedDataGridView.SelectedRows)
            {
                var instance = (CloudHostedInstance)row.DataBoundItem;
                if (nsgRule == null)
                {
                    var networkSecurityGroup = _httpClientHelper.GetNetworkSecurityGroup(instance);
                    using var form = new ChooseNSG();
                    form.NetworkSecurityGroup = networkSecurityGroup;
                    form.Text = $"Choose firewall rule to delete";
                    form.ShowDialog();
                    if (!form.Cancelled && (form.NSGRule != null))
                    {
                        nsgRule = form.NSGRule;
                        log.AppendLine($"Firewall rule to be deleted: {nsgRule.Name}, IP: {nsgRule.IpOrCidr}");
                        log.AppendLine();
                    }
                    else
                    {
                        break;
                    }
                }
                if (nsgRule != null)
                {
                    tasks.Add(Task.Run(() => new HttpClientHelper(_cookies) { LcsUrl = _lcsUrl, LcsUpdateUrl = _lcsUpdateUrl, LcsDiagUrl = _lcsDiagUrl, LcsProjectId = _selectedProject.Id.ToString() }.DeleteNsgRule(instance, nsgRule.Name)));
                }
            }
            Task.WhenAll(tasks).Wait();
            var logEntries = tasks.Select(x => x.Result).ToList();
            foreach (var entry in logEntries)
            {
                log.AppendLine(entry);
            }
            if (log.Length != 0)
            {
                var form = new LogDisplay
                {
                    LogEntries = log.ToString(),
                    Text = $"Log for deletion of firewall rule: {nsgRule.Name}"
                };
                form.Show();
            }
            Cursor = Cursors.Default;
        }

        private void SaasExportRDCManConnectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_saasInstancesList == null) return;
            Cursor = Cursors.WaitCursor;
            var sb = new StringBuilder();
            sb.Append(
                @"<?xml version=""1.0"" encoding=""utf-8""?>
<RDCMan schemaVersion=""1"">
    <version>2.2</version>
    <file>
        <properties>
            <name>SAAS instances exported with LCS!</name>
            <expanded>True</expanded>
            <comment />
            <logonCredentials inherit=""FromParent"" />
            <connectionSettings inherit=""FromParent"" />
            <gatewaySettings inherit=""FromParent"" />
            <remoteDesktop inherit=""FromParent"" />
            <localResources inherit=""FromParent"" />
            <securitySettings inherit=""FromParent"" />
            <displaySettings inherit=""FromParent"" />
        </properties>");

            foreach (var saasInstance in _saasInstancesList)
            {
                sb.Append(
                    $@"
        <group>
            <properties>
                <name>{saasInstance.InstanceId}</name>
                <expanded>True</expanded>
                <comment />
                <logonCredentials inherit=""FromParent"" />
                <connectionSettings inherit=""FromParent"" />
                <gatewaySettings inherit=""FromParent"" />
                <remoteDesktop inherit=""FromParent"" />
                <localResources inherit=""FromParent"" />
                <securitySettings inherit=""FromParent"" />
                <displaySettings inherit=""FromParent"" />
            </properties>");

                var rdpList = _httpClientHelper.GetRdpConnectionDetails(saasInstance);
                foreach (var rdpEntry in rdpList)
                {
                    sb.Append(
                        $@"
            <server>
                <name>{rdpEntry.Address}:{rdpEntry.Port}</name>
                <displayName>{rdpEntry.Machine}</displayName>
                <comment />
                <logonCredentials inherit=""None"">
                    <userName>{rdpEntry.Username}</userName>
                    <domain>{rdpEntry.Domain}</domain>
                    <password storeAsClearText=""True"">{rdpEntry.Password}</password>
                </logonCredentials>
                <connectionSettings inherit=""FromParent"" />
                <gatewaySettings inherit=""FromParent"" />
                <remoteDesktop inherit=""FromParent"" />
                <localResources inherit=""FromParent"" />
                <securitySettings inherit=""FromParent"" />
                <displaySettings inherit=""FromParent"" />
            </server>");
                }
                sb.Append(
                    @"
        </group>");
            }
            sb.Append(
                @"
    </file>
</RDCMan>");
            var savefile = new SaveFileDialog
            {
                FileName = "SAAS-Exported.rdg",
                Filter = "RDCMan file (*.rdg)|*.rdg|All files (*.*)|*.*",
                DefaultExt = "rdg",
                AddExtension = true
            };
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using StreamWriter sw = new StreamWriter(savefile.FileName);
                sw.Write(sb);
            }
            Cursor = Cursors.Default;
        }

        private void SaasExportRDMConnectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_saasInstancesList == null) return;
            Cursor = Cursors.WaitCursor;
            var sb = new StringBuilder();
            sb.Append(
                @"<?xml version=""1.0"" encoding=""utf-8""?>
<ArrayOfConnection>");

            foreach (var saasInstance in _saasInstancesList)
            {
                var rdpList = _httpClientHelper.GetRdpConnectionDetails(saasInstance);
                foreach (var rdpEntry in rdpList)
                {
                    sb.Append($@"
    <Connection>
        <RDP>
            <KeyboardLayoutText>Default</KeyboardLayoutText>
            <NetworkLevelAuthentication>true</NetworkLevelAuthentication>
            <UserName>{rdpEntry.Domain}\{rdpEntry.Username}</UserName>
        </RDP>
        <ConnectionType>RDPConfigured</ConnectionType>
        <ID>{Guid.NewGuid().ToString()}</ID>
        <Name>{saasInstance.InstanceId}-{rdpEntry.Machine}</Name>
        <OpenEmbedded>true</OpenEmbedded>
        <Url>{rdpEntry.Address}:{rdpEntry.Port}</Url>
        <UserName>{rdpEntry.Domain}\{rdpEntry.Username}</UserName>
    </Connection>");
                }
            }

            sb.Append(
                @"
    </ArrayOfConnection>");

            var savefile = new SaveFileDialog
            {
                FileName = "SAAS-Exported.rdm",
                Filter = "RDM file (*.rdm)|*.rdm|All files (*.*)|*.*",
                DefaultExt = "rdm",
                AddExtension = true
            };
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using StreamWriter sw = new StreamWriter(savefile.FileName);
                sw.Write(sb);
            }
            Cursor = Cursors.Default;
        }

        private void SaasOpenRdpConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            foreach (DataGridViewRow row in SelectedDataGridView.SelectedRows)
            {
                var instance = (CloudHostedInstance)row.DataBoundItem;
                var rdpList = _httpClientHelper.GetRdpConnectionDetails(instance);
                var form = new ChooseMachine
                {
                    Text = $"Choose machine to connect to. Instance: {instance.DisplayName}",
                    RDPConnections = rdpList
                };
                form.ShowDialog();
                if (!form.Cancelled && (form.RDPConnection != null))
                {
                    var rdpEntry = form.RDPConnection;
                    using (new RdpCredentials(rdpEntry.Address, $"{rdpEntry.Domain}\\{rdpEntry.Username}", rdpEntry.Password))
                    {
                        var rdcProcess = new Process
                        {
                            StartInfo =
                            {
                                FileName = Environment.ExpandEnvironmentVariables(@"%SystemRoot%\system32\mstsc.exe"),
                                Arguments = "/v " + $"{rdpEntry.Address}:{rdpEntry.Port}"
                            }
                        };
                        rdcProcess.Start();
                    }
                }
            }
            Cursor = Cursors.Default;
        }

        private void SaasShowPasswordsMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in saasDataGridView.SelectedRows)
            {
                var credentials = new Dictionary<string, string>();
                var instance = (CloudHostedInstance)row.DataBoundItem;
                foreach (var vm in instance.Instances)
                {
                    var creds = _httpClientHelper.GetCredentials(instance.EnvironmentId, vm.ItemName);
                    credentials = credentials.Concat(creds).GroupBy(d => d.Key).ToDictionary(d => d.Key, d => d.First().Value);
                }
                foreach (var cred in instance.SqlAzureCredentials.Select(x => x.DeploymentItemName).Distinct())
                {
                    var creds = _httpClientHelper.GetCredentials(instance.EnvironmentId, cred);
                    credentials = credentials.Concat(creds).GroupBy(d => d.Key).ToDictionary(d => d.Key, d => d.First().Value);
                }
                var form = new Credentials
                {
                    Text = $"Instance: {instance.InstanceId}",
                    CredentialsDict = credentials
                };
                form.Show();
            }
        }

        private void SaasShowPasswordsPowershellMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in saasDataGridView.SelectedRows)
            {
                var credentials = new Dictionary<string, string>();
                var instance = (CloudHostedInstance)row.DataBoundItem;
                foreach (var vm in instance.Instances)
                {
                    var creds = _httpClientHelper.GetCredentials(instance.EnvironmentId, vm.ItemName);
                    credentials = credentials.Concat(creds).GroupBy(d => d.Key).ToDictionary(d => d.Key, d => d.First().Value);
                }
                foreach (var cred in instance.SqlAzureCredentials.Select(x => x.DeploymentItemName).Distinct())
                {
                    var creds = _httpClientHelper.GetCredentials(instance.EnvironmentId, cred);
                    credentials = credentials.Concat(creds).GroupBy(d => d.Key).ToDictionary(d => d.Key, d => d.First().Value);
                }
                var form = new PowerShell
                {
                    Text = $"Instance: {instance.InstanceId}",
                    CredentialsDict = credentials
                };
                form.Show();
            }
        }

        private void ServiceRequestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start($"https://lcs.dynamics.com/V2/WorkItemsManagement/{_selectedProject.Id}?ActiveVerticalPivot=3");
        }

        private void SetInitialGridSettings()
        {
            cheDataGridView.AutoGenerateColumns = false;
            saasDataGridView.AutoGenerateColumns = false;
            //Perf fix for grids rendering
            if (!SystemInformation.TerminalServerSession)
            {
                var dgvType = cheDataGridView.GetType();
                var pi = dgvType.GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
                if (pi != null)
                {
                    pi.SetValue(cheDataGridView, true, null);
                    dgvType = saasDataGridView.GetType();
                }

                pi = dgvType.GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
                if (pi != null) pi.SetValue(saasDataGridView, true, null);
            }
            cheDataGridView.Columns["cheDeployedOn"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";
            saasDataGridView.Columns["saasDeployedOn"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";
            cheDataGridView.DataSource = _cheInstancesSource;
            saasDataGridView.DataSource = _saasInstancesSource;
        }

        private void SetLcsProjectText()
        {
            projectDescriptionLabel.Text = $"LCS Project ID: {_selectedProject.Id} : {_selectedProject.Name} : {_selectedProject.OrganizationName}";
        }

        private void ShowRDPDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            foreach (DataGridViewRow row in SelectedDataGridView.SelectedRows)
            {
                var instance = (CloudHostedInstance)row.DataBoundItem;
                var rdpList = _httpClientHelper.GetRdpConnectionDetails(instance);
                var details = new StringBuilder();
                foreach (var rdpEntry in rdpList)
                {
                    if (details.Length != 0)
                    {
                        details.AppendLine();
                        details.AppendLine();
                    }
                    details.AppendLine($"Virtual machine name: {rdpEntry.Machine}");
                    details.AppendLine($"Hostname: {rdpEntry.Address}:{rdpEntry.Port}");
                    details.AppendLine($"Username: {rdpEntry.Domain}\\{rdpEntry.Username}");
                    details.Append($"Password: {rdpEntry.Password}");
                }
                var form = new LogDisplay
                {
                    Text = $"RDP connection details for {instance.DisplayName}",
                    LogEntries = details.ToString()
                };
                form.Show();
            }
            Cursor = Cursors.Default;
        }

        private void StartInstanceMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            var tasks = new List<Task>();
            foreach (DataGridViewRow row in SelectedDataGridView.SelectedRows)
            {
                tasks.Add(Task.Run(() => new HttpClientHelper(_cookies) { LcsUrl = _lcsUrl, LcsUpdateUrl = _lcsUpdateUrl, LcsDiagUrl = _lcsDiagUrl, LcsProjectId = _selectedProject.Id.ToString() }.StartStopDeployment((CloudHostedInstance)row.DataBoundItem, "start")));
            }
            Task.WhenAll(tasks).Wait();
            Cursor = Cursors.Default;
        }

        private void StopInstanceMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            var tasks = new List<Task>();
            foreach (DataGridViewRow row in SelectedDataGridView.SelectedRows)
            {
                tasks.Add(Task.Run(() => new HttpClientHelper(_cookies) { LcsUrl = _lcsUrl, LcsUpdateUrl = _lcsUpdateUrl, LcsDiagUrl = _lcsDiagUrl, LcsProjectId = _selectedProject.Id.ToString() }.StartStopDeployment((CloudHostedInstance)row.DataBoundItem, "stop")));
            }
            Task.WhenAll(tasks).Wait();
            Cursor = Cursors.Default;
        }

        private void SubscriptionEstimatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start($"https://sizing.lcs.dynamics.com/SubscriptionEstimator/Estimate/{_selectedProject.Id}");
        }

        private void SubscriptionsAvailableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start($"https://lcs.dynamics.com/V2/OrganizationOfferDetail/{_selectedProject.Id}");
        }

        private void SupportIssuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start($"https://lcs.dynamics.com/V2/WorkItemsManagement/{_selectedProject.Id}?ActiveVerticalPivot=2");
        }

        private void SystemDiagnosticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start($"https://diag.lcs.dynamics.com/Home/Index/{_selectedProject.Id}");
        }

        private void LogonToPointOfSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            foreach (DataGridViewRow row in SelectedDataGridView.SelectedRows)
            {
                var item = (CloudHostedInstance)row.DataBoundItem;
                foreach (var link in item.NavigationLinks)
                {
                    if (link.DisplayName == "Log on to Cloud Point of Sale")
                    {
                        Process.Start(link.NavigationUri);
                        break;
                    }
                }
            }
            Cursor = Cursors.Default;
        }

        private void LaunchDynamicsRetailStorefrontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            foreach (DataGridViewRow row in SelectedDataGridView.SelectedRows)
            {
                var item = (CloudHostedInstance)row.DataBoundItem;
                foreach (var link in item.NavigationLinks)
                {
                    if (link.DisplayName == "Launch Dynamics Retail Storefront")
                    {
                        Process.Start(link.NavigationUri);
                        break;
                    }
                }
            }
            Cursor = Cursors.Default;
        }

        private void RetailServerURLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            foreach (DataGridViewRow row in SelectedDataGridView.SelectedRows)
            {
                var item = (CloudHostedInstance)row.DataBoundItem;
                foreach (var link in item.NavigationLinks)
                {
                    if (link.DisplayName == "Retail Server URL")
                    {
                        Process.Start(link.NavigationUri);
                        break;
                    }
                }
            }
            Cursor = Cursors.Default;
        }

        private void SaasUpcomingUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            var calendar = _httpClientHelper.GetUpcomingCalendars();
            if (calendar == null || calendar.Count == 0)
            {
                Cursor = Cursors.Default;
                MessageBox.Show($"Request to get upcoming service updates calendar failed. You are using learning project or you do not have access to that information.");
                return;
            }
            using var form = new UpcomingUpdates
            {
                Calendar = calendar,
                Text = $"Upcoming service updates for {_selectedProject.Name} project."
            };
            form.ShowDialog();

            Cursor = Cursors.Default;
        }

        private List<LcsProject> ExcludeProjectsForOrganization(List<LcsProject> _projects)
        {
            string exclOrg = Properties.Settings.Default.projOrgExcl;
            if (string.IsNullOrEmpty(exclOrg))
            {
                return _projects;
            }
            else
            {
                List<LcsProject> projectsLocal = new List<LcsProject>();

                foreach (var _project in _projects)
                {
                    if (!_project.OrganizationName.Contains(Properties.Settings.Default.projOrgExcl))
                        projectsLocal.Add(_project);
                }

                return projectsLocal;
            }
        }

        private void ExportUpdateScheduleForAllProjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon.BalloonTipText = $"Exporting updates schedule for all LCS projects. Please wait...";
            notifyIcon.BalloonTipTitle = "Exporting updates schedule list";

            notifyIcon.ShowBalloonTip(2000); //This setting might be overruled by the OS

            Cursor = Cursors.WaitCursor;
            var previousProject = _selectedProject;
            var exportedUpdates = new List<Datum>();

            Projects = _httpClientHelper.GetAllProjects();
            Projects = ExcludeProjectsForOrganization(Projects); //remove all internal projects for export.

            foreach (var _project in Projects)
            {
                if (_project.RequestPending == true) continue;
                _selectedProject = _project;
                _httpClientHelper.ChangeLcsProjectId(_project.Id.ToString());
                SetLcsProjectText();

                List<Datum> calendar = _httpClientHelper.GetUpcomingCalendars();
                if (calendar != null || calendar.Count != 0)
                {
                    foreach (var _updateRow in calendar)
                    {
                        exportedUpdates.Add(_updateRow);
                    }
                }
            }

            Cursor = Cursors.Default;

            SaveFileDialog savefile = new SaveFileDialog
            {
                FileName = "D365FO updates - 2LCS generated.csv",
                Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*"
            };

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using StreamWriter sw = new StreamWriter(savefile.FileName, false, Encoding.Unicode);
                    var csv = new CsvWriter(sw);
                    csv.WriteRecords(exportedUpdates);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            _selectedProject = previousProject;
            _httpClientHelper.ChangeLcsProjectId(_selectedProject.Id.ToString());
            SetLcsProjectText();
            RefreshChe(false);
            RefreshSaas(false);
        }

        private void AllInstancesExportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportListOfInstancesForAllProjects(LCSEnvironments.ALL);
        }

        private void CloudHostedInstancesExportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportListOfInstancesForAllProjects(LCSEnvironments.CHE);
        }

        private void MSHostedInstancesExportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportListOfInstancesForAllProjects(LCSEnvironments.SAAS);
        }

        private void SaasRestartService_Click(object sender, EventArgs e)
        {
            using var form = new ChooseService
            {
                AvailableServices = _httpClientHelper.GetServicesToRestart()
            };
            form.ShowDialog();
            if (form.Cancelled || (form.ServicesToRestart == null)) return;
            Cursor = Cursors.WaitCursor;

            StringBuilder log = new StringBuilder();
            foreach (DataGridViewRow row in saasDataGridView.SelectedRows)
            {
                foreach (var service in form.ServicesToRestart)
                {
                    var instance = (CloudHostedInstance)row.DataBoundItem;
                    log.AppendLine($"Validating ongoing actions of {instance.InstanceId} instance...");
                    ActionDetails actions;
                    var attempt = 1;
                    do
                    {
                        actions = _httpClientHelper.GetOngoingActionDetails(instance);
                        if (actions != null)
                        {
                            log.AppendLine($"Attempt {attempt}. Ongoing action found! Delaying next attempt for 30 seconds...");
                            log.AppendLine($"Action status: {actions.ActionStatusText}");
                            log.AppendLine($"Action type: {actions.ActionType}");
                            log.AppendLine($"Action name: {actions.Name}");
                            log.AppendLine($"Action start date: {actions.StartDate}");
                            System.Threading.Thread.Sleep(1000 * 30);
                            attempt++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    while (attempt <= 10);
                    if (actions == null)
                    {
                        log.AppendLine($"Restarting {service.Value} service of {instance.InstanceId} instance...");
                        var response = _httpClientHelper.RestartService(instance, service.Value);
                        log.AppendLine($"Result:  {response.Message}");
                        log.AppendLine();
                    }
                    else
                    {
                        log.AppendLine($" Previous ongoing action was not finished. Restart will not be executed.");
                    }
                }
            }
            Cursor = Cursors.Default;

            if (log.Length != 0)
            {
                using var logForm = new LogDisplay
                {
                    LogEntries = log.ToString(),
                    Text = $"Restarting service(s) log"
                };
                logForm.ShowDialog();
            }
        }

        private void EnvironmentChangesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            foreach (DataGridViewRow row in SelectedDataGridView.SelectedRows)
            {
                var instance = (CloudHostedInstance)row.DataBoundItem;
                var actions = _httpClientHelper.GetEnvironmentHistoryDetails(instance);
                if (actions != null)
                {
                    using var form = new EnvironmentChanges
                    {
                        ActionDetails = actions,
                        Text = $"Environment changes for {instance.DisplayName} instance."
                    };
                    form.ShowDialog();
                }
            }
            Cursor = Cursors.Default;
        }
    }

    public static class StringExtension
    {
        private static readonly Regex RegexMatch = new Regex(@"\%\%([^\}]+)\%\%", RegexOptions.Compiled);

        public static string FormatPlaceholders(this string str, Dictionary<string, string> fields)
        {
            return fields == null ? str : RegexMatch.Replace(str, match => fields[match.Groups[1].Value]);
        }
    }
}