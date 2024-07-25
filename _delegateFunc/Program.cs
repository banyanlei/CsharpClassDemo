using System;

class Program
{
    static void Main()
    {

  //      -**Func<string, string, (string, string, string)> * *:
  //- `Func < ...>` 是一个泛型委托，用于定义返回值的类型和参数的类型。
  //-第一个 `string` 和第二个 `string` 是输入参数的类型。
  //- `(string, string, string)` 是返回值的类型，表示返回一个包含三个字符串的元组。
        Func<string, string, (string, string, string)> prepare;
        // 定义一个方法与 Func<string, string, (string, string, string)> 签名匹配
        (string, string, string) MyMethod(string param1, string param2)
        {
            return (param1, param2, param1 + param2);
        }

        // 将方法赋值给 prepare 委托变量
        prepare = MyMethod;

        // 调用委托
        var result = prepare("Hello", "World");

        // 输出结果
        Console.WriteLine($"Result: {result.Item1}, {result.Item2}, {result.Item3}");
    }
}
