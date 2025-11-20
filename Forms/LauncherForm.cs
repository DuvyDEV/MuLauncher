using File_Downloader.My;
using Launcherlib;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace File_Downloader
{
    public partial class LauncherForm : Form
    {
        private const int WmNcHitTest = 0x84;
        private const int HtClient = 1;
        private const int HtCaption = 2;

        private string versionFilePath;
        private int currentVersion;
        private int versionInProgress;
        private int latestVersion;
        private UpdateProgressForm updateForm;

        public LauncherForm()
        {
            InitializeComponent();
            updateForm = new UpdateProgressForm();

            Icon executableIcon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            if (executableIcon != null)
            {
                Icon = executableIcon;
            }
        }

        internal RichTextBox ConsoleRichTextBox => consoleRichTextBox;
        internal Timer UpdateRetryTimer => updateCheckTimer;
        internal Timer UpdateCloseTimer => closeUpdateTimer;
        internal PictureBox StartButtonControl => startButton;

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

        private void LauncherForm_Load(object sender, EventArgs e)
        {
            bannerTimer.Interval = 3000;
            bannerTimer.Enabled = true;

            if (Directory.Exists(LauncherConfiguration.TempDirectory))
            {
                foreach (string file in MyProject.Computer.FileSystem.GetFiles(LauncherConfiguration.TempDirectory))
                {
                    MyProject.Computer.FileSystem.DeleteFile(file);
                }
            }

            LauncherConfiguration.LoadFromDisk();
            LanguageResources.LoadLanguage();
            InitializeLauncherAssets();

            string decryptedConfigPath = Path.Combine(LauncherConfiguration.TempDirectory, "ConfigDec.ini");
            if (File.Exists(decryptedConfigPath))
            {
                MyProject.Computer.FileSystem.DeleteFile(decryptedConfigPath);
            }

            ConsoleLogger.AddEntry(LanguageResources.lng01, byte.MaxValue, byte.MaxValue, byte.MaxValue, false, false);

            versionFilePath = Path.Combine(LauncherConfiguration.TempDirectory, "VEREXE.txt");
            versionFileWorker.RunWorkerAsync();
        }

        private void LauncherForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (LauncherConfiguration.IsUpdated != 1)
            {
            string updatesFolder = PathHelper.Combine(Application.StartupPath, LauncherConfiguration.LauncherDataFolder, "updates");
                if (Directory.Exists(updatesFolder))
                {
                    foreach (string updateFile in Directory.GetFiles(updatesFolder, "*.zip"))
                    {
                        File.Delete(updateFile);
                    }
                }
            }

            ProjectData.EndApp();
        }

        private void InitializeLauncherAssets()
        {
            serverNameLabel.Text = LauncherConfiguration.ServerName;
            newsBrowser.ScriptErrorsSuppressed = true;
            if (!string.IsNullOrEmpty(LauncherConfiguration.NewsUrl))
            {
                try
                {
                    newsBrowser.Navigate(LauncherConfiguration.NewsUrl);
                }
                catch
                {
                    // ignore navigation errors; the browser control will remain hidden until the user toggles it.
                }
            }

            consoleRichTextBox.BackColor = !string.IsNullOrEmpty(LauncherConfiguration.ConsoleBackground)
                ? ColorTranslator.FromHtml(LauncherConfiguration.ConsoleBackground)
                : Color.Black;

            string graphicsPath = PathHelper.Combine(Application.StartupPath, LauncherConfiguration.LauncherDataFolder, "GRAFICOS");
            string tempPath = LauncherConfiguration.TempDirectory;
            Directory.CreateDirectory(tempPath);

            File.Copy(Path.Combine(graphicsPath, "main.png"), Path.Combine(tempPath, "main.png"), true);
            File.Copy(Path.Combine(graphicsPath, "opcionbg.bmp"), Path.Combine(tempPath, "opcionbg.bmp"), true);
            File.Copy(Path.Combine(graphicsPath, "registerbg.bmp"), Path.Combine(tempPath, "registerbg.bmp"), true);

            BackgroundImage = new Bitmap(Path.Combine(tempPath, "main.png"));
            bannerPictureBox.Image = ConsoleLogger.LoadImage(PathHelper.Combine(graphicsPath, "banners", "banner1.bmp"));
            minimizeButton.Image = ConsoleLogger.LoadImage(Path.Combine(graphicsPath, "min1.png"));
            closeButton.Image = ConsoleLogger.LoadImage(Path.Combine(graphicsPath, "exit1.png"));
            settingsButton.Image = ConsoleLogger.LoadImage(Path.Combine(graphicsPath, "opciones0.bmp"));
            startButton.Image = ConsoleLogger.LoadImage(Path.Combine(graphicsPath, "start0.bmp"));
            startButton.Enabled = false;

            object currentWindowMode = MyProject.Computer.Registry.GetValue("HKEY_CURRENT_USER\\Software\\Webzen\\Mu\\Config", "WindowMode", 0);
            windowModeCheckBox.Checked = Conversions.ToBoolean(currentWindowMode);
        }

        private void VersionFileWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(LauncherConfiguration.UpdateUrl + "VEREXE.txt");
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream responseStream = response.GetResponseStream())
                using (FileStream fileStream = new FileStream(versionFilePath, FileMode.Create))
                {
                    byte[] buffer = new byte[4096];
                    int bytesRead;
                    while (responseStream != null && (bytesRead = responseStream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        if (versionFileWorker.CancellationPending)
                        {
                            e.Cancel = true;
                            break;
                        }

                        fileStream.Write(buffer, 0, bytesRead);
                    }
                }

                Invoke(new MethodInvoker(() => HandleVersionDownloadCompleted(false)));
            }
            catch
            {
                Invoke(new MethodInvoker(() => HandleVersionDownloadCompleted(true)));
            }
        }

        private void HandleVersionDownloadCompleted(bool cancelled)
        {
            if (cancelled)
            {
                ConsoleLogger.AddEntry(LanguageResources.lng02, byte.MaxValue, 0, 0, false, false);
                MessageBox.Show($"{LanguageResources.lng03}\r{LanguageResources.lng04}", LanguageResources.lng05, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            ConsoleLogger.AddEntry(LanguageResources.lng06, 27, 82, 127, false, false);
            string updateFile = PathHelper.Combine(Application.StartupPath, LauncherConfiguration.LauncherDataFolder, "Update.ini");
            currentVersion = Conversions.ToInteger(MyProject.Computer.FileSystem.ReadAllText(updateFile));
            versionInProgress = currentVersion + 1;
            latestVersion = Conversions.ToInteger(MyProject.Computer.FileSystem.ReadAllText(versionFilePath));

            if (currentVersion < latestVersion)
            {
                ShowUpdateDialog();
            }
            else
            {
                ConsoleLogger.AddEntry(LanguageResources.lng07, 27, 82, 127, false, false);
                startButton.Enabled = true;
                startButton.Image = ConsoleLogger.LoadImage(PathHelper.Combine(Application.StartupPath, LauncherConfiguration.LauncherDataFolder, "GRAFICOS", "start1.bmp"));
            }
        }

        private void ShowUpdateDialog()
        {
            updatePanel.Controls.Clear();
            if (updateForm != null)
            {
                updateForm.Dispose();
            }

            updateForm = new UpdateProgressForm
            {
                TopLevel = false,
                BackColor = !string.IsNullOrEmpty(LauncherConfiguration.UpdateBackground)
                    ? ColorTranslator.FromHtml(LauncherConfiguration.UpdateBackground)
                    : Color.Black
            };

            updatePanel.Controls.Add(updateForm);
            updateForm.Show();
        }

        private void UpdateCheckTimer_Tick(object sender, EventArgs e)
        {
            ShowUpdateDialog();
            updateCheckTimer.Enabled = false;
        }

        private void CloseUpdateTimer_Tick(object sender, EventArgs e)
        {
            if (updateForm != null)
            {
                updateForm.Close();
                updateForm.Dispose();
                updateForm = null;
                updatePanel.Controls.Clear();
            }

            closeUpdateTimer.Enabled = false;
        }

        private void WindowModeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            int value = windowModeCheckBox.Checked ? 1 : 0;
            MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\Software\\Webzen\\Mu\\Config", "WindowMode", value);
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            MyProject.Forms.SettingsForm.Show();
        }

        private void SettingsButton_MouseHover(object sender, EventArgs e)
        {
            settingsButton.Cursor = Cursors.Hand;
            settingsButton.Image = ConsoleLogger.LoadImage(PathHelper.Combine(Application.StartupPath, LauncherConfiguration.LauncherDataFolder, "GRAFICOS", "opciones1.bmp"));
        }

        private void SettingsButton_MouseLeave(object sender, EventArgs e)
        {
            settingsButton.Image = ConsoleLogger.LoadImage(PathHelper.Combine(Application.StartupPath, LauncherConfiguration.LauncherDataFolder, "GRAFICOS", "opciones0.bmp"));
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void MinimizeButton_MouseHover(object sender, EventArgs e)
        {
            minimizeButton.Cursor = Cursors.Hand;
            minimizeButton.Image = ConsoleLogger.LoadImage(PathHelper.Combine(Application.StartupPath, LauncherConfiguration.LauncherDataFolder, "GRAFICOS", "min2.png"));
        }

        private void MinimizeButton_MouseLeave(object sender, EventArgs e)
        {
            minimizeButton.Image = ConsoleLogger.LoadImage(PathHelper.Combine(Application.StartupPath, LauncherConfiguration.LauncherDataFolder, "GRAFICOS", "min1.png"));
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CloseButton_MouseHover(object sender, EventArgs e)
        {
            closeButton.Cursor = Cursors.Hand;
            closeButton.Image = ConsoleLogger.LoadImage(PathHelper.Combine(Application.StartupPath, LauncherConfiguration.LauncherDataFolder, "GRAFICOS", "exit2.png"));
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.Image = ConsoleLogger.LoadImage(PathHelper.Combine(Application.StartupPath, LauncherConfiguration.LauncherDataFolder, "GRAFICOS", "exit1.png"));
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            Process.Start(Path.Combine(Application.StartupPath, LauncherConfiguration.ClientExecutableName));
            Hide();
            exitTimer.Interval = 8000;
            exitTimer.Enabled = true;
        }

        private void StartButton_MouseHover(object sender, EventArgs e)
        {
            startButton.Cursor = Cursors.Hand;
            startButton.Image = ConsoleLogger.LoadImage(PathHelper.Combine(Application.StartupPath, LauncherConfiguration.LauncherDataFolder, "GRAFICOS", "start2.bmp"));
        }

        private void StartButton_MouseLeave(object sender, EventArgs e)
        {
            startButton.Image = ConsoleLogger.LoadImage(PathHelper.Combine(Application.StartupPath, LauncherConfiguration.LauncherDataFolder, "GRAFICOS", "start1.bmp"));
        }

        private void ExitTimer_Tick(object sender, EventArgs e)
        {
            exitTimer.Enabled = false;
            Close();
        }

        private void NewsLabel_Click(object sender, EventArgs e)
        {
            newsBrowser.Visible = !newsBrowser.Visible;
        }

        private void BannerTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                MainEmuF.MainMuEmu();
            }
            catch
            {
                // ignore errors from external library
            }

            bannerTimer.Enabled = false;
        }

        private void WebsiteLinkLabel_Click(object sender, EventArgs e)
        {
            string target = !string.IsNullOrEmpty(LauncherConfiguration.WebsiteUrl)
                ? LauncherConfiguration.WebsiteUrl
                : "http://gamesbit.net/";
            Process.Start(target);
        }
    }
}
