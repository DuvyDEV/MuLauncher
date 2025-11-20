using Microsoft.VisualBasic.CompilerServices;
using System.Windows.Forms;

namespace File_Downloader
{
    [StandardModule]
    internal static class LanguageResources
    {
        public static string SelectedLanguage;
        public static string lng01;
        public static string lng02;
        public static string lng03;
        public static string lng04;
        public static string lng05;
        public static string lng06;
        public static string lng07;
        public static string lng08;
        public static string lng09;
        public static string lng10;
        public static string lng11;
        public static string lng12;
        public static string lng13;
        public static string lng14;
        public static string lng15;
        public static string lng16;
        public static string lng17;
        public static string lng18;
        public static string lng19;
        public static string lng20;
        public static string lng21;
        public static string lng22;
        public static string lng23;
        public static string lng24;
        public static string lng25;
        public static string lng26;
        public static string lng27;
        public static string lng28;
        public static string lng29;
        public static string lng30;
        public static string lng31;
        public static string lng32;
        public static string lng33;
        public static string lng34;

        public static void LoadLanguage()
        {
            string languageFile = $"{Application.StartupPath}\\{LauncherConfiguration.LauncherDataFolder}\\ConfigLng.ini";
            SelectedLanguage = LauncherConfiguration.LanguageKey;

            lng01 = IniFileHelper.ReadValue(languageFile, SelectedLanguage, "lng01", "?");
            lng02 = IniFileHelper.ReadValue(languageFile, SelectedLanguage, "lng02", "?");
            lng03 = IniFileHelper.ReadValue(languageFile, SelectedLanguage, "lng03", "?");
            lng04 = IniFileHelper.ReadValue(languageFile, SelectedLanguage, "lng04", "?");
            lng05 = IniFileHelper.ReadValue(languageFile, SelectedLanguage, "lng05", "?");
            lng06 = IniFileHelper.ReadValue(languageFile, SelectedLanguage, "lng06", "?");
            lng07 = IniFileHelper.ReadValue(languageFile, SelectedLanguage, "lng07", "?");
            lng08 = IniFileHelper.ReadValue(languageFile, SelectedLanguage, "lng08", "?");
            lng09 = IniFileHelper.ReadValue(languageFile, SelectedLanguage, "lng09", "?");
            lng10 = IniFileHelper.ReadValue(languageFile, SelectedLanguage, "lng10", "?");
            lng11 = IniFileHelper.ReadValue(languageFile, SelectedLanguage, "lng11", "?");
            lng12 = IniFileHelper.ReadValue(languageFile, SelectedLanguage, "lng12", "?");
            lng13 = IniFileHelper.ReadValue(languageFile, SelectedLanguage, "lng13", "?");
            lng14 = IniFileHelper.ReadValue(languageFile, SelectedLanguage, "lng14", "?");
            lng15 = IniFileHelper.ReadValue(languageFile, SelectedLanguage, "lng15", "?");
            lng16 = IniFileHelper.ReadValue(languageFile, SelectedLanguage, "lng16", "?");
            lng17 = IniFileHelper.ReadValue(languageFile, SelectedLanguage, "lng17", "?");
            lng18 = IniFileHelper.ReadValue(languageFile, SelectedLanguage, "lng18", "?");
            lng19 = IniFileHelper.ReadValue(languageFile, SelectedLanguage, "lng19", "?");
            lng20 = IniFileHelper.ReadValue(languageFile, SelectedLanguage, "lng20", "?");
            lng21 = IniFileHelper.ReadValue(languageFile, SelectedLanguage, "lng21", "?");
            lng22 = IniFileHelper.ReadValue(languageFile, SelectedLanguage, "lng22", "?");
            lng23 = IniFileHelper.ReadValue(languageFile, SelectedLanguage, "lng23", "?");
            lng24 = IniFileHelper.ReadValue(languageFile, SelectedLanguage, "lng24", "?");
            lng25 = IniFileHelper.ReadValue(languageFile, SelectedLanguage, "lng25", "?");
            lng26 = IniFileHelper.ReadValue(languageFile, SelectedLanguage, "lng26", "?");
            lng27 = IniFileHelper.ReadValue(languageFile, SelectedLanguage, "lng27", "?");
            lng28 = IniFileHelper.ReadValue(languageFile, SelectedLanguage, "lng28", "?");
            lng29 = IniFileHelper.ReadValue(languageFile, SelectedLanguage, "lng29", "?");
            lng30 = IniFileHelper.ReadValue(languageFile, SelectedLanguage, "lng30", "?");
            lng31 = IniFileHelper.ReadValue(languageFile, SelectedLanguage, "lng31", "?");
            lng32 = IniFileHelper.ReadValue(languageFile, SelectedLanguage, "lng32", "?");
            lng33 = IniFileHelper.ReadValue(languageFile, SelectedLanguage, "lng33", "?");
            lng34 = IniFileHelper.ReadValue(languageFile, SelectedLanguage, "lng34", "?");
        }
    }
}
