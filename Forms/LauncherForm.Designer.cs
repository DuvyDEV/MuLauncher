using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace File_Downloader
{
    partial class LauncherForm
    {
        private IContainer components = null;
        private RichTextBox consoleRichTextBox;
        private BackgroundWorker versionFileWorker;
        private Timer updateCheckTimer;
        private Timer closeUpdateTimer;
        private Panel updatePanel;
        private WebBrowser newsBrowser;
        private CheckBox windowModeCheckBox;
        private PictureBox settingsButton;
        private PictureBox minimizeButton;
        private PictureBox closeButton;
        private Label serverNameLabel;
        private PictureBox startButton;
        private Timer exitTimer;
        private PictureBox bannerPictureBox;
        private Label newsLabel;
        private Label newsArrowLabel;
        private Timer bannerTimer;
        private Label websiteLinkLabel;

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
            this.consoleRichTextBox = new System.Windows.Forms.RichTextBox();
            this.versionFileWorker = new System.ComponentModel.BackgroundWorker();
            this.updateCheckTimer = new System.Windows.Forms.Timer(this.components);
            this.closeUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.updatePanel = new System.Windows.Forms.Panel();
            this.newsBrowser = new System.Windows.Forms.WebBrowser();
            this.windowModeCheckBox = new System.Windows.Forms.CheckBox();
            this.settingsButton = new System.Windows.Forms.PictureBox();
            this.minimizeButton = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.serverNameLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.PictureBox();
            this.exitTimer = new System.Windows.Forms.Timer(this.components);
            this.bannerPictureBox = new System.Windows.Forms.PictureBox();
            this.newsLabel = new System.Windows.Forms.Label();
            this.newsArrowLabel = new System.Windows.Forms.Label();
            this.bannerTimer = new System.Windows.Forms.Timer(this.components);
            this.websiteLinkLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.settingsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bannerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // consoleRichTextBox
            // 
            this.consoleRichTextBox.BackColor = System.Drawing.Color.Black;
            this.consoleRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.consoleRichTextBox.Location = new System.Drawing.Point(137, 449);
            this.consoleRichTextBox.Name = "consoleRichTextBox";
            this.consoleRichTextBox.ReadOnly = true;
            this.consoleRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.consoleRichTextBox.Size = new System.Drawing.Size(125, 62);
            this.consoleRichTextBox.TabIndex = 0;
            this.consoleRichTextBox.Text = string.Empty;
            // 
            // versionFileWorker
            // 
            this.versionFileWorker.WorkerSupportsCancellation = true;
            this.versionFileWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.VersionFileWorker_DoWork);
            // 
            // updateCheckTimer
            // 
            this.updateCheckTimer.Tick += new System.EventHandler(this.UpdateCheckTimer_Tick);
            // 
            // closeUpdateTimer
            // 
            this.closeUpdateTimer.Tick += new System.EventHandler(this.CloseUpdateTimer_Tick);
            // 
            // updatePanel
            // 
            this.updatePanel.BackColor = System.Drawing.Color.Transparent;
            this.updatePanel.Location = new System.Drawing.Point(496, 452);
            this.updatePanel.Name = "updatePanel";
            this.updatePanel.Size = new System.Drawing.Size(260, 50);
            this.updatePanel.TabIndex = 3;
            // 
            // newsBrowser
            // 
            this.newsBrowser.Location = new System.Drawing.Point(137, 163);
            this.newsBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.newsBrowser.Name = "newsBrowser";
            this.newsBrowser.Size = new System.Drawing.Size(337, 271);
            this.newsBrowser.TabIndex = 10;
            this.newsBrowser.Visible = false;
            // 
            // windowModeCheckBox
            // 
            this.windowModeCheckBox.AutoSize = true;
            this.windowModeCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.windowModeCheckBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.windowModeCheckBox.Location = new System.Drawing.Point(402, 486);
            this.windowModeCheckBox.Name = "windowModeCheckBox";
            this.windowModeCheckBox.Size = new System.Drawing.Size(72, 17);
            this.windowModeCheckBox.TabIndex = 12;
            this.windowModeCheckBox.Text = "WinMode";
            this.windowModeCheckBox.UseVisualStyleBackColor = false;
            this.windowModeCheckBox.CheckedChanged += new System.EventHandler(this.WindowModeCheckBox_CheckedChanged);
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.SystemColors.Control;
            this.settingsButton.Location = new System.Drawing.Point(762, 449);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(36, 51);
            this.settingsButton.TabIndex = 11;
            this.settingsButton.TabStop = false;
            this.settingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            this.settingsButton.MouseLeave += new System.EventHandler(this.SettingsButton_MouseLeave);
            this.settingsButton.MouseHover += new System.EventHandler(this.SettingsButton_MouseHover);
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.minimizeButton.Location = new System.Drawing.Point(879, 86);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(14, 14);
            this.minimizeButton.TabIndex = 14;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            this.minimizeButton.MouseLeave += new System.EventHandler(this.MinimizeButton_MouseLeave);
            this.minimizeButton.MouseHover += new System.EventHandler(this.MinimizeButton_MouseHover);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.Location = new System.Drawing.Point(898, 86);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(14, 14);
            this.closeButton.TabIndex = 13;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.closeButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            this.closeButton.MouseHover += new System.EventHandler(this.CloseButton_MouseHover);
            // 
            // serverNameLabel
            // 
            this.serverNameLabel.AutoSize = true;
            this.serverNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.serverNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverNameLabel.ForeColor = System.Drawing.Color.White;
            this.serverNameLabel.Location = new System.Drawing.Point(156, 89);
            this.serverNameLabel.Name = "serverNameLabel";
            this.serverNameLabel.Size = new System.Drawing.Size(103, 16);
            this.serverNameLabel.TabIndex = 19;
            this.serverNameLabel.Text = "KonohaLauncher";
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.SystemColors.Control;
            this.startButton.Location = new System.Drawing.Point(798, 449);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(89, 51);
            this.startButton.TabIndex = 20;
            this.startButton.TabStop = false;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            this.startButton.MouseLeave += new System.EventHandler(this.StartButton_MouseLeave);
            this.startButton.MouseHover += new System.EventHandler(this.StartButton_MouseHover);
            // 
            // exitTimer
            // 
            this.exitTimer.Tick += new System.EventHandler(this.ExitTimer_Tick);
            // 
            // bannerPictureBox
            // 
            this.bannerPictureBox.BackColor = System.Drawing.Color.Red;
            this.bannerPictureBox.Enabled = false;
            this.bannerPictureBox.Location = new System.Drawing.Point(338, 83);
            this.bannerPictureBox.Name = "bannerPictureBox";
            this.bannerPictureBox.Size = new System.Drawing.Size(581, 322);
            this.bannerPictureBox.TabIndex = 21;
            this.bannerPictureBox.TabStop = false;
            // 
            // newsLabel
            // 
            this.newsLabel.AutoSize = true;
            this.newsLabel.BackColor = System.Drawing.Color.Transparent;
            this.newsLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newsLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.newsLabel.Location = new System.Drawing.Point(160, 124);
            this.newsLabel.Name = "newsLabel";
            this.newsLabel.Size = new System.Drawing.Size(52, 20);
            this.newsLabel.TabIndex = 22;
            this.newsLabel.Text = "News";
            this.newsLabel.Click += new System.EventHandler(this.NewsLabel_Click);
            // 
            // newsArrowLabel
            // 
            this.newsArrowLabel.AutoSize = true;
            this.newsArrowLabel.BackColor = System.Drawing.Color.Transparent;
            this.newsArrowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newsArrowLabel.ForeColor = System.Drawing.Color.White;
            this.newsArrowLabel.Location = new System.Drawing.Point(144, 120);
            this.newsArrowLabel.Name = "newsArrowLabel";
            this.newsArrowLabel.Size = new System.Drawing.Size(21, 24);
            this.newsArrowLabel.TabIndex = 23;
            this.newsArrowLabel.Text = "»";
            // 
            // bannerTimer
            // 
            this.bannerTimer.Tick += new System.EventHandler(this.BannerTimer_Tick);
            // 
            // websiteLinkLabel
            // 
            this.websiteLinkLabel.AutoSize = true;
            this.websiteLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.websiteLinkLabel.ForeColor = System.Drawing.Color.White;
            this.websiteLinkLabel.Location = new System.Drawing.Point(611, 421);
            this.websiteLinkLabel.Name = "websiteLinkLabel";
            this.websiteLinkLabel.Size = new System.Drawing.Size(70, 13);
            this.websiteLinkLabel.TabIndex = 24;
            this.websiteLinkLabel.Text = "                 ";
            this.websiteLinkLabel.Click += new System.EventHandler(this.WebsiteLinkLabel_Click);
            // 
            // LauncherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(1114, 603);
            this.Controls.Add(this.websiteLinkLabel);
            this.Controls.Add(this.newsArrowLabel);
            this.Controls.Add(this.newsLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.serverNameLabel);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.windowModeCheckBox);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.newsBrowser);
            this.Controls.Add(this.updatePanel);
            this.Controls.Add(this.consoleRichTextBox);
            this.Controls.Add(this.bannerPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1114, 603);
            this.Name = "LauncherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KonohaLauncher";
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LauncherForm_FormClosing);
            this.Load += new System.EventHandler(this.LauncherForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.settingsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bannerPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
