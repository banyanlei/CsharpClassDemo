using System;
using System.Management;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enumerating Plug and Play devices...\n");

        string query = "SELECT * FROM Win32_PnPEntity";
        using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(query))
        {
            foreach (ManagementObject device in searcher.Get())
            {
                string name = device["Name"]?.ToString() ?? "(No Name)";
                string deviceId = device["DeviceID"]?.ToString() ?? "(No ID)";
                string status = device["Status"]?.ToString() ?? "(No Status)";
                string errorCode = device["ConfigManagerErrorCode"]?.ToString() ?? "N/A";

                // 只显示出错设备
                if (errorCode != "0")
                {
                    Console.WriteLine("⚠️ 设备异常:");
                    Console.WriteLine($"  Name     : {name}");
                    Console.WriteLine($"  DeviceID : {deviceId}");
                    Console.WriteLine($"  Status   : {status}");
                    Console.WriteLine($"  ErrorCode: {errorCode}");
                    Console.WriteLine($"  解释     : {GetErrorExplanation(errorCode)}");
                    Console.WriteLine(new string('-', 60));
                }
            }
        }

        Console.WriteLine("检查完成。按任意键退出。");
        Console.ReadKey();
    }

    //static string GetErrorExplanation(string code)
    //{
    //    return code switch
    //    {
    //        "10" => "Code 10 - 无法启动此设备，通常是驱动不兼容或签名问题",
    //        "28" => "Code 28 - 驱动程序未安装",
    //        "31" => "Code 31 - 驱动程序无法加载",
    //        "39" => "Code 39 - 驱动程序损坏或不完整",
    //        "52" => "Code 52 - Windows 无法验证驱动程序的数字签名（驱动签名强制问题）",
    //        _ => "其他错误（可查询微软 Code 表）"
    //    };
    //}

    static string GetErrorExplanation(string code)
    {
        switch (code)
        {
            case "10":
                return "Code 10 - 无法启动此设备，通常是驱动不兼容或签名问题";
            case "28":
                return "Code 28 - 驱动程序未安装";
            case "31":
                return "Code 31 - 驱动程序无法加载";
            case "39":
                return "Code 39 - 驱动程序损坏或不完整";
            case "52":
                return "Code 52 - Windows 无法验证驱动程序的数字签名（驱动签名强制问题）";
            default:
                return "其他错误（可查询微软 Code 表）";
        }
    }
}
