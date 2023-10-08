using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 自动属性和普通属性
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Person
    {
        private string _name;
        //普通属性
        public string Name { get => _name; set => _name = value; }
        //自动属性：没写字段，但是编译的时候依然自动生成私有字段
        public int Age
        {
            get;
            set;
        }
    }
}
