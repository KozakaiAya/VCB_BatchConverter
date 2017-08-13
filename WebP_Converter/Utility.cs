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
        public static string runWebpEncoder(string sourceFilePath, string destFilePath)
        {
            Process webpEncoderProc = new Process
            {
                StartInfo =
                {
                    FileName = GlobalVariables.encoderPath,
                    Arguments = $"-o \"{destFilePath}\" {GlobalVariables.encoderOpt} -- \"{sourceFilePath}\"",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    WindowStyle = ProcessWindowStyle.Hidden,
                    CreateNoWindow = true
                }
            };
            //not diplay a windows
            webpEncoderProc.Start();
            string output = webpEncoderProc.StandardOutput.ReadToEnd(); //The output result
            webpEncoderProc.WaitForExit();
            if (webpEncoderProc.ExitCode != 0)
            {
                throw new ArgumentException(sourceFilePath);
            }
            return output;
        }
    }
}
