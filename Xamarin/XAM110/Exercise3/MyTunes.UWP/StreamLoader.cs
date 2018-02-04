﻿using System;
using System.IO;
using Windows.ApplicationModel;
using MyTunes.NetStandard;

namespace MyTunes
{
    public class StreamLoader : IStreamLoader
    {
        public Stream GetStreamForFilename(string filename)
        {
            return Package.Current.InstalledLocation.GetFileAsync(filename)
                .AsTask().Result
                .OpenStreamForReadAsync().Result;
        }
    }
}
