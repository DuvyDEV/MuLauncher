using System.IO;

namespace File_Downloader
{
    internal static class PathHelper
    {
        public static string Combine(params string[] segments)
        {
            if (segments == null || segments.Length == 0)
                return string.Empty;

            string path = segments[0] ?? string.Empty;
            for (int i = 1; i < segments.Length; i++)
            {
                string next = segments[i] ?? string.Empty;
                path = Path.Combine(path, next);
            }

            return path;
        }
    }
}
