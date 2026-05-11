using System.Reflection;
using System.Linq;
using Interface_definition;

namespace Reflection_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string dllpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Plugins", "_Lambda.dll");
            string dllpath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "..", "_Lambda", "bin", "Debug", "_Lambda.dll"));

            Assembly asm = Assembly.LoadFrom(dllpath);
            Type type = asm.GetType("_Lambda.People");

            // 用接口接收（关键）
            List<IPerson> people = new List<IPerson>();

            people.Add((IPerson)Activator.CreateInstance(type, new object[] { 21, "guojing" }));
            people.Add((IPerson)Activator.CreateInstance(type, new object[] { 21, "wujunmin" }));
            people.Add((IPerson)Activator.CreateInstance(type, new object[] { 20, "muqing" }));
            people.Add((IPerson)Activator.CreateInstance(type, new object[] { 23, "lupan" }));

            // ✔ 完全不需要反射
            var results = people.Where(x => x.age > 20);

            var results1 =
                people.Count(x => x.age == 21) +
                people.Count(x => x.name == "guojing");

            foreach (var item in results)
            {
                Console.WriteLine(item.age);
            }
        }
    }

}