using File_Downloader.My;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace File_Downloader
{
    public partial class SettingsForm : Form
    {
        private const int WmNcHitTest = 0x84;
        private const int HtClient = 1;
        private const int HtCaption = 2;

        public SettingsForm()
        {
            InitializeComponent();

            Icon executableIcon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            if (executableIcon != null)
            {
                Icon = executableIcon;
            }
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WmNcHitTest)
            {
                base.WndProc(ref m);
                if (m.Result == (IntPtr)HtClient)
                {
                    m.Result = (IntPtr)HtCaption;
                }

                return;
            }

            base.WndProc(ref m);
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            BackgroundImage = new Bitmap(Path.Combine(LauncherConfiguration.TempDirectory, "opcionbg.bmp"));
            string graphicsPath = PathHelper.Combine(Application.StartupPath, LauncherConfiguration.LauncherDataFolder, "GRAFICOS");
            saveButton.Image = ConsoleLogger.LoadImage(Path.Combine(graphicsPath, "guardar0.bmp"));
            cancelButton.Image = ConsoleLogger.LoadImage(Path.Combine(graphicsPath, "cancelar0.bmp"));

            LoadRegistrySettings();
            ApplyLanguageTexts();
        }

        private void ApplyLanguageTexts()
        {
            accountLabel.Text = LanguageResources.lng26;
            resolutionLabel.Text = LanguageResources.lng27;
            languageLabel.Text = LanguageResources.lng28;
            musicCheckBox.Text = LanguageResources.lng29;
            effectsCheckBox.Text = LanguageResources.lng30;
            fpsLimitCheckBox.Text = LanguageResources.lng31;
            clockCheckBox.Text = LanguageResources.lng32;
            pingCheckBox.Text = LanguageResources.lng33;
            discordCheckBox.Text = LanguageResources.lng34;
        }

        private void LoadRegistrySettings()
        {
            musicCheckBox.Checked = Conversions.ToBoolean(MyProject.Computer.Registry.GetValue("HKEY_CURRENT_USER\\Software\\Webzen\\Mu\\Config", "MusicOnOff", null));
            effectsCheckBox.Checked = Conversions.ToBoolean(MyProject.Computer.Registry.GetValue("HKEY_CURRENT_USER\\Software\\Webzen\\Mu\\Config", "SoundOnOff", null));

            object resolutionValue = MyProject.Computer.Registry.GetValue("HKEY_CURRENT_USER\\Software\\Webzen\\Mu\\Config", "Resolution", null);
            int resolutionIndex = resolutionValue != null ? Conversions.ToInteger(resolutionValue) : 0;
            resolutionComboBox.SelectedIndex = Math.Min(Math.Max(resolutionIndex, 0), resolutionComboBox.Items.Count - 1);

            accountIdTextBox.Text = Conversions.ToString(MyProject.Computer.Registry.GetValue("HKEY_CURRENT_USER\\Software\\Webzen\\Mu\\Config", "ID", null));

            string lang = Conversions.ToString(MyProject.Computer.Registry.GetValue("HKEY_CURRENT_USER\\Software\\Webzen\\Mu\\Config", "LangSelection", null));
            switch (lang)
            {
                case "Eng":
                    languageComboBox.SelectedIndex = 0;
                    break;
                case "Spn":
                    languageComboBox.SelectedIndex = 1;
                    break;
                case "Por":
                    languageComboBox.SelectedIndex = 2;
                    break;
                default:
                    languageComboBox.SelectedIndex = 0;
                    break;
            }

            LoadSettingsIni();
        }

        private void SaveRegistrySettings()
        {
            MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\Software\\Webzen\\Mu\\Config", "ID", accountIdTextBox.Text);
            MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\Software\\Webzen\\Mu\\Config", "MusicOnOff", musicCheckBox.Checked ? 1 : 0);
            MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\Software\\Webzen\\Mu\\Config", "SoundOnOff", effectsCheckBox.Checked ? 1 : 0);

            int resolutionIndex = resolutionComboBox.SelectedIndex;
            MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\Software\\Webzen\\Mu\\Config", "Resolution", resolutionIndex);
            int resolutionMode = resolutionIndex <= 3 ? 0 : 1;
            MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\Software\\Webzen\\Mu\\Config", "ResolutionA", resolutionMode);

            switch (languageComboBox.SelectedIndex)
            {
                case 0:
                    MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\Software\\Webzen\\Mu\\Config", "LangSelection", "Eng");
                    break;
                case 1:
                    MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\Software\\Webzen\\Mu\\Config", "LangSelection", "Spn");
                    break;
                case 2:
                    MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\Software\\Webzen\\Mu\\Config", "LangSelection", "Por");
                    break;
            }

            SaveSettingsIni();
        }

        private void LoadSettingsIni()
        {
            string settingsPath = GetSettingsIniPath();
            if (!File.Exists(settingsPath))
            {
                return;
            }

            string disableFps = IniFileHelper.ReadValue(settingsPath, "Graphics", "DisableNewFPS", "1").Trim();
            fpsLimitCheckBox.Checked = disableFps == "0";

            string serverTime = IniFileHelper.ReadValue(settingsPath, "Other", "ServerTime", "0").Trim();
            clockCheckBox.Checked = serverTime == "1";

            string disablePing = IniFileHelper.ReadValue(settingsPath, "Other", "DisablePing", "1").Trim();
            pingCheckBox.Checked = disablePing == "0";

            string discordPresence = IniFileHelper.ReadValue(settingsPath, "Discord", "DiscordShowPresence", "0").Trim();
            discordCheckBox.Checked = discordPresence == "1";
        }

        private void SaveSettingsIni()
        {
            string settingsPath = GetSettingsIniPath();
            IniFileHelper.WriteValue(settingsPath, "Graphics", "DisableNewFPS", fpsLimitCheckBox.Checked ? "0" : "1");
            IniFileHelper.WriteValue(settingsPath, "Other", "ServerTime", clockCheckBox.Checked ? "1" : "0");
            IniFileHelper.WriteValue(settingsPath, "Other", "DisablePing", pingCheckBox.Checked ? "0" : "1");
            IniFileHelper.WriteValue(settingsPath, "Discord", "DiscordShowPresence", discordCheckBox.Checked ? "1" : "0");
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveRegistrySettings();
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveButton_MouseHover(object sender, EventArgs e)
        {
            saveButton.Cursor = Cursors.Hand;
            saveButton.Image = ConsoleLogger.LoadImage(PathHelper.Combine(Application.StartupPath, LauncherConfiguration.LauncherDataFolder, "GRAFICOS", "guardar1.bmp"));
        }

        private void SaveButton_MouseLeave(object sender, EventArgs e)
        {
            saveButton.Image = ConsoleLogger.LoadImage(PathHelper.Combine(Application.StartupPath, LauncherConfiguration.LauncherDataFolder, "GRAFICOS", "guardar0.bmp"));
        }

        private void CancelButton_MouseHover(object sender, EventArgs e)
        {
            cancelButton.Cursor = Cursors.Hand;
            cancelButton.Image = ConsoleLogger.LoadImage(PathHelper.Combine(Application.StartupPath, LauncherConfiguration.LauncherDataFolder, "GRAFICOS", "cancelar1.bmp"));
        }

        private void CancelButton_MouseLeave(object sender, EventArgs e)
        {
            cancelButton.Image = ConsoleLogger.LoadImage(PathHelper.Combine(Application.StartupPath, LauncherConfiguration.LauncherDataFolder, "GRAFICOS", "cancelar0.bmp"));
        }

        private string GetSettingsIniPath()
        {
            return Path.Combine(Application.StartupPath, "Settings.ini");
        }
    }
}
