using System;
namespace runoob
{
    class Student
    {

        private string code = "N.A";
        private string name = "not known";
        private int age = 0;

        // 声明类型为 string 的 Code 属性
        public string Code
        {
            //    get;
            //    set;

            //public string Code { get => code; set => code = value; 

            get
            {
                return code;
            }
            set
            {
                code = value;
            }
        }

        // 声明类型为 string 的 Name 属性
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        // 声明类型为 int 的 Age 属性
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }


        public override string ToString()
        {
            return "Code = " + Code + ", Name = " + Name + ", Age = " + Age;
        }
    }
    class ExampleDemo
    {
        public static void Main()
        {
            // 创建一个新的 Student 对象
            Student s = new Student();

            // 设置 student 的 code、name 和 age
            //s.Code = "001";
            s.Name = "Zara";
            s.Age = 9;
            Console.WriteLine("Student Info: {0}", s);
            // 增加年龄
            s.Age += 1;
            Console.WriteLine("Student Info: {0}", s);
            Console.ReadKey();
        }
    }
}