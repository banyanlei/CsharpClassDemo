using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Delegate
{
    /*
     * 我们先看看如果把 delegate1 声明为 private会怎样？结果就是：这简直就是在搞笑。
     * 因为声明委托的目的就是为了把它暴露在类的客户端进行方法的注册，你把它声明为private了，
     * 客户端对它根本就不可见，那它还有什么用？


    再看看把delegate1 声明为 public 会怎样？结果就是：在客户端可以对它进行随意的赋值等操作，严重破坏对象的封装性。
     现在已经很明确了：MakeGreet事件确实是一个GreetingDelegate类型的委托，
     只不过不管是不是声明为public，它总是被声明为private。另外，它还有两个方法，
     分别是add_MakeGreet和remove_MakeGreet，这两个方法分别用于注册委托类型的方法和取消注册。
     实际上也就是： “+= ”对应 add_MakeGreet，“-=”对应remove_MakeGreet。
     而这两个方法的访问限制取决于声明事件时的访问限制符。
         */
    public class Heater
    {
        public delegate void tongzhi(int para);
        public event tongzhi Tongzhi;
        private int _degree;
        public Heater(int degree)
        {
            _degree = degree;
        }
        public int Degree { get => _degree; set => _degree = value; }

        public void Heat()
        {
            int slep = 10;
            Console.WriteLine("初始温度为：{0}度", Degree);
            for (int i = _degree; i < 101; i++)
            {
                if (i % 10 == 0 && i < 90)
                {
                    Console.WriteLine("当前温度为：{0}度", i);
                }
                else if (i >= 90)
                {
                    if (Tongzhi != null)
                    {
                        Tongzhi(i);
                        slep += 100;
                    }
                }
                else
                {
                    slep += 1;
                }
                Thread.Sleep(slep);
            }
        }
    }

    public class Alert
    {
        public void Didi(int i)
        {
            Console.WriteLine("嘀嘀嘀嘀嘀嘀，快要沸腾了");
        }
    }
    public class ShowBox
    {
        public static void Show(int para)
        {
            Console.WriteLine("注意了当前温度：" + para + "度");
        }
    }
    class Program
    {
        static void Main()
        {

            Heater h = new Heater(5);
            Alert a = new Alert();
            //h.Degree = 55;
            //h.Tongzhi += Alert.Didi;
            h.Tongzhi += a.Didi;
            h.Tongzhi += ShowBox.Show;
            h.Heat();

        }

    }

}
