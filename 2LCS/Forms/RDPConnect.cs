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
        private BackgroundWorker bw = null;
        private dynamic rdpData = null;

        public RDPConnect()
        {
            InitializeComponent();
        }

        private  void SetProgress(int progress, string text)
        {
            progressBar.Value = progress;
            stateValueLabel.Text  =  text;
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

            validationOk &= string.IsNullOrWhiteSpace(rdpData.ProjectId) ? CheckFailed("ProjectId is missing", "Wrong arguments")  : validationOk;
            validationOk &= string.IsNullOrWhiteSpace(rdpData.Environment) ? CheckFailed("EnvironmentId is missing", "Wrong arguments") :  validationOk;

            if (validationOk)
            { 
                vmNameLabel.Text = rdpData.Environment;

                bw = new BackgroundWorker();

                bw.WorkerReportsProgress = true;
                bw.WorkerSupportsCancellation = true;
                bw.DoWork += new DoWorkEventHandler(bw_DoWork);
                bw.ProgressChanged += new ProgressChangedEventHandler(bw_ProgressChanged);
                bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);

                this.SetProgress(10, "Authenticating to LCS");

                using (var form = new Login())
                {                
                    form.ShowDialog();
                }

                this.SetProgress(25, "Initializing LCS connections");
                bw.RunWorkerAsync();
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

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Close();
        }

        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.SetProgress(e.ProgressPercentage, e.UserState as string);
        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {           
            if (rdpData.Command.ToLower() == "connectrdp")
            {

                CookieContainer cookies = MainForm.GetUriCookieContainer();
                if (cookies == null) return;

                HttpClientHelper httpClientHelper = new HttpClientHelper(cookies)
                {
                    LcsUrl = URIHandler.LCS_URL,
                    LcsUpdateUrl = URIHandler.LCS_UPDATE_URL,
                    LcsDiagUrl = URIHandler.LCS_DIAG_URL
                };

                bw.ReportProgress(20, "Loading project");

                httpClientHelper.ChangeLcsProjectId(rdpData.ProjectId);

                bw.ReportProgress(50, "Loading cloud-hosted instances");

                CloudHostedInstance chInstance = httpClientHelper.GetCheInstances().FirstOrDefault(e => e.DisplayName == rdpData.Environment);

                if (chInstance.CanShowRdp)
                {
                    bw.ReportProgress(80, "Loading connection details");

                    var rdpList = httpClientHelper.GetRdpConnectionDetails(chInstance);
                    RDPConnectionDetails rdpEntry = null;

                    if (rdpList.Count == 0)
                    {
                        MessageBox.Show($"Cannot retrieve RDP connection details. This instance is not accessible through RDP or you do not have access to see those details. Check if you have Environment Manager role.");
                    }
                    else if (rdpList.Count > 1)
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

                            bw.ReportProgress(95, "Starting connection..");

                            rdcProcess.Start();
                        }
                    }
                }
                else
                {
                    MessageBox.Show($"Cannot retrieve RDP connection details. This instance is not accessible through RDP or you do not have access to see those details. Check if you have Environment Manager role.", "Operaation failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Unsupported operation", "Unsupported operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
