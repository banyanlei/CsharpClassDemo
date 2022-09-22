using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
namespace LeeCarry
{
    public class Lock
    {
        //不同线程同时操作加锁，锁一个object对象，避免死锁
        private static readonly object obj = new object();
        private static Dictionary<int, string> dic = new Dictionary<int, string>();
        //private static ConcurrentDictionary<int,string> dic= new ConcurrentDictionary<int,string>();
        public static void Main(string[] args)
        {
            Thread oddThread = new Thread(OddThread);
            Thread evenThread = new Thread(EvenThread);
            evenThread.Start();
            //Thread.Sleep(1000);

            oddThread.Start();
            //Thread.Sleep(1000);
            //foreach (KeyValuePair<int, string> k in dic)
            //{
            //    Console.WriteLine("key:" + k.Key + " value:" + k.Value);
            //}
        }

        private static void EvenThread()
        {

            lock (obj)
            {
                for (int i = 0; i <= 10000; i += 2)
                {
                    //Console.WriteLine("线程1:{0}", i);
                    dic.Add(i, i.ToString());
                    //dic.TryAdd(i, i.ToString());
                }
            }
        }

        private static void OddThread()
        {
            lock (obj)
            {

                //    for (int i = 1; i <= 100; i += 2)
                //    {
                //    //Console.WriteLine("线程2:{0}", i);
                //    dic.Add(i, i.ToString());
                //foreach (KeyValuePair<int, string> k in dic)
                //{
                //    Console.WriteLine("key:" + k.Key + " value:" + k.Value);
                //}
                int a = dic.FirstOrDefault(q => q.Value == "8888").Key;
                Console.WriteLine("线程1:key:" + a);
            }

        }

    }
}