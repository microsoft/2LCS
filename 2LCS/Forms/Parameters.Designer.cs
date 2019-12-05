namespace LCS.Forms
{
    partial class Parameters
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Parameters));
            this.AutoRefreshCheckBox = new System.Windows.Forms.CheckBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AutoRefreshCheckBox
            // 
            this.AutoRefreshCheckBox.AutoSize = true;
            this.AutoRefreshCheckBox.Location = new System.Drawing.Point(12, 12);
            this.AutoRefreshCheckBox.Name = "AutoRefreshCheckBox";
            this.AutoRefreshCheckBox.Size = new System.Drawing.Size(109, 21);
            this.AutoRefreshCheckBox.TabIndex = 0;
            this.AutoRefreshCheckBox.Text = "Auto-refresh";
            this.AutoRefreshCheckBox.UseVisualStyleBackColor = true;
            this.AutoRefreshCheckBox.CheckedChanged += new System.EventHandler(this.AutoRefreshCheckBox_CheckedChanged);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.closeButton.Location = new System.Drawing.Point(28, 171);
            this.closeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(162, 26);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // Parameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 206);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.AutoRefreshCheckBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Parameters";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Parameters";
            this.Load += new System.EventHandler(this.Parameters_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox AutoRefreshCheckBox;
        private System.Windows.Forms.Button closeButton;
    }
}