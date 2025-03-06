using System;
using System.Windows.Automation;
using System.Diagnostics;
using System.Threading;

class Program
{
    static void Main()
    {
        // 更新文件路径为安装文件的实际位置
        string msiPath = @"C:\360安全浏览器下载\GitExtensions-x64-5.2.1.18061-0d74cfdc3.msi";

        // 启动安装程序
        Process.Start("msiexec.exe", $"/i \"{msiPath}\"");

        // 等待安装程序启动完成
        Thread.Sleep(8000); // 等待 5 秒，确保安装程序窗口出现

        // 查找安装程序窗口，假设窗口标题是 "Git Extensions Setup"
        AutomationElement root = AutomationElement.RootElement;
        AutomationElement installerWindow = root.FindFirst(TreeScope.Children, new PropertyCondition(AutomationElement.NameProperty, "Git Extensions 5.2.1.18061 Setup"));

        if (installerWindow != null)
        {
            // 查找 "Next" 按钮
            AutomationElement nextButton = installerWindow.FindFirst(TreeScope.Descendants, new PropertyCondition(AutomationElement.NameProperty, "Next"));
            if (nextButton != null)
            {
                // 执行点击操作
                InvokePattern clickPattern = nextButton.GetCurrentPattern(InvokePattern.Pattern) as InvokePattern;
                clickPattern.Invoke();
                Console.WriteLine("点击了 'Next' 按钮");
            }
            else
            {
                Console.WriteLine("'Next' 按钮未找到");
            }
        }
        else
        {
            Console.WriteLine("安装程序窗口未找到");
        }
    }
}
