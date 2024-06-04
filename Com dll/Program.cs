using System;

namespace ComClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Type comType = Type.GetTypeFromProgID("ivi config server"); // 替换为实际的ProgID
            dynamic comObject = Activator.CreateInstance(comType);

            // 调用COM方法
            comObject.YourMethod(); // 替换为实际的方法名称

            Console.WriteLine("Method called successfully");
        }
    }
}
