using System;
using System.Diagnostics;

class Program
{
    public static void Main(string[] args)
    {
        // 调用 DISM 启用 Windows 功能
        ProcessStartInfo processInfo = new ProcessStartInfo
        {
            FileName = "dism",
            Arguments = "/Online /Enable-Feature /FeatureName:IIS-WebServerRole /All /LimitAccess /NoRestart",
            RedirectStandardOutput = true,
            UseShellExecute = false,
            CreateNoWindow = true
        };

        Process process = new Process { StartInfo = processInfo };
        process.Start();

        // 读取 DISM 命令的输出
        string output = process.StandardOutput.ReadToEnd();
        process.WaitForExit();

        Console.WriteLine("DISM 输出:");
        Console.WriteLine(output);
    }
}
