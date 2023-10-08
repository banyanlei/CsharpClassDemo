using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _class_attribute
{
    class Program
    {
        static void Main(string[] args)
        {
            Person xioali = new Person("xiaoli", 19);
            xioali.SayHello();
            Console.ReadKey();
        }

        public class Person {

            private string _name;

            /// <summary>
            /// ctrl+R+E
            /// </summary>
            public string Name { get => _name; set => _name = value; }

            /// <summary>
            /// 自动属性
            /// </summary>
            public int Age
            {
                get;
                set;
            }

            public Person(string name, int age) 
            {
                this.Name = name;
                this.Age = age;
            }

            public void SayHello() {

                Console.WriteLine("My name is {0}, {1} years old!",this.Name, this.Age);
            }
        }
    }
}
