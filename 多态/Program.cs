using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多态
{
    class Program
    {
        static void Main(string[] args)
        {
            //让有个对象表现出多种状态
            //实现多态的3中手段：虚方法；抽象类；接口
            Chinese cn1 = new Chinese("韩梅梅");
            Chinese cn2 = new Chinese("李磊");
            Japanese j1 = new Japanese("秀子");
            Japanese j2 = new Japanese("边子");
            Korea k1 = new Korea("京休闲");
            Korea k2 = new Korea("李光洙");
            America a1 = new America("科比");
            America a2 = new America("保罗");
            Person[] pers = { cn1, cn2, j1, j2, k1, k2, a1, a2 };
            for (int i = 0; i < pers.Length; i++)
            {
                //if (pers[i] is Chinese)
                //{
                //    ((Chinese)pers[i]).SayHello();
                //}
                //else
                //{
                //pers[i].SayHello();

                //}

                pers[i].SayHello();
            }

        }

        public class Person
        {
            private string _name;

            public string Name { get => _name; set => _name = value; }

            public  Person(string name)
            {
                this.Name = name;
            }
            public virtual void SayHello()
            {
                Console.WriteLine("我是人类");

            }
        }
        public class Chinese: Person
        {
            public Chinese(string name) : base(name)
            {

            }
            public void SayHello()
            {

            }
        }

        public class Japanese : Person
        {
            public Japanese(string name):base(name)
            {

            }

            public override void SayHello()
            {
                Console.WriteLine("我是日本人，我叫{0}",this.Name);
            }
        }
        public class Korea : Person
        {
            public Korea(string name) : base(name)
            {

            }

            public override void SayHello()
            {
                Console.WriteLine("我是棒子，我叫{0}", this.Name);
            }
        }
        public class America : Person
        {
            public America(string name) : base(name)
            {

            }

            public override void SayHello()
            {
                Console.WriteLine("我是美利坚，我叫{0}", this.Name);
            }
        }
    }
}
