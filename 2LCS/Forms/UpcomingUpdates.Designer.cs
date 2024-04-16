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
            upcomingUpdatesDataGridView = new System.Windows.Forms.DataGridView();
            Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            UtcStartDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DownTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            EnvironmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            EventName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            StatusEnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            EventNameEnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CalendarId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            EnvironmentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            IsModified = new System.Windows.Forms.DataGridViewTextBoxColumn();
            WorkflowInstanceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ReleaseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)upcomingUpdatesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // upcomingUpdatesDataGridView
            // 
            upcomingUpdatesDataGridView.AllowUserToAddRows = false;
            upcomingUpdatesDataGridView.AllowUserToDeleteRows = false;
            upcomingUpdatesDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            upcomingUpdatesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            upcomingUpdatesDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            upcomingUpdatesDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            upcomingUpdatesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            upcomingUpdatesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Status, UtcStartDateTime, Month, Date, Time, DownTime, EnvironmentName, EventName, StatusEnum, EventNameEnum, CalendarId, EnvironmentId, IsModified, WorkflowInstanceId, ReleaseName });
            upcomingUpdatesDataGridView.Location = new System.Drawing.Point(10, 10);
            upcomingUpdatesDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            upcomingUpdatesDataGridView.Name = "upcomingUpdatesDataGridView";
            upcomingUpdatesDataGridView.ReadOnly = true;
            upcomingUpdatesDataGridView.RowHeadersWidth = 30;
            upcomingUpdatesDataGridView.RowTemplate.Height = 28;
            upcomingUpdatesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            upcomingUpdatesDataGridView.Size = new System.Drawing.Size(928, 285);
            upcomingUpdatesDataGridView.TabIndex = 0;
            upcomingUpdatesDataGridView.ColumnHeaderMouseClick += UpcomingUpdatesDataGridView_ColumnHeaderMouseClick;
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Status";
            Status.MinimumWidth = 9;
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // UtcStartDateTime
            // 
            UtcStartDateTime.DataPropertyName = "UtcStartDateTime";
            UtcStartDateTime.HeaderText = "UTC Start DateTime";
            UtcStartDateTime.MinimumWidth = 9;
            UtcStartDateTime.Name = "UtcStartDateTime";
            UtcStartDateTime.ReadOnly = true;
            // 
            // Month
            // 
            Month.DataPropertyName = "Month";
            Month.HeaderText = "Month";
            Month.MinimumWidth = 9;
            Month.Name = "Month";
            Month.ReadOnly = true;
            // 
            // Date
            // 
            Date.DataPropertyName = "Date";
            Date.HeaderText = "Date";
            Date.MinimumWidth = 9;
            Date.Name = "Date";
            Date.ReadOnly = true;
            // 
            // Time
            // 
            Time.DataPropertyName = "Time";
            Time.HeaderText = "Time (local)";
            Time.MinimumWidth = 9;
            Time.Name = "Time";
            Time.ReadOnly = true;
            // 
            // DownTime
            // 
            DownTime.DataPropertyName = "DownTime";
            DownTime.HeaderText = "Estimated downtime (minutes)";
            DownTime.MinimumWidth = 9;
            DownTime.Name = "DownTime";
            DownTime.ReadOnly = true;
            // 
            // EnvironmentName
            // 
            EnvironmentName.DataPropertyName = "EnvironmentName";
            EnvironmentName.HeaderText = "Environment name";
            EnvironmentName.MinimumWidth = 9;
            EnvironmentName.Name = "EnvironmentName";
            EnvironmentName.ReadOnly = true;
            // 
            // EventName
            // 
            EventName.DataPropertyName = "EventName";
            EventName.HeaderText = "Event";
            EventName.MinimumWidth = 9;
            EventName.Name = "EventName";
            EventName.ReadOnly = true;
            // 
            // StatusEnum
            // 
            StatusEnum.DataPropertyName = "StatusEnum";
            StatusEnum.HeaderText = "Status enum";
            StatusEnum.MinimumWidth = 9;
            StatusEnum.Name = "StatusEnum";
            StatusEnum.ReadOnly = true;
            StatusEnum.Visible = false;
            // 
            // EventNameEnum
            // 
            EventNameEnum.DataPropertyName = "EventNameEnum";
            EventNameEnum.HeaderText = "Event name enum";
            EventNameEnum.MinimumWidth = 9;
            EventNameEnum.Name = "EventNameEnum";
            EventNameEnum.ReadOnly = true;
            EventNameEnum.Visible = false;
            // 
            // CalendarId
            // 
            CalendarId.DataPropertyName = "CalendarId";
            CalendarId.HeaderText = "Calendar Id";
            CalendarId.MinimumWidth = 9;
            CalendarId.Name = "CalendarId";
            CalendarId.ReadOnly = true;
            CalendarId.Visible = false;
            // 
            // EnvironmentId
            // 
            EnvironmentId.DataPropertyName = "EnvironmentId";
            EnvironmentId.HeaderText = "Environment Id";
            EnvironmentId.MinimumWidth = 9;
            EnvironmentId.Name = "EnvironmentId";
            EnvironmentId.ReadOnly = true;
            EnvironmentId.Visible = false;
            // 
            // IsModified
            // 
            IsModified.DataPropertyName = "IsModified";
            IsModified.HeaderText = "IsModified";
            IsModified.MinimumWidth = 9;
            IsModified.Name = "IsModified";
            IsModified.ReadOnly = true;
            IsModified.Visible = false;
            // 
            // WorkflowInstanceId
            // 
            WorkflowInstanceId.DataPropertyName = "WorkflowInstanceId";
            WorkflowInstanceId.HeaderText = "WorkflowInstanceId";
            WorkflowInstanceId.MinimumWidth = 9;
            WorkflowInstanceId.Name = "WorkflowInstanceId";
            WorkflowInstanceId.ReadOnly = true;
            WorkflowInstanceId.Visible = false;
            // 
            // ReleaseName
            // 
            ReleaseName.DataPropertyName = "ReleaseName";
            ReleaseName.HeaderText = "Release Name";
            ReleaseName.Name = "ReleaseName";
            ReleaseName.ReadOnly = true;
            // 
            // UpcomingUpdates
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(948, 333);
            Controls.Add(upcomingUpdatesDataGridView);
            Icon = Properties.Resources.favicon_blue;
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(609, 307);
            Name = "UpcomingUpdates";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Load += UpcomingUpdates_Load;
            ((System.ComponentModel.ISupportInitialize)upcomingUpdatesDataGridView).EndInit();
            ResumeLayout(false);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ReleaseName;
    }
}