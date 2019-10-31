namespace LCS.Forms
{
    partial class UpcomingUpdates
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
            this.upcomingUpdatesDataGridView = new System.Windows.Forms.DataGridView();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UtcStartDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DownTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnvironmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusEnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventNameEnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CalendarId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnvironmentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsModified = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkflowInstanceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.upcomingUpdatesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // upcomingUpdatesDataGridView
            // 
            this.upcomingUpdatesDataGridView.AllowUserToAddRows = false;
            this.upcomingUpdatesDataGridView.AllowUserToDeleteRows = false;
            this.upcomingUpdatesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.upcomingUpdatesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.upcomingUpdatesDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.upcomingUpdatesDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.upcomingUpdatesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.upcomingUpdatesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Status,
            this.UtcStartDateTime,
            this.Month,
            this.Date,
            this.Time,
            this.DownTime,
            this.EnvironmentName,
            this.EventName,
            this.StatusEnum,
            this.EventNameEnum,
            this.CalendarId,
            this.EnvironmentId,
            this.IsModified,
            this.WorkflowInstanceId});
            this.upcomingUpdatesDataGridView.Location = new System.Drawing.Point(15, 16);
            this.upcomingUpdatesDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.upcomingUpdatesDataGridView.Name = "upcomingUpdatesDataGridView";
            this.upcomingUpdatesDataGridView.ReadOnly = true;
            this.upcomingUpdatesDataGridView.RowHeadersWidth = 30;
            this.upcomingUpdatesDataGridView.RowTemplate.Height = 28;
            this.upcomingUpdatesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.upcomingUpdatesDataGridView.Size = new System.Drawing.Size(1459, 456);
            this.upcomingUpdatesDataGridView.TabIndex = 0;
            this.upcomingUpdatesDataGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.UpcomingUpdatesDataGridView_ColumnHeaderMouseClick);
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 9;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // UtcStartDateTime
            // 
            this.UtcStartDateTime.DataPropertyName = "UtcStartDateTime";
            this.UtcStartDateTime.HeaderText = "UTC Start DateTime";
            this.UtcStartDateTime.MinimumWidth = 9;
            this.UtcStartDateTime.Name = "UtcStartDateTime";
            this.UtcStartDateTime.ReadOnly = true;
            // 
            // Month
            // 
            this.Month.DataPropertyName = "Month";
            this.Month.HeaderText = "Month";
            this.Month.MinimumWidth = 9;
            this.Month.Name = "Month";
            this.Month.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 9;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Time
            // 
            this.Time.DataPropertyName = "Time";
            this.Time.HeaderText = "Time (local)";
            this.Time.MinimumWidth = 9;
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // DownTime
            // 
            this.DownTime.DataPropertyName = "DownTime";
            this.DownTime.HeaderText = "Estimated downtime (minutes)";
            this.DownTime.MinimumWidth = 9;
            this.DownTime.Name = "DownTime";
            this.DownTime.ReadOnly = true;
            // 
            // EnvironmentName
            // 
            this.EnvironmentName.DataPropertyName = "EnvironmentName";
            this.EnvironmentName.HeaderText = "Environment name";
            this.EnvironmentName.MinimumWidth = 9;
            this.EnvironmentName.Name = "EnvironmentName";
            this.EnvironmentName.ReadOnly = true;
            // 
            // EventName
            // 
            this.EventName.DataPropertyName = "EventName";
            this.EventName.HeaderText = "Event";
            this.EventName.MinimumWidth = 9;
            this.EventName.Name = "EventName";
            this.EventName.ReadOnly = true;
            // 
            // StatusEnum
            // 
            this.StatusEnum.DataPropertyName = "StatusEnum";
            this.StatusEnum.HeaderText = "Status enum";
            this.StatusEnum.MinimumWidth = 9;
            this.StatusEnum.Name = "StatusEnum";
            this.StatusEnum.ReadOnly = true;
            this.StatusEnum.Visible = false;
            // 
            // EventNameEnum
            // 
            this.EventNameEnum.DataPropertyName = "EventNameEnum";
            this.EventNameEnum.HeaderText = "Event name enum";
            this.EventNameEnum.MinimumWidth = 9;
            this.EventNameEnum.Name = "EventNameEnum";
            this.EventNameEnum.ReadOnly = true;
            this.EventNameEnum.Visible = false;
            // 
            // CalendarId
            // 
            this.CalendarId.DataPropertyName = "CalendarId";
            this.CalendarId.HeaderText = "Calendar Id";
            this.CalendarId.MinimumWidth = 9;
            this.CalendarId.Name = "CalendarId";
            this.CalendarId.ReadOnly = true;
            this.CalendarId.Visible = false;
            // 
            // EnvironmentId
            // 
            this.EnvironmentId.DataPropertyName = "EnvironmentId";
            this.EnvironmentId.HeaderText = "Environment Id";
            this.EnvironmentId.MinimumWidth = 9;
            this.EnvironmentId.Name = "EnvironmentId";
            this.EnvironmentId.ReadOnly = true;
            this.EnvironmentId.Visible = false;
            // 
            // IsModified
            // 
            this.IsModified.DataPropertyName = "IsModified";
            this.IsModified.HeaderText = "IsModified";
            this.IsModified.MinimumWidth = 9;
            this.IsModified.Name = "IsModified";
            this.IsModified.ReadOnly = true;
            this.IsModified.Visible = false;
            // 
            // WorkflowInstanceId
            // 
            this.WorkflowInstanceId.DataPropertyName = "WorkflowInstanceId";
            this.WorkflowInstanceId.HeaderText = "WorkflowInstanceId";
            this.WorkflowInstanceId.MinimumWidth = 9;
            this.WorkflowInstanceId.Name = "WorkflowInstanceId";
            this.WorkflowInstanceId.ReadOnly = true;
            this.WorkflowInstanceId.Visible = false;
            // 
            // UpcomingUpdates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1489, 533);
            this.Controls.Add(this.upcomingUpdatesDataGridView);
            this.Icon = global::LCS.Properties.Resources.favicon_blue;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(948, 467);
            this.Name = "UpcomingUpdates";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.UpcomingUpdates_Load);
            ((System.ComponentModel.ISupportInitialize)(this.upcomingUpdatesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView upcomingUpdatesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn UtcStartDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn DownTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnvironmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusEnum;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventNameEnum;
        private System.Windows.Forms.DataGridViewTextBoxColumn CalendarId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnvironmentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsModified;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkflowInstanceId;
    }
}