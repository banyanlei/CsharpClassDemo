using System;
using System.Runtime.InteropServices;
using System.Threading;

class Program
{
    [DllImport("user32.dll")]
    public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

    [DllImport("user32.dll")]
    public static extern bool SetForegroundWindow(IntPtr hWnd);

    [DllImport("user32.dll")]
    public static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);

    // 定义按键的虚拟键码
    const byte VK_CONTROL = 0x11;
    const byte VK_N = 0x4E;
    const byte VK_H = 0x48;
    const byte VK_E = 0x45;
    const byte VK_L = 0x4C;
    const byte VK_O = 0x4F;
    const byte VK_SPACE = 0x20;
    const byte VK_W = 0x57;
    const byte VK_R = 0x52;
    const byte VK_D = 0x44;

    public static void Main(string[] args)
    {
        IntPtr hwnd = FindWindow("Notepad++", null); // 查找记事本窗口
        if (hwnd != IntPtr.Zero)
        {
            Console.WriteLine("找到记事本窗口句柄: " + hwnd);

            // 激活记事本窗口
            SetForegroundWindow(hwnd);
            Thread.Sleep(500); // 等待窗口切换

            // 模拟按下 Ctrl+N
            keybd_event(VK_CONTROL, 0, 0, UIntPtr.Zero); // 按下 Ctrl
            keybd_event(VK_N, 0, 0, UIntPtr.Zero); // 按下 N
            keybd_event(VK_N, 0, 2, UIntPtr.Zero); // 释放 N
            keybd_event(VK_CONTROL, 0, 2, UIntPtr.Zero); // 释放 Ctrl
            Thread.Sleep(500);

            // 输入 "Hello World"
            keybd_event(VK_H, 0, 0, UIntPtr.Zero); // 按下 H
            keybd_event(VK_H, 0, 2, UIntPtr.Zero); // 释放 H

            keybd_event(VK_E, 0, 0, UIntPtr.Zero); // 按下 E
            keybd_event(VK_E, 0, 2, UIntPtr.Zero); // 释放 E

            keybd_event(VK_L, 0, 0, UIntPtr.Zero); // 按下 L
            keybd_event(VK_L, 0, 2, UIntPtr.Zero); // 释放 L

            keybd_event(VK_L, 0, 0, UIntPtr.Zero); // 按下 L
            keybd_event(VK_L, 0, 2, UIntPtr.Zero); // 释放 L

            keybd_event(VK_O, 0, 0, UIntPtr.Zero); // 按下 O
            keybd_event(VK_O, 0, 2, UIntPtr.Zero); // 释放 O

            keybd_event(VK_SPACE, 0, 0, UIntPtr.Zero); // 按下 空格
            keybd_event(VK_SPACE, 0, 2, UIntPtr.Zero); // 释放 空格

            keybd_event(VK_W, 0, 0, UIntPtr.Zero); // 按下 W
            keybd_event(VK_W, 0, 2, UIntPtr.Zero); // 释放 W

            keybd_event(VK_O, 0, 0, UIntPtr.Zero); // 按下 O
            keybd_event(VK_O, 0, 2, UIntPtr.Zero); // 释放 O

            keybd_event(VK_R, 0, 0, UIntPtr.Zero); // 按下 R
            keybd_event(VK_R, 0, 2, UIntPtr.Zero); // 释放 R

            keybd_event(VK_L, 0, 0, UIntPtr.Zero); // 按下 L
            keybd_event(VK_L, 0, 2, UIntPtr.Zero); // 释放 L

            keybd_event(VK_D, 0, 0, UIntPtr.Zero); // 按下 D
            keybd_event(VK_D, 0, 2, UIntPtr.Zero); // 释放 D
        }
        else
        {
            Console.WriteLine("未找到记事本窗口");
        }
    }
}
