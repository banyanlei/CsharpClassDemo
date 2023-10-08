using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 密封类
{
    class Program
    {
        static void Main(string[] args)
        {
            //密封类：不能被继承，但可以继承别人
        }
    }

    public sealed class Person:Test
    {

    }

    public class Test
    {
    }

    public sealed class Student:Person
    {

    }

}
