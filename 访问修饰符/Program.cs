using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 访问修饰符
{
    class Program
    {
        static void Main(string[] args)
        {
            //public:公开的
            //private：私有的，只能当前类的内部访问
            //protected：受保护的，当前类的内部和该类的子类中访问
            //internal：只能在当前程序集中（当前项目）,作为引用别的访问不了internal，同项目中权限一样
            //protected internal：+
            //能够修饰类的只有public和internal,默认不加是internal
            //子类的访问权限不能高于父类的访问权限，会暴露父类的成员
        }

    }

    public class Person
    {
        protected string _name;
    }

    public class Student:Person
    {
        public string _age;
    }
}
