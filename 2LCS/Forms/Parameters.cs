using System;
using System.Windows.Forms;
using LCS.Cache;

namespace LCS.Forms
{
    public partial class Parameters : Form
    {
        public Parameters()
        {
            InitializeComponent();
        }

        public bool Autorefresh { get; private set; }
        public bool Cancelled { get; private set; }
        public bool CachingEnabled { get; private set; }
        public bool StoreCache { get; private set; }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            SetParameters();
            Close();
        }

        private void Parameters_Load(object sender, EventArgs e)
        {
            LoadParameters();
        }

        private void LoadParameters()
        {
            AutoRefreshCheckBox.Checked = Properties.Settings.Default.autorefresh;
            minimizeToNotificationArea.Checked = Properties.Settings.Default.minimizeToNotificationArea;
            textBoxProjectExcl.Text = Properties.Settings.Default.projOrgExcl;
            RDPCredentialsCheckbox.Checked = Properties.Settings.Default.RDPCredentialsEnabled;
            LocalCredentialsCheckbox.Checked = Properties.Settings.Default.LocalCredentialsEnabled;
            CachingEnabledCheckbox.Checked = Properties.Settings.Default.cachingEnabled;
            StoreCacheCheckBox.Checked = Properties.Settings.Default.keepCache;
            alwaysLogAsAdmin.Checked = Properties.Settings.Default.alwaysLogAsAdmin;
            uriSchemeEnabled.Checked = Properties.Settings.Default.uriSchemeEnabled;
            textBoxLcsUrl.Text = Properties.Settings.Default.lcsURL;
            textBoxLcsUpdateUrl.Text = Properties.Settings.Default.lcsUpdateURL;
            textBoxLcsDiagUrl.Text = Properties.Settings.Default.lcsDiagURL;
            textBoxLcsFixUrl.Text = Properties.Settings.Default.lcsFixURL;
            addExternalIpAddress.Checked = Properties.Settings.Default.populateOwnIPForNSG;

            SetStoreCacheEnabledDisabled();
        }

        private void SetParameters()
        {
            Properties.Settings.Default.autorefresh = AutoRefreshCheckBox.Checked;
            Properties.Settings.Default.minimizeToNotificationArea = minimizeToNotificationArea.Checked;
            Properties.Settings.Default.projOrgExcl = textBoxProjectExcl.Text;
            Properties.Settings.Default.RDPCredentialsEnabled = RDPCredentialsCheckbox.Checked;
            Properties.Settings.Default.LocalCredentialsEnabled = LocalCredentialsCheckbox.Checked;
            Properties.Settings.Default.cachingEnabled = CachingEnabledCheckbox.Checked;
            Properties.Settings.Default.keepCache = StoreCacheCheckBox.Checked;
            Properties.Settings.Default.alwaysLogAsAdmin = alwaysLogAsAdmin.Checked;
            Properties.Settings.Default.uriSchemeEnabled = uriSchemeEnabled.Checked;
            Properties.Settings.Default.lcsURL = textBoxLcsUrl.Text;
            Properties.Settings.Default.lcsUpdateURL = textBoxLcsUpdateUrl.Text;
            Properties.Settings.Default.lcsDiagURL = textBoxLcsDiagUrl.Text;
            Properties.Settings.Default.lcsFixURL = textBoxLcsFixUrl.Text;
            Properties.Settings.Default.populateOwnIPForNSG = addExternalIpAddress.Checked;

            Properties.Settings.Default.Save();
        }

        private void CachingEnabledCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            SetStoreCacheEnabledDisabled();
        }

        private void SetStoreCacheEnabledDisabled()
        {
            if (CachingEnabledCheckbox.Checked)
            {
                StoreCacheCheckBox.Enabled = true;
            }
            else
            {
                StoreCacheCheckBox.Enabled = false;
                StoreCacheCheckBox.Checked = false;
                CredentialsCacheHelper.DisableCache();
            }
        }

        private void ClearCacheButton_Click(object sender, EventArgs e)
        {
            var result = CredentialsCacheHelper.ClearCache();

            if (result != null)
            {
                MessageBox.Show(string.Format("Error while trying to clear cache, caching disabled.\n {0}", result), "Error");
            }
        }

        private void OnUriSchemeEnabledCheckedChanged(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.uriSchemeEnabled != uriSchemeEnabled.Checked)
            {
                try
                {
                    bool success = false;
                    if (uriSchemeEnabled.Checked)
                    {
                        success = URIHandler.RegisterHandler();
                    }
                    else
                    {
                        success = URIHandler.RemoveHandler();
                    }
                    if (success)
                    {
                        SetParameters();
                    }
                }
                finally
                {
                    LoadParameters();
                }
            }
        }
    }
}