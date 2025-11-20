using File_Downloader.My;
using Ionic.Zip;
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
    public partial class UpdateProgressForm : Form
    {
        private string destinationFile;
        private int currentVersion;
        private int versionInProgress;
        private int latestVersion;
        private string downloadUrl;

        public UpdateProgressForm()
        {
            InitializeComponent();

            Icon executableIcon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            if (executableIcon != null)
            {
                Icon = executableIcon;
            }
        }

        private void UpdateProgressForm_Load(object sender, EventArgs e)
        {
            LauncherForm launcher = MyProject.Forms.LauncherForm;
            launcher.StartButtonControl.Enabled = false;
            launcher.StartButtonControl.Image = ConsoleLogger.LoadImage(PathHelper.Combine(Application.StartupPath, LauncherConfiguration.LauncherDataFolder, "GRAFICOS", "start0.bmp"));

            currentVersion = Conversions.ToInteger(MyProject.Computer.FileSystem.ReadAllText(PathHelper.Combine(Application.StartupPath, LauncherConfiguration.LauncherDataFolder, "Update.ini")));
            versionInProgress = currentVersion + 1;
            latestVersion = Conversions.ToInteger(MyProject.Computer.FileSystem.ReadAllText(Path.Combine(LauncherConfiguration.TempDirectory, "VEREXE.txt")));

            if (currentVersion < latestVersion)
            {
                downloadUrl = string.Format("{0}update/Parche{1}.zip", LauncherConfiguration.UpdateUrl, versionInProgress);
                if (!IsNullOrWhiteSpace(downloadUrl) && downloadUrl.StartsWith("http://", StringComparison.OrdinalIgnoreCase))
                {
                    string updatesFolder = PathHelper.Combine(Application.StartupPath, LauncherConfiguration.LauncherDataFolder, "updates");
                    Directory.CreateDirectory(updatesFolder);
                    destinationFile = Path.Combine(updatesFolder, string.Format("Parche{0}.zip", versionInProgress));
                    patchDownloadWorker.RunWorkerAsync();
                    ConsoleLogger.AddEntry(string.Format("{0} {1} ...", LanguageResources.lng12, versionInProgress), byte.MaxValue, byte.MaxValue, byte.MaxValue, false, false);
                }
                else
                {
                    MessageBox.Show(LanguageResources.lng13, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Close();
                }
            }
            else
            {
                ConsoleLogger.AddEntry(LanguageResources.lng07, 27, 82, 127, false, false);
                launcher.StartButtonControl.Enabled = true;
                launcher.StartButtonControl.Image = ConsoleLogger.LoadImage(PathHelper.Combine(Application.StartupPath, LauncherConfiguration.LauncherDataFolder, "GRAFICOS", "start1.bmp"));
                Close();
            }
        }

        private void PatchDownloadWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            HttpWebResponse response;
            try
            {
                response = (HttpWebResponse)((HttpWebRequest)WebRequest.Create(downloadUrl)).GetResponse();
            }
            catch
            {
                Invoke(new MethodInvoker(() => HandleDownloadCompleted(true)));
                return;
            }

            long contentLength = response.ContentLength;
            UpdateProgress(contentLength, 0, 0, 0);
            using (Stream responseStream = response.GetResponseStream())
            using (FileStream fileStream = new FileStream(destinationFile, FileMode.Create))
            {
                Stopwatch stopwatch = new Stopwatch();
                int bytesDownloaded = 0;
                int sampleCounter = 0;
                double speed = -1.0;
                byte[] buffer = new byte[4096];

                while (!patchDownloadWorker.CancellationPending)
                {
                    stopwatch.Start();
                    int read = responseStream != null ? responseStream.Read(buffer, 0, buffer.Length) : 0;
                    if (read <= 0)
                    {
                        break;
                    }

                    fileStream.Write(buffer, 0, read);
                    bytesDownloaded += read;
                    sampleCounter++;

                    short percent = (short)Math.Round((double)bytesDownloaded / contentLength * 100.0);
                    if (sampleCounter >= 5)
                    {
                        speed = 20480.0 / (stopwatch.ElapsedMilliseconds / 1000.0);
                        stopwatch.Reset();
                        sampleCounter = 0;
                    }

                    Invoke(new MethodInvoker(() => UpdateProgress(contentLength, bytesDownloaded, percent, speed)));
                }
            }

            response.Close();

            if (patchDownloadWorker.CancellationPending)
            {
                if (File.Exists(destinationFile))
                {
                    File.Delete(destinationFile);
                }

                Invoke(new MethodInvoker(() => HandleDownloadCompleted(true)));
            }
            else
            {
                Invoke(new MethodInvoker(() => HandleDownloadCompleted(false)));
            }
        }

        private void UpdateProgress(long length, int position, int percent, double speed)
        {
            if (length <= 0)
            {
                return;
            }

            progressBar.Value = Math.Max(0, Math.Min(percent, 100));
            progressPercentLabel.Text = string.Format("{0} %", progressBar.Value);

            double downloadedMb = Math.Round(position / 1024.0 / 1024.0, 2);
            double totalMb = Math.Round(length / 1024.0 / 1024.0, 2);
            string speedText = speed > 0.0 ? string.Format("{0} KB/s", Math.Round(speed / 1024.0, 2)) : LanguageResources.lng11;
            generalStatusLabel.Text = string.Format("[ {0} MB of {1} MB ] - {2}", downloadedMb, totalMb, speedText);
        }

        private void HandleDownloadCompleted(bool cancelled)
        {
            LauncherForm launcher = MyProject.Forms.LauncherForm;

            if (cancelled)
            {
                ConsoleLogger.AddEntry(string.Format("{0} {1} ...", LanguageResources.lng08, versionInProgress), byte.MaxValue, 100, 200, false, false);
                Close();
                return;
            }

            ConsoleLogger.AddEntry(string.Format("{0} {1} ...", LanguageResources.lng09, versionInProgress), 27, 82, 127, false, false);
            LauncherConfiguration.IsUpdated = 1;
            using (ZipFile archive = ZipFile.Read(destinationFile))
            {
                archive.ExtractAll(Application.StartupPath, ExtractExistingFileAction.OverwriteSilently);
            }
            string updateIniPath = PathHelper.Combine(Application.StartupPath, LauncherConfiguration.LauncherDataFolder, "Update.ini");
            MyProject.Computer.FileSystem.DeleteFile(updateIniPath);
            MyProject.Computer.FileSystem.WriteAllText(updateIniPath, versionInProgress.ToString(), true);

            if (versionInProgress == latestVersion)
            {
                launcher.UpdateRetryTimer.Enabled = false;
                launcher.UpdateCloseTimer.Enabled = true;
                launcher.UpdateCloseTimer.Interval = 100;
                launcher.StartButtonControl.Enabled = true;
                launcher.StartButtonControl.Image = ConsoleLogger.LoadImage(PathHelper.Combine(Application.StartupPath, LauncherConfiguration.LauncherDataFolder, "GRAFICOS", "start1.bmp"));
                ConsoleLogger.AddEntry(LanguageResources.lng10, 27, 82, 127, false, false);
                Close();
            }
            else if (versionInProgress < latestVersion)
            {
                launcher.UpdateCloseTimer.Enabled = true;
                launcher.UpdateCloseTimer.Interval = 100;
                launcher.UpdateRetryTimer.Enabled = true;
                launcher.UpdateRetryTimer.Interval = 2000;
                Close();
            }
            else
            {
                launcher.UpdateRetryTimer.Enabled = false;
                launcher.UpdateCloseTimer.Enabled = true;
                launcher.UpdateCloseTimer.Interval = 100;
                launcher.StartButtonControl.Enabled = true;
                launcher.StartButtonControl.Image = ConsoleLogger.LoadImage(PathHelper.Combine(Application.StartupPath, LauncherConfiguration.LauncherDataFolder, "GRAFICOS", "start1.bmp"));
                ConsoleLogger.AddEntry(LanguageResources.lng10, 27, 82, 127, false, false);
                Close();
            }
        }

        private static bool IsNullOrWhiteSpace(string value)
        {
            return value == null || value.Trim().Length == 0;
        }
    }
}
