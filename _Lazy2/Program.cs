using System;

public class Program
{
    public static void Main()
    {
        // 创建一个 Lazy 实例，指定类型 T
        Lazy<ExpensiveObject> lazyExpensiveObject = new Lazy<ExpensiveObject>();

        // 首次访问 Lazy 对象，将触发对象的创建和初始化
        ExpensiveObject expensiveObject = lazyExpensiveObject.Value;

        // 后续访问 Lazy 对象，不会再次触发创建和初始化
        ExpensiveObject cachedObject = lazyExpensiveObject.Value;

        Console.WriteLine("ExpensiveObject created: " + (expensiveObject == cachedObject));
    }
}

public class ExpensiveObject
{
    public ExpensiveObject()
    {
        Console.WriteLine("ExpensiveObject created.");
    }
}
