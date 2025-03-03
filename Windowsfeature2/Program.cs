using System;
using System.Management.Automation;

class Program
{
    public static void Main(string[] args)
    {
        // 创建 PowerShell 会话
        using (PowerShell PowerShellInstance = PowerShell.Create())
        {
            // 查询安装的功能
            PowerShellInstance.AddScript("Get-WindowsFeature");
            var results = PowerShellInstance.Invoke();

            foreach (var result in results)
            {
                Console.WriteLine(result.ToString());
            }

            // 启用某个功能，例如启用 "IIS-Web-Server" 功能
            PowerShellInstance.Commands.Clear();
            PowerShellInstance.AddScript("Install-WindowsFeature -Name IIS-Web-Server");
            var installResults = PowerShellInstance.Invoke();

            Console.WriteLine("功能安装结果:");
            foreach (var installResult in installResults)
            {
                Console.WriteLine(installResult.ToString());
            }
        }
    }
}
