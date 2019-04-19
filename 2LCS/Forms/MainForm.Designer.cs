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
            this.components = new System.ComponentModel.Container();
            this.cheDataGridView = new System.Windows.Forms.DataGridView();
            this.cheInstanceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cheEnvironmentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cheDisplayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cheDeploymentStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cheDeploymentAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cheCurrentPlatformVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cheCurrentPlatformReleaseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cheCurrentApplicationReleaseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cheBuildInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cheDeployedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cheDeployedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cheTopologyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cheTopologyType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cheTopologyVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cheInstanceContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cheLogonToAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheOpenRDPConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheManageVirtualMachineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheStartInstanceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheStopInstanceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheDeallocateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheDeleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheRdpAndPasswordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheShowPasswordsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheShowPasswordsPowershellMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheShowRDPDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheExportRDCManConnectionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheExportRDMConnectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheAvailableHotfixesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheMetadataHotfixesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheApplicationBinaryHotfixesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chePlatformHotfixesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheDetailedBuildInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheLcsInstanceLinksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheInstanceDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheEnvironmentMonitoringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheDetailedVersionInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheEnvironmenChangeHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheDataPackagesHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheLcsProjectLinksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheServiceRequestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheSupportIssuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheOpenWorkItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheAssetLibraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheSystemDiagnosticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheSubscriptionEstimatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheSubscriptionsAvailableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheProjectSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheProjectUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheDeployPackageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.loginToLcsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeProjectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customLinksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportProjectDataToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exportListOfInstancesForAllProjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cookieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.cheTabPage = new System.Windows.Forms.TabPage();
            this.saasTabPage = new System.Windows.Forms.TabPage();
            this.saasDataGridView = new System.Windows.Forms.DataGridView();
            this.saasInstanceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saasEnvironmentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saasDisplayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saasDeploymentStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saasDeploymentAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saasCurrentPlatformVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saasCurrentPlatformReleaseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saasCurrentApplicationReleaseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saasBuildInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saasDeployedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saasDeployedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saasTopologyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saasTopologyType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saasTopologyVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saasInstanceContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saasLogonToApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saasOpenRdpConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saasManageVirtualMachineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saasStartInstanceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saasStopInstanceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saasDeallocateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saasDeleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saasAddNsgRule = new System.Windows.Forms.ToolStripMenuItem();
            this.saasDeleteNsgRule = new System.Windows.Forms.ToolStripMenuItem();
            this.saasRdpAndPasswordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saasShowPasswordsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saasShowPasswordsPowershellMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saasShowRDPDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saasExportRDCManConnectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saasExportRDMConnectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saasAvailableHotfixesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saasApplicationMetadataHotfixesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saasApplicationBinaryHotfixesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saasPlatformBinaryHotfixesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saasCriticalMetadataHotfixesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saasDetailedBuildInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saasLcsProjectLinksToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saasServiceRequestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saasSupportIssuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saasOpenWorkItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saasAssetLibraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saasSystemDiagnosticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saasSubscriptionEstimatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saasSubscriptionsAvailableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saasProjectSeetingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saasProjectUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saasLcsInstanceLinksToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saasInstanceDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saasEnvironmentMonitoringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saasDetailedVersionInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saasEnvironmentChangeHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saasDataPackagesHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saasDeployPackageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.projectDescriptionLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cheDataGridView)).BeginInit();
            this.cheInstanceContextMenu.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.cheTabPage.SuspendLayout();
            this.saasTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saasDataGridView)).BeginInit();
            this.saasInstanceContextMenu.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // cheDataGridView
            // 
            this.cheDataGridView.AllowUserToAddRows = false;
            this.cheDataGridView.AllowUserToDeleteRows = false;
            this.cheDataGridView.AllowUserToOrderColumns = true;
            this.cheDataGridView.AllowUserToResizeRows = false;
            this.cheDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.cheDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.cheDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cheDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cheInstanceId,
            this.cheEnvironmentId,
            this.cheDisplayName,
            this.cheDeploymentStatus,
            this.cheDeploymentAction,
            this.cheCurrentPlatformVersion,
            this.cheCurrentPlatformReleaseName,
            this.cheCurrentApplicationReleaseName,
            this.cheBuildInfo,
            this.cheDeployedBy,
            this.cheDeployedOn,
            this.cheTopologyName,
            this.cheTopologyType,
            this.cheTopologyVersion});
            this.cheDataGridView.ContextMenuStrip = this.cheInstanceContextMenu;
            this.cheDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cheDataGridView.Location = new System.Drawing.Point(3, 2);
            this.cheDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cheDataGridView.Name = "cheDataGridView";
            this.cheDataGridView.ReadOnly = true;
            this.cheDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.cheDataGridView.Size = new System.Drawing.Size(1464, 743);
            this.cheDataGridView.TabIndex = 0;
            this.cheDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CheDataGridView_CellMouseDoubleClick);
            this.cheDataGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CheDataGridView_ColumnHeaderMouseClick);
            this.cheDataGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DataGridView_MouseDown);
            // 
            // cheInstanceId
            // 
            this.cheInstanceId.DataPropertyName = "InstanceId";
            this.cheInstanceId.HeaderText = "Instance Id";
            this.cheInstanceId.MinimumWidth = 8;
            this.cheInstanceId.Name = "cheInstanceId";
            this.cheInstanceId.ReadOnly = true;
            this.cheInstanceId.Width = 116;
            // 
            // cheEnvironmentId
            // 
            this.cheEnvironmentId.DataPropertyName = "EnvironmentId";
            this.cheEnvironmentId.HeaderText = "Environment Id";
            this.cheEnvironmentId.MinimumWidth = 8;
            this.cheEnvironmentId.Name = "cheEnvironmentId";
            this.cheEnvironmentId.ReadOnly = true;
            this.cheEnvironmentId.Width = 140;
            // 
            // cheDisplayName
            // 
            this.cheDisplayName.DataPropertyName = "DisplayName";
            this.cheDisplayName.HeaderText = "Display Name";
            this.cheDisplayName.MinimumWidth = 8;
            this.cheDisplayName.Name = "cheDisplayName";
            this.cheDisplayName.ReadOnly = true;
            this.cheDisplayName.Width = 131;
            // 
            // cheDeploymentStatus
            // 
            this.cheDeploymentStatus.DataPropertyName = "DeploymentStatus";
            this.cheDeploymentStatus.HeaderText = "Deployment Status";
            this.cheDeploymentStatus.MinimumWidth = 8;
            this.cheDeploymentStatus.Name = "cheDeploymentStatus";
            this.cheDeploymentStatus.ReadOnly = true;
            this.cheDeploymentStatus.Width = 166;
            // 
            // cheDeploymentAction
            // 
            this.cheDeploymentAction.DataPropertyName = "DeploymentAction";
            this.cheDeploymentAction.HeaderText = "Deployment Action";
            this.cheDeploymentAction.MinimumWidth = 8;
            this.cheDeploymentAction.Name = "cheDeploymentAction";
            this.cheDeploymentAction.ReadOnly = true;
            this.cheDeploymentAction.Width = 164;
            // 
            // cheCurrentPlatformVersion
            // 
            this.cheCurrentPlatformVersion.DataPropertyName = "CurrentPlatformVersion";
            this.cheCurrentPlatformVersion.HeaderText = "Current Platform Version";
            this.cheCurrentPlatformVersion.MinimumWidth = 8;
            this.cheCurrentPlatformVersion.Name = "cheCurrentPlatformVersion";
            this.cheCurrentPlatformVersion.ReadOnly = true;
            this.cheCurrentPlatformVersion.Width = 200;
            // 
            // cheCurrentPlatformReleaseName
            // 
            this.cheCurrentPlatformReleaseName.DataPropertyName = "CurrentPlatformReleaseName";
            this.cheCurrentPlatformReleaseName.HeaderText = "Current Platform Release Name";
            this.cheCurrentPlatformReleaseName.MinimumWidth = 8;
            this.cheCurrentPlatformReleaseName.Name = "cheCurrentPlatformReleaseName";
            this.cheCurrentPlatformReleaseName.ReadOnly = true;
            this.cheCurrentPlatformReleaseName.Width = 208;
            // 
            // cheCurrentApplicationReleaseName
            // 
            this.cheCurrentApplicationReleaseName.DataPropertyName = "CurrentApplicationReleaseName";
            this.cheCurrentApplicationReleaseName.HeaderText = "Current Application Release Name";
            this.cheCurrentApplicationReleaseName.MinimumWidth = 8;
            this.cheCurrentApplicationReleaseName.Name = "cheCurrentApplicationReleaseName";
            this.cheCurrentApplicationReleaseName.ReadOnly = true;
            this.cheCurrentApplicationReleaseName.Width = 225;
            // 
            // cheBuildInfo
            // 
            this.cheBuildInfo.DataPropertyName = "BuildInfo";
            this.cheBuildInfo.HeaderText = "Build Info";
            this.cheBuildInfo.MinimumWidth = 8;
            this.cheBuildInfo.Name = "cheBuildInfo";
            this.cheBuildInfo.ReadOnly = true;
            this.cheBuildInfo.Width = 104;
            // 
            // cheDeployedBy
            // 
            this.cheDeployedBy.DataPropertyName = "DeployedBy";
            this.cheDeployedBy.HeaderText = "Deployed By";
            this.cheDeployedBy.MinimumWidth = 8;
            this.cheDeployedBy.Name = "cheDeployedBy";
            this.cheDeployedBy.ReadOnly = true;
            this.cheDeployedBy.Width = 124;
            // 
            // cheDeployedOn
            // 
            this.cheDeployedOn.DataPropertyName = "DeployedOn";
            this.cheDeployedOn.HeaderText = "Deployed On";
            this.cheDeployedOn.MinimumWidth = 8;
            this.cheDeployedOn.Name = "cheDeployedOn";
            this.cheDeployedOn.ReadOnly = true;
            this.cheDeployedOn.Width = 126;
            // 
            // cheTopologyName
            // 
            this.cheTopologyName.DataPropertyName = "TopologyName";
            this.cheTopologyName.HeaderText = "Topology Name";
            this.cheTopologyName.MinimumWidth = 8;
            this.cheTopologyName.Name = "cheTopologyName";
            this.cheTopologyName.ReadOnly = true;
            this.cheTopologyName.Width = 143;
            // 
            // cheTopologyType
            // 
            this.cheTopologyType.DataPropertyName = "TopologyType";
            this.cheTopologyType.HeaderText = "Topology Type";
            this.cheTopologyType.MinimumWidth = 8;
            this.cheTopologyType.Name = "cheTopologyType";
            this.cheTopologyType.ReadOnly = true;
            this.cheTopologyType.Width = 135;
            // 
            // cheTopologyVersion
            // 
            this.cheTopologyVersion.DataPropertyName = "TopologyVersion";
            this.cheTopologyVersion.HeaderText = "Topology Version";
            this.cheTopologyVersion.MinimumWidth = 8;
            this.cheTopologyVersion.Name = "cheTopologyVersion";
            this.cheTopologyVersion.ReadOnly = true;
            this.cheTopologyVersion.Width = 153;
            // 
            // cheInstanceContextMenu
            // 
            this.cheInstanceContextMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cheInstanceContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cheLogonToAppToolStripMenuItem,
            this.cheOpenRDPConnectionToolStripMenuItem,
            this.cheManageVirtualMachineToolStripMenuItem,
            this.cheRdpAndPasswordsToolStripMenuItem,
            this.cheAvailableHotfixesToolStripMenuItem,
            this.cheDetailedBuildInfoToolStripMenuItem,
            this.cheLcsInstanceLinksToolStripMenuItem,
            this.cheLcsProjectLinksToolStripMenuItem,
            this.cheDeployPackageToolStripMenuItem});
            this.cheInstanceContextMenu.Name = "instanceContextMenuStrip";
            this.cheInstanceContextMenu.Size = new System.Drawing.Size(273, 292);
            this.cheInstanceContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.InstanceContextMenu_Opening);
            // 
            // cheLogonToAppToolStripMenuItem
            // 
            this.cheLogonToAppToolStripMenuItem.Name = "cheLogonToAppToolStripMenuItem";
            this.cheLogonToAppToolStripMenuItem.Size = new System.Drawing.Size(272, 32);
            this.cheLogonToAppToolStripMenuItem.Text = "Logon to application";
            this.cheLogonToAppToolStripMenuItem.Click += new System.EventHandler(this.LogonToApplicationToolStripMenuItem_Click);
            // 
            // cheOpenRDPConnectionToolStripMenuItem
            // 
            this.cheOpenRDPConnectionToolStripMenuItem.Name = "cheOpenRDPConnectionToolStripMenuItem";
            this.cheOpenRDPConnectionToolStripMenuItem.Size = new System.Drawing.Size(272, 32);
            this.cheOpenRDPConnectionToolStripMenuItem.Text = "Open RDP connection";
            this.cheOpenRDPConnectionToolStripMenuItem.Click += new System.EventHandler(this.OpenRDPConnectionToolStripMenuItem_Click);
            // 
            // cheManageVirtualMachineToolStripMenuItem
            // 
            this.cheManageVirtualMachineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cheStartInstanceMenuItem,
            this.cheStopInstanceMenuItem,
            this.cheDeallocateMenuItem,
            this.cheDeleteMenuItem});
            this.cheManageVirtualMachineToolStripMenuItem.Name = "cheManageVirtualMachineToolStripMenuItem";
            this.cheManageVirtualMachineToolStripMenuItem.Size = new System.Drawing.Size(272, 32);
            this.cheManageVirtualMachineToolStripMenuItem.Text = "Manage virtual machine";
            // 
            // cheStartInstanceMenuItem
            // 
            this.cheStartInstanceMenuItem.Name = "cheStartInstanceMenuItem";
            this.cheStartInstanceMenuItem.Size = new System.Drawing.Size(265, 34);
            this.cheStartInstanceMenuItem.Text = "Start instance(s)";
            this.cheStartInstanceMenuItem.Click += new System.EventHandler(this.StartInstanceMenuItem_Click);
            // 
            // cheStopInstanceMenuItem
            // 
            this.cheStopInstanceMenuItem.Name = "cheStopInstanceMenuItem";
            this.cheStopInstanceMenuItem.Size = new System.Drawing.Size(265, 34);
            this.cheStopInstanceMenuItem.Text = "Stop instance(s)";
            this.cheStopInstanceMenuItem.Click += new System.EventHandler(this.StopInstanceMenuItem_Click);
            // 
            // cheDeallocateMenuItem
            // 
            this.cheDeallocateMenuItem.Name = "cheDeallocateMenuItem";
            this.cheDeallocateMenuItem.Size = new System.Drawing.Size(265, 34);
            this.cheDeallocateMenuItem.Text = "Deallocate instance";
            this.cheDeallocateMenuItem.Click += new System.EventHandler(this.DeallocateMenuItem_Click);
            // 
            // cheDeleteMenuItem
            // 
            this.cheDeleteMenuItem.Name = "cheDeleteMenuItem";
            this.cheDeleteMenuItem.Size = new System.Drawing.Size(265, 34);
            this.cheDeleteMenuItem.Text = "Delete instance";
            this.cheDeleteMenuItem.Click += new System.EventHandler(this.DeleteMenuItem_Click);
            // 
            // cheRdpAndPasswordsToolStripMenuItem
            // 
            this.cheRdpAndPasswordsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cheShowPasswordsMenuItem,
            this.cheShowPasswordsPowershellMenuItem,
            this.cheShowRDPDetailsToolStripMenuItem,
            this.cheExportRDCManConnectionsMenuItem,
            this.cheExportRDMConnectionsToolStripMenuItem});
            this.cheRdpAndPasswordsToolStripMenuItem.Name = "cheRdpAndPasswordsToolStripMenuItem";
            this.cheRdpAndPasswordsToolStripMenuItem.Size = new System.Drawing.Size(272, 32);
            this.cheRdpAndPasswordsToolStripMenuItem.Text = "RDP and passwords";
            // 
            // cheShowPasswordsMenuItem
            // 
            this.cheShowPasswordsMenuItem.Name = "cheShowPasswordsMenuItem";
            this.cheShowPasswordsMenuItem.Size = new System.Drawing.Size(348, 34);
            this.cheShowPasswordsMenuItem.Text = "Show passwords";
            this.cheShowPasswordsMenuItem.Click += new System.EventHandler(this.CheShowPasswordsMenuItem_Click);
            // 
            // cheShowPasswordsPowershellMenuItem
            // 
            this.cheShowPasswordsPowershellMenuItem.Name = "cheShowPasswordsPowershellMenuItem";
            this.cheShowPasswordsPowershellMenuItem.Size = new System.Drawing.Size(348, 34);
            this.cheShowPasswordsPowershellMenuItem.Text = "Show passwords (powershell)";
            this.cheShowPasswordsPowershellMenuItem.Click += new System.EventHandler(this.CheShowPasswordsPowershellMenuItem_Click);
            // 
            // cheShowRDPDetailsToolStripMenuItem
            // 
            this.cheShowRDPDetailsToolStripMenuItem.Name = "cheShowRDPDetailsToolStripMenuItem";
            this.cheShowRDPDetailsToolStripMenuItem.Size = new System.Drawing.Size(348, 34);
            this.cheShowRDPDetailsToolStripMenuItem.Text = "Show RDP details";
            this.cheShowRDPDetailsToolStripMenuItem.Click += new System.EventHandler(this.ShowRDPDetailsToolStripMenuItem_Click);
            // 
            // cheExportRDCManConnectionsMenuItem
            // 
            this.cheExportRDCManConnectionsMenuItem.Name = "cheExportRDCManConnectionsMenuItem";
            this.cheExportRDCManConnectionsMenuItem.Size = new System.Drawing.Size(348, 34);
            this.cheExportRDCManConnectionsMenuItem.Text = "Export RDCMan connections";
            this.cheExportRDCManConnectionsMenuItem.ToolTipText = "Export all RDP connections to Remote Desktop Connection Manager import file";
            this.cheExportRDCManConnectionsMenuItem.Click += new System.EventHandler(this.CheExportRDCManConnectionsMenuItem_Click);
            // 
            // cheExportRDMConnectionsToolStripMenuItem
            // 
            this.cheExportRDMConnectionsToolStripMenuItem.Name = "cheExportRDMConnectionsToolStripMenuItem";
            this.cheExportRDMConnectionsToolStripMenuItem.Size = new System.Drawing.Size(348, 34);
            this.cheExportRDMConnectionsToolStripMenuItem.Text = "Export RDM connections";
            this.cheExportRDMConnectionsToolStripMenuItem.Click += new System.EventHandler(this.CheExportRDMConnectionsToolStripMenuItem_Click);
            // 
            // cheAvailableHotfixesToolStripMenuItem
            // 
            this.cheAvailableHotfixesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cheMetadataHotfixesToolStripMenuItem,
            this.cheApplicationBinaryHotfixesToolStripMenuItem,
            this.chePlatformHotfixesToolStripMenuItem});
            this.cheAvailableHotfixesToolStripMenuItem.Name = "cheAvailableHotfixesToolStripMenuItem";
            this.cheAvailableHotfixesToolStripMenuItem.Size = new System.Drawing.Size(272, 32);
            this.cheAvailableHotfixesToolStripMenuItem.Text = "Available hotfixes";
            // 
            // cheMetadataHotfixesToolStripMenuItem
            // 
            this.cheMetadataHotfixesToolStripMenuItem.Name = "cheMetadataHotfixesToolStripMenuItem";
            this.cheMetadataHotfixesToolStripMenuItem.Size = new System.Drawing.Size(351, 34);
            this.cheMetadataHotfixesToolStripMenuItem.Text = "Application metadata hotfixes";
            this.cheMetadataHotfixesToolStripMenuItem.Click += new System.EventHandler(this.HotfixesToolStripMenuItem_Click);
            // 
            // cheApplicationBinaryHotfixesToolStripMenuItem
            // 
            this.cheApplicationBinaryHotfixesToolStripMenuItem.Name = "cheApplicationBinaryHotfixesToolStripMenuItem";
            this.cheApplicationBinaryHotfixesToolStripMenuItem.Size = new System.Drawing.Size(351, 34);
            this.cheApplicationBinaryHotfixesToolStripMenuItem.Text = "Application binary hotfixes";
            this.cheApplicationBinaryHotfixesToolStripMenuItem.Click += new System.EventHandler(this.HotfixesToolStripMenuItem_Click);
            // 
            // chePlatformHotfixesToolStripMenuItem
            // 
            this.chePlatformHotfixesToolStripMenuItem.Name = "chePlatformHotfixesToolStripMenuItem";
            this.chePlatformHotfixesToolStripMenuItem.Size = new System.Drawing.Size(351, 34);
            this.chePlatformHotfixesToolStripMenuItem.Text = "Platform binary hotfixes";
            this.chePlatformHotfixesToolStripMenuItem.Click += new System.EventHandler(this.HotfixesToolStripMenuItem_Click);
            // 
            // cheDetailedBuildInfoToolStripMenuItem
            // 
            this.cheDetailedBuildInfoToolStripMenuItem.Name = "cheDetailedBuildInfoToolStripMenuItem";
            this.cheDetailedBuildInfoToolStripMenuItem.Size = new System.Drawing.Size(272, 32);
            this.cheDetailedBuildInfoToolStripMenuItem.Text = "Detailed build info";
            this.cheDetailedBuildInfoToolStripMenuItem.Click += new System.EventHandler(this.DetailedBuildInfoToolStripMenuItem_Click);
            // 
            // cheLcsInstanceLinksToolStripMenuItem
            // 
            this.cheLcsInstanceLinksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cheInstanceDetailsToolStripMenuItem,
            this.cheEnvironmentMonitoringToolStripMenuItem,
            this.cheDetailedVersionInformationToolStripMenuItem,
            this.cheEnvironmenChangeHistoryToolStripMenuItem,
            this.cheDataPackagesHistoryToolStripMenuItem});
            this.cheLcsInstanceLinksToolStripMenuItem.Name = "cheLcsInstanceLinksToolStripMenuItem";
            this.cheLcsInstanceLinksToolStripMenuItem.Size = new System.Drawing.Size(272, 32);
            this.cheLcsInstanceLinksToolStripMenuItem.Text = "LCS instance links";
            // 
            // cheInstanceDetailsToolStripMenuItem
            // 
            this.cheInstanceDetailsToolStripMenuItem.Name = "cheInstanceDetailsToolStripMenuItem";
            this.cheInstanceDetailsToolStripMenuItem.Size = new System.Drawing.Size(339, 34);
            this.cheInstanceDetailsToolStripMenuItem.Text = "Instance details";
            this.cheInstanceDetailsToolStripMenuItem.Click += new System.EventHandler(this.InstanceDetailsToolStripMenuItem_Click);
            // 
            // cheEnvironmentMonitoringToolStripMenuItem
            // 
            this.cheEnvironmentMonitoringToolStripMenuItem.Name = "cheEnvironmentMonitoringToolStripMenuItem";
            this.cheEnvironmentMonitoringToolStripMenuItem.Size = new System.Drawing.Size(339, 34);
            this.cheEnvironmentMonitoringToolStripMenuItem.Text = "Environment monitoring";
            this.cheEnvironmentMonitoringToolStripMenuItem.Click += new System.EventHandler(this.EnvironmentMonitoringToolStripMenuItem_Click);
            // 
            // cheDetailedVersionInformationToolStripMenuItem
            // 
            this.cheDetailedVersionInformationToolStripMenuItem.Name = "cheDetailedVersionInformationToolStripMenuItem";
            this.cheDetailedVersionInformationToolStripMenuItem.Size = new System.Drawing.Size(339, 34);
            this.cheDetailedVersionInformationToolStripMenuItem.Text = "Detailed version information";
            this.cheDetailedVersionInformationToolStripMenuItem.Click += new System.EventHandler(this.DetailedVersionInformationToolStripMenuItem_Click);
            // 
            // cheEnvironmenChangeHistoryToolStripMenuItem
            // 
            this.cheEnvironmenChangeHistoryToolStripMenuItem.Name = "cheEnvironmenChangeHistoryToolStripMenuItem";
            this.cheEnvironmenChangeHistoryToolStripMenuItem.Size = new System.Drawing.Size(339, 34);
            this.cheEnvironmenChangeHistoryToolStripMenuItem.Text = "Environment change history";
            this.cheEnvironmenChangeHistoryToolStripMenuItem.Click += new System.EventHandler(this.EnvironmentChangeHistoryToolStripMenuItem_Click);
            // 
            // cheDataPackagesHistoryToolStripMenuItem
            // 
            this.cheDataPackagesHistoryToolStripMenuItem.Name = "cheDataPackagesHistoryToolStripMenuItem";
            this.cheDataPackagesHistoryToolStripMenuItem.Size = new System.Drawing.Size(339, 34);
            this.cheDataPackagesHistoryToolStripMenuItem.Text = "Data packages history";
            this.cheDataPackagesHistoryToolStripMenuItem.Click += new System.EventHandler(this.DataPackagesHistoryToolStripMenuItem_Click);
            // 
            // cheLcsProjectLinksToolStripMenuItem
            // 
            this.cheLcsProjectLinksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cheServiceRequestsToolStripMenuItem,
            this.cheSupportIssuesToolStripMenuItem,
            this.cheOpenWorkItemsToolStripMenuItem,
            this.cheAssetLibraryToolStripMenuItem,
            this.cheSystemDiagnosticsToolStripMenuItem,
            this.cheSubscriptionEstimatorToolStripMenuItem,
            this.cheSubscriptionsAvailableToolStripMenuItem,
            this.cheProjectSettingsToolStripMenuItem,
            this.cheProjectUsersToolStripMenuItem});
            this.cheLcsProjectLinksToolStripMenuItem.Name = "cheLcsProjectLinksToolStripMenuItem";
            this.cheLcsProjectLinksToolStripMenuItem.Size = new System.Drawing.Size(272, 32);
            this.cheLcsProjectLinksToolStripMenuItem.Text = "LCS project links";
            // 
            // cheServiceRequestsToolStripMenuItem
            // 
            this.cheServiceRequestsToolStripMenuItem.Name = "cheServiceRequestsToolStripMenuItem";
            this.cheServiceRequestsToolStripMenuItem.Size = new System.Drawing.Size(294, 34);
            this.cheServiceRequestsToolStripMenuItem.Text = "Service requests";
            this.cheServiceRequestsToolStripMenuItem.Click += new System.EventHandler(this.ServiceRequestsToolStripMenuItem_Click);
            // 
            // cheSupportIssuesToolStripMenuItem
            // 
            this.cheSupportIssuesToolStripMenuItem.Name = "cheSupportIssuesToolStripMenuItem";
            this.cheSupportIssuesToolStripMenuItem.Size = new System.Drawing.Size(294, 34);
            this.cheSupportIssuesToolStripMenuItem.Text = "Support issues";
            this.cheSupportIssuesToolStripMenuItem.Click += new System.EventHandler(this.SupportIssuesToolStripMenuItem_Click);
            // 
            // cheOpenWorkItemsToolStripMenuItem
            // 
            this.cheOpenWorkItemsToolStripMenuItem.Name = "cheOpenWorkItemsToolStripMenuItem";
            this.cheOpenWorkItemsToolStripMenuItem.Size = new System.Drawing.Size(294, 34);
            this.cheOpenWorkItemsToolStripMenuItem.Text = "Open work items";
            this.cheOpenWorkItemsToolStripMenuItem.Click += new System.EventHandler(this.OpenWorkItemsToolStripMenuItem_Click);
            // 
            // cheAssetLibraryToolStripMenuItem
            // 
            this.cheAssetLibraryToolStripMenuItem.Name = "cheAssetLibraryToolStripMenuItem";
            this.cheAssetLibraryToolStripMenuItem.Size = new System.Drawing.Size(294, 34);
            this.cheAssetLibraryToolStripMenuItem.Text = "Asset library";
            this.cheAssetLibraryToolStripMenuItem.Click += new System.EventHandler(this.AssetLibraryToolStripMenuItem_Click);
            // 
            // cheSystemDiagnosticsToolStripMenuItem
            // 
            this.cheSystemDiagnosticsToolStripMenuItem.Name = "cheSystemDiagnosticsToolStripMenuItem";
            this.cheSystemDiagnosticsToolStripMenuItem.Size = new System.Drawing.Size(294, 34);
            this.cheSystemDiagnosticsToolStripMenuItem.Text = "System diagnostics";
            this.cheSystemDiagnosticsToolStripMenuItem.Click += new System.EventHandler(this.SystemDiagnosticsToolStripMenuItem_Click);
            // 
            // cheSubscriptionEstimatorToolStripMenuItem
            // 
            this.cheSubscriptionEstimatorToolStripMenuItem.Name = "cheSubscriptionEstimatorToolStripMenuItem";
            this.cheSubscriptionEstimatorToolStripMenuItem.Size = new System.Drawing.Size(294, 34);
            this.cheSubscriptionEstimatorToolStripMenuItem.Text = "Subscription estimator";
            this.cheSubscriptionEstimatorToolStripMenuItem.Click += new System.EventHandler(this.SubscriptionEstimatorToolStripMenuItem_Click);
            // 
            // cheSubscriptionsAvailableToolStripMenuItem
            // 
            this.cheSubscriptionsAvailableToolStripMenuItem.Name = "cheSubscriptionsAvailableToolStripMenuItem";
            this.cheSubscriptionsAvailableToolStripMenuItem.Size = new System.Drawing.Size(294, 34);
            this.cheSubscriptionsAvailableToolStripMenuItem.Text = "Subscriptions available";
            this.cheSubscriptionsAvailableToolStripMenuItem.Click += new System.EventHandler(this.SubscriptionsAvailableToolStripMenuItem_Click);
            // 
            // cheProjectSettingsToolStripMenuItem
            // 
            this.cheProjectSettingsToolStripMenuItem.Name = "cheProjectSettingsToolStripMenuItem";
            this.cheProjectSettingsToolStripMenuItem.Size = new System.Drawing.Size(294, 34);
            this.cheProjectSettingsToolStripMenuItem.Text = "Project settings";
            this.cheProjectSettingsToolStripMenuItem.Click += new System.EventHandler(this.ProjectSettingsToolStripMenuItem_Click);
            // 
            // cheProjectUsersToolStripMenuItem
            // 
            this.cheProjectUsersToolStripMenuItem.Name = "cheProjectUsersToolStripMenuItem";
            this.cheProjectUsersToolStripMenuItem.Size = new System.Drawing.Size(294, 34);
            this.cheProjectUsersToolStripMenuItem.Text = "Project users";
            this.cheProjectUsersToolStripMenuItem.Click += new System.EventHandler(this.ProjectUsersToolStripMenuItem_Click);
            // 
            // cheDeployPackageToolStripMenuItem
            // 
            this.cheDeployPackageToolStripMenuItem.Name = "cheDeployPackageToolStripMenuItem";
            this.cheDeployPackageToolStripMenuItem.Size = new System.Drawing.Size(272, 32);
            this.cheDeployPackageToolStripMenuItem.Text = "Deploy package";
            this.cheDeployPackageToolStripMenuItem.Click += new System.EventHandler(this.DeployPackageToolStripMenuItem_Click);
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToLcsMenuItem,
            this.changeProjectMenuItem,
            this.refreshMenuItem,
            this.customLinksToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.cookieToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(1478, 33);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // loginToLcsMenuItem
            // 
            this.loginToLcsMenuItem.Name = "loginToLcsMenuItem";
            this.loginToLcsMenuItem.Size = new System.Drawing.Size(127, 29);
            this.loginToLcsMenuItem.Text = "&Login to LCS";
            this.loginToLcsMenuItem.Click += new System.EventHandler(this.LoginToLCSMenuItem_Click);
            // 
            // changeProjectMenuItem
            // 
            this.changeProjectMenuItem.Enabled = false;
            this.changeProjectMenuItem.Name = "changeProjectMenuItem";
            this.changeProjectMenuItem.Size = new System.Drawing.Size(211, 29);
            this.changeProjectMenuItem.Text = "&Change project context";
            this.changeProjectMenuItem.Click += new System.EventHandler(this.ChangeProjectMenuItem_Click);
            // 
            // refreshMenuItem
            // 
            this.refreshMenuItem.Enabled = false;
            this.refreshMenuItem.Name = "refreshMenuItem";
            this.refreshMenuItem.Size = new System.Drawing.Size(251, 29);
            this.refreshMenuItem.Text = "&Refresh instances for project";
            this.refreshMenuItem.Click += new System.EventHandler(this.RefreshMenuItem_Click);
            // 
            // customLinksToolStripMenuItem
            // 
            this.customLinksToolStripMenuItem.Name = "customLinksToolStripMenuItem";
            this.customLinksToolStripMenuItem.Size = new System.Drawing.Size(183, 29);
            this.customLinksToolStripMenuItem.Text = "Define c&ustom links";
            this.customLinksToolStripMenuItem.Click += new System.EventHandler(this.CustomLinksToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportProjectDataToolStripMenuItem1,
            this.exportListOfInstancesForAllProjectsToolStripMenuItem});
            this.exportToolStripMenuItem.Enabled = false;
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(79, 29);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // exportProjectDataToolStripMenuItem1
            // 
            this.exportProjectDataToolStripMenuItem1.Name = "exportProjectDataToolStripMenuItem1";
            this.exportProjectDataToolStripMenuItem1.Size = new System.Drawing.Size(409, 34);
            this.exportProjectDataToolStripMenuItem1.Text = "Export project data";
            this.exportProjectDataToolStripMenuItem1.Click += new System.EventHandler(this.ExportProjectDataToolStripMenuItem_Click);
            // 
            // exportListOfInstancesForAllProjectsToolStripMenuItem
            // 
            this.exportListOfInstancesForAllProjectsToolStripMenuItem.Name = "exportListOfInstancesForAllProjectsToolStripMenuItem";
            this.exportListOfInstancesForAllProjectsToolStripMenuItem.Size = new System.Drawing.Size(409, 34);
            this.exportListOfInstancesForAllProjectsToolStripMenuItem.Text = "Export list of instances for all projects";
            this.exportListOfInstancesForAllProjectsToolStripMenuItem.Click += new System.EventHandler(this.ExportListOfInstancesForAllProjectsToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Enabled = false;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(85, 29);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.LogoutToolStripMenuItem_Click);
            // 
            // cookieToolStripMenuItem
            // 
            this.cookieToolStripMenuItem.Name = "cookieToolStripMenuItem";
            this.cookieToolStripMenuItem.Size = new System.Drawing.Size(83, 29);
            this.cookieToolStripMenuItem.Text = "Cookie";
            this.cookieToolStripMenuItem.Click += new System.EventHandler(this.CookieToolStripMenuItem_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.cheTabPage);
            this.tabControl.Controls.Add(this.saasTabPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 33);
            this.tabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1478, 780);
            this.tabControl.TabIndex = 1;
            // 
            // cheTabPage
            // 
            this.cheTabPage.Controls.Add(this.cheDataGridView);
            this.cheTabPage.Location = new System.Drawing.Point(4, 29);
            this.cheTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cheTabPage.Name = "cheTabPage";
            this.cheTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cheTabPage.Size = new System.Drawing.Size(1470, 747);
            this.cheTabPage.TabIndex = 0;
            this.cheTabPage.Text = "Cloud-hosted instances";
            this.cheTabPage.UseVisualStyleBackColor = true;
            // 
            // saasTabPage
            // 
            this.saasTabPage.Controls.Add(this.saasDataGridView);
            this.saasTabPage.Location = new System.Drawing.Point(4, 29);
            this.saasTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saasTabPage.Name = "saasTabPage";
            this.saasTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saasTabPage.Size = new System.Drawing.Size(1470, 747);
            this.saasTabPage.TabIndex = 1;
            this.saasTabPage.Text = "MS-hosted environments";
            this.saasTabPage.UseVisualStyleBackColor = true;
            // 
            // saasDataGridView
            // 
            this.saasDataGridView.AllowUserToAddRows = false;
            this.saasDataGridView.AllowUserToDeleteRows = false;
            this.saasDataGridView.AllowUserToOrderColumns = true;
            this.saasDataGridView.AllowUserToResizeRows = false;
            this.saasDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.saasDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.saasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.saasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.saasInstanceId,
            this.saasEnvironmentId,
            this.saasDisplayName,
            this.saasDeploymentStatus,
            this.saasDeploymentAction,
            this.saasCurrentPlatformVersion,
            this.saasCurrentPlatformReleaseName,
            this.saasCurrentApplicationReleaseName,
            this.saasBuildInfo,
            this.saasDeployedBy,
            this.saasDeployedOn,
            this.saasTopologyName,
            this.saasTopologyType,
            this.saasTopologyVersion});
            this.saasDataGridView.ContextMenuStrip = this.saasInstanceContextMenu;
            this.saasDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saasDataGridView.Location = new System.Drawing.Point(3, 2);
            this.saasDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saasDataGridView.Name = "saasDataGridView";
            this.saasDataGridView.ReadOnly = true;
            this.saasDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.saasDataGridView.Size = new System.Drawing.Size(1464, 743);
            this.saasDataGridView.TabIndex = 1;
            this.saasDataGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SaasDataGridView_ColumnHeaderMouseClick);
            this.saasDataGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DataGridView_MouseDown);
            // 
            // saasInstanceId
            // 
            this.saasInstanceId.DataPropertyName = "InstanceId";
            this.saasInstanceId.HeaderText = "Instance Id";
            this.saasInstanceId.MinimumWidth = 8;
            this.saasInstanceId.Name = "saasInstanceId";
            this.saasInstanceId.ReadOnly = true;
            this.saasInstanceId.Width = 116;
            // 
            // saasEnvironmentId
            // 
            this.saasEnvironmentId.DataPropertyName = "EnvironmentId";
            this.saasEnvironmentId.HeaderText = "Environment Id";
            this.saasEnvironmentId.MinimumWidth = 8;
            this.saasEnvironmentId.Name = "saasEnvironmentId";
            this.saasEnvironmentId.ReadOnly = true;
            this.saasEnvironmentId.Width = 140;
            // 
            // saasDisplayName
            // 
            this.saasDisplayName.DataPropertyName = "DisplayName";
            this.saasDisplayName.HeaderText = "Display Name";
            this.saasDisplayName.MinimumWidth = 8;
            this.saasDisplayName.Name = "saasDisplayName";
            this.saasDisplayName.ReadOnly = true;
            this.saasDisplayName.Width = 131;
            // 
            // saasDeploymentStatus
            // 
            this.saasDeploymentStatus.DataPropertyName = "DeploymentStatus";
            this.saasDeploymentStatus.HeaderText = "Deployment Status";
            this.saasDeploymentStatus.MinimumWidth = 8;
            this.saasDeploymentStatus.Name = "saasDeploymentStatus";
            this.saasDeploymentStatus.ReadOnly = true;
            this.saasDeploymentStatus.Width = 166;
            // 
            // saasDeploymentAction
            // 
            this.saasDeploymentAction.DataPropertyName = "DeploymentAction";
            this.saasDeploymentAction.HeaderText = "Deployment Action";
            this.saasDeploymentAction.MinimumWidth = 8;
            this.saasDeploymentAction.Name = "saasDeploymentAction";
            this.saasDeploymentAction.ReadOnly = true;
            this.saasDeploymentAction.Width = 164;
            // 
            // saasCurrentPlatformVersion
            // 
            this.saasCurrentPlatformVersion.DataPropertyName = "CurrentPlatformVersion";
            this.saasCurrentPlatformVersion.HeaderText = "Current Platform Version";
            this.saasCurrentPlatformVersion.MinimumWidth = 8;
            this.saasCurrentPlatformVersion.Name = "saasCurrentPlatformVersion";
            this.saasCurrentPlatformVersion.ReadOnly = true;
            this.saasCurrentPlatformVersion.Width = 200;
            // 
            // saasCurrentPlatformReleaseName
            // 
            this.saasCurrentPlatformReleaseName.DataPropertyName = "CurrentPlatformReleaseName";
            this.saasCurrentPlatformReleaseName.HeaderText = "Current Platform Release Name";
            this.saasCurrentPlatformReleaseName.MinimumWidth = 8;
            this.saasCurrentPlatformReleaseName.Name = "saasCurrentPlatformReleaseName";
            this.saasCurrentPlatformReleaseName.ReadOnly = true;
            this.saasCurrentPlatformReleaseName.Width = 208;
            // 
            // saasCurrentApplicationReleaseName
            // 
            this.saasCurrentApplicationReleaseName.DataPropertyName = "CurrentApplicationReleaseName";
            this.saasCurrentApplicationReleaseName.HeaderText = "Current Application Release Name";
            this.saasCurrentApplicationReleaseName.MinimumWidth = 8;
            this.saasCurrentApplicationReleaseName.Name = "saasCurrentApplicationReleaseName";
            this.saasCurrentApplicationReleaseName.ReadOnly = true;
            this.saasCurrentApplicationReleaseName.Width = 225;
            // 
            // saasBuildInfo
            // 
            this.saasBuildInfo.DataPropertyName = "BuildInfo";
            this.saasBuildInfo.HeaderText = "Build Info";
            this.saasBuildInfo.MinimumWidth = 8;
            this.saasBuildInfo.Name = "saasBuildInfo";
            this.saasBuildInfo.ReadOnly = true;
            this.saasBuildInfo.Width = 104;
            // 
            // saasDeployedBy
            // 
            this.saasDeployedBy.DataPropertyName = "DeployedBy";
            this.saasDeployedBy.HeaderText = "Deployed By";
            this.saasDeployedBy.MinimumWidth = 8;
            this.saasDeployedBy.Name = "saasDeployedBy";
            this.saasDeployedBy.ReadOnly = true;
            this.saasDeployedBy.Width = 124;
            // 
            // saasDeployedOn
            // 
            this.saasDeployedOn.DataPropertyName = "DeployedOn";
            this.saasDeployedOn.HeaderText = "Deployed On";
            this.saasDeployedOn.MinimumWidth = 8;
            this.saasDeployedOn.Name = "saasDeployedOn";
            this.saasDeployedOn.ReadOnly = true;
            this.saasDeployedOn.Width = 126;
            // 
            // saasTopologyName
            // 
            this.saasTopologyName.DataPropertyName = "TopologyName";
            this.saasTopologyName.HeaderText = "Topology Name";
            this.saasTopologyName.MinimumWidth = 8;
            this.saasTopologyName.Name = "saasTopologyName";
            this.saasTopologyName.ReadOnly = true;
            this.saasTopologyName.Width = 143;
            // 
            // saasTopologyType
            // 
            this.saasTopologyType.DataPropertyName = "TopologyType";
            this.saasTopologyType.HeaderText = "Topology Type";
            this.saasTopologyType.MinimumWidth = 8;
            this.saasTopologyType.Name = "saasTopologyType";
            this.saasTopologyType.ReadOnly = true;
            this.saasTopologyType.Width = 135;
            // 
            // saasTopologyVersion
            // 
            this.saasTopologyVersion.DataPropertyName = "TopologyVersion";
            this.saasTopologyVersion.HeaderText = "Topology Version";
            this.saasTopologyVersion.MinimumWidth = 8;
            this.saasTopologyVersion.Name = "saasTopologyVersion";
            this.saasTopologyVersion.ReadOnly = true;
            this.saasTopologyVersion.Width = 153;
            // 
            // saasInstanceContextMenu
            // 
            this.saasInstanceContextMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.saasInstanceContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saasLogonToApplicationToolStripMenuItem,
            this.saasOpenRdpConnectionToolStripMenuItem,
            this.saasManageVirtualMachineToolStripMenuItem,
            this.saasRdpAndPasswordsToolStripMenuItem,
            this.saasAvailableHotfixesToolStripMenuItem,
            this.saasDetailedBuildInfoToolStripMenuItem,
            this.saasLcsProjectLinksToolStripMenuItem1,
            this.saasLcsInstanceLinksToolStripMenuItem1,
            this.saasDeployPackageToolStripMenuItem});
            this.saasInstanceContextMenu.Name = "instanceContextMenuStrip";
            this.saasInstanceContextMenu.Size = new System.Drawing.Size(273, 292);
            this.saasInstanceContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.InstanceContextMenu_Opening);
            // 
            // saasLogonToApplicationToolStripMenuItem
            // 
            this.saasLogonToApplicationToolStripMenuItem.Name = "saasLogonToApplicationToolStripMenuItem";
            this.saasLogonToApplicationToolStripMenuItem.Size = new System.Drawing.Size(272, 32);
            this.saasLogonToApplicationToolStripMenuItem.Text = "Logon to application";
            this.saasLogonToApplicationToolStripMenuItem.Click += new System.EventHandler(this.LogonToApplicationToolStripMenuItem_Click);
            // 
            // saasOpenRdpConnectionToolStripMenuItem
            // 
            this.saasOpenRdpConnectionToolStripMenuItem.Name = "saasOpenRdpConnectionToolStripMenuItem";
            this.saasOpenRdpConnectionToolStripMenuItem.Size = new System.Drawing.Size(272, 32);
            this.saasOpenRdpConnectionToolStripMenuItem.Text = "Open RDP Connection";
            this.saasOpenRdpConnectionToolStripMenuItem.Click += new System.EventHandler(this.SaasOpenRdpConnectionToolStripMenuItem_Click);
            // 
            // saasManageVirtualMachineToolStripMenuItem
            // 
            this.saasManageVirtualMachineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saasStartInstanceMenuItem,
            this.saasStopInstanceMenuItem,
            this.saasDeallocateMenuItem,
            this.saasDeleteMenuItem,
            this.saasAddNsgRule,
            this.saasDeleteNsgRule});
            this.saasManageVirtualMachineToolStripMenuItem.Name = "saasManageVirtualMachineToolStripMenuItem";
            this.saasManageVirtualMachineToolStripMenuItem.Size = new System.Drawing.Size(272, 32);
            this.saasManageVirtualMachineToolStripMenuItem.Text = "Manage virtual machine";
            // 
            // saasStartInstanceMenuItem
            // 
            this.saasStartInstanceMenuItem.Name = "saasStartInstanceMenuItem";
            this.saasStartInstanceMenuItem.Size = new System.Drawing.Size(305, 34);
            this.saasStartInstanceMenuItem.Text = "Start instance(s)";
            this.saasStartInstanceMenuItem.Click += new System.EventHandler(this.StartInstanceMenuItem_Click);
            // 
            // saasStopInstanceMenuItem
            // 
            this.saasStopInstanceMenuItem.Name = "saasStopInstanceMenuItem";
            this.saasStopInstanceMenuItem.Size = new System.Drawing.Size(305, 34);
            this.saasStopInstanceMenuItem.Text = "Stop instance(s)";
            this.saasStopInstanceMenuItem.Click += new System.EventHandler(this.StopInstanceMenuItem_Click);
            // 
            // saasDeallocateMenuItem
            // 
            this.saasDeallocateMenuItem.Name = "saasDeallocateMenuItem";
            this.saasDeallocateMenuItem.Size = new System.Drawing.Size(305, 34);
            this.saasDeallocateMenuItem.Text = "Deallocate instance";
            this.saasDeallocateMenuItem.Click += new System.EventHandler(this.DeallocateMenuItem_Click);
            // 
            // saasDeleteMenuItem
            // 
            this.saasDeleteMenuItem.Name = "saasDeleteMenuItem";
            this.saasDeleteMenuItem.Size = new System.Drawing.Size(305, 34);
            this.saasDeleteMenuItem.Text = "Delete instance";
            this.saasDeleteMenuItem.Click += new System.EventHandler(this.DeleteMenuItem_Click);
            // 
            // saasAddNsgRule
            // 
            this.saasAddNsgRule.Name = "saasAddNsgRule";
            this.saasAddNsgRule.Size = new System.Drawing.Size(305, 34);
            this.saasAddNsgRule.Text = "Add firewall exception";
            this.saasAddNsgRule.Click += new System.EventHandler(this.SaasAddNsgRule_Click);
            // 
            // saasDeleteNsgRule
            // 
            this.saasDeleteNsgRule.Name = "saasDeleteNsgRule";
            this.saasDeleteNsgRule.Size = new System.Drawing.Size(305, 34);
            this.saasDeleteNsgRule.Text = "Delete firewall exception";
            this.saasDeleteNsgRule.Click += new System.EventHandler(this.SaasDeleteNsgRule_Click);
            // 
            // saasRdpAndPasswordsToolStripMenuItem
            // 
            this.saasRdpAndPasswordsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saasShowPasswordsMenuItem,
            this.saasShowPasswordsPowershellMenuItem,
            this.saasShowRDPDetailsToolStripMenuItem,
            this.saasExportRDCManConnectionsToolStripMenuItem,
            this.saasExportRDMConnectionsToolStripMenuItem});
            this.saasRdpAndPasswordsToolStripMenuItem.Name = "saasRdpAndPasswordsToolStripMenuItem";
            this.saasRdpAndPasswordsToolStripMenuItem.Size = new System.Drawing.Size(272, 32);
            this.saasRdpAndPasswordsToolStripMenuItem.Text = "RDP and passwords";
            // 
            // saasShowPasswordsMenuItem
            // 
            this.saasShowPasswordsMenuItem.Name = "saasShowPasswordsMenuItem";
            this.saasShowPasswordsMenuItem.Size = new System.Drawing.Size(348, 34);
            this.saasShowPasswordsMenuItem.Text = "Show passwords";
            this.saasShowPasswordsMenuItem.Click += new System.EventHandler(this.SaasShowPasswordsMenuItem_Click);
            // 
            // saasShowPasswordsPowershellMenuItem
            // 
            this.saasShowPasswordsPowershellMenuItem.Name = "saasShowPasswordsPowershellMenuItem";
            this.saasShowPasswordsPowershellMenuItem.Size = new System.Drawing.Size(348, 34);
            this.saasShowPasswordsPowershellMenuItem.Text = "Show passwords (powershell)";
            this.saasShowPasswordsPowershellMenuItem.Click += new System.EventHandler(this.SaasShowPasswordsPowershellMenuItem_Click);
            // 
            // saasShowRDPDetailsToolStripMenuItem
            // 
            this.saasShowRDPDetailsToolStripMenuItem.Name = "saasShowRDPDetailsToolStripMenuItem";
            this.saasShowRDPDetailsToolStripMenuItem.Size = new System.Drawing.Size(348, 34);
            this.saasShowRDPDetailsToolStripMenuItem.Text = "Show RDP details";
            this.saasShowRDPDetailsToolStripMenuItem.Click += new System.EventHandler(this.ShowRDPDetailsToolStripMenuItem_Click);
            // 
            // saasExportRDCManConnectionsToolStripMenuItem
            // 
            this.saasExportRDCManConnectionsToolStripMenuItem.Name = "saasExportRDCManConnectionsToolStripMenuItem";
            this.saasExportRDCManConnectionsToolStripMenuItem.Size = new System.Drawing.Size(348, 34);
            this.saasExportRDCManConnectionsToolStripMenuItem.Text = "Export RDCMan connections";
            this.saasExportRDCManConnectionsToolStripMenuItem.ToolTipText = "Export all RDP connections to Remote Desktop Connection Manager import file";
            this.saasExportRDCManConnectionsToolStripMenuItem.Click += new System.EventHandler(this.SaasExportRDCManConnectionsToolStripMenuItem_Click);
            // 
            // saasExportRDMConnectionsToolStripMenuItem
            // 
            this.saasExportRDMConnectionsToolStripMenuItem.Name = "saasExportRDMConnectionsToolStripMenuItem";
            this.saasExportRDMConnectionsToolStripMenuItem.Size = new System.Drawing.Size(348, 34);
            this.saasExportRDMConnectionsToolStripMenuItem.Text = "Export RDM connections";
            this.saasExportRDMConnectionsToolStripMenuItem.Click += new System.EventHandler(this.SaasExportRDMConnectionsToolStripMenuItem_Click);
            // 
            // saasAvailableHotfixesToolStripMenuItem
            // 
            this.saasAvailableHotfixesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saasApplicationMetadataHotfixesToolStripMenuItem,
            this.saasApplicationBinaryHotfixesToolStripMenuItem,
            this.saasPlatformBinaryHotfixesToolStripMenuItem,
            this.saasCriticalMetadataHotfixesToolStripMenuItem});
            this.saasAvailableHotfixesToolStripMenuItem.Name = "saasAvailableHotfixesToolStripMenuItem";
            this.saasAvailableHotfixesToolStripMenuItem.Size = new System.Drawing.Size(272, 32);
            this.saasAvailableHotfixesToolStripMenuItem.Text = "Available hotfixes";
            // 
            // saasApplicationMetadataHotfixesToolStripMenuItem
            // 
            this.saasApplicationMetadataHotfixesToolStripMenuItem.Name = "saasApplicationMetadataHotfixesToolStripMenuItem";
            this.saasApplicationMetadataHotfixesToolStripMenuItem.Size = new System.Drawing.Size(351, 34);
            this.saasApplicationMetadataHotfixesToolStripMenuItem.Text = "Application metadata hotfixes";
            this.saasApplicationMetadataHotfixesToolStripMenuItem.Click += new System.EventHandler(this.HotfixesToolStripMenuItem_Click);
            // 
            // saasApplicationBinaryHotfixesToolStripMenuItem
            // 
            this.saasApplicationBinaryHotfixesToolStripMenuItem.Name = "saasApplicationBinaryHotfixesToolStripMenuItem";
            this.saasApplicationBinaryHotfixesToolStripMenuItem.Size = new System.Drawing.Size(351, 34);
            this.saasApplicationBinaryHotfixesToolStripMenuItem.Text = "Application binary hotfixes";
            this.saasApplicationBinaryHotfixesToolStripMenuItem.Click += new System.EventHandler(this.HotfixesToolStripMenuItem_Click);
            // 
            // saasPlatformBinaryHotfixesToolStripMenuItem
            // 
            this.saasPlatformBinaryHotfixesToolStripMenuItem.Name = "saasPlatformBinaryHotfixesToolStripMenuItem";
            this.saasPlatformBinaryHotfixesToolStripMenuItem.Size = new System.Drawing.Size(351, 34);
            this.saasPlatformBinaryHotfixesToolStripMenuItem.Text = "Platform binary hotfixes";
            this.saasPlatformBinaryHotfixesToolStripMenuItem.Click += new System.EventHandler(this.HotfixesToolStripMenuItem_Click);
            // 
            // saasCriticalMetadataHotfixesToolStripMenuItem
            // 
            this.saasCriticalMetadataHotfixesToolStripMenuItem.Name = "saasCriticalMetadataHotfixesToolStripMenuItem";
            this.saasCriticalMetadataHotfixesToolStripMenuItem.Size = new System.Drawing.Size(351, 34);
            this.saasCriticalMetadataHotfixesToolStripMenuItem.Text = "Critical metadata hotfixes";
            this.saasCriticalMetadataHotfixesToolStripMenuItem.Click += new System.EventHandler(this.HotfixesToolStripMenuItem_Click);
            // 
            // saasDetailedBuildInfoToolStripMenuItem
            // 
            this.saasDetailedBuildInfoToolStripMenuItem.Name = "saasDetailedBuildInfoToolStripMenuItem";
            this.saasDetailedBuildInfoToolStripMenuItem.Size = new System.Drawing.Size(272, 32);
            this.saasDetailedBuildInfoToolStripMenuItem.Text = "Detailed build info";
            this.saasDetailedBuildInfoToolStripMenuItem.Click += new System.EventHandler(this.DetailedBuildInfoToolStripMenuItem_Click);
            // 
            // saasLcsProjectLinksToolStripMenuItem1
            // 
            this.saasLcsProjectLinksToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saasServiceRequestsToolStripMenuItem,
            this.saasSupportIssuesToolStripMenuItem,
            this.saasOpenWorkItemsToolStripMenuItem,
            this.saasAssetLibraryToolStripMenuItem,
            this.saasSystemDiagnosticsToolStripMenuItem,
            this.saasSubscriptionEstimatorToolStripMenuItem,
            this.saasSubscriptionsAvailableToolStripMenuItem,
            this.saasProjectSeetingsToolStripMenuItem,
            this.saasProjectUsersToolStripMenuItem});
            this.saasLcsProjectLinksToolStripMenuItem1.Name = "saasLcsProjectLinksToolStripMenuItem1";
            this.saasLcsProjectLinksToolStripMenuItem1.Size = new System.Drawing.Size(272, 32);
            this.saasLcsProjectLinksToolStripMenuItem1.Text = "LCS project links";
            // 
            // saasServiceRequestsToolStripMenuItem
            // 
            this.saasServiceRequestsToolStripMenuItem.Name = "saasServiceRequestsToolStripMenuItem";
            this.saasServiceRequestsToolStripMenuItem.Size = new System.Drawing.Size(294, 34);
            this.saasServiceRequestsToolStripMenuItem.Text = "Service requests";
            this.saasServiceRequestsToolStripMenuItem.Click += new System.EventHandler(this.ServiceRequestsToolStripMenuItem_Click);
            // 
            // saasSupportIssuesToolStripMenuItem
            // 
            this.saasSupportIssuesToolStripMenuItem.Name = "saasSupportIssuesToolStripMenuItem";
            this.saasSupportIssuesToolStripMenuItem.Size = new System.Drawing.Size(294, 34);
            this.saasSupportIssuesToolStripMenuItem.Text = "Support issues";
            this.saasSupportIssuesToolStripMenuItem.Click += new System.EventHandler(this.SupportIssuesToolStripMenuItem_Click);
            // 
            // saasOpenWorkItemsToolStripMenuItem
            // 
            this.saasOpenWorkItemsToolStripMenuItem.Name = "saasOpenWorkItemsToolStripMenuItem";
            this.saasOpenWorkItemsToolStripMenuItem.Size = new System.Drawing.Size(294, 34);
            this.saasOpenWorkItemsToolStripMenuItem.Text = "Open work items";
            this.saasOpenWorkItemsToolStripMenuItem.Click += new System.EventHandler(this.OpenWorkItemsToolStripMenuItem_Click);
            // 
            // saasAssetLibraryToolStripMenuItem
            // 
            this.saasAssetLibraryToolStripMenuItem.Name = "saasAssetLibraryToolStripMenuItem";
            this.saasAssetLibraryToolStripMenuItem.Size = new System.Drawing.Size(294, 34);
            this.saasAssetLibraryToolStripMenuItem.Text = "Asset library";
            this.saasAssetLibraryToolStripMenuItem.Click += new System.EventHandler(this.AssetLibraryToolStripMenuItem_Click);
            // 
            // saasSystemDiagnosticsToolStripMenuItem
            // 
            this.saasSystemDiagnosticsToolStripMenuItem.Name = "saasSystemDiagnosticsToolStripMenuItem";
            this.saasSystemDiagnosticsToolStripMenuItem.Size = new System.Drawing.Size(294, 34);
            this.saasSystemDiagnosticsToolStripMenuItem.Text = "System diagnostics";
            this.saasSystemDiagnosticsToolStripMenuItem.Click += new System.EventHandler(this.SystemDiagnosticsToolStripMenuItem_Click);
            // 
            // saasSubscriptionEstimatorToolStripMenuItem
            // 
            this.saasSubscriptionEstimatorToolStripMenuItem.Name = "saasSubscriptionEstimatorToolStripMenuItem";
            this.saasSubscriptionEstimatorToolStripMenuItem.Size = new System.Drawing.Size(294, 34);
            this.saasSubscriptionEstimatorToolStripMenuItem.Text = "Subscription estimator";
            this.saasSubscriptionEstimatorToolStripMenuItem.Click += new System.EventHandler(this.SubscriptionEstimatorToolStripMenuItem_Click);
            // 
            // saasSubscriptionsAvailableToolStripMenuItem
            // 
            this.saasSubscriptionsAvailableToolStripMenuItem.Name = "saasSubscriptionsAvailableToolStripMenuItem";
            this.saasSubscriptionsAvailableToolStripMenuItem.Size = new System.Drawing.Size(294, 34);
            this.saasSubscriptionsAvailableToolStripMenuItem.Text = "Subscriptions available";
            this.saasSubscriptionsAvailableToolStripMenuItem.Click += new System.EventHandler(this.SubscriptionsAvailableToolStripMenuItem_Click);
            // 
            // saasProjectSeetingsToolStripMenuItem
            // 
            this.saasProjectSeetingsToolStripMenuItem.Name = "saasProjectSeetingsToolStripMenuItem";
            this.saasProjectSeetingsToolStripMenuItem.Size = new System.Drawing.Size(294, 34);
            this.saasProjectSeetingsToolStripMenuItem.Text = "Project seetings";
            this.saasProjectSeetingsToolStripMenuItem.Click += new System.EventHandler(this.ProjectUsersToolStripMenuItem_Click);
            // 
            // saasProjectUsersToolStripMenuItem
            // 
            this.saasProjectUsersToolStripMenuItem.Name = "saasProjectUsersToolStripMenuItem";
            this.saasProjectUsersToolStripMenuItem.Size = new System.Drawing.Size(294, 34);
            this.saasProjectUsersToolStripMenuItem.Text = "Project users";
            this.saasProjectUsersToolStripMenuItem.Click += new System.EventHandler(this.ProjectUsersToolStripMenuItem_Click);
            // 
            // saasLcsInstanceLinksToolStripMenuItem1
            // 
            this.saasLcsInstanceLinksToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saasInstanceDetailsToolStripMenuItem,
            this.saasEnvironmentMonitoringToolStripMenuItem,
            this.saasDetailedVersionInformationToolStripMenuItem,
            this.saasEnvironmentChangeHistoryToolStripMenuItem,
            this.saasDataPackagesHistoryToolStripMenuItem});
            this.saasLcsInstanceLinksToolStripMenuItem1.Name = "saasLcsInstanceLinksToolStripMenuItem1";
            this.saasLcsInstanceLinksToolStripMenuItem1.Size = new System.Drawing.Size(272, 32);
            this.saasLcsInstanceLinksToolStripMenuItem1.Text = "LCS instance links";
            // 
            // saasInstanceDetailsToolStripMenuItem
            // 
            this.saasInstanceDetailsToolStripMenuItem.Name = "saasInstanceDetailsToolStripMenuItem";
            this.saasInstanceDetailsToolStripMenuItem.Size = new System.Drawing.Size(339, 34);
            this.saasInstanceDetailsToolStripMenuItem.Text = "Instance details";
            this.saasInstanceDetailsToolStripMenuItem.Click += new System.EventHandler(this.InstanceDetailsToolStripMenuItem_Click);
            // 
            // saasEnvironmentMonitoringToolStripMenuItem
            // 
            this.saasEnvironmentMonitoringToolStripMenuItem.Name = "saasEnvironmentMonitoringToolStripMenuItem";
            this.saasEnvironmentMonitoringToolStripMenuItem.Size = new System.Drawing.Size(339, 34);
            this.saasEnvironmentMonitoringToolStripMenuItem.Text = "Environment monitoring";
            this.saasEnvironmentMonitoringToolStripMenuItem.Click += new System.EventHandler(this.EnvironmentMonitoringToolStripMenuItem_Click);
            // 
            // saasDetailedVersionInformationToolStripMenuItem
            // 
            this.saasDetailedVersionInformationToolStripMenuItem.Name = "saasDetailedVersionInformationToolStripMenuItem";
            this.saasDetailedVersionInformationToolStripMenuItem.Size = new System.Drawing.Size(339, 34);
            this.saasDetailedVersionInformationToolStripMenuItem.Text = "Detailed version information";
            this.saasDetailedVersionInformationToolStripMenuItem.Click += new System.EventHandler(this.DetailedVersionInformationToolStripMenuItem_Click);
            // 
            // saasEnvironmentChangeHistoryToolStripMenuItem
            // 
            this.saasEnvironmentChangeHistoryToolStripMenuItem.Name = "saasEnvironmentChangeHistoryToolStripMenuItem";
            this.saasEnvironmentChangeHistoryToolStripMenuItem.Size = new System.Drawing.Size(339, 34);
            this.saasEnvironmentChangeHistoryToolStripMenuItem.Text = "Environment change history";
            this.saasEnvironmentChangeHistoryToolStripMenuItem.Click += new System.EventHandler(this.EnvironmentChangeHistoryToolStripMenuItem_Click);
            // 
            // saasDataPackagesHistoryToolStripMenuItem
            // 
            this.saasDataPackagesHistoryToolStripMenuItem.Name = "saasDataPackagesHistoryToolStripMenuItem";
            this.saasDataPackagesHistoryToolStripMenuItem.Size = new System.Drawing.Size(339, 34);
            this.saasDataPackagesHistoryToolStripMenuItem.Text = "Data packages history";
            this.saasDataPackagesHistoryToolStripMenuItem.Click += new System.EventHandler(this.DataPackagesHistoryToolStripMenuItem_Click);
            // 
            // saasDeployPackageToolStripMenuItem
            // 
            this.saasDeployPackageToolStripMenuItem.Name = "saasDeployPackageToolStripMenuItem";
            this.saasDeployPackageToolStripMenuItem.Size = new System.Drawing.Size(272, 32);
            this.saasDeployPackageToolStripMenuItem.Text = "Deploy package";
            this.saasDeployPackageToolStripMenuItem.Click += new System.EventHandler(this.DeployPackageToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectDescriptionLabel,
            this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 813);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 14, 0);
            this.statusStrip.Size = new System.Drawing.Size(1478, 32);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // projectDescriptionLabel
            // 
            this.projectDescriptionLabel.Name = "projectDescriptionLabel";
            this.projectDescriptionLabel.Size = new System.Drawing.Size(0, 25);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(384, 25);
            this.toolStripStatusLabel1.Text = "Right click on an instance to perform an action.";
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.Icon = global::LCS.Properties.Resources.favicon_white;
            this.notifyIcon.Text = "2LCS - Lightweight LCS";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 845);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.mainMenuStrip);
            this.Controls.Add(this.statusStrip);
            this.Icon = global::LCS.Properties.Resources.favicon_blue;
            this.MainMenuStrip = this.mainMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(599, 357);
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2LCS - Lifecycle Services companion app";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cheDataGridView)).EndInit();
            this.cheInstanceContextMenu.ResumeLayout(false);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.cheTabPage.ResumeLayout(false);
            this.saasTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.saasDataGridView)).EndInit();
            this.saasInstanceContextMenu.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.ToolStripMenuItem saasLcsProjectLinksToolStripMenuItem1;
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
        private System.Windows.Forms.ToolStripMenuItem saasProjectSeetingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saasAssetLibraryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saasServiceRequestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saasSupportIssuesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saasSystemDiagnosticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cheOpenRDPConnectionToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn cheInstanceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cheEnvironmentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cheDisplayName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cheDeploymentStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn cheDeploymentAction;
        private System.Windows.Forms.DataGridViewTextBoxColumn cheCurrentPlatformVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cheCurrentPlatformReleaseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cheCurrentApplicationReleaseName;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn saasCurrentPlatformVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn saasCurrentPlatformReleaseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn saasCurrentApplicationReleaseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn saasBuildInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn saasDeployedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn saasDeployedOn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saasTopologyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn saasTopologyType;
        private System.Windows.Forms.DataGridViewTextBoxColumn saasTopologyVersion;
        private System.Windows.Forms.ToolStripMenuItem saasOpenRdpConnectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cookieToolStripMenuItem;
    }
}

