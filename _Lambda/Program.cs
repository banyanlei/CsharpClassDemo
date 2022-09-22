using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<People> people = new List<People>();   //创建泛型对象  
            People p1 = new People(21, "guojing");       //创建一个对象  
            People p2 = new People(21, "wujunmin");     //创建一个对象  
            People p3 = new People(20, "muqing");       //创建一个对象  
            People p4 = new People(23, "lupan");        //创建一个对象  
            people.Add(p1);                     //添加一个对象  
            people.Add(p2);                     //添加一个对象  
            people.Add(p3);                     //添加一个对象  
            people.Add(p4);                     //添加一个对象 

            //匿名方法
            //            IEnumerable<People> results = people.Where
            //(delegate (People p) { return p.age > 20; });

            //lambda
            List<People> results = people.Where(x => x.age > 20).ToList();
            int results1 = people.Count(x => (x.age == 21))+ people.Count(x => (x.name.Equals("guojing")));
            foreach (var item in results)
            {
                Console.WriteLine(item.age);

            }
        }
    }

    public class People
    {
        public int age { get; set; }                //设置属性  
        public string name { get; set; }            //设置属性  
        public People(int age, string name)      //设置属性(构造函数构造)  
        {
            this.age = age;                 //初始化属性值age  
            this.name = name;               //初始化属性值name  
        }
    }
}
