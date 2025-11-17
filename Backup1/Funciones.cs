// Decompiled with JetBrains decompiler
// Type: File_Downloader.Funciones
// Assembly: ZeroLauncher, Version=2.0.9.0, Culture=neutral, PublicKeyToken=null
// MVID: 3A2BC2C6-6C50-4584-B700-5D7713B95215
// Assembly location: C:\Mu Konoha 2.0\Launcher.exe

using File_Downloader.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace File_Downloader
{

[StandardModule]
internal sealed class Funciones
{
    public static void addConsole(
      string Texto,
      byte Rojo,
      byte Verde,
      byte Azul,
      bool Bold,
      bool Italic,
      bool Enter = false)
    {
        RichTextBox richTextBox1 = MyProject.Forms.Form1.RichTextBox1;
        if (Strings.Len(richTextBox1.Text) > 700)
            richTextBox1.Text = "";
        richTextBox1.SelectionStart = Strings.Len(richTextBox1.Text);
        richTextBox1.SelectionLength = 0;
        richTextBox1.SelectionColor = Color.FromArgb((int)Rojo, (int)Verde, (int)Azul);
        richTextBox1.SelectedText = Conversions.ToString(Interaction.IIf(Enter, (object)Texto, (object)(Texto + "\r\n")));
        richTextBox1.Refresh();
        richTextBox1.SelectionStart = MyProject.Forms.Form1.RichTextBox1.TextLength;
        richTextBox1.ScrollToCaret();
    }

    public static object LoadImgAOH(string ImagenFile)
    {
        FileStream fileStream = new FileStream(ImagenFile, FileMode.Open, FileAccess.Read);
        Image image = Image.FromStream((Stream)fileStream);
        fileStream.Close();
        return (object)image;
    }
}
}
