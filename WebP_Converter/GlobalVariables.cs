using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebP_Converter
{
    class GlobalVariables
    {
        static public string workingDir;

        static public string sourcePath;
        static public string destPath;
        static public bool deleteOrigial = false;
        static public bool useSourceAsDest = false;

        static public string encoderOpt;
        static public string encoderPath;
    }
}
