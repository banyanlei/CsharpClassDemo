using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口_显示实现
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird b = new Bird();
            b.Fly();
            Iflyable bb = new Bird();
            bb.Fly();
        }
    }

    public class Bird:Iflyable
    {
        public void Fly()
        {
            Console.WriteLine("鸟会飞");
        }
        //显示实现接口
         void Iflyable.Fly()
        {
            Console.WriteLine("我是接口的飞");
        }
    }
     interface Iflyable
    {
        void Fly();
    }

}

