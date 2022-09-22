using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _testEXE
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //System.Diagnostics.Process.Start(@"C:\Users\Public\Desktop\腾讯QQ");
            //System.Diagnostics.Process.Start(@"C:\Users\caya\Desktop\RumaData.exe");
            //RunProcess(@"C:\Users\caya\Desktop\RumaData.exe");
            System.Diagnostics.Process.Start("http://www.baidu.com");
        }

        static int RunProcess(string fileName)
        {
            int returnValue = -1;
            try
            {
                Process myProcess = new Process();
                ProcessStartInfo myProcessStartInfo = new ProcessStartInfo(fileName);
                myProcessStartInfo.CreateNoWindow = true;
                myProcessStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                myProcess.StartInfo = myProcessStartInfo;
                myProcess.Start();

                while (!myProcess.HasExited)
                {
                    myProcess.WaitForExit();
                }

                returnValue = myProcess.ExitCode;
                myProcess.Dispose();
                myProcess.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString()); 
            }
            return returnValue;
        }
    }
}
