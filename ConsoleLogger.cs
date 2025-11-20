using File_Downloader.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace File_Downloader
{
    [StandardModule]
    internal static class ConsoleLogger
    {
        public static void AddEntry(string message, byte red, byte green, byte blue, bool bold, bool italic, bool appendNewLine = true)
        {
            RichTextBox console = MyProject.Forms.LauncherForm.ConsoleRichTextBox;
            if (console == null)
                return;

            if (Strings.Len(console.Text) > 700)
            {
                console.Text = string.Empty;
            }

            console.SelectionStart = console.TextLength;
            console.SelectionLength = 0;
            console.SelectionColor = Color.FromArgb(red, green, blue);
            console.SelectedText = appendNewLine ? message + "\r\n" : message;
            console.Refresh();
            console.SelectionStart = console.TextLength;
            console.ScrollToCaret();
        }

        public static Image LoadImage(string filePath)
        {
            using (FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                Image image = Image.FromStream(stream);
                return (Image)image.Clone();
            }
        }
    }
}
