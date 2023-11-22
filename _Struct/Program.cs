
using System.Net.NetworkInformation;
using System.Net;

//在C#中，struct 是一种值类型（value type）的数据结构，通常用于表示轻量级的数据类型。
//与类（class）不同，结构是值类型，而类是引用类型。以下是关于 C# 中结构的主要用法：
class Program
{

    static void Main()
    {
        MyStruct point = new MyStruct(10, 20);
        int xValue = point.X;
        int yValue = point.Y;
        point.Display();

    }
    struct MyStruct
    {
        // 成员变量
        public int X;
        public int Y;

        // 构造函数
        public MyStruct(int x, int y)
        {
            X = x;
            Y = y;
        }

        // 方法
        public void Display()
        {
            Console.WriteLine($"X: {X}, Y: {Y}");
        }
    }


}