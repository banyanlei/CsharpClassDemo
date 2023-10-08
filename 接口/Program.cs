using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口
{
    class Program
    {
        //接口就是有个规范，能力。
        //一般I开头，able结尾
        static void Main(string[] args)
        {
            Student s = new Student();
            s.CHLS();
            s.KouLan();

        }


    }

    //没有访问修饰符，默认就是public(类的成员默认是private)
    //不允许写方法体的函数
    //字段不能写，属性可以写自动属性（就是两个没有方法体的函数）
    public interface IKouLanable
    {
        void KouLan();
        //string _name;
        string Name
        {
            get;
            set;
        }
    }

    public class Person
    {
        public void CHLS()
        {
            Console.WriteLine("我是人类");
        }
    }

    public class NBAPlayer
    {
        public void KouLan()
        {
            Console.WriteLine("我可以扣篮");
        }
    }
    //继承单根性
    public class Student : Person, IKouLanable
    {
        private string _name;
        public void KouLan()
        {
            Console.WriteLine("我也可以扣篮");
        }

        public string Name { get => _name; set => _name = value; }
    }



}
