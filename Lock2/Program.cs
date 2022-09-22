using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lock2
{
    //应该尽量避免大量嵌套的锁的使用，这也是预防为主，当然也有信号量也可能会造成死锁，
    //这样的话只能靠程序员自身注意去避免了,即使在两个线程都在互相等待资源的情况下，利用超时机制，
    //依然能够使他们放弃当前锁，保证解决死锁问题。
    class Program
    {
        private static readonly object obj1 = new object();
        private static readonly object obj2 = new object();
        static void Main(string[] args)
        {
            Task.Run(() => Method1());
            Task.Run(() => Method2());
            Console.Read();
        }
        static void Method1()
        {
            try
            {
                if (Monitor.TryEnter(obj1, 5000))
                {
                    Console.WriteLine("开始执行方法一");
                    Thread.Sleep(1000);
                    bool locked = false;
                    try
                    {
                        Monitor.TryEnter(obj2, 5000, ref locked);
                        Console.WriteLine("方法一执行完毕");
                    }
                    finally
                    {
                        if (locked)
                        {
                            Monitor.Exit(obj2);
                        }
                    }
                }
            }
            finally
            {
                Monitor.Exit(obj1);
            }
        }
        static void Method2()
        {
            try
            {
                if (Monitor.TryEnter(obj2, 5000))
                {
                    Console.WriteLine("开始执行方法二");
                    Thread.Sleep(1000);
                    bool locked = false;
                    try
                    {
                        Monitor.TryEnter(obj1, 5000, ref locked);
                        Console.WriteLine("方法二执行完毕");
                    }
                    finally
                    {
                        if (locked)
                        {
                            Monitor.Exit(obj1);
                        }
                    }
                }
            }
            finally
            {
                Monitor.Exit(obj2);
            }
        }
    }
}
