﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;



public class Log
{
    public static log4net.ILog GetLogger([CallerFilePath]string filename = "")
    {
        return log4net.LogManager.GetLogger(filename);
    }
}

