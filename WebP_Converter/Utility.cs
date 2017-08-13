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
        static public string runWebpEncoder(string sourceFilePath, string destFilePath)
        {
            Process webpEncoderProc = new Process();
            webpEncoderProc.StartInfo.FileName = GlobalVariables.encoderPath;
            webpEncoderProc.StartInfo.Arguments = "-o \"" + destFilePath + "\" " + GlobalVariables.encoderOpt + " -- \"" + sourceFilePath + "\"";
            webpEncoderProc.StartInfo.UseShellExecute = false;
            webpEncoderProc.StartInfo.RedirectStandardOutput = true;
            webpEncoderProc.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            webpEncoderProc.StartInfo.CreateNoWindow = true; //not diplay a windows
            webpEncoderProc.Start();
            string output = webpEncoderProc.StandardOutput.ReadToEnd(); //The output result
            webpEncoderProc.WaitForExit();
            if (webpEncoderProc.ExitCode!=0)
            {
                throw new System.ArgumentException(sourceFilePath);
            }
            return output;
        }
    }
}
