using System.IO;

namespace MyTunes.NetStandard
{
    public interface IStreamLoader
    {
        Stream GetStreamForFilename(string filename);
    }
}