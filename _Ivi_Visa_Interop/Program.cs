using System;
using Ivi.ConfigServer.Interop;

class Program
{
    static void Main()
    {
        // 创建 ConfigServer 的实例
        IviConfigServer configServer = new IviConfigServer();

        try
        {
            // 列出系统中可用的仪器配置
            string[] availableConfigs = configServer.GetAvailableInstrumentConfigs();

            Console.WriteLine("可用的仪器配置：");
            foreach (string config in availableConfigs)
            {
                Console.WriteLine(config);
            }

            // 选择并加载特定仪器配置
            string selectedConfig = "MyInstrumentConfig"; // 替换为您的仪器配置名称
            bool configLoaded = configServer.SelectInstrumentConfig(selectedConfig);

            if (configLoaded)
            {
                Console.WriteLine($"已加载仪器配置：{selectedConfig}");
                // 这里可以添加与已加载配置相关的操作
            }
            else
            {
                Console.WriteLine($"未能加载仪器配置：{selectedConfig}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("发生错误：" + ex.Message);
        }
        finally
        {
            // 释放资源
            configServer.Dispose();
        }
    }
}
