using LCS.JsonObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace LCS.Forms
{
    public partial class RDPConnect : Form
    {
        private BackgroundWorker worker = null;
        private dynamic rdpData = null;

        public RDPConnect()
        {
            InitializeComponent();
        }

        private void SetProgress(int progress, string text)
        {
            progressBar.Value = progress;
            stateValueLabel.Text = text;
        }

        private void RDPConnect_Shown(object sender, EventArgs e)
        {
            string[] args = Environment.GetCommandLineArgs();

            Uri uri = new Uri(args.FirstOrDefault(e => e.StartsWith(URIHandler.URI_PROTOCOL_NAME.ToLower())));

            rdpData = new
            {
                Command = uri.Host,
                ProjectId = HttpUtility.ParseQueryString(uri.Query).Get("projectId"),
                Environment = HttpUtility.ParseQueryString(uri.Query).Get("environment"),
                Instance = HttpUtility.ParseQueryString(uri.Query).Get("instance"),
                User = HttpUtility.ParseQueryString(uri.Query).Get("user"),
            };
            bool validationOk = true;

            validationOk &= string.IsNullOrWhiteSpace(rdpData.ProjectId) ? CheckFailed("ProjectId is missing", "Wrong arguments") : validationOk;
            validationOk &= string.IsNullOrWhiteSpace(rdpData.Environment) ? CheckFailed("EnvironmentId is missing", "Wrong arguments") : validationOk;

            if (validationOk)
            {
                vmNameLabel.Text = rdpData.Environment;
                projectIdLabel.Text = rdpData.ProjectId;

                worker = new BackgroundWorker
                {
                    WorkerReportsProgress = true,
                    WorkerSupportsCancellation = true
                };
                worker.DoWork += new DoWorkEventHandler(OnWorkerDoWork);
                worker.ProgressChanged += new ProgressChangedEventHandler(OnWorkerProgressChanged);
                worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(OnWorkerRunWorkerCompleted);

                this.SetProgress(10, "Authenticating to LCS");

                using (var form = new Login())
                {
                    form.ShowDialog();
                }

                worker.RunWorkerAsync();
            }
            else
            {
                this.Close();
            }
        }

        private bool CheckFailed(string message, string caption)
        {
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private void OnWorkerRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Close();
        }

        private void OnWorkerProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.SetProgress(e.ProgressPercentage, e.UserState as string);
        }

        private async void OnWorkerDoWork(object sender, DoWorkEventArgs e)
        {
            worker.ReportProgress(25, "Initializing LCS connections");

            CookieContainer cookies = MainForm.GetUriCookieContainer();
            if (cookies == null) return;

            HttpClientHelper httpClientHelper = new HttpClientHelper(cookies)
            {
                LcsUrl = URIHandler.LCS_URL,
                LcsUpdateUrl = URIHandler.LCS_UPDATE_URL,
                LcsDiagUrl = URIHandler.LCS_DIAG_URL
            };

            if (rdpData.Command.ToLower() == "connectrdp")
            {
                worker.ReportProgress(20, "Loading project");

                httpClientHelper.ChangeLcsProjectId(rdpData.ProjectId);

                ProjectData project = httpClientHelper.GetProject(rdpData.ProjectId);
                projectNameLabel.Invoke(new MethodInvoker(delegate { projectNameLabel.Text = project.Name; }));

                worker.ReportProgress(50, "Loading cloud-hosted instances");

                var chInstances = await httpClientHelper.GetCheInstancesAsync();
                
                var chInstance = chInstances.FirstOrDefault(e => e.DisplayName == rdpData.Environment);

                if (chInstance != null)
                {
                    if (chInstance.CanShowRdp)
                    {
                        worker.ReportProgress(80, "Loading connection details");

                        var rdpList = httpClientHelper.GetRdpConnectionDetails(chInstance);
                        RDPConnectionDetails rdpEntry = null;

                        if (rdpList != null && rdpList.Count > 0)
                        {
                            if (rdpList.Count > 1)
                            {
                                rdpEntry = MainForm.ChooseRdpLogonUser(rdpList);
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

                                    worker.ReportProgress(95, "Starting connection..");

                                    rdcProcess.Start();
                                }
                            }
                            else
                            {
                                MessageBox.Show($"Operation cancelled", "Operation failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show($"Cannot retrieve RDP connection details. This instance is not accessible through RDP or you do not have access to see those details. Check if you have Environment Manager role.", "Operation failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show($"Cannot retrieve RDP connection details. This instance is not accessible through RDP or you do not have access to see those details. Check if you have Environment Manager role.", "Operation failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show($"Cannot find cloud-hosted instance with ID {rdpData.Environment} on project {project.Name}", "Operation failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Unsupported operation", "Operation failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RDPConnect_Load(object sender, EventArgs e)
        {

        }
    }
}
