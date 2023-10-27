using System;
using System.IO;
using System.Threading;

class Program
{
    private static object fileLock = new object(); // 创建一个用于锁定的对象

    static void Main()
    {
        string fileName = Path.Combine(@"C:\Temp", "files.rc");
        string output = Path.Combine(@"C:\Temp", "output.rc\\");

        if (output[output.Length - 1] == '\\' || output[output.Length - 1] == '/')
        {
            if (File.Exists(Path.Combine(output, Path.GetFileName(fileName))))
                File.Delete(Path.Combine(output, Path.GetFileName(fileName)));
            File.Copy(fileName, Path.Combine(output, Path.GetFileName(fileName)));
        }
        //Console.WriteLine(path);
    }

    
}
