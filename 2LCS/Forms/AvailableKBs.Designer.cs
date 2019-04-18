namespace LCS.Forms
{
    partial class AvailableKBs
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
            this.availableKBsDataGridView = new System.Windows.Forms.DataGridView();
            this.KBNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BugNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Solution = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReleasedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.availableKBsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // availableKBsDataGridView
            // 
            this.availableKBsDataGridView.AllowUserToAddRows = false;
            this.availableKBsDataGridView.AllowUserToDeleteRows = false;
            this.availableKBsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.availableKBsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.availableKBsDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.availableKBsDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.availableKBsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.availableKBsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KBNumber,
            this.BugNumber,
            this.Title,
            this.Solution,
            this.ReleasedDate,
            this.Url});
            this.availableKBsDataGridView.Location = new System.Drawing.Point(12, 13);
            this.availableKBsDataGridView.Name = "availableKBsDataGridView";
            this.availableKBsDataGridView.RowTemplate.Height = 28;
            this.availableKBsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.availableKBsDataGridView.Size = new System.Drawing.Size(1194, 380);
            this.availableKBsDataGridView.TabIndex = 0;
            this.availableKBsDataGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.AvailableKBsDataGridView_ColumnHeaderMouseClick);
            // 
            // KBNumber
            // 
            this.KBNumber.DataPropertyName = "KBNumber";
            this.KBNumber.FillWeight = 10F;
            this.KBNumber.HeaderText = "KB Number";
            this.KBNumber.Name = "KBNumber";
            // 
            // BugNumber
            // 
            this.BugNumber.DataPropertyName = "BugNumber";
            this.BugNumber.FillWeight = 10F;
            this.BugNumber.HeaderText = "Bug Number";
            this.BugNumber.Name = "BugNumber";
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.FillWeight = 30F;
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            // 
            // Solution
            // 
            this.Solution.DataPropertyName = "Solution";
            this.Solution.FillWeight = 30F;
            this.Solution.HeaderText = "Solution";
            this.Solution.Name = "Solution";
            // 
            // ReleasedDate
            // 
            this.ReleasedDate.DataPropertyName = "ReleasedDate";
            this.ReleasedDate.FillWeight = 10F;
            this.ReleasedDate.HeaderText = "Released Date";
            this.ReleasedDate.Name = "ReleasedDate";
            // 
            // Url
            // 
            this.Url.DataPropertyName = "Url";
            this.Url.FillWeight = 10F;
            this.Url.HeaderText = "Link";
            this.Url.Name = "Url";
            // 
            // AvailableKBs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 444);
            this.Controls.Add(this.availableKBsDataGridView);
            this.Icon = global::LCS.Properties.Resources.favicon_blue;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(780, 400);
            this.Name = "AvailableKBs";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.AvailableKBs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.availableKBsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView availableKBsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn KBNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn BugNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Solution;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReleasedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Url;
    }
}