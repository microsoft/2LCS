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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.cheDataGridView = new System.Windows.Forms.DataGridView();
            this.cheInstanceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cheEnvironmentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cheDisplayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cheTopologyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cheTopologyType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cheTopologyVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cheCurrentPlatformVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cheCurrentPlatformReleaseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cheCurrentApplicationReleaseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cheBuildInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cheDeploymentStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cheDeploymentAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cheDeployedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cheDeployedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cheInstanceContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cheLogonToAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openRDPConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheManageVirtualMachineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheStartInstanceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheStopInstanceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheDeallocateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheDeleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheRdpAndPasswordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheShowPasswordsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheShowRDPDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheExportRDCManConnectionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheAvailableHotfixesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheMetadataHotfixesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheApplicationBinaryHotfixesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chePlatformHotfixesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.loginToLcsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeProjectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customLinksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.cheTabPage = new System.Windows.Forms.TabPage();
            this.saasTabPage = new System.Windows.Forms.TabPage();
            this.saasDataGridView = new System.Windows.Forms.DataGridView();
            this.saasInstanceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saasEnvironmentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saasDisplayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saasTopologyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saasTopologyType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saasTopologyVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saasCurrentPlatformVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saasCurrentPlatformReleaseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saasCurrentApplicationReleaseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saasBuildInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saasDeploymentStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saasDeploymentAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saasDeployedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saasDeployedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saasInstanceContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saasLogonToApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saasManageVirtualMachineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saasStartInstanceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saasStopInstanceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saasDeallocateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saasDeleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saasAddNsgRule = new System.Windows.Forms.ToolStripMenuItem();
            this.saasDeleteNsgRule = new System.Windows.Forms.ToolStripMenuItem();
            this.saasRdpAndPasswordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saasShowPasswordsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saasShowRDPDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saasExportRDCManConnectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saasAvailableHotfixesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saasApplicationMetadataHotfixesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saasApplicationBinaryHotfixesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saasPlatformBinaryHotfixesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saasCriticalMetadataHotfixesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.projectDescriptionLabel = new System.Windows.Forms.ToolStripStatusLabel();
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
            this.cheTopologyName,
            this.cheTopologyType,
            this.cheTopologyVersion,
            this.cheCurrentPlatformVersion,
            this.cheCurrentPlatformReleaseName,
            this.cheCurrentApplicationReleaseName,
            this.cheBuildInfo,
            this.cheDeploymentStatus,
            this.cheDeploymentAction,
            this.cheDeployedBy,
            this.cheDeployedOn});
            this.cheDataGridView.ContextMenuStrip = this.cheInstanceContextMenu;
            this.cheDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cheDataGridView.Location = new System.Drawing.Point(3, 3);
            this.cheDataGridView.Name = "cheDataGridView";
            this.cheDataGridView.ReadOnly = true;
            this.cheDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.cheDataGridView.Size = new System.Drawing.Size(1464, 751);
            this.cheDataGridView.TabIndex = 0;
            this.cheDataGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CheDataGridView_ColumnHeaderMouseClick);
            this.cheDataGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DataGridView_MouseDown);
            // 
            // cheInstanceId
            // 
            this.cheInstanceId.DataPropertyName = "InstanceId";
            this.cheInstanceId.HeaderText = "Instance Id";
            this.cheInstanceId.Name = "cheInstanceId";
            this.cheInstanceId.ReadOnly = true;
            this.cheInstanceId.Width = 116;
            // 
            // cheEnvironmentId
            // 
            this.cheEnvironmentId.DataPropertyName = "EnvironmentId";
            this.cheEnvironmentId.HeaderText = "Environment Id";
            this.cheEnvironmentId.Name = "cheEnvironmentId";
            this.cheEnvironmentId.ReadOnly = true;
            this.cheEnvironmentId.Width = 140;
            // 
            // cheDisplayName
            // 
            this.cheDisplayName.DataPropertyName = "DisplayName";
            this.cheDisplayName.HeaderText = "Display Name";
            this.cheDisplayName.Name = "cheDisplayName";
            this.cheDisplayName.ReadOnly = true;
            this.cheDisplayName.Width = 131;
            // 
            // cheTopologyName
            // 
            this.cheTopologyName.DataPropertyName = "TopologyName";
            this.cheTopologyName.HeaderText = "Topology Name";
            this.cheTopologyName.Name = "cheTopologyName";
            this.cheTopologyName.ReadOnly = true;
            this.cheTopologyName.Width = 143;
            // 
            // cheTopologyType
            // 
            this.cheTopologyType.DataPropertyName = "TopologyType";
            this.cheTopologyType.HeaderText = "Topology Type";
            this.cheTopologyType.Name = "cheTopologyType";
            this.cheTopologyType.ReadOnly = true;
            this.cheTopologyType.Width = 135;
            // 
            // cheTopologyVersion
            // 
            this.cheTopologyVersion.DataPropertyName = "TopologyVersion";
            this.cheTopologyVersion.HeaderText = "Topology Version";
            this.cheTopologyVersion.Name = "cheTopologyVersion";
            this.cheTopologyVersion.ReadOnly = true;
            this.cheTopologyVersion.Width = 153;
            // 
            // cheCurrentPlatformVersion
            // 
            this.cheCurrentPlatformVersion.DataPropertyName = "CurrentPlatformVersion";
            this.cheCurrentPlatformVersion.HeaderText = "Current Platform Version";
            this.cheCurrentPlatformVersion.Name = "cheCurrentPlatformVersion";
            this.cheCurrentPlatformVersion.ReadOnly = true;
            this.cheCurrentPlatformVersion.Width = 200;
            // 
            // cheCurrentPlatformReleaseName
            // 
            this.cheCurrentPlatformReleaseName.DataPropertyName = "CurrentPlatformReleaseName";
            this.cheCurrentPlatformReleaseName.HeaderText = "Current Platform Release Name";
            this.cheCurrentPlatformReleaseName.Name = "cheCurrentPlatformReleaseName";
            this.cheCurrentPlatformReleaseName.ReadOnly = true;
            this.cheCurrentPlatformReleaseName.Width = 208;
            // 
            // cheCurrentApplicationReleaseName
            // 
            this.cheCurrentApplicationReleaseName.DataPropertyName = "CurrentApplicationReleaseName";
            this.cheCurrentApplicationReleaseName.HeaderText = "Current Application Release Name";
            this.cheCurrentApplicationReleaseName.Name = "cheCurrentApplicationReleaseName";
            this.cheCurrentApplicationReleaseName.ReadOnly = true;
            this.cheCurrentApplicationReleaseName.Width = 225;
            // 
            // cheBuildInfo
            // 
            this.cheBuildInfo.DataPropertyName = "BuildInfo";
            this.cheBuildInfo.HeaderText = "Build Info";
            this.cheBuildInfo.Name = "cheBuildInfo";
            this.cheBuildInfo.ReadOnly = true;
            this.cheBuildInfo.Width = 104;
            // 
            // cheDeploymentStatus
            // 
            this.cheDeploymentStatus.DataPropertyName = "DeploymentStatus";
            this.cheDeploymentStatus.HeaderText = "Deployment Status";
            this.cheDeploymentStatus.Name = "cheDeploymentStatus";
            this.cheDeploymentStatus.ReadOnly = true;
            this.cheDeploymentStatus.Width = 166;
            // 
            // cheDeploymentAction
            // 
            this.cheDeploymentAction.DataPropertyName = "DeploymentAction";
            this.cheDeploymentAction.HeaderText = "Deployment Action";
            this.cheDeploymentAction.Name = "cheDeploymentAction";
            this.cheDeploymentAction.ReadOnly = true;
            this.cheDeploymentAction.Width = 164;
            // 
            // cheDeployedBy
            // 
            this.cheDeployedBy.DataPropertyName = "DeployedBy";
            this.cheDeployedBy.HeaderText = "Deployed By";
            this.cheDeployedBy.Name = "cheDeployedBy";
            this.cheDeployedBy.ReadOnly = true;
            this.cheDeployedBy.Width = 124;
            // 
            // cheDeployedOn
            // 
            this.cheDeployedOn.DataPropertyName = "DeployedOn";
            this.cheDeployedOn.HeaderText = "Deployed On";
            this.cheDeployedOn.Name = "cheDeployedOn";
            this.cheDeployedOn.ReadOnly = true;
            this.cheDeployedOn.Width = 126;
            // 
            // cheInstanceContextMenu
            // 
            this.cheInstanceContextMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cheInstanceContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cheLogonToAppToolStripMenuItem,
            this.openRDPConnectionToolStripMenuItem,
            this.cheManageVirtualMachineToolStripMenuItem,
            this.cheRdpAndPasswordsToolStripMenuItem,
            this.cheAvailableHotfixesToolStripMenuItem,
            this.cheLcsInstanceLinksToolStripMenuItem,
            this.cheLcsProjectLinksToolStripMenuItem});
            this.cheInstanceContextMenu.Name = "instanceContextMenuStrip";
            this.cheInstanceContextMenu.Size = new System.Drawing.Size(273, 214);
            this.cheInstanceContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.InstanceContextMenu_Opening);
            // 
            // cheLogonToAppToolStripMenuItem
            // 
            this.cheLogonToAppToolStripMenuItem.Name = "cheLogonToAppToolStripMenuItem";
            this.cheLogonToAppToolStripMenuItem.Size = new System.Drawing.Size(272, 30);
            this.cheLogonToAppToolStripMenuItem.Text = "Logon to application";
            this.cheLogonToAppToolStripMenuItem.Click += new System.EventHandler(this.LogonToApplicationToolStripMenuItem_Click);
            // 
            // openRDPConnectionToolStripMenuItem
            // 
            this.openRDPConnectionToolStripMenuItem.Name = "openRDPConnectionToolStripMenuItem";
            this.openRDPConnectionToolStripMenuItem.Size = new System.Drawing.Size(272, 30);
            this.openRDPConnectionToolStripMenuItem.Text = "Open RDP connection";
            this.openRDPConnectionToolStripMenuItem.Click += new System.EventHandler(this.OpenRDPConnectionToolStripMenuItem_Click);
            // 
            // cheManageVirtualMachineToolStripMenuItem
            // 
            this.cheManageVirtualMachineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cheStartInstanceMenuItem,
            this.cheStopInstanceMenuItem,
            this.cheDeallocateMenuItem,
            this.cheDeleteMenuItem});
            this.cheManageVirtualMachineToolStripMenuItem.Name = "cheManageVirtualMachineToolStripMenuItem";
            this.cheManageVirtualMachineToolStripMenuItem.Size = new System.Drawing.Size(272, 30);
            this.cheManageVirtualMachineToolStripMenuItem.Text = "Manage virtual machine";
            // 
            // cheStartInstanceMenuItem
            // 
            this.cheStartInstanceMenuItem.Name = "cheStartInstanceMenuItem";
            this.cheStartInstanceMenuItem.Size = new System.Drawing.Size(247, 30);
            this.cheStartInstanceMenuItem.Text = "Start instance(s)";
            this.cheStartInstanceMenuItem.Click += new System.EventHandler(this.StartInstanceMenuItem_Click);
            // 
            // cheStopInstanceMenuItem
            // 
            this.cheStopInstanceMenuItem.Name = "cheStopInstanceMenuItem";
            this.cheStopInstanceMenuItem.Size = new System.Drawing.Size(247, 30);
            this.cheStopInstanceMenuItem.Text = "Stop instance(s)";
            this.cheStopInstanceMenuItem.Click += new System.EventHandler(this.StopInstanceMenuItem_Click);
            // 
            // cheDeallocateMenuItem
            // 
            this.cheDeallocateMenuItem.Name = "cheDeallocateMenuItem";
            this.cheDeallocateMenuItem.Size = new System.Drawing.Size(247, 30);
            this.cheDeallocateMenuItem.Text = "Deallocate instance";
            this.cheDeallocateMenuItem.Click += new System.EventHandler(this.DeallocateMenuItem_Click);
            // 
            // cheDeleteMenuItem
            // 
            this.cheDeleteMenuItem.Name = "cheDeleteMenuItem";
            this.cheDeleteMenuItem.Size = new System.Drawing.Size(247, 30);
            this.cheDeleteMenuItem.Text = "Delete instance";
            this.cheDeleteMenuItem.Click += new System.EventHandler(this.DeleteMenuItem_Click);
            // 
            // cheRdpAndPasswordsToolStripMenuItem
            // 
            this.cheRdpAndPasswordsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cheShowPasswordsMenuItem,
            this.cheShowRDPDetailsToolStripMenuItem,
            this.cheExportRDCManConnectionsMenuItem});
            this.cheRdpAndPasswordsToolStripMenuItem.Name = "cheRdpAndPasswordsToolStripMenuItem";
            this.cheRdpAndPasswordsToolStripMenuItem.Size = new System.Drawing.Size(272, 30);
            this.cheRdpAndPasswordsToolStripMenuItem.Text = "RDP and passwords";
            // 
            // cheShowPasswordsMenuItem
            // 
            this.cheShowPasswordsMenuItem.Name = "cheShowPasswordsMenuItem";
            this.cheShowPasswordsMenuItem.Size = new System.Drawing.Size(322, 30);
            this.cheShowPasswordsMenuItem.Text = "Show passwords";
            this.cheShowPasswordsMenuItem.Click += new System.EventHandler(this.CheShowPasswordsMenuItem_Click);
            // 
            // cheShowRDPDetailsToolStripMenuItem
            // 
            this.cheShowRDPDetailsToolStripMenuItem.Name = "cheShowRDPDetailsToolStripMenuItem";
            this.cheShowRDPDetailsToolStripMenuItem.Size = new System.Drawing.Size(322, 30);
            this.cheShowRDPDetailsToolStripMenuItem.Text = "Show RDP details";
            this.cheShowRDPDetailsToolStripMenuItem.Click += new System.EventHandler(this.ShowRDPDetailsToolStripMenuItem_Click);
            // 
            // cheExportRDCManConnectionsMenuItem
            // 
            this.cheExportRDCManConnectionsMenuItem.Name = "cheExportRDCManConnectionsMenuItem";
            this.cheExportRDCManConnectionsMenuItem.Size = new System.Drawing.Size(322, 30);
            this.cheExportRDCManConnectionsMenuItem.Text = "Export RDCMan connections";
            this.cheExportRDCManConnectionsMenuItem.ToolTipText = "Export all RDP connections to Remote Desktop Connection Manager import file";
            this.cheExportRDCManConnectionsMenuItem.Click += new System.EventHandler(this.CheExportRDCManConnectionsMenuItem_Click);
            // 
            // cheAvailableHotfixesToolStripMenuItem
            // 
            this.cheAvailableHotfixesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cheMetadataHotfixesToolStripMenuItem,
            this.cheApplicationBinaryHotfixesToolStripMenuItem,
            this.chePlatformHotfixesToolStripMenuItem});
            this.cheAvailableHotfixesToolStripMenuItem.Name = "cheAvailableHotfixesToolStripMenuItem";
            this.cheAvailableHotfixesToolStripMenuItem.Size = new System.Drawing.Size(272, 30);
            this.cheAvailableHotfixesToolStripMenuItem.Text = "Available hotfixes";
            // 
            // cheMetadataHotfixesToolStripMenuItem
            // 
            this.cheMetadataHotfixesToolStripMenuItem.Name = "cheMetadataHotfixesToolStripMenuItem";
            this.cheMetadataHotfixesToolStripMenuItem.Size = new System.Drawing.Size(333, 30);
            this.cheMetadataHotfixesToolStripMenuItem.Text = "Application metadata hotfixes";
            this.cheMetadataHotfixesToolStripMenuItem.Click += new System.EventHandler(this.HotfixesToolStripMenuItem_Click);
            // 
            // cheApplicationBinaryHotfixesToolStripMenuItem
            // 
            this.cheApplicationBinaryHotfixesToolStripMenuItem.Name = "cheApplicationBinaryHotfixesToolStripMenuItem";
            this.cheApplicationBinaryHotfixesToolStripMenuItem.Size = new System.Drawing.Size(333, 30);
            this.cheApplicationBinaryHotfixesToolStripMenuItem.Text = "Application binary hotfixes";
            this.cheApplicationBinaryHotfixesToolStripMenuItem.Click += new System.EventHandler(this.HotfixesToolStripMenuItem_Click);
            // 
            // chePlatformHotfixesToolStripMenuItem
            // 
            this.chePlatformHotfixesToolStripMenuItem.Name = "chePlatformHotfixesToolStripMenuItem";
            this.chePlatformHotfixesToolStripMenuItem.Size = new System.Drawing.Size(333, 30);
            this.chePlatformHotfixesToolStripMenuItem.Text = "Platform binary hotfixes";
            this.chePlatformHotfixesToolStripMenuItem.Click += new System.EventHandler(this.HotfixesToolStripMenuItem_Click);
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
            this.cheLcsInstanceLinksToolStripMenuItem.Size = new System.Drawing.Size(272, 30);
            this.cheLcsInstanceLinksToolStripMenuItem.Text = "LCS instance links";
            // 
            // cheInstanceDetailsToolStripMenuItem
            // 
            this.cheInstanceDetailsToolStripMenuItem.Name = "cheInstanceDetailsToolStripMenuItem";
            this.cheInstanceDetailsToolStripMenuItem.Size = new System.Drawing.Size(321, 30);
            this.cheInstanceDetailsToolStripMenuItem.Text = "Instance details";
            this.cheInstanceDetailsToolStripMenuItem.Click += new System.EventHandler(this.InstanceDetailsToolStripMenuItem_Click);
            // 
            // cheEnvironmentMonitoringToolStripMenuItem
            // 
            this.cheEnvironmentMonitoringToolStripMenuItem.Name = "cheEnvironmentMonitoringToolStripMenuItem";
            this.cheEnvironmentMonitoringToolStripMenuItem.Size = new System.Drawing.Size(321, 30);
            this.cheEnvironmentMonitoringToolStripMenuItem.Text = "Environment monitoring";
            this.cheEnvironmentMonitoringToolStripMenuItem.Click += new System.EventHandler(this.EnvironmentMonitoringToolStripMenuItem_Click);
            // 
            // cheDetailedVersionInformationToolStripMenuItem
            // 
            this.cheDetailedVersionInformationToolStripMenuItem.Name = "cheDetailedVersionInformationToolStripMenuItem";
            this.cheDetailedVersionInformationToolStripMenuItem.Size = new System.Drawing.Size(321, 30);
            this.cheDetailedVersionInformationToolStripMenuItem.Text = "Detailed version information";
            this.cheDetailedVersionInformationToolStripMenuItem.Click += new System.EventHandler(this.DetailedVersionInformationToolStripMenuItem_Click);
            // 
            // cheEnvironmenChangeHistoryToolStripMenuItem
            // 
            this.cheEnvironmenChangeHistoryToolStripMenuItem.Name = "cheEnvironmenChangeHistoryToolStripMenuItem";
            this.cheEnvironmenChangeHistoryToolStripMenuItem.Size = new System.Drawing.Size(321, 30);
            this.cheEnvironmenChangeHistoryToolStripMenuItem.Text = "Environment change history";
            this.cheEnvironmenChangeHistoryToolStripMenuItem.Click += new System.EventHandler(this.EnvironmentChangeHistoryToolStripMenuItem_Click);
            // 
            // cheDataPackagesHistoryToolStripMenuItem
            // 
            this.cheDataPackagesHistoryToolStripMenuItem.Name = "cheDataPackagesHistoryToolStripMenuItem";
            this.cheDataPackagesHistoryToolStripMenuItem.Size = new System.Drawing.Size(321, 30);
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
            this.cheLcsProjectLinksToolStripMenuItem.Size = new System.Drawing.Size(272, 30);
            this.cheLcsProjectLinksToolStripMenuItem.Text = "LCS project links";
            // 
            // cheServiceRequestsToolStripMenuItem
            // 
            this.cheServiceRequestsToolStripMenuItem.Name = "cheServiceRequestsToolStripMenuItem";
            this.cheServiceRequestsToolStripMenuItem.Size = new System.Drawing.Size(276, 30);
            this.cheServiceRequestsToolStripMenuItem.Text = "Service requests";
            this.cheServiceRequestsToolStripMenuItem.Click += new System.EventHandler(this.ServiceRequestsToolStripMenuItem_Click);
            // 
            // cheSupportIssuesToolStripMenuItem
            // 
            this.cheSupportIssuesToolStripMenuItem.Name = "cheSupportIssuesToolStripMenuItem";
            this.cheSupportIssuesToolStripMenuItem.Size = new System.Drawing.Size(276, 30);
            this.cheSupportIssuesToolStripMenuItem.Text = "Support issues";
            this.cheSupportIssuesToolStripMenuItem.Click += new System.EventHandler(this.SupportIssuesToolStripMenuItem_Click);
            // 
            // cheOpenWorkItemsToolStripMenuItem
            // 
            this.cheOpenWorkItemsToolStripMenuItem.Name = "cheOpenWorkItemsToolStripMenuItem";
            this.cheOpenWorkItemsToolStripMenuItem.Size = new System.Drawing.Size(276, 30);
            this.cheOpenWorkItemsToolStripMenuItem.Text = "Open work items";
            this.cheOpenWorkItemsToolStripMenuItem.Click += new System.EventHandler(this.OpenWorkItemsToolStripMenuItem_Click);
            // 
            // cheAssetLibraryToolStripMenuItem
            // 
            this.cheAssetLibraryToolStripMenuItem.Name = "cheAssetLibraryToolStripMenuItem";
            this.cheAssetLibraryToolStripMenuItem.Size = new System.Drawing.Size(276, 30);
            this.cheAssetLibraryToolStripMenuItem.Text = "Asset library";
            this.cheAssetLibraryToolStripMenuItem.Click += new System.EventHandler(this.AssetLibraryToolStripMenuItem_Click);
            // 
            // cheSystemDiagnosticsToolStripMenuItem
            // 
            this.cheSystemDiagnosticsToolStripMenuItem.Name = "cheSystemDiagnosticsToolStripMenuItem";
            this.cheSystemDiagnosticsToolStripMenuItem.Size = new System.Drawing.Size(276, 30);
            this.cheSystemDiagnosticsToolStripMenuItem.Text = "System diagnostics";
            this.cheSystemDiagnosticsToolStripMenuItem.Click += new System.EventHandler(this.SystemDiagnosticsToolStripMenuItem_Click);
            // 
            // cheSubscriptionEstimatorToolStripMenuItem
            // 
            this.cheSubscriptionEstimatorToolStripMenuItem.Name = "cheSubscriptionEstimatorToolStripMenuItem";
            this.cheSubscriptionEstimatorToolStripMenuItem.Size = new System.Drawing.Size(276, 30);
            this.cheSubscriptionEstimatorToolStripMenuItem.Text = "Subscription estimator";
            this.cheSubscriptionEstimatorToolStripMenuItem.Click += new System.EventHandler(this.SubscriptionEstimatorToolStripMenuItem_Click);
            // 
            // cheSubscriptionsAvailableToolStripMenuItem
            // 
            this.cheSubscriptionsAvailableToolStripMenuItem.Name = "cheSubscriptionsAvailableToolStripMenuItem";
            this.cheSubscriptionsAvailableToolStripMenuItem.Size = new System.Drawing.Size(276, 30);
            this.cheSubscriptionsAvailableToolStripMenuItem.Text = "Subscriptions available";
            this.cheSubscriptionsAvailableToolStripMenuItem.Click += new System.EventHandler(this.SubscriptionsAvailableToolStripMenuItem_Click);
            // 
            // cheProjectSettingsToolStripMenuItem
            // 
            this.cheProjectSettingsToolStripMenuItem.Name = "cheProjectSettingsToolStripMenuItem";
            this.cheProjectSettingsToolStripMenuItem.Size = new System.Drawing.Size(276, 30);
            this.cheProjectSettingsToolStripMenuItem.Text = "Project settings";
            this.cheProjectSettingsToolStripMenuItem.Click += new System.EventHandler(this.ProjectSettingsToolStripMenuItem_Click);
            // 
            // cheProjectUsersToolStripMenuItem
            // 
            this.cheProjectUsersToolStripMenuItem.Name = "cheProjectUsersToolStripMenuItem";
            this.cheProjectUsersToolStripMenuItem.Size = new System.Drawing.Size(276, 30);
            this.cheProjectUsersToolStripMenuItem.Text = "Project users";
            this.cheProjectUsersToolStripMenuItem.Click += new System.EventHandler(this.ProjectUsersToolStripMenuItem_Click);
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToLcsMenuItem,
            this.changeProjectMenuItem,
            this.refreshMenuItem,
            this.customLinksToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(1478, 33);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // loginToLcsMenuItem
            // 
            this.loginToLcsMenuItem.Name = "loginToLcsMenuItem";
            this.loginToLcsMenuItem.Size = new System.Drawing.Size(123, 29);
            this.loginToLcsMenuItem.Text = "&Login to LCS";
            this.loginToLcsMenuItem.Click += new System.EventHandler(this.LoginToLCSMenuItem_Click);
            // 
            // changeProjectMenuItem
            // 
            this.changeProjectMenuItem.Enabled = false;
            this.changeProjectMenuItem.Name = "changeProjectMenuItem";
            this.changeProjectMenuItem.Size = new System.Drawing.Size(207, 29);
            this.changeProjectMenuItem.Text = "&Change project context";
            this.changeProjectMenuItem.Click += new System.EventHandler(this.ChangeProjectMenuItem_Click);
            // 
            // refreshMenuItem
            // 
            this.refreshMenuItem.Enabled = false;
            this.refreshMenuItem.Name = "refreshMenuItem";
            this.refreshMenuItem.Size = new System.Drawing.Size(247, 29);
            this.refreshMenuItem.Text = "&Refresh instances for project";
            this.refreshMenuItem.Click += new System.EventHandler(this.RefreshMenuItem_Click);
            // 
            // customLinksToolStripMenuItem
            // 
            this.customLinksToolStripMenuItem.Name = "customLinksToolStripMenuItem";
            this.customLinksToolStripMenuItem.Size = new System.Drawing.Size(179, 29);
            this.customLinksToolStripMenuItem.Text = "Define c&ustom links";
            this.customLinksToolStripMenuItem.Click += new System.EventHandler(this.CustomLinksToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Enabled = false;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(81, 29);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.LogoutToolStripMenuItem_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.cheTabPage);
            this.tabControl.Controls.Add(this.saasTabPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 33);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1478, 790);
            this.tabControl.TabIndex = 1;
            // 
            // cheTabPage
            // 
            this.cheTabPage.Controls.Add(this.cheDataGridView);
            this.cheTabPage.Location = new System.Drawing.Point(4, 29);
            this.cheTabPage.Name = "cheTabPage";
            this.cheTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.cheTabPage.Size = new System.Drawing.Size(1470, 757);
            this.cheTabPage.TabIndex = 0;
            this.cheTabPage.Text = "Cloud-hosted instances";
            this.cheTabPage.UseVisualStyleBackColor = true;
            // 
            // saasTabPage
            // 
            this.saasTabPage.Controls.Add(this.saasDataGridView);
            this.saasTabPage.Location = new System.Drawing.Point(4, 29);
            this.saasTabPage.Name = "saasTabPage";
            this.saasTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.saasTabPage.Size = new System.Drawing.Size(1470, 757);
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
            this.saasTopologyName,
            this.saasTopologyType,
            this.saasTopologyVersion,
            this.saasCurrentPlatformVersion,
            this.saasCurrentPlatformReleaseName,
            this.saasCurrentApplicationReleaseName,
            this.saasBuildInfo,
            this.saasDeploymentStatus,
            this.saasDeploymentAction,
            this.saasDeployedBy,
            this.saasDeployedOn});
            this.saasDataGridView.ContextMenuStrip = this.saasInstanceContextMenu;
            this.saasDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saasDataGridView.Location = new System.Drawing.Point(3, 3);
            this.saasDataGridView.Name = "saasDataGridView";
            this.saasDataGridView.ReadOnly = true;
            this.saasDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.saasDataGridView.Size = new System.Drawing.Size(1464, 751);
            this.saasDataGridView.TabIndex = 1;
            this.saasDataGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SaasDataGridView_ColumnHeaderMouseClick);
            this.saasDataGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DataGridView_MouseDown);
            // 
            // saasInstanceId
            // 
            this.saasInstanceId.DataPropertyName = "InstanceId";
            this.saasInstanceId.HeaderText = "Instance Id";
            this.saasInstanceId.Name = "saasInstanceId";
            this.saasInstanceId.ReadOnly = true;
            this.saasInstanceId.Width = 116;
            // 
            // saasEnvironmentId
            // 
            this.saasEnvironmentId.DataPropertyName = "EnvironmentId";
            this.saasEnvironmentId.HeaderText = "Environment Id";
            this.saasEnvironmentId.Name = "saasEnvironmentId";
            this.saasEnvironmentId.ReadOnly = true;
            this.saasEnvironmentId.Width = 140;
            // 
            // saasDisplayName
            // 
            this.saasDisplayName.DataPropertyName = "DisplayName";
            this.saasDisplayName.HeaderText = "Display Name";
            this.saasDisplayName.Name = "saasDisplayName";
            this.saasDisplayName.ReadOnly = true;
            this.saasDisplayName.Width = 131;
            // 
            // saasTopologyName
            // 
            this.saasTopologyName.DataPropertyName = "TopologyName";
            this.saasTopologyName.HeaderText = "Topology Name";
            this.saasTopologyName.Name = "saasTopologyName";
            this.saasTopologyName.ReadOnly = true;
            this.saasTopologyName.Width = 143;
            // 
            // saasTopologyType
            // 
            this.saasTopologyType.DataPropertyName = "TopologyType";
            this.saasTopologyType.HeaderText = "Topology Type";
            this.saasTopologyType.Name = "saasTopologyType";
            this.saasTopologyType.ReadOnly = true;
            this.saasTopologyType.Width = 135;
            // 
            // saasTopologyVersion
            // 
            this.saasTopologyVersion.DataPropertyName = "TopologyVersion";
            this.saasTopologyVersion.HeaderText = "Topology Version";
            this.saasTopologyVersion.Name = "saasTopologyVersion";
            this.saasTopologyVersion.ReadOnly = true;
            this.saasTopologyVersion.Width = 153;
            // 
            // saasCurrentPlatformVersion
            // 
            this.saasCurrentPlatformVersion.DataPropertyName = "CurrentPlatformVersion";
            this.saasCurrentPlatformVersion.HeaderText = "Current Platform Version";
            this.saasCurrentPlatformVersion.Name = "saasCurrentPlatformVersion";
            this.saasCurrentPlatformVersion.ReadOnly = true;
            this.saasCurrentPlatformVersion.Width = 200;
            // 
            // saasCurrentPlatformReleaseName
            // 
            this.saasCurrentPlatformReleaseName.DataPropertyName = "CurrentPlatformReleaseName";
            this.saasCurrentPlatformReleaseName.HeaderText = "Current Platform Release Name";
            this.saasCurrentPlatformReleaseName.Name = "saasCurrentPlatformReleaseName";
            this.saasCurrentPlatformReleaseName.ReadOnly = true;
            this.saasCurrentPlatformReleaseName.Width = 208;
            // 
            // saasCurrentApplicationReleaseName
            // 
            this.saasCurrentApplicationReleaseName.DataPropertyName = "CurrentApplicationReleaseName";
            this.saasCurrentApplicationReleaseName.HeaderText = "Current Application Release Name";
            this.saasCurrentApplicationReleaseName.Name = "saasCurrentApplicationReleaseName";
            this.saasCurrentApplicationReleaseName.ReadOnly = true;
            this.saasCurrentApplicationReleaseName.Width = 225;
            // 
            // saasBuildInfo
            // 
            this.saasBuildInfo.DataPropertyName = "BuildInfo";
            this.saasBuildInfo.HeaderText = "Build Info";
            this.saasBuildInfo.Name = "saasBuildInfo";
            this.saasBuildInfo.ReadOnly = true;
            this.saasBuildInfo.Width = 104;
            // 
            // saasDeploymentStatus
            // 
            this.saasDeploymentStatus.DataPropertyName = "DeploymentStatus";
            this.saasDeploymentStatus.HeaderText = "Deployment Status";
            this.saasDeploymentStatus.Name = "saasDeploymentStatus";
            this.saasDeploymentStatus.ReadOnly = true;
            this.saasDeploymentStatus.Width = 166;
            // 
            // saasDeploymentAction
            // 
            this.saasDeploymentAction.DataPropertyName = "DeploymentAction";
            this.saasDeploymentAction.HeaderText = "Deployment Action";
            this.saasDeploymentAction.Name = "saasDeploymentAction";
            this.saasDeploymentAction.ReadOnly = true;
            this.saasDeploymentAction.Width = 164;
            // 
            // saasDeployedBy
            // 
            this.saasDeployedBy.DataPropertyName = "DeployedBy";
            this.saasDeployedBy.HeaderText = "Deployed By";
            this.saasDeployedBy.Name = "saasDeployedBy";
            this.saasDeployedBy.ReadOnly = true;
            this.saasDeployedBy.Width = 124;
            // 
            // saasDeployedOn
            // 
            this.saasDeployedOn.DataPropertyName = "DeployedOn";
            this.saasDeployedOn.HeaderText = "Deployed On";
            this.saasDeployedOn.Name = "saasDeployedOn";
            this.saasDeployedOn.ReadOnly = true;
            this.saasDeployedOn.Width = 126;
            // 
            // saasInstanceContextMenu
            // 
            this.saasInstanceContextMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.saasInstanceContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saasLogonToApplicationToolStripMenuItem,
            this.saasManageVirtualMachineToolStripMenuItem,
            this.saasRdpAndPasswordsToolStripMenuItem,
            this.saasAvailableHotfixesToolStripMenuItem,
            this.saasLcsProjectLinksToolStripMenuItem1,
            this.saasLcsInstanceLinksToolStripMenuItem1});
            this.saasInstanceContextMenu.Name = "instanceContextMenuStrip";
            this.saasInstanceContextMenu.Size = new System.Drawing.Size(273, 184);
            this.saasInstanceContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.InstanceContextMenu_Opening);
            // 
            // saasLogonToApplicationToolStripMenuItem
            // 
            this.saasLogonToApplicationToolStripMenuItem.Name = "saasLogonToApplicationToolStripMenuItem";
            this.saasLogonToApplicationToolStripMenuItem.Size = new System.Drawing.Size(272, 30);
            this.saasLogonToApplicationToolStripMenuItem.Text = "Logon to application";
            this.saasLogonToApplicationToolStripMenuItem.Click += new System.EventHandler(this.LogonToApplicationToolStripMenuItem_Click);
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
            this.saasManageVirtualMachineToolStripMenuItem.Size = new System.Drawing.Size(272, 30);
            this.saasManageVirtualMachineToolStripMenuItem.Text = "Manage virtual machine";
            // 
            // saasStartInstanceMenuItem
            // 
            this.saasStartInstanceMenuItem.Name = "saasStartInstanceMenuItem";
            this.saasStartInstanceMenuItem.Size = new System.Drawing.Size(287, 30);
            this.saasStartInstanceMenuItem.Text = "Start instance(s)";
            this.saasStartInstanceMenuItem.Click += new System.EventHandler(this.StartInstanceMenuItem_Click);
            // 
            // saasStopInstanceMenuItem
            // 
            this.saasStopInstanceMenuItem.Name = "saasStopInstanceMenuItem";
            this.saasStopInstanceMenuItem.Size = new System.Drawing.Size(287, 30);
            this.saasStopInstanceMenuItem.Text = "Stop instance(s)";
            this.saasStopInstanceMenuItem.Click += new System.EventHandler(this.StopInstanceMenuItem_Click);
            // 
            // saasDeallocateMenuItem
            // 
            this.saasDeallocateMenuItem.Name = "saasDeallocateMenuItem";
            this.saasDeallocateMenuItem.Size = new System.Drawing.Size(287, 30);
            this.saasDeallocateMenuItem.Text = "Deallocate instance";
            this.saasDeallocateMenuItem.Click += new System.EventHandler(this.DeallocateMenuItem_Click);
            // 
            // saasDeleteMenuItem
            // 
            this.saasDeleteMenuItem.Name = "saasDeleteMenuItem";
            this.saasDeleteMenuItem.Size = new System.Drawing.Size(287, 30);
            this.saasDeleteMenuItem.Text = "Delete instance";
            this.saasDeleteMenuItem.Click += new System.EventHandler(this.DeleteMenuItem_Click);
            // 
            // saasAddNsgRule
            // 
            this.saasAddNsgRule.Name = "saasAddNsgRule";
            this.saasAddNsgRule.Size = new System.Drawing.Size(287, 30);
            this.saasAddNsgRule.Text = "Add firewall exception";
            this.saasAddNsgRule.Click += new System.EventHandler(this.SaasAddNsgRule_Click);
            // 
            // saasDeleteNsgRule
            // 
            this.saasDeleteNsgRule.Name = "saasDeleteNsgRule";
            this.saasDeleteNsgRule.Size = new System.Drawing.Size(287, 30);
            this.saasDeleteNsgRule.Text = "Delete firewall exception";
            this.saasDeleteNsgRule.Click += new System.EventHandler(this.SaasDeleteNsgRule_Click);
            // 
            // saasRdpAndPasswordsToolStripMenuItem
            // 
            this.saasRdpAndPasswordsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saasShowPasswordsMenuItem,
            this.saasShowRDPDetailsToolStripMenuItem,
            this.saasExportRDCManConnectionsToolStripMenuItem});
            this.saasRdpAndPasswordsToolStripMenuItem.Name = "saasRdpAndPasswordsToolStripMenuItem";
            this.saasRdpAndPasswordsToolStripMenuItem.Size = new System.Drawing.Size(272, 30);
            this.saasRdpAndPasswordsToolStripMenuItem.Text = "RDP and passwords";
            // 
            // saasShowPasswordsMenuItem
            // 
            this.saasShowPasswordsMenuItem.Name = "saasShowPasswordsMenuItem";
            this.saasShowPasswordsMenuItem.Size = new System.Drawing.Size(322, 30);
            this.saasShowPasswordsMenuItem.Text = "Show passwords";
            this.saasShowPasswordsMenuItem.Click += new System.EventHandler(this.SaasShowPasswordsMenuItem_Click);
            // 
            // saasShowRDPDetailsToolStripMenuItem
            // 
            this.saasShowRDPDetailsToolStripMenuItem.Name = "saasShowRDPDetailsToolStripMenuItem";
            this.saasShowRDPDetailsToolStripMenuItem.Size = new System.Drawing.Size(322, 30);
            this.saasShowRDPDetailsToolStripMenuItem.Text = "Show RDP details";
            this.saasShowRDPDetailsToolStripMenuItem.Click += new System.EventHandler(this.ShowRDPDetailsToolStripMenuItem_Click);
            // 
            // saasExportRDCManConnectionsToolStripMenuItem
            // 
            this.saasExportRDCManConnectionsToolStripMenuItem.Name = "saasExportRDCManConnectionsToolStripMenuItem";
            this.saasExportRDCManConnectionsToolStripMenuItem.Size = new System.Drawing.Size(322, 30);
            this.saasExportRDCManConnectionsToolStripMenuItem.Text = "Export RDCMan connections";
            this.saasExportRDCManConnectionsToolStripMenuItem.ToolTipText = "Export all RDP connections to Remote Desktop Connection Manager import file";
            this.saasExportRDCManConnectionsToolStripMenuItem.Click += new System.EventHandler(this.SaasExportRDCManConnectionsToolStripMenuItem_Click);
            // 
            // saasAvailableHotfixesToolStripMenuItem
            // 
            this.saasAvailableHotfixesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saasApplicationMetadataHotfixesToolStripMenuItem,
            this.saasApplicationBinaryHotfixesToolStripMenuItem,
            this.saasPlatformBinaryHotfixesToolStripMenuItem,
            this.saasCriticalMetadataHotfixesToolStripMenuItem});
            this.saasAvailableHotfixesToolStripMenuItem.Name = "saasAvailableHotfixesToolStripMenuItem";
            this.saasAvailableHotfixesToolStripMenuItem.Size = new System.Drawing.Size(272, 30);
            this.saasAvailableHotfixesToolStripMenuItem.Text = "Available hotfixes";
            // 
            // saasApplicationMetadataHotfixesToolStripMenuItem
            // 
            this.saasApplicationMetadataHotfixesToolStripMenuItem.Name = "saasApplicationMetadataHotfixesToolStripMenuItem";
            this.saasApplicationMetadataHotfixesToolStripMenuItem.Size = new System.Drawing.Size(333, 30);
            this.saasApplicationMetadataHotfixesToolStripMenuItem.Text = "Application metadata hotfixes";
            this.saasApplicationMetadataHotfixesToolStripMenuItem.Click += new System.EventHandler(this.HotfixesToolStripMenuItem_Click);
            // 
            // saasApplicationBinaryHotfixesToolStripMenuItem
            // 
            this.saasApplicationBinaryHotfixesToolStripMenuItem.Name = "saasApplicationBinaryHotfixesToolStripMenuItem";
            this.saasApplicationBinaryHotfixesToolStripMenuItem.Size = new System.Drawing.Size(333, 30);
            this.saasApplicationBinaryHotfixesToolStripMenuItem.Text = "Application binary hotfixes";
            this.saasApplicationBinaryHotfixesToolStripMenuItem.Click += new System.EventHandler(this.HotfixesToolStripMenuItem_Click);
            // 
            // saasPlatformBinaryHotfixesToolStripMenuItem
            // 
            this.saasPlatformBinaryHotfixesToolStripMenuItem.Name = "saasPlatformBinaryHotfixesToolStripMenuItem";
            this.saasPlatformBinaryHotfixesToolStripMenuItem.Size = new System.Drawing.Size(333, 30);
            this.saasPlatformBinaryHotfixesToolStripMenuItem.Text = "Platform binary hotfixes";
            this.saasPlatformBinaryHotfixesToolStripMenuItem.Click += new System.EventHandler(this.HotfixesToolStripMenuItem_Click);
            // 
            // saasCriticalMetadataHotfixesToolStripMenuItem
            // 
            this.saasCriticalMetadataHotfixesToolStripMenuItem.Name = "saasCriticalMetadataHotfixesToolStripMenuItem";
            this.saasCriticalMetadataHotfixesToolStripMenuItem.Size = new System.Drawing.Size(333, 30);
            this.saasCriticalMetadataHotfixesToolStripMenuItem.Text = "Critical metadata hotfixes";
            this.saasCriticalMetadataHotfixesToolStripMenuItem.Click += new System.EventHandler(this.HotfixesToolStripMenuItem_Click);
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
            this.saasLcsProjectLinksToolStripMenuItem1.Size = new System.Drawing.Size(272, 30);
            this.saasLcsProjectLinksToolStripMenuItem1.Text = "LCS project links";
            // 
            // saasServiceRequestsToolStripMenuItem
            // 
            this.saasServiceRequestsToolStripMenuItem.Name = "saasServiceRequestsToolStripMenuItem";
            this.saasServiceRequestsToolStripMenuItem.Size = new System.Drawing.Size(276, 30);
            this.saasServiceRequestsToolStripMenuItem.Text = "Service requests";
            this.saasServiceRequestsToolStripMenuItem.Click += new System.EventHandler(this.ServiceRequestsToolStripMenuItem_Click);
            // 
            // saasSupportIssuesToolStripMenuItem
            // 
            this.saasSupportIssuesToolStripMenuItem.Name = "saasSupportIssuesToolStripMenuItem";
            this.saasSupportIssuesToolStripMenuItem.Size = new System.Drawing.Size(276, 30);
            this.saasSupportIssuesToolStripMenuItem.Text = "Support issues";
            this.saasSupportIssuesToolStripMenuItem.Click += new System.EventHandler(this.SupportIssuesToolStripMenuItem_Click);
            // 
            // saasOpenWorkItemsToolStripMenuItem
            // 
            this.saasOpenWorkItemsToolStripMenuItem.Name = "saasOpenWorkItemsToolStripMenuItem";
            this.saasOpenWorkItemsToolStripMenuItem.Size = new System.Drawing.Size(276, 30);
            this.saasOpenWorkItemsToolStripMenuItem.Text = "Open work items";
            this.saasOpenWorkItemsToolStripMenuItem.Click += new System.EventHandler(this.OpenWorkItemsToolStripMenuItem_Click);
            // 
            // saasAssetLibraryToolStripMenuItem
            // 
            this.saasAssetLibraryToolStripMenuItem.Name = "saasAssetLibraryToolStripMenuItem";
            this.saasAssetLibraryToolStripMenuItem.Size = new System.Drawing.Size(276, 30);
            this.saasAssetLibraryToolStripMenuItem.Text = "Asset library";
            this.saasAssetLibraryToolStripMenuItem.Click += new System.EventHandler(this.AssetLibraryToolStripMenuItem_Click);
            // 
            // saasSystemDiagnosticsToolStripMenuItem
            // 
            this.saasSystemDiagnosticsToolStripMenuItem.Name = "saasSystemDiagnosticsToolStripMenuItem";
            this.saasSystemDiagnosticsToolStripMenuItem.Size = new System.Drawing.Size(276, 30);
            this.saasSystemDiagnosticsToolStripMenuItem.Text = "System diagnostics";
            this.saasSystemDiagnosticsToolStripMenuItem.Click += new System.EventHandler(this.SystemDiagnosticsToolStripMenuItem_Click);
            // 
            // saasSubscriptionEstimatorToolStripMenuItem
            // 
            this.saasSubscriptionEstimatorToolStripMenuItem.Name = "saasSubscriptionEstimatorToolStripMenuItem";
            this.saasSubscriptionEstimatorToolStripMenuItem.Size = new System.Drawing.Size(276, 30);
            this.saasSubscriptionEstimatorToolStripMenuItem.Text = "Subscription estimator";
            this.saasSubscriptionEstimatorToolStripMenuItem.Click += new System.EventHandler(this.SubscriptionEstimatorToolStripMenuItem_Click);
            // 
            // saasSubscriptionsAvailableToolStripMenuItem
            // 
            this.saasSubscriptionsAvailableToolStripMenuItem.Name = "saasSubscriptionsAvailableToolStripMenuItem";
            this.saasSubscriptionsAvailableToolStripMenuItem.Size = new System.Drawing.Size(276, 30);
            this.saasSubscriptionsAvailableToolStripMenuItem.Text = "Subscriptions available";
            this.saasSubscriptionsAvailableToolStripMenuItem.Click += new System.EventHandler(this.SubscriptionsAvailableToolStripMenuItem_Click);
            // 
            // saasProjectSeetingsToolStripMenuItem
            // 
            this.saasProjectSeetingsToolStripMenuItem.Name = "saasProjectSeetingsToolStripMenuItem";
            this.saasProjectSeetingsToolStripMenuItem.Size = new System.Drawing.Size(276, 30);
            this.saasProjectSeetingsToolStripMenuItem.Text = "Project seetings";
            this.saasProjectSeetingsToolStripMenuItem.Click += new System.EventHandler(this.ProjectUsersToolStripMenuItem_Click);
            // 
            // saasProjectUsersToolStripMenuItem
            // 
            this.saasProjectUsersToolStripMenuItem.Name = "saasProjectUsersToolStripMenuItem";
            this.saasProjectUsersToolStripMenuItem.Size = new System.Drawing.Size(276, 30);
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
            this.saasLcsInstanceLinksToolStripMenuItem1.Size = new System.Drawing.Size(272, 30);
            this.saasLcsInstanceLinksToolStripMenuItem1.Text = "LCS instance links";
            // 
            // saasInstanceDetailsToolStripMenuItem
            // 
            this.saasInstanceDetailsToolStripMenuItem.Name = "saasInstanceDetailsToolStripMenuItem";
            this.saasInstanceDetailsToolStripMenuItem.Size = new System.Drawing.Size(321, 30);
            this.saasInstanceDetailsToolStripMenuItem.Text = "Instance details";
            this.saasInstanceDetailsToolStripMenuItem.Click += new System.EventHandler(this.InstanceDetailsToolStripMenuItem_Click);
            // 
            // saasEnvironmentMonitoringToolStripMenuItem
            // 
            this.saasEnvironmentMonitoringToolStripMenuItem.Name = "saasEnvironmentMonitoringToolStripMenuItem";
            this.saasEnvironmentMonitoringToolStripMenuItem.Size = new System.Drawing.Size(321, 30);
            this.saasEnvironmentMonitoringToolStripMenuItem.Text = "Environment monitoring";
            this.saasEnvironmentMonitoringToolStripMenuItem.Click += new System.EventHandler(this.EnvironmentMonitoringToolStripMenuItem_Click);
            // 
            // saasDetailedVersionInformationToolStripMenuItem
            // 
            this.saasDetailedVersionInformationToolStripMenuItem.Name = "saasDetailedVersionInformationToolStripMenuItem";
            this.saasDetailedVersionInformationToolStripMenuItem.Size = new System.Drawing.Size(321, 30);
            this.saasDetailedVersionInformationToolStripMenuItem.Text = "Detailed version information";
            this.saasDetailedVersionInformationToolStripMenuItem.Click += new System.EventHandler(this.DetailedVersionInformationToolStripMenuItem_Click);
            // 
            // saasEnvironmentChangeHistoryToolStripMenuItem
            // 
            this.saasEnvironmentChangeHistoryToolStripMenuItem.Name = "saasEnvironmentChangeHistoryToolStripMenuItem";
            this.saasEnvironmentChangeHistoryToolStripMenuItem.Size = new System.Drawing.Size(321, 30);
            this.saasEnvironmentChangeHistoryToolStripMenuItem.Text = "Environment change history";
            this.saasEnvironmentChangeHistoryToolStripMenuItem.Click += new System.EventHandler(this.EnvironmentChangeHistoryToolStripMenuItem_Click);
            // 
            // saasDataPackagesHistoryToolStripMenuItem
            // 
            this.saasDataPackagesHistoryToolStripMenuItem.Name = "saasDataPackagesHistoryToolStripMenuItem";
            this.saasDataPackagesHistoryToolStripMenuItem.Size = new System.Drawing.Size(321, 30);
            this.saasDataPackagesHistoryToolStripMenuItem.Text = "Data packages history";
            this.saasDataPackagesHistoryToolStripMenuItem.Click += new System.EventHandler(this.DataPackagesHistoryToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectDescriptionLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 823);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 14, 0);
            this.statusStrip.Size = new System.Drawing.Size(1478, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // projectDescriptionLabel
            // 
            this.projectDescriptionLabel.Name = "projectDescriptionLabel";
            this.projectDescriptionLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.Icon = Properties.Resources.favicon_white;
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
            this.Icon = Properties.Resources.favicon_blue;
            this.MainMenuStrip = this.mainMenuStrip;
            this.MinimumSize = new System.Drawing.Size(600, 360);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2LCS - Lifecycle Services companion app";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn saasInstanceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn saasEnvironmentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn saasDisplayName;
        private System.Windows.Forms.DataGridViewTextBoxColumn saasTopologyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn saasTopologyType;
        private System.Windows.Forms.DataGridViewTextBoxColumn saasTopologyVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn saasCurrentPlatformVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn saasCurrentPlatformReleaseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn saasCurrentApplicationReleaseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn saasBuildInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn saasDeploymentStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn saasDeploymentAction;
        private System.Windows.Forms.DataGridViewTextBoxColumn saasDeployedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn saasDeployedOn;
        private System.Windows.Forms.ToolStripMenuItem changeProjectMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel projectDescriptionLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn cheInstanceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cheEnvironmentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cheDisplayName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cheTopologyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cheTopologyType;
        private System.Windows.Forms.DataGridViewTextBoxColumn cheTopologyVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cheCurrentPlatformVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cheCurrentPlatformReleaseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cheCurrentApplicationReleaseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cheBuildInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cheDeploymentStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn cheDeploymentAction;
        private System.Windows.Forms.DataGridViewTextBoxColumn cheDeployedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn cheDeployedOn;
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
        private System.Windows.Forms.ToolStripMenuItem openRDPConnectionToolStripMenuItem;
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
    }
}

