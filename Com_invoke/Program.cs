using System;

namespace ComClient
{
    class Program
    {
        static void Main(string[] args)
        {
            // 使用COM类型
            Type comType = Type.GetTypeFromProgID("MyComLibrary.MyComClass");
            dynamic comObject = Activator.CreateInstance(comType);

            // 调用COM方法
            comObject.MyMethod();

            Console.WriteLine("Method called successfully");
        }
    }
}
