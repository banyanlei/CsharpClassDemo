using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

public class AwaitOperator
{
    public static async Task Main()
    {
        //Task<int> downloading = DownloadDocsMainPageAsync("https://www.baidu.com/?tn=62095104_26_oem_dg",2000);
        int bytesLoaded = await DownloadDocsMainPageAsync("https://www.baidu.com/?tn=62095104_26_oem_dg", 2000);
        Task<int> downloading2 = DownloadDocsMainPageAsync("https://news.baidu.com/");
        Console.WriteLine($"{nameof(Main)}: Launched downloading.");
        //int bytesLoaded = await downloading;
        //Task本身就是异步的相当于开一个线程，await就是要等这个task完成再继续下面的step,await和await也是顺序等待的
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine(i);
            Thread.Sleep(20);
        }
        int bytesLoaded2 = await downloading2;
        Console.WriteLine($"{nameof(Main)}: Downloaded {bytesLoaded} bytes.");
        Console.WriteLine($"{nameof(Main)}: Downloaded {bytesLoaded2} bytes.");
        //Console.WriteLine($"baibai.");
    }


    private static async Task<int> DownloadDocsMainPageAsync(String https, int delayTime=0)
    {
        Console.WriteLine($"{nameof(DownloadDocsMainPageAsync)}: About to start downloading:{https}.");

        var client = new HttpClient();
        byte[] content = await client.GetByteArrayAsync(https);
        await Task.Delay(delayTime);
        Console.WriteLine($"{nameof(DownloadDocsMainPageAsync)}: Finished downloading:{https}.");
        return content.Length;
    }
}
// Output similar to:
// DownloadDocsMainPageAsync: About to start downloading.
// Main: Launched downloading.
// DownloadDocsMainPageAsync: Finished downloading.
// Main: Downloaded 27700 bytes.