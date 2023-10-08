using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace 序列化和反序列化
{
    class Program
    {
        static void Main(string[] args)
        {
            //序列化：将对象转化为二进制
            //反序列化：将二进制转化为对象
            //作用：传输数据
            Person p = new Person();
            p.Name = "zhangsan";
            p.Gender = '男';

            using (FileStream fs = new FileStream(@"haha.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, p);
            }
            Console.WriteLine("序列化成功");

            //using (FileStream fsread = new FileStream(@"haha.txt", FileMode.Open, FileAccess.Read))
            //{

            //    BinaryFormatter bf = new BinaryFormatter();
            //    Person p1 = (Person)bf.Deserialize(fsread);
            //    Console.WriteLine(p.Name);
            //    Console.WriteLine(p.Gender);
            //}
        }
    }
    [Serializable]
    public  class Person
    {

        private string _name;
        private char _gender;
        public string Name { get => _name; set => _name = value; }
        public char Gender { get => _gender; set => _gender = value; }
    }
}
