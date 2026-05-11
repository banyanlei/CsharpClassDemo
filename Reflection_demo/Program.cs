using System.Reflection;

namespace Reflection_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            string dllpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Plugins", "_Lambda.dll");
            Assembly asm = Assembly.LoadFrom(dllpath);
            Type type = asm.GetType("_Lambda.People");
            object p1 = Activator.CreateInstance(type, new object[] { 21, "guojing" });
            object p2 = Activator.CreateInstance(type, new object[] { 21, "wujunmin" });
            object p3 = Activator.CreateInstance(type, new object[] { 20, "muqing" });
            object p4 = Activator.CreateInstance(type, new object[] { 23, "lupan" });


            List<object> people = new List<object>();   //创建泛型对象  
            //People p1 = new People(21, "guojing");       //创建一个对象  
            //People p2 = new People(21, "wujunmin");     //创建一个对象  
            //People p3 = new People(20, "muqing");       //创建一个对象  
            //People p4 = new People(23, "lupan");        //创建一个对象  
            people.Add(p1);                     //添加一个对象  
            people.Add(p2);                     //添加一个对象  
            people.Add(p3);                     //添加一个对象  
            people.Add(p4);                     //添加一个对象 

            //匿名方法
            //            IEnumerable<People> results = people.Where
            //(delegate (People p) { return p.age > 20; });

            //lambda
            //List<People> results = people.Where(x => x.age > 20).ToList();
            //var results = people.Where(x => x.age > 20);
            //int results1 = people.Count(x => (x.age == 21)) + people.Count(x => (x.name.Equals("guojing")));
            //foreach (var item in results)
            //{
            //    Console.WriteLine(item.age);

            //}

            PropertyInfo age = type.GetProperty("age");
            var results = people.Where(x => (int)age.GetValue(x) > 20);
            var results1 = people.Count(x => (int)age.GetValue(x) == 21) + people.Count(x => (string)type.GetProperty("name").GetValue(x) == "guojing");
            foreach (var item in results)
            {
                Console.WriteLine(age.GetValue(item));

            }
        }
    }
}
