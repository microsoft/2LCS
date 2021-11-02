
namespace LCS.Forms
{
    partial class RDPConnect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RDPConnect));
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.rdpConnectTitle = new System.Windows.Forms.Label();
            this.StateLabel = new System.Windows.Forms.Label();
            this.stateValueLabel = new System.Windows.Forms.Label();
            this.vmLabel = new System.Windows.Forms.Label();
            this.vmNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 150);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(299, 23);
            this.progressBar.TabIndex = 0;
            // 
            // rdpConnectTitle
            // 
            this.rdpConnectTitle.AutoSize = true;
            this.rdpConnectTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdpConnectTitle.Location = new System.Drawing.Point(9, 9);
            this.rdpConnectTitle.Name = "rdpConnectTitle";
            this.rdpConnectTitle.Size = new System.Drawing.Size(135, 17);
            this.rdpConnectTitle.TabIndex = 1;
            this.rdpConnectTitle.Text = "Connecting to VM";
            // 
            // StateLabel
            // 
            this.StateLabel.AutoSize = true;
            this.StateLabel.Location = new System.Drawing.Point(15, 89);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(38, 13);
            this.StateLabel.TabIndex = 2;
            this.StateLabel.Text = "State: ";
            // 
            // stateValueLabel
            // 
            this.stateValueLabel.AutoSize = true;
            this.stateValueLabel.Location = new System.Drawing.Point(71, 89);
            this.stateValueLabel.Name = "stateValueLabel";
            this.stateValueLabel.Size = new System.Drawing.Size(61, 13);
            this.stateValueLabel.TabIndex = 3;
            this.stateValueLabel.Text = "Connecting";
            // 
            // vmLabel
            // 
            this.vmLabel.AutoSize = true;
            this.vmLabel.Location = new System.Drawing.Point(15, 49);
            this.vmLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vmLabel.Name = "vmLabel";
            this.vmLabel.Size = new System.Drawing.Size(57, 13);
            this.vmLabel.TabIndex = 4;
            this.vmLabel.Text = "Machine:  ";
            // 
            // vmNameLabel
            // 
            this.vmNameLabel.AutoSize = true;
            this.vmNameLabel.Location = new System.Drawing.Point(71, 49);
            this.vmNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vmNameLabel.Name = "vmNameLabel";
            this.vmNameLabel.Size = new System.Drawing.Size(0, 13);
            this.vmNameLabel.TabIndex = 5;
            // 
            // RDPConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 186);
            this.Controls.Add(this.vmNameLabel);
            this.Controls.Add(this.vmLabel);
            this.Controls.Add(this.stateValueLabel);
            this.Controls.Add(this.StateLabel);
            this.Controls.Add(this.rdpConnectTitle);
            this.Controls.Add(this.progressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RDPConnect";
            this.Text = "2LCS - Lifecycle Services companion app";
            this.Shown += new System.EventHandler(this.RDPConnect_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label rdpConnectTitle;
        private System.Windows.Forms.Label StateLabel;
        private System.Windows.Forms.Label stateValueLabel;
        private System.Windows.Forms.Label vmLabel;
        private System.Windows.Forms.Label vmNameLabel;
    }
}