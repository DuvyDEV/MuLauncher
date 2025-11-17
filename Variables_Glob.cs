using File_Downloader.My;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.IO;
using System.Windows.Forms;


namespace File_Downloader
{

    [StandardModule]
    internal sealed class Variables_Glob
    {
        public static string Def_Carpeta_Launcher = "Data\\Launcher";
        public static string timeStamp = DateTime.Now.ToString("yyyyMMddhhmmss");
        public static string Def_Carpeta_Temp = $"{Path.GetTempPath()}\\ZeroLauncherFree_{Variables_Glob.timeStamp}";
        public static string Config_Nombre_Server;
        public static string Config_Update_url;
        public static string Config_Noticia_url;
        public static string Config_Fondo_console;
        public static string Config_Fondo_update;
        public static string Config_Nombre_Main;
        public static string Config_Lenguaje_UPD;
        public static string Config_Url_Web;
        public static string Config_Url_Facebook;
        public static string Config_Url_Foro;
        public static int True_Actualizado;
        public static int Contador_Banner;
        public static int Contador_Banner_Max;
        public static int Contador_Banner_Time;

        public static void Load_Config_INI()
        {
            MyProject.Computer.FileSystem.CreateDirectory(Variables_Glob.Def_Carpeta_Temp);
            Encriptador.DecryptFile($"{Application.StartupPath}\\{Variables_Glob.Def_Carpeta_Launcher}\\Config.ini", Variables_Glob.Def_Carpeta_Temp + "\\ConfigDec.ini", "AOHFREEL");
            Variables_Glob.Config_Nombre_Server = Manejo_INI.LeerINI(Variables_Glob.Def_Carpeta_Temp + "\\ConfigDec.ini", "UPDATE", "Nombre_Server", "?");
            Variables_Glob.Config_Update_url = Manejo_INI.LeerINI(Variables_Glob.Def_Carpeta_Temp + "\\ConfigDec.ini", "UPDATE", "Update_url", "?");
            Variables_Glob.Config_Noticia_url = Manejo_INI.LeerINI(Variables_Glob.Def_Carpeta_Temp + "\\ConfigDec.ini", "UPDATE", "Noticia_url", "?");
            Variables_Glob.Config_Fondo_console = Manejo_INI.LeerINI(Variables_Glob.Def_Carpeta_Temp + "\\ConfigDec.ini", "UPDATE", "Fondo_console", "?");
            Variables_Glob.Config_Fondo_update = Manejo_INI.LeerINI(Variables_Glob.Def_Carpeta_Temp + "\\ConfigDec.ini", "UPDATE", "Fondo_update", "?");
            Variables_Glob.Config_Nombre_Main = Manejo_INI.LeerINI(Variables_Glob.Def_Carpeta_Temp + "\\ConfigDec.ini", "UPDATE", "Nombre_Main", "?");
            Variables_Glob.Config_Lenguaje_UPD = Manejo_INI.LeerINI(Variables_Glob.Def_Carpeta_Temp + "\\ConfigDec.ini", "UPDATE", "Lenguaje_UPD", "?");
            Variables_Glob.Config_Url_Web = Manejo_INI.LeerINI(Variables_Glob.Def_Carpeta_Temp + "\\ConfigDec.ini", "BOTONES", "Url_Web", "?");
            Variables_Glob.Config_Url_Facebook = Manejo_INI.LeerINI(Variables_Glob.Def_Carpeta_Temp + "\\ConfigDec.ini", "BOTONES", "Url_Facebook", "?");
            Variables_Glob.Config_Url_Foro = Manejo_INI.LeerINI(Variables_Glob.Def_Carpeta_Temp + "\\ConfigDec.ini", "BOTONES", "Url_Foro", "?");
            Variables_Glob.Contador_Banner = 1;
            Variables_Glob.Contador_Banner_Max = 4;
            Variables_Glob.Contador_Banner_Time = 6000;
        }
    }
}
