using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace WebP_Converter
{
    class Utility
    {
        public static void runWebpEncoder(string sourceFilePath, string destFilePath, out string output)
        {
            Process webpEncoderProc = new Process
            {
                StartInfo =
                {
                    FileName = GlobalVariables.encoderPath,
                    Arguments = $"-o \"{destFilePath}\" {GlobalVariables.encoderOpt} -- \"{sourceFilePath}\"",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    WindowStyle = ProcessWindowStyle.Hidden,
                    CreateNoWindow = true
                }
            };
            //not diplay a windows
            webpEncoderProc.Start();
            output = webpEncoderProc.StandardError.ReadToEnd(); //The output result
            webpEncoderProc.WaitForExit();
            if (webpEncoderProc.ExitCode != 0)
            {
                throw new ArgumentException(sourceFilePath);
            }
        }
    }
}
