using System.Threading;
using System;
using System.Collections.Concurrent;
using System.Configuration;


namespace _Thread_Task_async_await
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //菜没做完不能动，主线程block了
            Thread.Sleep(3000);
            MessageBox.Show("素菜1做好了", "友情提示");
            Thread.Sleep(5000);
            MessageBox.Show("荤菜1做好了", "友情提示");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //lambda 表达式
            Thread t = new Thread(() =>
            {
                Thread.Sleep(3000);
                MessageBox.Show("素菜2做好了", "友情提示");
                Thread.Sleep(5000);
                MessageBox.Show("荤菜2做好了", "友情提示");
            });
            t.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //底层也是Thread实现，更扩展，推荐
            Task.Run(() =>
            {
                Thread.Sleep(3000);
                MessageBox.Show("素菜2做好了", "友情提示");
                Thread.Sleep(5000);
                MessageBox.Show("荤菜2做好了", "友情提示");
            });
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                Thread.Sleep(3000);
                MessageBox.Show("素菜2做好了", "友情提示");
            });
            Task.Run(() =>
            {
                Thread.Sleep(5000);
                MessageBox.Show("荤菜2做好了", "友情提示");
            });
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            //await就是等待，没await直接就菜好了。。。
            await Task.Run(() =>
            {
                Thread.Sleep(3000);
                MessageBox.Show("素菜2做好了", "友情提示");
            });
            await Task.Run(() =>
            {
                Thread.Sleep(5000);
                MessageBox.Show("荤菜2做好了", "友情提示");
            });
            MessageBox.Show("菜都做好了，大家来吃", "友情提示");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            List<Task> ts = new List<Task>();
            ts.Add(Task.Run(() =>
            {
                Thread.Sleep(3000);
                MessageBox.Show("素菜2做好了", "友情提示");
            }));

            ts.Add(Task.Run(() =>
            {
                Thread.Sleep(5000);
                MessageBox.Show("荤菜2做好了", "友情提示");
            }));
            Task.WhenAll(ts).ContinueWith(t =>
            {
                MessageBox.Show($"菜都做好了，大家来吃", "友情提示");

            });
        }

        private class VersionInformationItem
        {
            public string AutoConfig { get; set; }
            public string MpSuffix { get; set; }
            public string Description { get; set; }
        }
        private readonly List<VersionInformationItem> VersionItems = new()
        {
            new VersionInformationItem { AutoConfig = "IMeasureIQ", MpSuffix = "VSA", Description = "VSA" },
            new VersionInformationItem { AutoConfig = "IMeasurePower", MpSuffix = "PM", Description = "Power Meter" },
            new VersionInformationItem { AutoConfig = "ISwitch", MpSuffix = "RFMUX", Description = "RF Multiplexer" },
            //new VersionInformationItem { AutoConfig = "IPowerSupply", MpSuffix = "PSU", Description = "Power Supply" },
            //new VersionInformationItem { AutoConfig = "IFanTray", MpSuffix = "FU", Description = "Fan Tray" },
            //new VersionInformationItem { AutoConfig = "MeasClient", MpSuffix = "MSRV", Description = "Measurement Server" },
        };
        public static string GlobalLockName { get; private set; } = "{DCCE47D0-6D43-47D3-B886-4D74868E9620}";

        public async static Task<string> GetDataAsync(string autoConfig)
        {
           
            if (autoConfig == "PM")
            {
                ////会抛上去，不影响下面继续执行
                //SystemException ex = new NotImplementedException();
                //throw ex;

                //一直block造成死锁
                await Task.Delay(10000);
            }
            MessageBox.Show($"Reading version information for {autoConfig}");
            return await Task.FromResult(autoConfig);
        }
        private async void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Start");
            foreach (var item in VersionItems)
            {

                MessageBox.Show($"Reading version information for {item.AutoConfig}");
                try
                {
                    using (await AsyncLock.CreateAsync(GlobalLockName, 6000))
                    {
                        //string ip = await GetDataAsync(item.MpSuffix);


                        //SystemException ex = new NotImplementedException();
                        ////throw ex;
                        //MessageBox.Show($"Throw后");

                        //改进意见
                        var getDataTask = GetDataAsync(item.MpSuffix);
                        var timeoutTask = Task.Delay(6000); // 6秒超时

                        var completedTask = await Task.WhenAny(getDataTask, timeoutTask);
                        if (!getDataTask.IsCompleted)
                        {
                            throw new TimeoutException($"ConnectSocketOnDemand timed out after  6 seconds.");
                        }

                        //if (completedTask == timeoutTask)
                        //{
                        //    MessageBox.Show($"GetDataAsync operation timed out after 6 seconds for {item.MpSuffix}");
                        //    continue; // 继续下一个循环
                        //}

                        string ip = await getDataTask;
                        MessageBox.Show($"Successfully reading {ip}");

                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Unable to connect to {item.MpSuffix}，{ex.Message}");
                }
                //MessageBox.Show($"Finish");
            }
        }

    }

}