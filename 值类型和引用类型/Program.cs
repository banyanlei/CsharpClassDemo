using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 值类型和引用类型
{
    class Program
    {
        static void Main(string[] args)
        {

            //unsafe
            //{
            //    //有趣的问题：为什么b的值改变了
            //    //回答：因为i的地址指向了b,栈中由高字节往低字节使用
            //    int a = 10;
            //    int b = 20;
            //    int* i;
            //    i = &a;//将a的地址赋值给指针i
            //    i -= 1;//将i的地址-1（相当于向下移动4个字节（int类型的大小为4个字节））
            //    *i = 30;//取出i指针指向的内容赋值为30
            //    Console.WriteLine(b);//输出30
            //}



            //值类型：int double char decimal bool enum struct 存栈上
            //引用类型：string 数组 自定义类 集合 接口 存堆上

            //值类型在复制的时候传递的是值本身
            //int n1 = 10;
            //int n2 = n1;
            //n2 = 20;
            //Console.WriteLine(n1);
            //Console.WriteLine(n2);

            //引用类型在复制的时候传递的是这个对象的引用
            //Person p1 = new Person();
            //p1.Name = "zhangsan";
            //Person p2 = p1;//p2和p1在栈中存对象的地址（引用），指向堆中同一个对象
            //p2.Name = "lisi";
            //Console.WriteLine(p2.Name);
            //Console.WriteLine(p1.Name);

            //Person p = new Person();
            //p.Name = "zhangsan";
            //Test(p);
            //Console.WriteLine(p.Name);

            //string是引用类型，但是string有不可变性
            //string s1 = "zhangsan";
            //string s2 = s1;
            //s2 = "lisi";
            //Console.WriteLine(s1);
            //Console.WriteLine(s2);

            int n = 10, m = 10;
            TestTwo(n);
            TestThree(ref m);
            Console.WriteLine(n);
            Console.WriteLine(m);
        }

        private static void TestThree(ref int nn)
        {
            nn += 10;

        }

        private static void TestTwo(int nn)
        {
            nn += 10;
        }

        public static void Test(Person pp)
        {
            Person p = pp;
            p.Name = "lisi";
        }
    }

    internal class Person
    {
        private string _name;

        public string Name { get => _name; set => _name = value; }
    }
}
