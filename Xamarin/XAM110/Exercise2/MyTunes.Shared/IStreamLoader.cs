﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTunes.Shared
{
    public interface IStreamLoader
    {
        System.IO.Stream GetStreamForFileName(string filename);
    }
}
