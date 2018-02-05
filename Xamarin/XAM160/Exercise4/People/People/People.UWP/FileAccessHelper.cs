using System.IO;

namespace People.UWP
{
    public class FileAccessHelper
    {
        public static string GetLocalFilePath(string filename)
        {
            string path = global::Windows.Storage.ApplicationData.Current.LocalFolder.Path;

            return Path.Combine(path, filename);

        }
    }
}
