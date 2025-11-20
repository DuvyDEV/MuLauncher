using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace File_Downloader
{
    partial class SettingsForm
    {
        private IContainer components = null;
        private PictureBox saveButton;
        private PictureBox cancelButton;
        private TextBox accountIdTextBox;
        private ComboBox resolutionComboBox;
        private ComboBox languageComboBox;
        private Label accountLabel;
        private Label resolutionLabel;
        private Label languageLabel;
        private CheckBox musicCheckBox;
        private CheckBox effectsCheckBox;
        private CheckBox fpsLimitCheckBox;
        private CheckBox clockCheckBox;
        private CheckBox pingCheckBox;
        private CheckBox discordCheckBox;

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
            this.saveButton = new System.Windows.Forms.PictureBox();
            this.cancelButton = new System.Windows.Forms.PictureBox();
            this.accountIdTextBox = new System.Windows.Forms.TextBox();
            this.resolutionComboBox = new System.Windows.Forms.ComboBox();
            this.languageComboBox = new System.Windows.Forms.ComboBox();
            this.accountLabel = new System.Windows.Forms.Label();
            this.resolutionLabel = new System.Windows.Forms.Label();
            this.languageLabel = new System.Windows.Forms.Label();
            this.musicCheckBox = new System.Windows.Forms.CheckBox();
            this.effectsCheckBox = new System.Windows.Forms.CheckBox();
            this.fpsLimitCheckBox = new System.Windows.Forms.CheckBox();
            this.clockCheckBox = new System.Windows.Forms.CheckBox();
            this.pingCheckBox = new System.Windows.Forms.CheckBox();
            this.discordCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.saveButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelButton)).BeginInit();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(30, 390);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(150, 35);
            this.saveButton.TabIndex = 0;
            this.saveButton.TabStop = false;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            this.saveButton.MouseLeave += new System.EventHandler(this.SaveButton_MouseLeave);
            this.saveButton.MouseHover += new System.EventHandler(this.SaveButton_MouseHover);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(180, 390);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(150, 35);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.TabStop = false;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            this.cancelButton.MouseLeave += new System.EventHandler(this.CancelButton_MouseLeave);
            this.cancelButton.MouseHover += new System.EventHandler(this.CancelButton_MouseHover);
            // 
            // accountIdTextBox
            // 
            this.accountIdTextBox.Location = new System.Drawing.Point(30, 83);
            this.accountIdTextBox.Name = "accountIdTextBox";
            this.accountIdTextBox.Size = new System.Drawing.Size(300, 20);
            this.accountIdTextBox.TabIndex = 2;
            // 
            // resolutionComboBox
            // 
            this.resolutionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resolutionComboBox.FormattingEnabled = true;
            this.resolutionComboBox.Items.AddRange(new object[] {
            "640 x 480",
            "800 x 600",
            "1024 x 768",
            "1280 x 1024",
            "1366 x 768",
            "1600 x 1280"});
            this.resolutionComboBox.Location = new System.Drawing.Point(30, 144);
            this.resolutionComboBox.Name = "resolutionComboBox";
            this.resolutionComboBox.Size = new System.Drawing.Size(300, 21);
            this.resolutionComboBox.TabIndex = 3;
            // 
            // languageComboBox
            // 
            this.languageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.languageComboBox.FormattingEnabled = true;
            this.languageComboBox.Items.AddRange(new object[] {
            "English",
            "Español",
            "Portugues"});
            this.languageComboBox.Location = new System.Drawing.Point(30, 211);
            this.languageComboBox.Name = "languageComboBox";
            this.languageComboBox.Size = new System.Drawing.Size(300, 21);
            this.languageComboBox.TabIndex = 4;
            // 
            // accountLabel
            // 
            this.accountLabel.AutoSize = true;
            this.accountLabel.BackColor = System.Drawing.Color.Transparent;
            this.accountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.accountLabel.Location = new System.Drawing.Point(30, 62);
            this.accountLabel.Name = "accountLabel";
            this.accountLabel.Size = new System.Drawing.Size(82, 18);
            this.accountLabel.TabIndex = 5;
            this.accountLabel.Text = "Default ID";
            // 
            // resolutionLabel
            // 
            this.resolutionLabel.AutoSize = true;
            this.resolutionLabel.BackColor = System.Drawing.Color.Transparent;
            this.resolutionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resolutionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.resolutionLabel.Location = new System.Drawing.Point(30, 123);
            this.resolutionLabel.Name = "resolutionLabel";
            this.resolutionLabel.Size = new System.Drawing.Size(95, 18);
            this.resolutionLabel.TabIndex = 6;
            this.resolutionLabel.Text = "Resolution";
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.BackColor = System.Drawing.Color.Transparent;
            this.languageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.languageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.languageLabel.Location = new System.Drawing.Point(30, 190);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(83, 18);
            this.languageLabel.TabIndex = 7;
            this.languageLabel.Text = "Language";
            // 
            // musicCheckBox
            // 
            this.musicCheckBox.AutoSize = true;
            this.musicCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.musicCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musicCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.musicCheckBox.Location = new System.Drawing.Point(33, 241);
            this.musicCheckBox.Name = "musicCheckBox";
            this.musicCheckBox.Size = new System.Drawing.Size(68, 20);
            this.musicCheckBox.TabIndex = 8;
            this.musicCheckBox.Text = "Music";
            this.musicCheckBox.UseVisualStyleBackColor = false;
            // 
            // effectsCheckBox
            // 
            this.effectsCheckBox.AutoSize = true;
            this.effectsCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.effectsCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.effectsCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.effectsCheckBox.Location = new System.Drawing.Point(191, 241);
            this.effectsCheckBox.Name = "effectsCheckBox";
            this.effectsCheckBox.Size = new System.Drawing.Size(77, 20);
            this.effectsCheckBox.TabIndex = 9;
            this.effectsCheckBox.Text = "Effects";
            this.effectsCheckBox.UseVisualStyleBackColor = false;
            // 
            // fpsLimitCheckBox
            // 
            this.fpsLimitCheckBox.AutoSize = true;
            this.fpsLimitCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.fpsLimitCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fpsLimitCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.fpsLimitCheckBox.Location = new System.Drawing.Point(33, 275);
            this.fpsLimitCheckBox.Name = "fpsLimitCheckBox";
            this.fpsLimitCheckBox.Size = new System.Drawing.Size(126, 20);
            this.fpsLimitCheckBox.TabIndex = 10;
            this.fpsLimitCheckBox.Text = "Enable 60 FPS";
            this.fpsLimitCheckBox.UseVisualStyleBackColor = false;
            // 
            // clockCheckBox
            // 
            this.clockCheckBox.AutoSize = true;
            this.clockCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.clockCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.clockCheckBox.Location = new System.Drawing.Point(191, 275);
            this.clockCheckBox.Name = "clockCheckBox";
            this.clockCheckBox.Size = new System.Drawing.Size(100, 20);
            this.clockCheckBox.TabIndex = 11;
            this.clockCheckBox.Text = "Show clock";
            this.clockCheckBox.UseVisualStyleBackColor = false;
            // 
            // pingCheckBox
            // 
            this.pingCheckBox.AutoSize = true;
            this.pingCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.pingCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pingCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pingCheckBox.Location = new System.Drawing.Point(33, 311);
            this.pingCheckBox.Name = "pingCheckBox";
            this.pingCheckBox.Size = new System.Drawing.Size(171, 20);
            this.pingCheckBox.TabIndex = 12;
            this.pingCheckBox.Text = "Latency indicator";
            this.pingCheckBox.UseVisualStyleBackColor = false;
            // 
            // discordCheckBox
            // 
            this.discordCheckBox.AutoSize = true;
            this.discordCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.discordCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discordCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.discordCheckBox.Location = new System.Drawing.Point(33, 352);
            this.discordCheckBox.Name = "discordCheckBox";
            this.discordCheckBox.Size = new System.Drawing.Size(110, 20);
            this.discordCheckBox.TabIndex = 13;
            this.discordCheckBox.Text = "Discord RPC";
            this.discordCheckBox.UseVisualStyleBackColor = false;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 440);
            this.Controls.Add(this.discordCheckBox);
            this.Controls.Add(this.pingCheckBox);
            this.Controls.Add(this.clockCheckBox);
            this.Controls.Add(this.fpsLimitCheckBox);
            this.Controls.Add(this.effectsCheckBox);
            this.Controls.Add(this.musicCheckBox);
            this.Controls.Add(this.languageLabel);
            this.Controls.Add(this.resolutionLabel);
            this.Controls.Add(this.accountLabel);
            this.Controls.Add(this.languageComboBox);
            this.Controls.Add(this.resolutionComboBox);
            this.Controls.Add(this.accountIdTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.saveButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
