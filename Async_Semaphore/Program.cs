using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static SemaphoreSlim semaphoreSlim = new SemaphoreSlim(3); // 限制同时只能有3个线程访问

    static async Task Main(string[] args)
    {
        // 启动多个任务，每个任务都会请求信号量许可
        var tasks = new Task[5];
        for (int i = 0; i < tasks.Length; i++)
        {
            tasks[i] = Task.Run(async () =>
            {
                await AccessResource();
            });
        }

        await Task.WhenAll(tasks);
    }

    static async Task AccessResource()
    {
        await semaphoreSlim.WaitAsync(); // 请求信号量许可
        try
        {
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} accessing resource...");
            await Task.Delay(1000); // 模拟访问资源的耗时操作
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} released resource.");
        }
        finally
        {
            semaphoreSlim.Release(); // 释放信号量许可
        }
    }
}