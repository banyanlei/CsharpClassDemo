using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _interface_特点
{
    class Program
    {
        static void Main(string[] args)
        {
            IFlyable fly = new Person();//new IFlyable();
            fly.Fly();
            IFlyable fly1 = new Bird();//new IFlyable();
            fly1.Fly();
            //Console.ReadKey();
        }

        public class Person : IFlyable
        {
            public void Fly()
            {
                Console.WriteLine("Perople are Flying");
            }
        }

        public class Bird : IFlyable
        {
            public void Fly()
            {
                Console.WriteLine("Bird are Flying");
            }
        }


        public interface IFlyable
        {
            //不允许有访问修饰符，默认为public
            
            void Fly();
            //方法、自动属性,接口中只能有方法，属性，索引器，不能有“字段”和构造函数
            //int Age
            //{
            //    get;
            //    set;
            //}
        }

    }
}
