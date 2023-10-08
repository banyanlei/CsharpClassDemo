using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            //集合：很多数据的一个集合
            //数组：长度不可变，类型单一
            //集合的好处：长度任意改变，类型随便
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add(3.14);
            list.Add("zhangsan");
            list.Add('男');
            list.Add(5000m);
            list.Add(new int[] { 1, 2, 3, 4, 5, 6, 7 });
            //AddRange 添加集合元素
            list.AddRange(new string[] { "xiaoming","wangjing"});
            Person p = new Person();
            list.Add(p);
            //返回的是类型的命名空间
            //list.Add(list);
            //list.AddRange(list);

            //list.Clear();
            //list.Remove(5000m);
            //list.RemoveAt(0);
            //list.RemoveRange(0, 1);
            //list.Reverse();
            //list.Sort();
            //list.Insert(1,"插入的");
            bool b = list.Contains(1);

            for (int i = 0; i < list.Count; i++)
            {
                //list[i]是 Object类型，Object是Person的父类
                if (list[i] is Person)
                {
                    ((Person)list[i]).sayHello();
                }
                else if (list[i] is int[])
                {
                    for (int j = 0; j < ((int[])list[i]).Length; j++)
                    {
                        Console.WriteLine(((int[])list[i])[j]);

                    }
                }
                else
                {
                    Console.WriteLine(list[i]);

                }
            }

            
        }

    }

    public class Person
    {
        public Person()
        {
        }
            public void sayHello()
            {
                Console.WriteLine("p hello");

            }
    }
}
