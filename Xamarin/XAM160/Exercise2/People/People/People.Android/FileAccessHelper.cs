using System.IO;
using Environment = System.Environment;

namespace People.Droid
{
    public class FileAccessHelper
    {
        public static string GetLocalFilePath(string filename)
        {
            string path = Environment.GetFolderPath(
                Environment.SpecialFolder.Personal);

            return Path.Combine(path, filename);
        }
    }
}