using System.IO;
using Android.Content;
using MyTunes.NetStandard;

namespace MyTunes
{
	public class StreamLoader : IStreamLoader
	{
	    private readonly Context _context;

	    public StreamLoader(Context context)
	    {
	        this._context = context;
	    }
	    public Stream GetStreamForFilename(string filename)
	    {
	        return _context.Assets.Open(filename);
	    }
	}
}