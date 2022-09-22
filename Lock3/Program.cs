using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lock3
{
    //死锁的演示
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
            lock (obj1)
            {
                Console.WriteLine("开始执行方法一");
                Thread.Sleep(1000);
                lock (obj2)
                {
                    Console.WriteLine("方法一执行完毕");
                }
            }
        }
        static void Method2()
        {
            lock (obj2)
            {
                Console.WriteLine("开始执行方法二");
                Thread.Sleep(1000);
                lock (obj1)
                {
                    Console.WriteLine("方法二执行完毕");
                }
            }
        }
    }
}
