using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Start");
        //await MyAsyncMethod(); // 等待异步方法完成
        MyAsyncMethod(); // 不使用 await        Console.WriteLine("End");
        Console.WriteLine("End");
    }

    static async Task MyAsyncMethod()
    {
        Console.WriteLine("Async method start");
        await Task.Delay(2000); // 模拟一个异步操作，例如等待2秒
        Console.WriteLine("Async method end");
    }
}