namespace LCS.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            cheDataGridView = new System.Windows.Forms.DataGridView();
            cheInstanceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cheEnvironmentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cheDisplayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cheDeploymentStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cheDeploymentAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cheCurrentApplicationBuildVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cheCurrentApplicationReleaseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cheCurrentPlatformVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cheCurrentPlatformReleaseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cheBuildInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cheDeployedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cheDeployedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cheTopologyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cheTopologyType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cheTopologyVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cheInstanceContextMenu = new System.Windows.Forms.ContextMenuStrip(components);
            cheLogonToAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cheOpenRDPConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cheManageVirtualMachineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cheStartInstanceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cheStopInstanceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cheDeallocateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cheDeleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cheRdpAndPasswordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cheShowPasswordsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cheShowPasswordsPowershellMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cheShowRDPDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cheExportRDCManConnectionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cheExportRDMConnectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cheAvailableHotfixesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cheMetadataHotfixesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cheApplicationBinaryHotfixesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            chePlatformHotfixesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cheDetailedBuildInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cheEnvironmentChangesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cheLcsInstanceLinksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cheInstanceDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cheEnvironmentMonitoringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cheDetailedVersionInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cheEnvironmenChangeHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cheDataPackagesHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cheLogonToPointOfSaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cheLaunchDynamicsRetailStorefrontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cheRetailServerURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cheLcsProjectLinksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cheServiceRequestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cheSupportIssuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cheOpenWorkItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cheAssetLibraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cheSystemDiagnosticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cheSubscriptionEstimatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cheSubscriptionsAvailableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cheProjectSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cheProjectUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cheDeployPackageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            mainMenuStrip = new System.Windows.Forms.MenuStrip();
            loginToLcsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            changeProjectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            refreshMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            customLinksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exportProjectDataToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            exportListOfUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            allProjectUsersExportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            currentProjectUsersExportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exportListOfInstancesForAllProjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            allInstancesExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            allProjectsTSMExportAllInstances = new System.Windows.Forms.ToolStripMenuItem();
            currentProjectTSMExportAllInstances = new System.Windows.Forms.ToolStripMenuItem();
            cloudHostedInstancesExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            mSHostedInstancesExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exportUpdateScheduleForAllProjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exportListOfEnvChangesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            allInstancesExportChangesTSM = new System.Windows.Forms.ToolStripMenuItem();
            cloudInstancesExportChangesTSM = new System.Windows.Forms.ToolStripMenuItem();
            saasInstancesExportChangesTSM = new System.Windows.Forms.ToolStripMenuItem();
            logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cookieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            parametersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            tabControl = new System.Windows.Forms.TabControl();
            cheTabPage = new System.Windows.Forms.TabPage();
            saasTabPage = new System.Windows.Forms.TabPage();
            saasDataGridView = new System.Windows.Forms.DataGridView();
            saasInstanceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            saasEnvironmentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            saasDisplayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            saasDeploymentStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            saasDeploymentAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            saasCurrentApplicationBuildVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            saasCurrentApplicationReleaseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            saasCurrentPlatformVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            saasCurrentPlatformReleaseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            saasBuildInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            saasDeployedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            saasDeployedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            saasTopologyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            saasTopologyType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            saasTopologyVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            saasInstanceContextMenu = new System.Windows.Forms.ContextMenuStrip(components);
            saasLogonToApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saasOpenRdpConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saasManageVirtualMachineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saasStartInstanceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saasStopInstanceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saasDeallocateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saasDeleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saasAddNsgRule = new System.Windows.Forms.ToolStripMenuItem();
            saasDeleteNsgRule = new System.Windows.Forms.ToolStripMenuItem();
            saasRestartService = new System.Windows.Forms.ToolStripMenuItem();
            saasRdpAndPasswordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saasShowPasswordsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saasShowPasswordsPowershellMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saasShowRDPDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saasExportRDCManConnectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saasExportRDMConnectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saasAvailableHotfixesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saasApplicationMetadataHotfixesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saasApplicationBinaryHotfixesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saasPlatformBinaryHotfixesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saasCriticalMetadataHotfixesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saasUpcomingUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saasDetailedBuildInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saasEnvironmentChangesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saasLcsInstanceLinksToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            saasInstanceDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saasEnvironmentMonitoringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saasDetailedVersionInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saasEnvironmentChangeHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saasDataPackagesHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saasLogonToPointOfSaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saasLaunchDynamicsRetailStorefrontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saasRetailServerURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saasLcsProjectLinksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saasServiceRequestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saasSupportIssuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saasOpenWorkItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saasAssetLibraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saasSystemDiagnosticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saasSubscriptionEstimatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saasSubscriptionsAvailableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saasProjectSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saasProjectUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saasDeployPackageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            statusStrip = new System.Windows.Forms.StatusStrip();
            projectDescriptionLabel = new System.Windows.Forms.ToolStripStatusLabel();
            toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            notifyIcon = new System.Windows.Forms.NotifyIcon(components);
            notifyIconContextMenu = new System.Windows.Forms.ContextMenuStrip(components);
            notifyIconMenuClose = new System.Windows.Forms.ToolStripMenuItem();
            exportListOfNuGetPackagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)cheDataGridView).BeginInit();
            cheInstanceContextMenu.SuspendLayout();
            mainMenuStrip.SuspendLayout();
            tabControl.SuspendLayout();
            cheTabPage.SuspendLayout();
            saasTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)saasDataGridView).BeginInit();
            saasInstanceContextMenu.SuspendLayout();
            statusStrip.SuspendLayout();
            notifyIconContextMenu.SuspendLayout();
            SuspendLayout();
            // 
            // cheDataGridView
            // 
            cheDataGridView.AllowUserToAddRows = false;
            cheDataGridView.AllowUserToDeleteRows = false;
            cheDataGridView.AllowUserToOrderColumns = true;
            cheDataGridView.AllowUserToResizeRows = false;
            cheDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            cheDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            cheDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cheDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { cheInstanceId, cheEnvironmentId, cheDisplayName, cheDeploymentStatus, cheDeploymentAction, cheCurrentApplicationBuildVersion, cheCurrentApplicationReleaseName, cheCurrentPlatformVersion, cheCurrentPlatformReleaseName, cheBuildInfo, cheDeployedBy, cheDeployedOn, cheTopologyName, cheTopologyType, cheTopologyVersion });
            cheDataGridView.ContextMenuStrip = cheInstanceContextMenu;
            cheDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            cheDataGridView.Location = new System.Drawing.Point(3, 3);
            cheDataGridView.Name = "cheDataGridView";
            cheDataGridView.ReadOnly = true;
            cheDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            cheDataGridView.Size = new System.Drawing.Size(1301, 750);
            cheDataGridView.TabIndex = 0;
            cheDataGridView.CellMouseDoubleClick += CheDataGridView_CellMouseDoubleClick;
            cheDataGridView.ColumnHeaderMouseClick += CheDataGridView_ColumnHeaderMouseClick;
            cheDataGridView.MouseDown += DataGridView_MouseDown;
            // 
            // cheInstanceId
            // 
            cheInstanceId.DataPropertyName = "InstanceId";
            cheInstanceId.HeaderText = "Instance Id";
            cheInstanceId.MinimumWidth = 8;
            cheInstanceId.Name = "cheInstanceId";
            cheInstanceId.ReadOnly = true;
            cheInstanceId.Width = 101;
            // 
            // cheEnvironmentId
            // 
            cheEnvironmentId.DataPropertyName = "EnvironmentId";
            cheEnvironmentId.HeaderText = "Environment Id";
            cheEnvironmentId.MinimumWidth = 8;
            cheEnvironmentId.Name = "cheEnvironmentId";
            cheEnvironmentId.ReadOnly = true;
            cheEnvironmentId.Width = 127;
            // 
            // cheDisplayName
            // 
            cheDisplayName.DataPropertyName = "DisplayName";
            cheDisplayName.HeaderText = "Display Name";
            cheDisplayName.MinimumWidth = 8;
            cheDisplayName.Name = "cheDisplayName";
            cheDisplayName.ReadOnly = true;
            cheDisplayName.Width = 120;
            // 
            // cheDeploymentStatus
            // 
            cheDeploymentStatus.DataPropertyName = "DeploymentStatus";
            cheDeploymentStatus.HeaderText = "Deployment Status";
            cheDeploymentStatus.MinimumWidth = 8;
            cheDeploymentStatus.Name = "cheDeploymentStatus";
            cheDeploymentStatus.ReadOnly = true;
            cheDeploymentStatus.Width = 150;
            // 
            // cheDeploymentAction
            // 
            cheDeploymentAction.DataPropertyName = "DeploymentAction";
            cheDeploymentAction.HeaderText = "Deployment Action";
            cheDeploymentAction.MinimumWidth = 8;
            cheDeploymentAction.Name = "cheDeploymentAction";
            cheDeploymentAction.ReadOnly = true;
            cheDeploymentAction.Width = 153;
            // 
            // cheCurrentApplicationBuildVersion
            // 
            cheCurrentApplicationBuildVersion.DataPropertyName = "CurrentApplicationBuildVersion";
            cheCurrentApplicationBuildVersion.HeaderText = "Current Application Build Version";
            cheCurrentApplicationBuildVersion.MinimumWidth = 9;
            cheCurrentApplicationBuildVersion.Name = "cheCurrentApplicationBuildVersion";
            cheCurrentApplicationBuildVersion.ReadOnly = true;
            cheCurrentApplicationBuildVersion.Width = 191;
            // 
            // cheCurrentApplicationReleaseName
            // 
            cheCurrentApplicationReleaseName.DataPropertyName = "CurrentApplicationReleaseName";
            cheCurrentApplicationReleaseName.HeaderText = "Current Application Release Name";
            cheCurrentApplicationReleaseName.MinimumWidth = 8;
            cheCurrentApplicationReleaseName.Name = "cheCurrentApplicationReleaseName";
            cheCurrentApplicationReleaseName.ReadOnly = true;
            cheCurrentApplicationReleaseName.Width = 206;
            // 
            // cheCurrentPlatformVersion
            // 
            cheCurrentPlatformVersion.DataPropertyName = "CurrentPlatformVersion";
            cheCurrentPlatformVersion.HeaderText = "Current Platform Version";
            cheCurrentPlatformVersion.MinimumWidth = 8;
            cheCurrentPlatformVersion.Name = "cheCurrentPlatformVersion";
            cheCurrentPlatformVersion.ReadOnly = true;
            cheCurrentPlatformVersion.Width = 182;
            // 
            // cheCurrentPlatformReleaseName
            // 
            cheCurrentPlatformReleaseName.DataPropertyName = "CurrentPlatformReleaseName";
            cheCurrentPlatformReleaseName.HeaderText = "Current Platform Release Name";
            cheCurrentPlatformReleaseName.MinimumWidth = 8;
            cheCurrentPlatformReleaseName.Name = "cheCurrentPlatformReleaseName";
            cheCurrentPlatformReleaseName.ReadOnly = true;
            cheCurrentPlatformReleaseName.Width = 188;
            // 
            // cheBuildInfo
            // 
            cheBuildInfo.DataPropertyName = "BuildInfo";
            cheBuildInfo.HeaderText = "Build Info";
            cheBuildInfo.MinimumWidth = 8;
            cheBuildInfo.Name = "cheBuildInfo";
            cheBuildInfo.ReadOnly = true;
            cheBuildInfo.Width = 94;
            // 
            // cheDeployedBy
            // 
            cheDeployedBy.DataPropertyName = "DeployedBy";
            cheDeployedBy.HeaderText = "Deployed By";
            cheDeployedBy.MinimumWidth = 8;
            cheDeployedBy.Name = "cheDeployedBy";
            cheDeployedBy.ReadOnly = true;
            cheDeployedBy.Width = 113;
            // 
            // cheDeployedOn
            // 
            cheDeployedOn.DataPropertyName = "DeployedOn";
            cheDeployedOn.HeaderText = "Deployed On";
            cheDeployedOn.MinimumWidth = 8;
            cheDeployedOn.Name = "cheDeployedOn";
            cheDeployedOn.ReadOnly = true;
            cheDeployedOn.Width = 116;
            // 
            // cheTopologyName
            // 
            cheTopologyName.DataPropertyName = "TopologyName";
            cheTopologyName.HeaderText = "Topology Name";
            cheTopologyName.MinimumWidth = 8;
            cheTopologyName.Name = "cheTopologyName";
            cheTopologyName.ReadOnly = true;
            cheTopologyName.Width = 133;
            // 
            // cheTopologyType
            // 
            cheTopologyType.DataPropertyName = "TopologyType";
            cheTopologyType.HeaderText = "Topology Type";
            cheTopologyType.MinimumWidth = 8;
            cheTopologyType.Name = "cheTopologyType";
            cheTopologyType.ReadOnly = true;
            cheTopologyType.Width = 125;
            // 
            // cheTopologyVersion
            // 
            cheTopologyVersion.DataPropertyName = "TopologyVersion";
            cheTopologyVersion.HeaderText = "Topology Version";
            cheTopologyVersion.MinimumWidth = 8;
            cheTopologyVersion.Name = "cheTopologyVersion";
            cheTopologyVersion.ReadOnly = true;
            cheTopologyVersion.Width = 140;
            // 
            // cheInstanceContextMenu
            // 
            cheInstanceContextMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            cheInstanceContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { cheLogonToAppToolStripMenuItem, cheOpenRDPConnectionToolStripMenuItem, cheManageVirtualMachineToolStripMenuItem, cheRdpAndPasswordsToolStripMenuItem, cheAvailableHotfixesToolStripMenuItem, cheDetailedBuildInfoToolStripMenuItem, cheEnvironmentChangesToolStripMenuItem, cheLcsInstanceLinksToolStripMenuItem, cheLcsProjectLinksToolStripMenuItem, cheDeployPackageToolStripMenuItem });
            cheInstanceContextMenu.Name = "instanceContextMenuStrip";
            cheInstanceContextMenu.Size = new System.Drawing.Size(224, 244);
            cheInstanceContextMenu.Opening += InstanceContextMenu_Opening;
            // 
            // cheLogonToAppToolStripMenuItem
            // 
            cheLogonToAppToolStripMenuItem.Name = "cheLogonToAppToolStripMenuItem";
            cheLogonToAppToolStripMenuItem.Size = new System.Drawing.Size(223, 24);
            cheLogonToAppToolStripMenuItem.Text = "Logon to application";
            cheLogonToAppToolStripMenuItem.Click += LogonToApplicationToolStripMenuItem_Click;
            // 
            // cheOpenRDPConnectionToolStripMenuItem
            // 
            cheOpenRDPConnectionToolStripMenuItem.Name = "cheOpenRDPConnectionToolStripMenuItem";
            cheOpenRDPConnectionToolStripMenuItem.Size = new System.Drawing.Size(223, 24);
            cheOpenRDPConnectionToolStripMenuItem.Text = "Open RDP connection";
            cheOpenRDPConnectionToolStripMenuItem.Click += OpenRDPConnectionToolStripMenuItem_Click;
            // 
            // cheManageVirtualMachineToolStripMenuItem
            // 
            cheManageVirtualMachineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { cheStartInstanceMenuItem, cheStopInstanceMenuItem, cheDeallocateMenuItem, cheDeleteMenuItem });
            cheManageVirtualMachineToolStripMenuItem.Name = "cheManageVirtualMachineToolStripMenuItem";
            cheManageVirtualMachineToolStripMenuItem.Size = new System.Drawing.Size(223, 24);
            cheManageVirtualMachineToolStripMenuItem.Text = "Manage instance";
            // 
            // cheStartInstanceMenuItem
            // 
            cheStartInstanceMenuItem.Name = "cheStartInstanceMenuItem";
            cheStartInstanceMenuItem.Size = new System.Drawing.Size(222, 26);
            cheStartInstanceMenuItem.Text = "Start instance(s)";
            cheStartInstanceMenuItem.Click += StartInstanceMenuItem_Click;
            // 
            // cheStopInstanceMenuItem
            // 
            cheStopInstanceMenuItem.Name = "cheStopInstanceMenuItem";
            cheStopInstanceMenuItem.Size = new System.Drawing.Size(222, 26);
            cheStopInstanceMenuItem.Text = "Stop instance(s)";
            cheStopInstanceMenuItem.Click += StopInstanceMenuItem_Click;
            // 
            // cheDeallocateMenuItem
            // 
            cheDeallocateMenuItem.Name = "cheDeallocateMenuItem";
            cheDeallocateMenuItem.Size = new System.Drawing.Size(222, 26);
            cheDeallocateMenuItem.Text = "Deallocate instance";
            cheDeallocateMenuItem.Click += DeallocateMenuItem_Click;
            // 
            // cheDeleteMenuItem
            // 
            cheDeleteMenuItem.Name = "cheDeleteMenuItem";
            cheDeleteMenuItem.Size = new System.Drawing.Size(222, 26);
            cheDeleteMenuItem.Text = "Delete instance";
            cheDeleteMenuItem.Click += DeleteMenuItem_Click;
            // 
            // cheRdpAndPasswordsToolStripMenuItem
            // 
            cheRdpAndPasswordsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { cheShowPasswordsMenuItem, cheShowPasswordsPowershellMenuItem, cheShowRDPDetailsToolStripMenuItem, cheExportRDCManConnectionsMenuItem, cheExportRDMConnectionsToolStripMenuItem });
            cheRdpAndPasswordsToolStripMenuItem.Name = "cheRdpAndPasswordsToolStripMenuItem";
            cheRdpAndPasswordsToolStripMenuItem.Size = new System.Drawing.Size(223, 24);
            cheRdpAndPasswordsToolStripMenuItem.Text = "RDP and passwords";
            // 
            // cheShowPasswordsMenuItem
            // 
            cheShowPasswordsMenuItem.Name = "cheShowPasswordsMenuItem";
            cheShowPasswordsMenuItem.Size = new System.Drawing.Size(287, 26);
            cheShowPasswordsMenuItem.Text = "Show passwords";
            cheShowPasswordsMenuItem.Click += CheShowPasswordsMenuItem_Click;
            // 
            // cheShowPasswordsPowershellMenuItem
            // 
            cheShowPasswordsPowershellMenuItem.Name = "cheShowPasswordsPowershellMenuItem";
            cheShowPasswordsPowershellMenuItem.Size = new System.Drawing.Size(287, 26);
            cheShowPasswordsPowershellMenuItem.Text = "Show passwords (powershell)";
            cheShowPasswordsPowershellMenuItem.Click += CheShowPasswordsPowershellMenuItem_Click;
            // 
            // cheShowRDPDetailsToolStripMenuItem
            // 
            cheShowRDPDetailsToolStripMenuItem.Name = "cheShowRDPDetailsToolStripMenuItem";
            cheShowRDPDetailsToolStripMenuItem.Size = new System.Drawing.Size(287, 26);
            cheShowRDPDetailsToolStripMenuItem.Text = "Show RDP details";
            cheShowRDPDetailsToolStripMenuItem.Click += ShowRDPDetailsToolStripMenuItem_Click;
            // 
            // cheExportRDCManConnectionsMenuItem
            // 
            cheExportRDCManConnectionsMenuItem.Name = "cheExportRDCManConnectionsMenuItem";
            cheExportRDCManConnectionsMenuItem.Size = new System.Drawing.Size(287, 26);
            cheExportRDCManConnectionsMenuItem.Text = "Export RDCMan connections";
            cheExportRDCManConnectionsMenuItem.ToolTipText = "Export all RDP connections to Remote Desktop Connection Manager import file";
            cheExportRDCManConnectionsMenuItem.Click += CheExportRDCManConnectionsMenuItem_Click;
            // 
            // cheExportRDMConnectionsToolStripMenuItem
            // 
            cheExportRDMConnectionsToolStripMenuItem.Name = "cheExportRDMConnectionsToolStripMenuItem";
            cheExportRDMConnectionsToolStripMenuItem.Size = new System.Drawing.Size(287, 26);
            cheExportRDMConnectionsToolStripMenuItem.Text = "Export RDM connections";
            cheExportRDMConnectionsToolStripMenuItem.Click += CheExportRDMConnectionsToolStripMenuItem_Click;
            // 
            // cheAvailableHotfixesToolStripMenuItem
            // 
            cheAvailableHotfixesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { cheMetadataHotfixesToolStripMenuItem, cheApplicationBinaryHotfixesToolStripMenuItem, chePlatformHotfixesToolStripMenuItem });
            cheAvailableHotfixesToolStripMenuItem.Name = "cheAvailableHotfixesToolStripMenuItem";
            cheAvailableHotfixesToolStripMenuItem.Size = new System.Drawing.Size(223, 24);
            cheAvailableHotfixesToolStripMenuItem.Text = "Available hotfixes";
            // 
            // cheMetadataHotfixesToolStripMenuItem
            // 
            cheMetadataHotfixesToolStripMenuItem.Name = "cheMetadataHotfixesToolStripMenuItem";
            cheMetadataHotfixesToolStripMenuItem.Size = new System.Drawing.Size(293, 26);
            cheMetadataHotfixesToolStripMenuItem.Text = "Application metadata hotfixes";
            cheMetadataHotfixesToolStripMenuItem.Click += HotfixesToolStripMenuItem_Click;
            // 
            // cheApplicationBinaryHotfixesToolStripMenuItem
            // 
            cheApplicationBinaryHotfixesToolStripMenuItem.Name = "cheApplicationBinaryHotfixesToolStripMenuItem";
            cheApplicationBinaryHotfixesToolStripMenuItem.Size = new System.Drawing.Size(293, 26);
            cheApplicationBinaryHotfixesToolStripMenuItem.Text = "Application binary hotfixes";
            cheApplicationBinaryHotfixesToolStripMenuItem.Click += HotfixesToolStripMenuItem_Click;
            // 
            // chePlatformHotfixesToolStripMenuItem
            // 
            chePlatformHotfixesToolStripMenuItem.Name = "chePlatformHotfixesToolStripMenuItem";
            chePlatformHotfixesToolStripMenuItem.Size = new System.Drawing.Size(293, 26);
            chePlatformHotfixesToolStripMenuItem.Text = "Platform binary hotfixes";
            chePlatformHotfixesToolStripMenuItem.Click += HotfixesToolStripMenuItem_Click;
            // 
            // cheDetailedBuildInfoToolStripMenuItem
            // 
            cheDetailedBuildInfoToolStripMenuItem.Name = "cheDetailedBuildInfoToolStripMenuItem";
            cheDetailedBuildInfoToolStripMenuItem.Size = new System.Drawing.Size(223, 24);
            cheDetailedBuildInfoToolStripMenuItem.Text = "Detailed build info";
            cheDetailedBuildInfoToolStripMenuItem.Click += DetailedBuildInfoToolStripMenuItem_Click;
            // 
            // cheEnvironmentChangesToolStripMenuItem
            // 
            cheEnvironmentChangesToolStripMenuItem.Name = "cheEnvironmentChangesToolStripMenuItem";
            cheEnvironmentChangesToolStripMenuItem.Size = new System.Drawing.Size(223, 24);
            cheEnvironmentChangesToolStripMenuItem.Text = "Environment changes";
            cheEnvironmentChangesToolStripMenuItem.Click += EnvironmentChangesToolStripMenuItem_Click;
            // 
            // cheLcsInstanceLinksToolStripMenuItem
            // 
            cheLcsInstanceLinksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { cheInstanceDetailsToolStripMenuItem, cheEnvironmentMonitoringToolStripMenuItem, cheDetailedVersionInformationToolStripMenuItem, cheEnvironmenChangeHistoryToolStripMenuItem, cheDataPackagesHistoryToolStripMenuItem, cheLogonToPointOfSaleToolStripMenuItem, cheLaunchDynamicsRetailStorefrontToolStripMenuItem, cheRetailServerURLToolStripMenuItem });
            cheLcsInstanceLinksToolStripMenuItem.Name = "cheLcsInstanceLinksToolStripMenuItem";
            cheLcsInstanceLinksToolStripMenuItem.Size = new System.Drawing.Size(223, 24);
            cheLcsInstanceLinksToolStripMenuItem.Text = "LCS instance links";
            // 
            // cheInstanceDetailsToolStripMenuItem
            // 
            cheInstanceDetailsToolStripMenuItem.Name = "cheInstanceDetailsToolStripMenuItem";
            cheInstanceDetailsToolStripMenuItem.Size = new System.Drawing.Size(319, 26);
            cheInstanceDetailsToolStripMenuItem.Text = "Instance details";
            cheInstanceDetailsToolStripMenuItem.Click += InstanceDetailsToolStripMenuItem_Click;
            // 
            // cheEnvironmentMonitoringToolStripMenuItem
            // 
            cheEnvironmentMonitoringToolStripMenuItem.Name = "cheEnvironmentMonitoringToolStripMenuItem";
            cheEnvironmentMonitoringToolStripMenuItem.Size = new System.Drawing.Size(319, 26);
            cheEnvironmentMonitoringToolStripMenuItem.Text = "Environment monitoring";
            cheEnvironmentMonitoringToolStripMenuItem.Click += EnvironmentMonitoringToolStripMenuItem_Click;
            // 
            // cheDetailedVersionInformationToolStripMenuItem
            // 
            cheDetailedVersionInformationToolStripMenuItem.Name = "cheDetailedVersionInformationToolStripMenuItem";
            cheDetailedVersionInformationToolStripMenuItem.Size = new System.Drawing.Size(319, 26);
            cheDetailedVersionInformationToolStripMenuItem.Text = "Detailed version information";
            cheDetailedVersionInformationToolStripMenuItem.Click += DetailedVersionInformationToolStripMenuItem_Click;
            // 
            // cheEnvironmenChangeHistoryToolStripMenuItem
            // 
            cheEnvironmenChangeHistoryToolStripMenuItem.Name = "cheEnvironmenChangeHistoryToolStripMenuItem";
            cheEnvironmenChangeHistoryToolStripMenuItem.Size = new System.Drawing.Size(319, 26);
            cheEnvironmenChangeHistoryToolStripMenuItem.Text = "Environment change history";
            cheEnvironmenChangeHistoryToolStripMenuItem.Click += EnvironmentChangeHistoryToolStripMenuItem_Click;
            // 
            // cheDataPackagesHistoryToolStripMenuItem
            // 
            cheDataPackagesHistoryToolStripMenuItem.Name = "cheDataPackagesHistoryToolStripMenuItem";
            cheDataPackagesHistoryToolStripMenuItem.Size = new System.Drawing.Size(319, 26);
            cheDataPackagesHistoryToolStripMenuItem.Text = "Data packages history";
            cheDataPackagesHistoryToolStripMenuItem.Click += DataPackagesHistoryToolStripMenuItem_Click;
            // 
            // cheLogonToPointOfSaleToolStripMenuItem
            // 
            cheLogonToPointOfSaleToolStripMenuItem.Name = "cheLogonToPointOfSaleToolStripMenuItem";
            cheLogonToPointOfSaleToolStripMenuItem.Size = new System.Drawing.Size(319, 26);
            cheLogonToPointOfSaleToolStripMenuItem.Text = "Logon to Point of Sale";
            cheLogonToPointOfSaleToolStripMenuItem.Click += LogonToPointOfSaleToolStripMenuItem_Click;
            // 
            // cheLaunchDynamicsRetailStorefrontToolStripMenuItem
            // 
            cheLaunchDynamicsRetailStorefrontToolStripMenuItem.Name = "cheLaunchDynamicsRetailStorefrontToolStripMenuItem";
            cheLaunchDynamicsRetailStorefrontToolStripMenuItem.Size = new System.Drawing.Size(319, 26);
            cheLaunchDynamicsRetailStorefrontToolStripMenuItem.Text = "Launch Dynamics Retail Storefront";
            cheLaunchDynamicsRetailStorefrontToolStripMenuItem.Click += LaunchDynamicsRetailStorefrontToolStripMenuItem_Click;
            // 
            // cheRetailServerURLToolStripMenuItem
            // 
            cheRetailServerURLToolStripMenuItem.Name = "cheRetailServerURLToolStripMenuItem";
            cheRetailServerURLToolStripMenuItem.Size = new System.Drawing.Size(319, 26);
            cheRetailServerURLToolStripMenuItem.Text = "Retail Server URL";
            cheRetailServerURLToolStripMenuItem.Click += RetailServerURLToolStripMenuItem_Click;
            // 
            // cheLcsProjectLinksToolStripMenuItem
            // 
            cheLcsProjectLinksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { cheServiceRequestsToolStripMenuItem, cheSupportIssuesToolStripMenuItem, cheOpenWorkItemsToolStripMenuItem, cheAssetLibraryToolStripMenuItem, cheSystemDiagnosticsToolStripMenuItem, cheSubscriptionEstimatorToolStripMenuItem, cheSubscriptionsAvailableToolStripMenuItem, cheProjectSettingsToolStripMenuItem, cheProjectUsersToolStripMenuItem });
            cheLcsProjectLinksToolStripMenuItem.Name = "cheLcsProjectLinksToolStripMenuItem";
            cheLcsProjectLinksToolStripMenuItem.Size = new System.Drawing.Size(223, 24);
            cheLcsProjectLinksToolStripMenuItem.Text = "LCS project links";
            // 
            // cheServiceRequestsToolStripMenuItem
            // 
            cheServiceRequestsToolStripMenuItem.Name = "cheServiceRequestsToolStripMenuItem";
            cheServiceRequestsToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            cheServiceRequestsToolStripMenuItem.Text = "Service requests";
            cheServiceRequestsToolStripMenuItem.Click += ServiceRequestsToolStripMenuItem_Click;
            // 
            // cheSupportIssuesToolStripMenuItem
            // 
            cheSupportIssuesToolStripMenuItem.Name = "cheSupportIssuesToolStripMenuItem";
            cheSupportIssuesToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            cheSupportIssuesToolStripMenuItem.Text = "Support issues";
            cheSupportIssuesToolStripMenuItem.Click += SupportIssuesToolStripMenuItem_Click;
            // 
            // cheOpenWorkItemsToolStripMenuItem
            // 
            cheOpenWorkItemsToolStripMenuItem.Name = "cheOpenWorkItemsToolStripMenuItem";
            cheOpenWorkItemsToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            cheOpenWorkItemsToolStripMenuItem.Text = "Open work items";
            cheOpenWorkItemsToolStripMenuItem.Click += OpenWorkItemsToolStripMenuItem_Click;
            // 
            // cheAssetLibraryToolStripMenuItem
            // 
            cheAssetLibraryToolStripMenuItem.Name = "cheAssetLibraryToolStripMenuItem";
            cheAssetLibraryToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            cheAssetLibraryToolStripMenuItem.Text = "Asset library";
            cheAssetLibraryToolStripMenuItem.Click += AssetLibraryToolStripMenuItem_Click;
            // 
            // cheSystemDiagnosticsToolStripMenuItem
            // 
            cheSystemDiagnosticsToolStripMenuItem.Name = "cheSystemDiagnosticsToolStripMenuItem";
            cheSystemDiagnosticsToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            cheSystemDiagnosticsToolStripMenuItem.Text = "System diagnostics";
            cheSystemDiagnosticsToolStripMenuItem.Click += SystemDiagnosticsToolStripMenuItem_Click;
            // 
            // cheSubscriptionEstimatorToolStripMenuItem
            // 
            cheSubscriptionEstimatorToolStripMenuItem.Name = "cheSubscriptionEstimatorToolStripMenuItem";
            cheSubscriptionEstimatorToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            cheSubscriptionEstimatorToolStripMenuItem.Text = "Subscription estimator";
            cheSubscriptionEstimatorToolStripMenuItem.Click += SubscriptionEstimatorToolStripMenuItem_Click;
            // 
            // cheSubscriptionsAvailableToolStripMenuItem
            // 
            cheSubscriptionsAvailableToolStripMenuItem.Name = "cheSubscriptionsAvailableToolStripMenuItem";
            cheSubscriptionsAvailableToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            cheSubscriptionsAvailableToolStripMenuItem.Text = "Subscriptions available";
            cheSubscriptionsAvailableToolStripMenuItem.Click += SubscriptionsAvailableToolStripMenuItem_Click;
            // 
            // cheProjectSettingsToolStripMenuItem
            // 
            cheProjectSettingsToolStripMenuItem.Name = "cheProjectSettingsToolStripMenuItem";
            cheProjectSettingsToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            cheProjectSettingsToolStripMenuItem.Text = "Project settings";
            cheProjectSettingsToolStripMenuItem.Click += ProjectSettingsToolStripMenuItem_Click;
            // 
            // cheProjectUsersToolStripMenuItem
            // 
            cheProjectUsersToolStripMenuItem.Name = "cheProjectUsersToolStripMenuItem";
            cheProjectUsersToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            cheProjectUsersToolStripMenuItem.Text = "Project users";
            cheProjectUsersToolStripMenuItem.Click += ProjectUsersToolStripMenuItem_Click;
            // 
            // cheDeployPackageToolStripMenuItem
            // 
            cheDeployPackageToolStripMenuItem.Name = "cheDeployPackageToolStripMenuItem";
            cheDeployPackageToolStripMenuItem.Size = new System.Drawing.Size(223, 24);
            cheDeployPackageToolStripMenuItem.Text = "Deploy package";
            cheDeployPackageToolStripMenuItem.Click += DeployPackageToolStripMenuItem_Click;
            // 
            // mainMenuStrip
            // 
            mainMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { loginToLcsMenuItem, changeProjectMenuItem, refreshMenuItem, customLinksToolStripMenuItem, exportToolStripMenuItem, logoutToolStripMenuItem, cookieToolStripMenuItem, parametersToolStripMenuItem, aboutToolStripMenuItem });
            mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            mainMenuStrip.Name = "mainMenuStrip";
            mainMenuStrip.Padding = new System.Windows.Forms.Padding(5, 3, 0, 3);
            mainMenuStrip.Size = new System.Drawing.Size(1315, 30);
            mainMenuStrip.TabIndex = 0;
            mainMenuStrip.Text = "menuStrip1";
            // 
            // loginToLcsMenuItem
            // 
            loginToLcsMenuItem.Name = "loginToLcsMenuItem";
            loginToLcsMenuItem.Size = new System.Drawing.Size(105, 24);
            loginToLcsMenuItem.Text = "&Login to LCS";
            loginToLcsMenuItem.Click += LoginToLCSMenuItem_Click;
            // 
            // changeProjectMenuItem
            // 
            changeProjectMenuItem.Enabled = false;
            changeProjectMenuItem.Name = "changeProjectMenuItem";
            changeProjectMenuItem.Size = new System.Drawing.Size(177, 24);
            changeProjectMenuItem.Text = "&Change project context";
            changeProjectMenuItem.Click += ChangeProjectMenuItem_Click;
            // 
            // refreshMenuItem
            // 
            refreshMenuItem.Enabled = false;
            refreshMenuItem.Name = "refreshMenuItem";
            refreshMenuItem.Size = new System.Drawing.Size(210, 24);
            refreshMenuItem.Text = "&Refresh instances for project";
            refreshMenuItem.Click += RefreshMenuItem_Click;
            // 
            // customLinksToolStripMenuItem
            // 
            customLinksToolStripMenuItem.Name = "customLinksToolStripMenuItem";
            customLinksToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            customLinksToolStripMenuItem.Text = "Define c&ustom links";
            customLinksToolStripMenuItem.Click += CustomLinksToolStripMenuItem_Click;
            // 
            // exportToolStripMenuItem
            // 
            exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { exportProjectDataToolStripMenuItem1, exportListOfUsersToolStripMenuItem, exportListOfInstancesForAllProjectsToolStripMenuItem, exportUpdateScheduleForAllProjectsToolStripMenuItem, exportListOfEnvChangesToolStripMenuItem, exportListOfNuGetPackagesToolStripMenuItem });
            exportToolStripMenuItem.Enabled = false;
            exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            exportToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            exportToolStripMenuItem.Text = "Export";
            // 
            // exportProjectDataToolStripMenuItem1
            // 
            exportProjectDataToolStripMenuItem1.Name = "exportProjectDataToolStripMenuItem1";
            exportProjectDataToolStripMenuItem1.Size = new System.Drawing.Size(445, 26);
            exportProjectDataToolStripMenuItem1.Text = "Export project data";
            exportProjectDataToolStripMenuItem1.Click += ExportProjectDataToolStripMenuItem_Click;
            // 
            // exportListOfUsersToolStripMenuItem
            // 
            exportListOfUsersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { allProjectUsersExportMenuItem, currentProjectUsersExportMenuItem });
            exportListOfUsersToolStripMenuItem.Name = "exportListOfUsersToolStripMenuItem";
            exportListOfUsersToolStripMenuItem.Size = new System.Drawing.Size(445, 26);
            exportListOfUsersToolStripMenuItem.Text = "Export list of users";
            // 
            // allProjectUsersExportMenuItem
            // 
            allProjectUsersExportMenuItem.Name = "allProjectUsersExportMenuItem";
            allProjectUsersExportMenuItem.Size = new System.Drawing.Size(191, 26);
            allProjectUsersExportMenuItem.Text = "All projects";
            allProjectUsersExportMenuItem.Click += allProjectUsersExportMenuItem_Click;
            // 
            // currentProjectUsersExportMenuItem
            // 
            currentProjectUsersExportMenuItem.Name = "currentProjectUsersExportMenuItem";
            currentProjectUsersExportMenuItem.Size = new System.Drawing.Size(191, 26);
            currentProjectUsersExportMenuItem.Text = "Current project";
            currentProjectUsersExportMenuItem.Click += currentProjectUsersExportMenuItem_Click;
            // 
            // exportListOfInstancesForAllProjectsToolStripMenuItem
            // 
            exportListOfInstancesForAllProjectsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { allInstancesExportToolStripMenuItem, cloudHostedInstancesExportToolStripMenuItem, mSHostedInstancesExportToolStripMenuItem });
            exportListOfInstancesForAllProjectsToolStripMenuItem.Name = "exportListOfInstancesForAllProjectsToolStripMenuItem";
            exportListOfInstancesForAllProjectsToolStripMenuItem.Size = new System.Drawing.Size(445, 26);
            exportListOfInstancesForAllProjectsToolStripMenuItem.Text = "Export list of instances";
            // 
            // allInstancesExportToolStripMenuItem
            // 
            allInstancesExportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { allProjectsTSMExportAllInstances, currentProjectTSMExportAllInstances });
            allInstancesExportToolStripMenuItem.Name = "allInstancesExportToolStripMenuItem";
            allInstancesExportToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            allInstancesExportToolStripMenuItem.Text = "All instances";
            // 
            // allProjectsTSMExportAllInstances
            // 
            allProjectsTSMExportAllInstances.Name = "allProjectsTSMExportAllInstances";
            allProjectsTSMExportAllInstances.Size = new System.Drawing.Size(191, 26);
            allProjectsTSMExportAllInstances.Text = "All projects";
            allProjectsTSMExportAllInstances.Click += allProjectsTSMExportAllInstances_Click;
            // 
            // currentProjectTSMExportAllInstances
            // 
            currentProjectTSMExportAllInstances.Name = "currentProjectTSMExportAllInstances";
            currentProjectTSMExportAllInstances.Size = new System.Drawing.Size(191, 26);
            currentProjectTSMExportAllInstances.Text = "Current project";
            currentProjectTSMExportAllInstances.Click += currentProjectTSMExportAllInstances_Click;
            // 
            // cloudHostedInstancesExportToolStripMenuItem
            // 
            cloudHostedInstancesExportToolStripMenuItem.Name = "cloudHostedInstancesExportToolStripMenuItem";
            cloudHostedInstancesExportToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            cloudHostedInstancesExportToolStripMenuItem.Text = "Cloud hosted (all projects)";
            cloudHostedInstancesExportToolStripMenuItem.Click += CloudHostedInstancesExportToolStripMenuItem_Click;
            // 
            // mSHostedInstancesExportToolStripMenuItem
            // 
            mSHostedInstancesExportToolStripMenuItem.Name = "mSHostedInstancesExportToolStripMenuItem";
            mSHostedInstancesExportToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            mSHostedInstancesExportToolStripMenuItem.Text = "MS hosted (all projects)";
            mSHostedInstancesExportToolStripMenuItem.Click += MSHostedInstancesExportToolStripMenuItem_Click;
            // 
            // exportUpdateScheduleForAllProjectsToolStripMenuItem
            // 
            exportUpdateScheduleForAllProjectsToolStripMenuItem.Name = "exportUpdateScheduleForAllProjectsToolStripMenuItem";
            exportUpdateScheduleForAllProjectsToolStripMenuItem.Size = new System.Drawing.Size(445, 26);
            exportUpdateScheduleForAllProjectsToolStripMenuItem.Text = "Export update schedule for all projects";
            exportUpdateScheduleForAllProjectsToolStripMenuItem.Click += ExportUpdateScheduleForAllProjectsToolStripMenuItem_Click;
            // 
            // exportListOfEnvChangesToolStripMenuItem
            // 
            exportListOfEnvChangesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { allInstancesExportChangesTSM, cloudInstancesExportChangesTSM, saasInstancesExportChangesTSM });
            exportListOfEnvChangesToolStripMenuItem.Name = "exportListOfEnvChangesToolStripMenuItem";
            exportListOfEnvChangesToolStripMenuItem.Size = new System.Drawing.Size(445, 26);
            exportListOfEnvChangesToolStripMenuItem.Text = "Export list of environment changes for current project";
            // 
            // allInstancesExportChangesTSM
            // 
            allInstancesExportChangesTSM.Name = "allInstancesExportChangesTSM";
            allInstancesExportChangesTSM.Size = new System.Drawing.Size(207, 26);
            allInstancesExportChangesTSM.Text = "All instances";
            allInstancesExportChangesTSM.Click += allInstancesExportChangesTSM_Click;
            // 
            // cloudInstancesExportChangesTSM
            // 
            cloudInstancesExportChangesTSM.Name = "cloudInstancesExportChangesTSM";
            cloudInstancesExportChangesTSM.Size = new System.Drawing.Size(207, 26);
            cloudInstancesExportChangesTSM.Text = "Cloud hosted";
            cloudInstancesExportChangesTSM.Click += cloudInstancesExportChangesTSM_Click;
            // 
            // saasInstancesExportChangesTSM
            // 
            saasInstancesExportChangesTSM.Name = "saasInstancesExportChangesTSM";
            saasInstancesExportChangesTSM.Size = new System.Drawing.Size(207, 26);
            saasInstancesExportChangesTSM.Text = "Microsoft Hosted";
            saasInstancesExportChangesTSM.Click += saasInstancesExportChangesTSM_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Enabled = false;
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += LogoutToolStripMenuItem_Click;
            // 
            // cookieToolStripMenuItem
            // 
            cookieToolStripMenuItem.Name = "cookieToolStripMenuItem";
            cookieToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            cookieToolStripMenuItem.Text = "Cookie";
            cookieToolStripMenuItem.Click += CookieToolStripMenuItem_Click;
            // 
            // parametersToolStripMenuItem
            // 
            parametersToolStripMenuItem.Name = "parametersToolStripMenuItem";
            parametersToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            parametersToolStripMenuItem.Text = "Parameters";
            parametersToolStripMenuItem.Click += ParametersToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(cheTabPage);
            tabControl.Controls.Add(saasTabPage);
            tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl.Location = new System.Drawing.Point(0, 30);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new System.Drawing.Size(1315, 789);
            tabControl.TabIndex = 1;
            // 
            // cheTabPage
            // 
            cheTabPage.Controls.Add(cheDataGridView);
            cheTabPage.Location = new System.Drawing.Point(4, 29);
            cheTabPage.Name = "cheTabPage";
            cheTabPage.Padding = new System.Windows.Forms.Padding(3);
            cheTabPage.Size = new System.Drawing.Size(1307, 756);
            cheTabPage.TabIndex = 0;
            cheTabPage.Text = "Cloud-hosted instances";
            cheTabPage.UseVisualStyleBackColor = true;
            // 
            // saasTabPage
            // 
            saasTabPage.Controls.Add(saasDataGridView);
            saasTabPage.Location = new System.Drawing.Point(4, 29);
            saasTabPage.Name = "saasTabPage";
            saasTabPage.Padding = new System.Windows.Forms.Padding(3);
            saasTabPage.Size = new System.Drawing.Size(1307, 756);
            saasTabPage.TabIndex = 1;
            saasTabPage.Text = "MS-hosted environments";
            saasTabPage.UseVisualStyleBackColor = true;
            // 
            // saasDataGridView
            // 
            saasDataGridView.AllowUserToAddRows = false;
            saasDataGridView.AllowUserToDeleteRows = false;
            saasDataGridView.AllowUserToOrderColumns = true;
            saasDataGridView.AllowUserToResizeRows = false;
            saasDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            saasDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            saasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            saasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { saasInstanceId, saasEnvironmentId, saasDisplayName, saasDeploymentStatus, saasDeploymentAction, saasCurrentApplicationBuildVersion, saasCurrentApplicationReleaseName, saasCurrentPlatformVersion, saasCurrentPlatformReleaseName, saasBuildInfo, saasDeployedBy, saasDeployedOn, saasTopologyName, saasTopologyType, saasTopologyVersion });
            saasDataGridView.ContextMenuStrip = saasInstanceContextMenu;
            saasDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            saasDataGridView.Location = new System.Drawing.Point(3, 3);
            saasDataGridView.Name = "saasDataGridView";
            saasDataGridView.ReadOnly = true;
            saasDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            saasDataGridView.Size = new System.Drawing.Size(1301, 750);
            saasDataGridView.TabIndex = 1;
            saasDataGridView.ColumnHeaderMouseClick += SaasDataGridView_ColumnHeaderMouseClick;
            saasDataGridView.MouseDown += DataGridView_MouseDown;
            // 
            // saasInstanceId
            // 
            saasInstanceId.DataPropertyName = "InstanceId";
            saasInstanceId.HeaderText = "Instance Id";
            saasInstanceId.MinimumWidth = 8;
            saasInstanceId.Name = "saasInstanceId";
            saasInstanceId.ReadOnly = true;
            saasInstanceId.Width = 101;
            // 
            // saasEnvironmentId
            // 
            saasEnvironmentId.DataPropertyName = "EnvironmentId";
            saasEnvironmentId.HeaderText = "Environment Id";
            saasEnvironmentId.MinimumWidth = 8;
            saasEnvironmentId.Name = "saasEnvironmentId";
            saasEnvironmentId.ReadOnly = true;
            saasEnvironmentId.Width = 127;
            // 
            // saasDisplayName
            // 
            saasDisplayName.DataPropertyName = "DisplayName";
            saasDisplayName.HeaderText = "Display Name";
            saasDisplayName.MinimumWidth = 8;
            saasDisplayName.Name = "saasDisplayName";
            saasDisplayName.ReadOnly = true;
            saasDisplayName.Width = 120;
            // 
            // saasDeploymentStatus
            // 
            saasDeploymentStatus.DataPropertyName = "DeploymentStatus";
            saasDeploymentStatus.HeaderText = "Deployment Status";
            saasDeploymentStatus.MinimumWidth = 8;
            saasDeploymentStatus.Name = "saasDeploymentStatus";
            saasDeploymentStatus.ReadOnly = true;
            saasDeploymentStatus.Width = 150;
            // 
            // saasDeploymentAction
            // 
            saasDeploymentAction.DataPropertyName = "DeploymentAction";
            saasDeploymentAction.HeaderText = "Deployment Action";
            saasDeploymentAction.MinimumWidth = 8;
            saasDeploymentAction.Name = "saasDeploymentAction";
            saasDeploymentAction.ReadOnly = true;
            saasDeploymentAction.Width = 153;
            // 
            // saasCurrentApplicationBuildVersion
            // 
            saasCurrentApplicationBuildVersion.DataPropertyName = "CurrentApplicationBuildVersion";
            saasCurrentApplicationBuildVersion.HeaderText = "Current Application Build Version";
            saasCurrentApplicationBuildVersion.MinimumWidth = 9;
            saasCurrentApplicationBuildVersion.Name = "saasCurrentApplicationBuildVersion";
            saasCurrentApplicationBuildVersion.ReadOnly = true;
            saasCurrentApplicationBuildVersion.Width = 191;
            // 
            // saasCurrentApplicationReleaseName
            // 
            saasCurrentApplicationReleaseName.DataPropertyName = "CurrentApplicationReleaseName";
            saasCurrentApplicationReleaseName.HeaderText = "Current Application Release Name";
            saasCurrentApplicationReleaseName.MinimumWidth = 8;
            saasCurrentApplicationReleaseName.Name = "saasCurrentApplicationReleaseName";
            saasCurrentApplicationReleaseName.ReadOnly = true;
            saasCurrentApplicationReleaseName.Width = 206;
            // 
            // saasCurrentPlatformVersion
            // 
            saasCurrentPlatformVersion.DataPropertyName = "CurrentPlatformVersion";
            saasCurrentPlatformVersion.HeaderText = "Current Platform Version";
            saasCurrentPlatformVersion.MinimumWidth = 8;
            saasCurrentPlatformVersion.Name = "saasCurrentPlatformVersion";
            saasCurrentPlatformVersion.ReadOnly = true;
            saasCurrentPlatformVersion.Width = 182;
            // 
            // saasCurrentPlatformReleaseName
            // 
            saasCurrentPlatformReleaseName.DataPropertyName = "CurrentPlatformReleaseName";
            saasCurrentPlatformReleaseName.HeaderText = "Current Platform Release Name";
            saasCurrentPlatformReleaseName.MinimumWidth = 8;
            saasCurrentPlatformReleaseName.Name = "saasCurrentPlatformReleaseName";
            saasCurrentPlatformReleaseName.ReadOnly = true;
            saasCurrentPlatformReleaseName.Width = 188;
            // 
            // saasBuildInfo
            // 
            saasBuildInfo.DataPropertyName = "BuildInfo";
            saasBuildInfo.HeaderText = "Build Info";
            saasBuildInfo.MinimumWidth = 8;
            saasBuildInfo.Name = "saasBuildInfo";
            saasBuildInfo.ReadOnly = true;
            saasBuildInfo.Width = 94;
            // 
            // saasDeployedBy
            // 
            saasDeployedBy.DataPropertyName = "DeployedBy";
            saasDeployedBy.HeaderText = "Deployed By";
            saasDeployedBy.MinimumWidth = 8;
            saasDeployedBy.Name = "saasDeployedBy";
            saasDeployedBy.ReadOnly = true;
            saasDeployedBy.Width = 113;
            // 
            // saasDeployedOn
            // 
            saasDeployedOn.DataPropertyName = "DeployedOn";
            saasDeployedOn.HeaderText = "Deployed On";
            saasDeployedOn.MinimumWidth = 8;
            saasDeployedOn.Name = "saasDeployedOn";
            saasDeployedOn.ReadOnly = true;
            saasDeployedOn.Width = 116;
            // 
            // saasTopologyName
            // 
            saasTopologyName.DataPropertyName = "TopologyName";
            saasTopologyName.HeaderText = "Topology Name";
            saasTopologyName.MinimumWidth = 8;
            saasTopologyName.Name = "saasTopologyName";
            saasTopologyName.ReadOnly = true;
            saasTopologyName.Width = 133;
            // 
            // saasTopologyType
            // 
            saasTopologyType.DataPropertyName = "TopologyType";
            saasTopologyType.HeaderText = "Topology Type";
            saasTopologyType.MinimumWidth = 8;
            saasTopologyType.Name = "saasTopologyType";
            saasTopologyType.ReadOnly = true;
            saasTopologyType.Width = 125;
            // 
            // saasTopologyVersion
            // 
            saasTopologyVersion.DataPropertyName = "TopologyVersion";
            saasTopologyVersion.HeaderText = "Topology Version";
            saasTopologyVersion.MinimumWidth = 8;
            saasTopologyVersion.Name = "saasTopologyVersion";
            saasTopologyVersion.ReadOnly = true;
            saasTopologyVersion.Width = 140;
            // 
            // saasInstanceContextMenu
            // 
            saasInstanceContextMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            saasInstanceContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { saasLogonToApplicationToolStripMenuItem, saasOpenRdpConnectionToolStripMenuItem, saasManageVirtualMachineToolStripMenuItem, saasRdpAndPasswordsToolStripMenuItem, saasAvailableHotfixesToolStripMenuItem, saasUpcomingUpdatesToolStripMenuItem, saasDetailedBuildInfoToolStripMenuItem, saasEnvironmentChangesToolStripMenuItem, saasLcsInstanceLinksToolStripMenuItem1, saasLcsProjectLinksToolStripMenuItem, saasDeployPackageToolStripMenuItem });
            saasInstanceContextMenu.Name = "instanceContextMenuStrip";
            saasInstanceContextMenu.Size = new System.Drawing.Size(226, 268);
            saasInstanceContextMenu.Opening += InstanceContextMenu_Opening;
            // 
            // saasLogonToApplicationToolStripMenuItem
            // 
            saasLogonToApplicationToolStripMenuItem.Name = "saasLogonToApplicationToolStripMenuItem";
            saasLogonToApplicationToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            saasLogonToApplicationToolStripMenuItem.Text = "Logon to application";
            saasLogonToApplicationToolStripMenuItem.Click += LogonToApplicationToolStripMenuItem_Click;
            // 
            // saasOpenRdpConnectionToolStripMenuItem
            // 
            saasOpenRdpConnectionToolStripMenuItem.Name = "saasOpenRdpConnectionToolStripMenuItem";
            saasOpenRdpConnectionToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            saasOpenRdpConnectionToolStripMenuItem.Text = "Open RDP Connection";
            saasOpenRdpConnectionToolStripMenuItem.Click += SaasOpenRdpConnectionToolStripMenuItem_Click;
            // 
            // saasManageVirtualMachineToolStripMenuItem
            // 
            saasManageVirtualMachineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { saasStartInstanceMenuItem, saasStopInstanceMenuItem, saasDeallocateMenuItem, saasDeleteMenuItem, saasAddNsgRule, saasDeleteNsgRule, saasRestartService });
            saasManageVirtualMachineToolStripMenuItem.Name = "saasManageVirtualMachineToolStripMenuItem";
            saasManageVirtualMachineToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            saasManageVirtualMachineToolStripMenuItem.Text = "Manage instance";
            // 
            // saasStartInstanceMenuItem
            // 
            saasStartInstanceMenuItem.Name = "saasStartInstanceMenuItem";
            saasStartInstanceMenuItem.Size = new System.Drawing.Size(258, 26);
            saasStartInstanceMenuItem.Text = "Start instance(s)";
            saasStartInstanceMenuItem.Click += StartInstanceMenuItem_Click;
            // 
            // saasStopInstanceMenuItem
            // 
            saasStopInstanceMenuItem.Name = "saasStopInstanceMenuItem";
            saasStopInstanceMenuItem.Size = new System.Drawing.Size(258, 26);
            saasStopInstanceMenuItem.Text = "Stop instance(s)";
            saasStopInstanceMenuItem.Click += StopInstanceMenuItem_Click;
            // 
            // saasDeallocateMenuItem
            // 
            saasDeallocateMenuItem.Name = "saasDeallocateMenuItem";
            saasDeallocateMenuItem.Size = new System.Drawing.Size(258, 26);
            saasDeallocateMenuItem.Text = "Deallocate instance";
            saasDeallocateMenuItem.Click += DeallocateMenuItem_Click;
            // 
            // saasDeleteMenuItem
            // 
            saasDeleteMenuItem.Name = "saasDeleteMenuItem";
            saasDeleteMenuItem.Size = new System.Drawing.Size(258, 26);
            saasDeleteMenuItem.Text = "Delete instance";
            saasDeleteMenuItem.Click += DeleteMenuItem_Click;
            // 
            // saasAddNsgRule
            // 
            saasAddNsgRule.Name = "saasAddNsgRule";
            saasAddNsgRule.Size = new System.Drawing.Size(258, 26);
            saasAddNsgRule.Text = "Add firewall exception";
            saasAddNsgRule.Click += SaasAddNsgRule_Click;
            // 
            // saasDeleteNsgRule
            // 
            saasDeleteNsgRule.Name = "saasDeleteNsgRule";
            saasDeleteNsgRule.Size = new System.Drawing.Size(258, 26);
            saasDeleteNsgRule.Text = "Delete firewall exception";
            saasDeleteNsgRule.Click += SaasDeleteNsgRule_Click;
            // 
            // saasRestartService
            // 
            saasRestartService.Name = "saasRestartService";
            saasRestartService.Size = new System.Drawing.Size(258, 26);
            saasRestartService.Text = "Restart service";
            saasRestartService.Click += SaasRestartService_Click;
            // 
            // saasRdpAndPasswordsToolStripMenuItem
            // 
            saasRdpAndPasswordsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { saasShowPasswordsMenuItem, saasShowPasswordsPowershellMenuItem, saasShowRDPDetailsToolStripMenuItem, saasExportRDCManConnectionsToolStripMenuItem, saasExportRDMConnectionsToolStripMenuItem });
            saasRdpAndPasswordsToolStripMenuItem.Name = "saasRdpAndPasswordsToolStripMenuItem";
            saasRdpAndPasswordsToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            saasRdpAndPasswordsToolStripMenuItem.Text = "RDP and passwords";
            // 
            // saasShowPasswordsMenuItem
            // 
            saasShowPasswordsMenuItem.Name = "saasShowPasswordsMenuItem";
            saasShowPasswordsMenuItem.Size = new System.Drawing.Size(287, 26);
            saasShowPasswordsMenuItem.Text = "Show passwords";
            saasShowPasswordsMenuItem.Click += SaasShowPasswordsMenuItem_Click;
            // 
            // saasShowPasswordsPowershellMenuItem
            // 
            saasShowPasswordsPowershellMenuItem.Name = "saasShowPasswordsPowershellMenuItem";
            saasShowPasswordsPowershellMenuItem.Size = new System.Drawing.Size(287, 26);
            saasShowPasswordsPowershellMenuItem.Text = "Show passwords (powershell)";
            saasShowPasswordsPowershellMenuItem.Click += SaasShowPasswordsPowershellMenuItem_Click;
            // 
            // saasShowRDPDetailsToolStripMenuItem
            // 
            saasShowRDPDetailsToolStripMenuItem.Name = "saasShowRDPDetailsToolStripMenuItem";
            saasShowRDPDetailsToolStripMenuItem.Size = new System.Drawing.Size(287, 26);
            saasShowRDPDetailsToolStripMenuItem.Text = "Show RDP details";
            saasShowRDPDetailsToolStripMenuItem.Click += ShowRDPDetailsToolStripMenuItem_Click;
            // 
            // saasExportRDCManConnectionsToolStripMenuItem
            // 
            saasExportRDCManConnectionsToolStripMenuItem.Name = "saasExportRDCManConnectionsToolStripMenuItem";
            saasExportRDCManConnectionsToolStripMenuItem.Size = new System.Drawing.Size(287, 26);
            saasExportRDCManConnectionsToolStripMenuItem.Text = "Export RDCMan connections";
            saasExportRDCManConnectionsToolStripMenuItem.ToolTipText = "Export all RDP connections to Remote Desktop Connection Manager import file";
            saasExportRDCManConnectionsToolStripMenuItem.Click += SaasExportRDCManConnectionsToolStripMenuItem_Click;
            // 
            // saasExportRDMConnectionsToolStripMenuItem
            // 
            saasExportRDMConnectionsToolStripMenuItem.Name = "saasExportRDMConnectionsToolStripMenuItem";
            saasExportRDMConnectionsToolStripMenuItem.Size = new System.Drawing.Size(287, 26);
            saasExportRDMConnectionsToolStripMenuItem.Text = "Export RDM connections";
            saasExportRDMConnectionsToolStripMenuItem.Click += SaasExportRDMConnectionsToolStripMenuItem_Click;
            // 
            // saasAvailableHotfixesToolStripMenuItem
            // 
            saasAvailableHotfixesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { saasApplicationMetadataHotfixesToolStripMenuItem, saasApplicationBinaryHotfixesToolStripMenuItem, saasPlatformBinaryHotfixesToolStripMenuItem, saasCriticalMetadataHotfixesToolStripMenuItem });
            saasAvailableHotfixesToolStripMenuItem.Name = "saasAvailableHotfixesToolStripMenuItem";
            saasAvailableHotfixesToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            saasAvailableHotfixesToolStripMenuItem.Text = "Available hotfixes";
            // 
            // saasApplicationMetadataHotfixesToolStripMenuItem
            // 
            saasApplicationMetadataHotfixesToolStripMenuItem.Name = "saasApplicationMetadataHotfixesToolStripMenuItem";
            saasApplicationMetadataHotfixesToolStripMenuItem.Size = new System.Drawing.Size(293, 26);
            saasApplicationMetadataHotfixesToolStripMenuItem.Text = "Application metadata hotfixes";
            saasApplicationMetadataHotfixesToolStripMenuItem.Click += HotfixesToolStripMenuItem_Click;
            // 
            // saasApplicationBinaryHotfixesToolStripMenuItem
            // 
            saasApplicationBinaryHotfixesToolStripMenuItem.Name = "saasApplicationBinaryHotfixesToolStripMenuItem";
            saasApplicationBinaryHotfixesToolStripMenuItem.Size = new System.Drawing.Size(293, 26);
            saasApplicationBinaryHotfixesToolStripMenuItem.Text = "Application binary hotfixes";
            saasApplicationBinaryHotfixesToolStripMenuItem.Click += HotfixesToolStripMenuItem_Click;
            // 
            // saasPlatformBinaryHotfixesToolStripMenuItem
            // 
            saasPlatformBinaryHotfixesToolStripMenuItem.Name = "saasPlatformBinaryHotfixesToolStripMenuItem";
            saasPlatformBinaryHotfixesToolStripMenuItem.Size = new System.Drawing.Size(293, 26);
            saasPlatformBinaryHotfixesToolStripMenuItem.Text = "Platform binary hotfixes";
            saasPlatformBinaryHotfixesToolStripMenuItem.Click += HotfixesToolStripMenuItem_Click;
            // 
            // saasCriticalMetadataHotfixesToolStripMenuItem
            // 
            saasCriticalMetadataHotfixesToolStripMenuItem.Name = "saasCriticalMetadataHotfixesToolStripMenuItem";
            saasCriticalMetadataHotfixesToolStripMenuItem.Size = new System.Drawing.Size(293, 26);
            saasCriticalMetadataHotfixesToolStripMenuItem.Text = "Critical metadata hotfixes";
            saasCriticalMetadataHotfixesToolStripMenuItem.Click += HotfixesToolStripMenuItem_Click;
            // 
            // saasUpcomingUpdatesToolStripMenuItem
            // 
            saasUpcomingUpdatesToolStripMenuItem.Name = "saasUpcomingUpdatesToolStripMenuItem";
            saasUpcomingUpdatesToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            saasUpcomingUpdatesToolStripMenuItem.Text = "Upcoming updates";
            saasUpcomingUpdatesToolStripMenuItem.Click += SaasUpcomingUpdatesToolStripMenuItem_Click;
            // 
            // saasDetailedBuildInfoToolStripMenuItem
            // 
            saasDetailedBuildInfoToolStripMenuItem.Name = "saasDetailedBuildInfoToolStripMenuItem";
            saasDetailedBuildInfoToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            saasDetailedBuildInfoToolStripMenuItem.Text = "Detailed build info";
            saasDetailedBuildInfoToolStripMenuItem.Click += DetailedBuildInfoToolStripMenuItem_Click;
            // 
            // saasEnvironmentChangesToolStripMenuItem
            // 
            saasEnvironmentChangesToolStripMenuItem.Name = "saasEnvironmentChangesToolStripMenuItem";
            saasEnvironmentChangesToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            saasEnvironmentChangesToolStripMenuItem.Text = "Environment changes";
            saasEnvironmentChangesToolStripMenuItem.Click += EnvironmentChangesToolStripMenuItem_Click;
            // 
            // saasLcsInstanceLinksToolStripMenuItem1
            // 
            saasLcsInstanceLinksToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { saasInstanceDetailsToolStripMenuItem, saasEnvironmentMonitoringToolStripMenuItem, saasDetailedVersionInformationToolStripMenuItem, saasEnvironmentChangeHistoryToolStripMenuItem, saasDataPackagesHistoryToolStripMenuItem, saasLogonToPointOfSaleToolStripMenuItem, saasLaunchDynamicsRetailStorefrontToolStripMenuItem, saasRetailServerURLToolStripMenuItem });
            saasLcsInstanceLinksToolStripMenuItem1.Name = "saasLcsInstanceLinksToolStripMenuItem1";
            saasLcsInstanceLinksToolStripMenuItem1.Size = new System.Drawing.Size(225, 24);
            saasLcsInstanceLinksToolStripMenuItem1.Text = "LCS instance links";
            // 
            // saasInstanceDetailsToolStripMenuItem
            // 
            saasInstanceDetailsToolStripMenuItem.Name = "saasInstanceDetailsToolStripMenuItem";
            saasInstanceDetailsToolStripMenuItem.Size = new System.Drawing.Size(319, 26);
            saasInstanceDetailsToolStripMenuItem.Text = "Instance details";
            saasInstanceDetailsToolStripMenuItem.Click += InstanceDetailsToolStripMenuItem_Click;
            // 
            // saasEnvironmentMonitoringToolStripMenuItem
            // 
            saasEnvironmentMonitoringToolStripMenuItem.Name = "saasEnvironmentMonitoringToolStripMenuItem";
            saasEnvironmentMonitoringToolStripMenuItem.Size = new System.Drawing.Size(319, 26);
            saasEnvironmentMonitoringToolStripMenuItem.Text = "Environment monitoring";
            saasEnvironmentMonitoringToolStripMenuItem.Click += EnvironmentMonitoringToolStripMenuItem_Click;
            // 
            // saasDetailedVersionInformationToolStripMenuItem
            // 
            saasDetailedVersionInformationToolStripMenuItem.Name = "saasDetailedVersionInformationToolStripMenuItem";
            saasDetailedVersionInformationToolStripMenuItem.Size = new System.Drawing.Size(319, 26);
            saasDetailedVersionInformationToolStripMenuItem.Text = "Detailed version information";
            saasDetailedVersionInformationToolStripMenuItem.Click += DetailedVersionInformationToolStripMenuItem_Click;
            // 
            // saasEnvironmentChangeHistoryToolStripMenuItem
            // 
            saasEnvironmentChangeHistoryToolStripMenuItem.Name = "saasEnvironmentChangeHistoryToolStripMenuItem";
            saasEnvironmentChangeHistoryToolStripMenuItem.Size = new System.Drawing.Size(319, 26);
            saasEnvironmentChangeHistoryToolStripMenuItem.Text = "Environment change history";
            saasEnvironmentChangeHistoryToolStripMenuItem.Click += EnvironmentChangeHistoryToolStripMenuItem_Click;
            // 
            // saasDataPackagesHistoryToolStripMenuItem
            // 
            saasDataPackagesHistoryToolStripMenuItem.Name = "saasDataPackagesHistoryToolStripMenuItem";
            saasDataPackagesHistoryToolStripMenuItem.Size = new System.Drawing.Size(319, 26);
            saasDataPackagesHistoryToolStripMenuItem.Text = "Data packages history";
            saasDataPackagesHistoryToolStripMenuItem.Click += DataPackagesHistoryToolStripMenuItem_Click;
            // 
            // saasLogonToPointOfSaleToolStripMenuItem
            // 
            saasLogonToPointOfSaleToolStripMenuItem.Name = "saasLogonToPointOfSaleToolStripMenuItem";
            saasLogonToPointOfSaleToolStripMenuItem.Size = new System.Drawing.Size(319, 26);
            saasLogonToPointOfSaleToolStripMenuItem.Text = "Logon to Point of Sale";
            saasLogonToPointOfSaleToolStripMenuItem.Click += LogonToPointOfSaleToolStripMenuItem_Click;
            // 
            // saasLaunchDynamicsRetailStorefrontToolStripMenuItem
            // 
            saasLaunchDynamicsRetailStorefrontToolStripMenuItem.Name = "saasLaunchDynamicsRetailStorefrontToolStripMenuItem";
            saasLaunchDynamicsRetailStorefrontToolStripMenuItem.Size = new System.Drawing.Size(319, 26);
            saasLaunchDynamicsRetailStorefrontToolStripMenuItem.Text = "Launch Dynamics Retail Storefront";
            saasLaunchDynamicsRetailStorefrontToolStripMenuItem.Click += LaunchDynamicsRetailStorefrontToolStripMenuItem_Click;
            // 
            // saasRetailServerURLToolStripMenuItem
            // 
            saasRetailServerURLToolStripMenuItem.Name = "saasRetailServerURLToolStripMenuItem";
            saasRetailServerURLToolStripMenuItem.Size = new System.Drawing.Size(319, 26);
            saasRetailServerURLToolStripMenuItem.Text = "Retail Server URL";
            saasRetailServerURLToolStripMenuItem.Click += RetailServerURLToolStripMenuItem_Click;
            // 
            // saasLcsProjectLinksToolStripMenuItem
            // 
            saasLcsProjectLinksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { saasServiceRequestsToolStripMenuItem, saasSupportIssuesToolStripMenuItem, saasOpenWorkItemsToolStripMenuItem, saasAssetLibraryToolStripMenuItem, saasSystemDiagnosticsToolStripMenuItem, saasSubscriptionEstimatorToolStripMenuItem, saasSubscriptionsAvailableToolStripMenuItem, saasProjectSettingsToolStripMenuItem, saasProjectUsersToolStripMenuItem });
            saasLcsProjectLinksToolStripMenuItem.Name = "saasLcsProjectLinksToolStripMenuItem";
            saasLcsProjectLinksToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            saasLcsProjectLinksToolStripMenuItem.Text = "LCS project links";
            // 
            // saasServiceRequestsToolStripMenuItem
            // 
            saasServiceRequestsToolStripMenuItem.Name = "saasServiceRequestsToolStripMenuItem";
            saasServiceRequestsToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            saasServiceRequestsToolStripMenuItem.Text = "Service requests";
            saasServiceRequestsToolStripMenuItem.Click += ServiceRequestsToolStripMenuItem_Click;
            // 
            // saasSupportIssuesToolStripMenuItem
            // 
            saasSupportIssuesToolStripMenuItem.Name = "saasSupportIssuesToolStripMenuItem";
            saasSupportIssuesToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            saasSupportIssuesToolStripMenuItem.Text = "Support issues";
            saasSupportIssuesToolStripMenuItem.Click += SupportIssuesToolStripMenuItem_Click;
            // 
            // saasOpenWorkItemsToolStripMenuItem
            // 
            saasOpenWorkItemsToolStripMenuItem.Name = "saasOpenWorkItemsToolStripMenuItem";
            saasOpenWorkItemsToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            saasOpenWorkItemsToolStripMenuItem.Text = "Open work items";
            saasOpenWorkItemsToolStripMenuItem.Click += OpenWorkItemsToolStripMenuItem_Click;
            // 
            // saasAssetLibraryToolStripMenuItem
            // 
            saasAssetLibraryToolStripMenuItem.Name = "saasAssetLibraryToolStripMenuItem";
            saasAssetLibraryToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            saasAssetLibraryToolStripMenuItem.Text = "Asset library";
            saasAssetLibraryToolStripMenuItem.Click += AssetLibraryToolStripMenuItem_Click;
            // 
            // saasSystemDiagnosticsToolStripMenuItem
            // 
            saasSystemDiagnosticsToolStripMenuItem.Name = "saasSystemDiagnosticsToolStripMenuItem";
            saasSystemDiagnosticsToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            saasSystemDiagnosticsToolStripMenuItem.Text = "System diagnostics";
            saasSystemDiagnosticsToolStripMenuItem.Click += SystemDiagnosticsToolStripMenuItem_Click;
            // 
            // saasSubscriptionEstimatorToolStripMenuItem
            // 
            saasSubscriptionEstimatorToolStripMenuItem.Name = "saasSubscriptionEstimatorToolStripMenuItem";
            saasSubscriptionEstimatorToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            saasSubscriptionEstimatorToolStripMenuItem.Text = "Subscription estimator";
            saasSubscriptionEstimatorToolStripMenuItem.Click += SubscriptionEstimatorToolStripMenuItem_Click;
            // 
            // saasSubscriptionsAvailableToolStripMenuItem
            // 
            saasSubscriptionsAvailableToolStripMenuItem.Name = "saasSubscriptionsAvailableToolStripMenuItem";
            saasSubscriptionsAvailableToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            saasSubscriptionsAvailableToolStripMenuItem.Text = "Subscriptions available";
            saasSubscriptionsAvailableToolStripMenuItem.Click += SubscriptionsAvailableToolStripMenuItem_Click;
            // 
            // saasProjectSettingsToolStripMenuItem
            // 
            saasProjectSettingsToolStripMenuItem.Name = "saasProjectSettingsToolStripMenuItem";
            saasProjectSettingsToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            saasProjectSettingsToolStripMenuItem.Text = "Project settings";
            saasProjectSettingsToolStripMenuItem.Click += ProjectSettingsToolStripMenuItem_Click;
            // 
            // saasProjectUsersToolStripMenuItem
            // 
            saasProjectUsersToolStripMenuItem.Name = "saasProjectUsersToolStripMenuItem";
            saasProjectUsersToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            saasProjectUsersToolStripMenuItem.Text = "Project users";
            saasProjectUsersToolStripMenuItem.Click += ProjectUsersToolStripMenuItem_Click;
            // 
            // saasDeployPackageToolStripMenuItem
            // 
            saasDeployPackageToolStripMenuItem.Name = "saasDeployPackageToolStripMenuItem";
            saasDeployPackageToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            saasDeployPackageToolStripMenuItem.Text = "Deploy package";
            saasDeployPackageToolStripMenuItem.Click += DeployPackageToolStripMenuItem_Click;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { projectDescriptionLabel, toolStripStatusLabel1 });
            statusStrip.Location = new System.Drawing.Point(0, 819);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new System.Windows.Forms.Padding(3, 0, 12, 0);
            statusStrip.Size = new System.Drawing.Size(1315, 26);
            statusStrip.TabIndex = 1;
            statusStrip.Text = "statusStrip1";
            // 
            // projectDescriptionLabel
            // 
            projectDescriptionLabel.Name = "projectDescriptionLabel";
            projectDescriptionLabel.Size = new System.Drawing.Size(0, 20);
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new System.Drawing.Size(320, 20);
            toolStripStatusLabel1.Text = "Right click on an instance to perform an action.";
            // 
            // notifyIcon
            // 
            notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            notifyIcon.ContextMenuStrip = notifyIconContextMenu;
            notifyIcon.Icon = Properties.Resources.favicon_white;
            notifyIcon.Text = "2LCS - Lightweight LCS";
            notifyIcon.Visible = true;
            notifyIcon.MouseClick += NotifyIcon_MouseClick;
            // 
            // notifyIconContextMenu
            // 
            notifyIconContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            notifyIconContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { notifyIconMenuClose });
            notifyIconContextMenu.Name = "notifyIconContextMenu";
            notifyIconContextMenu.Size = new System.Drawing.Size(150, 28);
            // 
            // notifyIconMenuClose
            // 
            notifyIconMenuClose.Name = "notifyIconMenuClose";
            notifyIconMenuClose.Size = new System.Drawing.Size(149, 24);
            notifyIconMenuClose.Text = "Close 2LCS";
            notifyIconMenuClose.Click += NotifyIconMenuClose_Click;
            // 
            // exportListOfNuGetPackagesToolStripMenuItem
            // 
            exportListOfNuGetPackagesToolStripMenuItem.Name = "exportListOfNuGetPackagesToolStripMenuItem";
            exportListOfNuGetPackagesToolStripMenuItem.Size = new System.Drawing.Size(455, 26);
            exportListOfNuGetPackagesToolStripMenuItem.Text = "Export list of NuGet packages from shared asset library";
            exportListOfNuGetPackagesToolStripMenuItem.Click += exportListOfNuGetPackagesToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1315, 845);
            Controls.Add(tabControl);
            Controls.Add(mainMenuStrip);
            Controls.Add(statusStrip);
            Icon = Properties.Resources.favicon_white;
            MainMenuStrip = mainMenuStrip;
            MinimumSize = new System.Drawing.Size(531, 344);
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "2LCS - Lifecycle Services companion app";
            FormClosing += MainForm_Closing;
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)cheDataGridView).EndInit();
            cheInstanceContextMenu.ResumeLayout(false);
            mainMenuStrip.ResumeLayout(false);
            mainMenuStrip.PerformLayout();
            tabControl.ResumeLayout(false);
            cheTabPage.ResumeLayout(false);
            saasTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)saasDataGridView).EndInit();
            saasInstanceContextMenu.ResumeLayout(false);
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            notifyIconContextMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView cheDataGridView;
        private System.Windows.Forms.ContextMenuStrip cheInstanceContextMenu;
        private System.Windows.Forms.ToolStripMenuItem cheStartInstanceMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cheStopInstanceMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cheDeallocateMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cheDeleteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cheShowPasswordsMenuItem;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem loginToLcsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage cheTabPage;
        private System.Windows.Forms.TabPage saasTabPage;
        private System.Windows.Forms.DataGridView saasDataGridView;
        private System.Windows.Forms.ContextMenuStrip saasInstanceContextMenu;
        private System.Windows.Forms.ToolStripMenuItem saasStartInstanceMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saasStopInstanceMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saasDeleteNsgRule;
        private System.Windows.Forms.ToolStripMenuItem saasAddNsgRule;
        private System.Windows.Forms.ToolStripMenuItem saasDeallocateMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saasDeleteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saasShowPasswordsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cheExportRDCManConnectionsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saasExportRDCManConnectionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeProjectMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel projectDescriptionLabel;
        private System.Windows.Forms.ToolStripMenuItem customLinksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cheLcsProjectLinksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cheLcsInstanceLinksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cheLogonToAppToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cheInstanceDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cheEnvironmentMonitoringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cheDetailedVersionInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cheEnvironmenChangeHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cheDataPackagesHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cheProjectUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cheOpenWorkItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cheSubscriptionEstimatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cheSubscriptionsAvailableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cheProjectSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cheAssetLibraryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cheServiceRequestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cheSupportIssuesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cheSystemDiagnosticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saasLcsProjectLinksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saasLcsInstanceLinksToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saasLogonToApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saasInstanceDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saasEnvironmentMonitoringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saasDetailedVersionInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saasEnvironmentChangeHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saasDataPackagesHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saasProjectUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saasOpenWorkItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saasSubscriptionEstimatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saasSubscriptionsAvailableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saasProjectSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saasAssetLibraryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saasServiceRequestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saasSupportIssuesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saasSystemDiagnosticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cheOpenRDPConnectionToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip notifyIconContextMenu;
        private System.Windows.Forms.ToolStripMenuItem notifyIconMenuClose;
        private System.Windows.Forms.ToolStripMenuItem cheShowRDPDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saasShowRDPDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cheAvailableHotfixesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cheMetadataHotfixesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chePlatformHotfixesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cheApplicationBinaryHotfixesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saasAvailableHotfixesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saasApplicationMetadataHotfixesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saasApplicationBinaryHotfixesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saasPlatformBinaryHotfixesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cheManageVirtualMachineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cheRdpAndPasswordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saasManageVirtualMachineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saasRdpAndPasswordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saasCriticalMetadataHotfixesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportProjectDataToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exportListOfInstancesForAllProjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cheShowPasswordsPowershellMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cheExportRDMConnectionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saasExportRDMConnectionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saasShowPasswordsPowershellMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cheDetailedBuildInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saasDetailedBuildInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cheDeployPackageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saasDeployPackageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saasOpenRdpConnectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cookieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parametersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cheLogonToPointOfSaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cheLaunchDynamicsRetailStorefrontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cheRetailServerURLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saasLogonToPointOfSaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saasLaunchDynamicsRetailStorefrontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saasRetailServerURLToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn cheInstanceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cheEnvironmentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cheDisplayName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cheDeploymentStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn cheDeploymentAction;
        private System.Windows.Forms.DataGridViewTextBoxColumn cheCurrentApplicationBuildVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cheCurrentApplicationReleaseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cheCurrentPlatformVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cheCurrentPlatformReleaseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cheBuildInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cheDeployedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn cheDeployedOn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cheTopologyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cheTopologyType;
        private System.Windows.Forms.DataGridViewTextBoxColumn cheTopologyVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn saasInstanceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn saasEnvironmentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn saasDisplayName;
        private System.Windows.Forms.DataGridViewTextBoxColumn saasDeploymentStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn saasDeploymentAction;
        private System.Windows.Forms.DataGridViewTextBoxColumn saasCurrentApplicationBuildVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn saasCurrentApplicationReleaseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn saasCurrentPlatformVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn saasCurrentPlatformReleaseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn saasBuildInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn saasDeployedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn saasDeployedOn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saasTopologyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn saasTopologyType;
        private System.Windows.Forms.DataGridViewTextBoxColumn saasTopologyVersion;
        private System.Windows.Forms.ToolStripMenuItem saasUpcomingUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportUpdateScheduleForAllProjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allInstancesExportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cloudHostedInstancesExportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mSHostedInstancesExportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saasRestartService;
        private System.Windows.Forms.ToolStripMenuItem saasEnvironmentChangesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cheEnvironmentChangesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allProjectsTSMExportAllInstances;
        private System.Windows.Forms.ToolStripMenuItem currentProjectTSMExportAllInstances;
        private System.Windows.Forms.ToolStripMenuItem exportListOfEnvChangesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allInstancesExportChangesTSM;
        private System.Windows.Forms.ToolStripMenuItem cloudInstancesExportChangesTSM;
        private System.Windows.Forms.ToolStripMenuItem saasInstancesExportChangesTSM;
        private System.Windows.Forms.ToolStripMenuItem exportListOfUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentProjectUsersExportMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allProjectUsersExportMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportListOfNuGetPackagesToolStripMenuItem;
    }
}

