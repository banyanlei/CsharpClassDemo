//预处理器指令指导编译器在实际编译开始之前对信息进行预处理。所有的预处理器指令都是以#开始。在C#中，预处理器指令用于在条件编译中起作用。

//在编译软件的基本版本时，使用预处理器指令还可以禁止编译器编译额外功能相关的代码。在编写提供调试信息的代码时，也可以使用预处理器指令进行控制。总结：和控制语句（if等）功能类似，方便在于预处理器指令包含的未执行部分是不需要编译的。
//————————————————
//版权声明：本文为CSDN博主「心定亦是归宿」的原创文章，遵循CC 4.0 BY - SA版权协议，转载请附上原文出处链接及本声明。
//原文链接：https://blog.csdn.net/qq_51025538/article/details/122176710


#define DEBUG
#define VC_V7
using System;
public class MyClass
{
    static void Main()
    {
#if (DEBUG && !VC_V7)
        Console.WriteLine("DEBUG is defined");
#elif (!DEBUG && VC_V7)
        Console.WriteLine("VC_V7 is defined");
#elif (DEBUG && VC_V7)
        Console.WriteLine("DEBUG and VC_V7 are defined");
#else
        Console.WriteLine("DEBUG and VC_V7 are not defined");
#endif
    }
}