using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace File_Downloader
{
    partial class UpdateProgressForm
    {
        private IContainer components = null;
        private Label progressPercentLabel;
        private BackgroundWorker patchDownloadWorker;
        private ProgressBar progressBar;
        private Label statusLabel;
        private Panel progressPanel;
        private Label generalStatusLabel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.progressPercentLabel = new System.Windows.Forms.Label();
            this.patchDownloadWorker = new System.ComponentModel.BackgroundWorker();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.statusLabel = new System.Windows.Forms.Label();
            this.progressPanel = new System.Windows.Forms.Panel();
            this.generalStatusLabel = new System.Windows.Forms.Label();
            this.progressPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressPercentLabel
            // 
            this.progressPercentLabel.AutoSize = true;
            this.progressPercentLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressPercentLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.progressPercentLabel.Location = new System.Drawing.Point(210, 7);
            this.progressPercentLabel.Name = "progressPercentLabel";
            this.progressPercentLabel.Size = new System.Drawing.Size(26, 15);
            this.progressPercentLabel.TabIndex = 0;
            this.progressPercentLabel.Text = "0 %";
            // 
            // patchDownloadWorker
            // 
            this.patchDownloadWorker.WorkerSupportsCancellation = true;
            this.patchDownloadWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.PatchDownloadWorker_DoWork);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(5, 11);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(200, 5);
            this.progressBar.TabIndex = 4;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.BackColor = System.Drawing.Color.Transparent;
            this.statusLabel.Location = new System.Drawing.Point(15, 68);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(34, 15);
            this.statusLabel.TabIndex = 5;
            this.statusLabel.Text = "stats";
            this.statusLabel.Visible = false;
            // 
            // progressPanel
            // 
            this.progressPanel.BackColor = System.Drawing.Color.Transparent;
            this.progressPanel.Controls.Add(this.progressBar);
            this.progressPanel.Controls.Add(this.progressPercentLabel);
            this.progressPanel.Location = new System.Drawing.Point(1, 18);
            this.progressPanel.Name = "progressPanel";
            this.progressPanel.Size = new System.Drawing.Size(334, 38);
            this.progressPanel.TabIndex = 7;
            // 
            // generalStatusLabel
            // 
            this.generalStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.generalStatusLabel.AutoSize = true;
            this.generalStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.generalStatusLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generalStatusLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.generalStatusLabel.Location = new System.Drawing.Point(3, 9);
            this.generalStatusLabel.Name = "generalStatusLabel";
            this.generalStatusLabel.Size = new System.Drawing.Size(45, 15);
            this.generalStatusLabel.TabIndex = 10;
            this.generalStatusLabel.Text = "Label";
            // 
            // UpdateProgressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(357, 88);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.generalStatusLabel);
            this.Controls.Add(this.progressPanel);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "UpdateProgressForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "File Downloader";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Red;
            this.Load += new System.EventHandler(this.UpdateProgressForm_Load);
            this.progressPanel.ResumeLayout(false);
            this.progressPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
