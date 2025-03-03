using System;
using System.Management;

class Program
{
    public static void Main(string[] args)
    {
        // 查询安装的 Windows 功能
        string query = "SELECT * FROM Win32_OptionalFeature";
        ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);

        foreach (ManagementObject feature in searcher.Get())
        {
            string name = feature["Name"]?.ToString();
            string description = feature["Description"]?.ToString();
            string installState = feature["InstallState"]?.ToString();

            //File.AppendAllText("feature.txt", @"加一行");

            File.AppendAllText("feature.txt", $"Feature: {name}\r\n" );
            File.AppendAllText("feature.txt", $"Description: {description}r\n");
            File.AppendAllText("feature.txt", $"Install State: {installState}r\n");
            Console.WriteLine();
        }
    }
}
