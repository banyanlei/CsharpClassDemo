using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型约束
{
    public class MyClass<T, K, V, W, X>
        where T : struct           //约束T必须为值类型
        where K : class           //约束K必须为引用类型
        where V : IComparable     //约束V必须是实现了IComparable接口
        where W : K               //要求W必须是K类型，或者K类型的子类
        where X : class, new()    // X必须是引用类型，并且要有一个无参的构造函数（对于一个类型有多有约束，中间用逗号隔开）

    {
        public void SayHello()
        {
            Console.WriteLine("你好"); //虽然类是一个泛型类，但是那些T,K,V,W,X类型，我可用，也可以不用。
        }

        public void SayHello(X obj)
        {
            Console.WriteLine(obj.ToString());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //int类型是实现了IComparable接口的，所以第三个参数是可以使用int的
            MyClass<int, Stream, int, FileStream, object> mc = new MyClass<int, Stream, int, FileStream, object>();

            mc.SayHello(); //输出：你好

            mc.SayHello("大家好!"); //输出：大家好

            Console.ReadKey();
        }
    }
}