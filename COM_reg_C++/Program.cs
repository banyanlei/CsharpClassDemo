using System;
using System.Runtime.InteropServices;

[UnmanagedFunctionPointer(CallingConvention.StdCall)]
public delegate int DllRegisterServer();


class Program
{
    // 定义 LoadLibrary 和 GetProcAddress 的外部方法
    [DllImport("kernel32.dll", SetLastError = true)]
    static extern IntPtr LoadLibrary(string lpFileName);

    [DllImport("kernel32.dll", SetLastError = true)]
    static extern IntPtr GetProcAddress(IntPtr hModule, string lpProcName);

    [DllImport("kernel32.dll", SetLastError = true)]
    static extern bool FreeLibrary(IntPtr hModule);

    static void Main(string[] args)
    {
        // DLL 文件路径
        string dllPath = @"C:\CAYA\work\COMMON\PACKAGES CODE BACKUP\BBS6K\package\TRXUNIT\R61A02\CXP9040281_1-R61A02\rcmRfSwitchAgtL449xA.dll";



        // 加载 DLL
        IntPtr hModule = LoadLibrary(dllPath);
        if (hModule == IntPtr.Zero)
        {
            Console.WriteLine("Failed to load DLL.");
            return;
        }

        try
        {
            // 获取函数指针
            IntPtr fptr = GetProcAddress(hModule, "DllRegisterServer");
            if (fptr == IntPtr.Zero)
            {
                Console.WriteLine("Failed to get function pointer.");
                return;
            }

            // 将函数指针转换为委托
            DllRegisterServer drs = (DllRegisterServer)Marshal.GetDelegateForFunctionPointer(fptr, typeof(DllRegisterServer));

            // 调用函数
            int result = drs();
            Console.WriteLine("DllRegisterServer returned: " + result);
        }
        finally
        {
            // 释放 DLL
            FreeLibrary(hModule);
        }
    }
}
