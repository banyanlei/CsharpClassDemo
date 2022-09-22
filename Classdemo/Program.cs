
#region ref

//参数的变化
//using System;
//namespace CalculatorApplication
//{
//    class NumberManipulator
//    {
//        public void swap(int x, int y)
//        //public void swap(ref int x, ref int y)
//        {
//            int temp;

//            temp = x; /* 保存 x 的值 */
//            x = y;    /* 把 y 赋值给 x */
//            y = temp; /* 把 temp 赋值给 y */
//        }

//        static void Main(string[] args)
//        {
//            NumberManipulator n = new NumberManipulator();
//            /* 局部变量定义 */
//            int a = 100;
//            int b = 200;

//            Console.WriteLine("在交换之前，a 的值： {0}", a);
//            Console.WriteLine("在交换之前，b 的值： {0}", b);

//            /* 调用函数来交换值 */
//            n.swap(a, b);
//            //n.swap(ref a, ref b);

//            Console.WriteLine("在交换之后, a 的值： " + a);
//            Console.WriteLine("在交换之后，b 的值： {0}", b);

//            Console.ReadLine();
//        }
//    }
//}

#endregion



//结构是值类型（在栈中），类是引用类型（在堆中）
//结构不支持继承，类支持继承
//结构不能定义默认构造函数，编译器会定义

//结构：由于分配内存快，作用域结束即被删除，不需要垃圾回收，用于小型数据结构
//但传递过程中会复制，应该使用ref提升效率
//类： 用于其他的需要继承体系的场合


#region static 字段和构造函数

//using System;
//using System.IO;
//namespace PetShop

//{
//    //static 静态的使用和静态的构造函数
//    //静态成员将被类的所有实例共享，所有实例抖访问同一内存位置
//    abstract public class Pet
//    {
//        protected string Name;
//        public Pet(string name)
//        {
//            Name = name;
//        }

//        public abstract void PrintName();

//    }
//    public class Dog : Pet
//    {
//        //静态函数也独立于任何实例，没有实例也可以调用
//        //静态函数不能访问实例成员，仅能访问其他静态成员
//        static int Num;
//        //静态构造函数用于初始化静态字段
//        //在引用任何静态成员之前，和创建任何实例之前调用
//        //与类同名，使用static，无参数，无访问修饰符
//        static Dog()
//        {
//            Num = 0;
//        }
//        //实例成员能访问静态成员
//        public Dog(string name) : base(name)
//        {
//            ++Num;
//        }
//        public override void PrintName()
//        {
//            Console.WriteLine("Dog's name is:" + Name);
//        }
//        static public void ShowNum()
//        {
//            Console.WriteLine("Dog's num:" + Num);
//        }
//    }

//    class Pro
//    {
//        static void Main(string[] args)
//        {
//            Dog dog = new Dog("Puppy");
//            Dog dog1 = new Dog("Puppy");
//            Dog dog2 = new Dog("Puppy");
//            Dog dog3 = new Dog("Puppy");
//            Dog[] dogs = { new Dog("haha"), new Dog("da") };
//            //静态成员直接由类名访问
//            Dog.ShowNum();
//        }
//    }
//}

#endregion



#region static类 扩展类得方法
//using System;
//using System.IO;
//namespace PetShop

//{
//    //如果类只包含静态的方法和属性，并且标识为static
//    //静态类不能创建实例，不能被继承
//    //可以为静态类定义一个静态构造函数
//    //主要用于基础类库（如数学库）和扩展方法
//    //Math
//    abstract public class Pet
//    {
//        protected string Name;
//        public Pet(string name)
//        {
//            Name = name;
//        }

//        public abstract void PrintName();

//    }
//    public class Dog : Pet
//    {
//        static int Num;
//        static Dog()
//        {
//            Num = 0;
//        }
//        public Dog(string name) : base(name)
//        {
//            ++Num;
//        }
//        public override void PrintName()
//        {
//            Console.WriteLine("Dog's name is:" + Name);
//        }
//        static public void ShowNum()
//        {
//            Console.WriteLine("Dog's num:" + Num);
//        }
//    }

//    //如何扩展方法：
//    //  如果有源代码，直接添加一个新方法
//    //  如果不能修改但也不是密闭类，可以派生子类扩展
//    //  如果以上条件都不满足，可以使用静态类扩展方法

//    //静态类 ,用来扩展dog对象的功能，就像调用自己的方法
//    static class PetGuide
//    {
//        //要求
//        // 扩展方法所属的类，必须是static类
//        // 扩展方法本身必须是static方法
//        // 扩展方法的第一个参数类型，必须是this + 类名
//        static public void HowToFeedDog(this Dog dog)
//        {
//            Console.WriteLine("Dog's Feed Guide");
//        }
//    }

//    class Pro
//    {
//        static void Main(string[] args)
//        {
//            Dog dog = new Dog("Puppy");
//            dog.HowToFeedDog();
//        }
//    }
//} 
#endregion



//using System;
//using System.IO;
//namespace PetShop

//{
//    //装箱与拆箱
//    //装箱：根据值类型（在栈上）的值，在堆上创建一个完整的引用类型对象，
//    //      并返回对象的引用，是一种隐式转换
//    //为什么要装箱：有时候需要将值类型转化为引用类型来进行统一的操作和统一的存储
//    class pro
//    {
//        static void Main(string[] args)
//        {
//            int i = 3;
//            object oi = i;
//            oi = 10;
//            i = 7;
//            Console.WriteLine("i=" + i + "oi=" + oi.ToString());
//            int j = (int)oi;
//            Console.WriteLine(j);
//        }
//    }
//}



#region operator 隐式转换和显示转换

//using System;
//using System.IO;
//namespace PetShop

//{
//    //abstract 抽象方法
//    abstract public class Pet
//    {
//        protected string Name;
//        public Pet(string name)
//        {
//            Name = name;
//        }

//        public abstract void PrintName();

//    }

//    public class Dog : Pet
//    {
//        public Dog(string name) : base(name)
//        {
//        }
//        public override void PrintName()
//        {
//            Console.WriteLine("Dog's name is:" + Name);
//        }
//        //隐式转换
//        //static implicit operator表示是一种操作 Cat是返回类型，没有函数名称
//        public static implicit operator Cat(Dog dog)
//        {
//            return new Cat(dog.Name);
//        }
//    }

//    public class Cat : Pet
//    {
//        public Cat(string name) : base(name)
//        {

//        }
//        public override void PrintName()
//        {
//            Console.WriteLine("Cat's name is:" + Name);
//        }
//        //显式转换
//        public static explicit operator Dog(Cat cat)
//        {
//            return new Dog(cat.Name);

//        }
//    }
//    class Pro
//    {
//        static void Main(string[] args)
//        {
//            //隐式
//            Dog haha = new Dog("jack");
//            haha.PrintName();
//            Cat wawa = haha;
//            wawa.PrintName();
//            //显式
//            Dog haha2 = (Dog)wawa;
//            haha2.PrintName();
//        }
//    }
//} 
#endregion



#region operate 重载运算符

//using System;
//using System.IO;
//namespace PetShop

//{
//    //重载运算符
//    abstract public class Pet
//    {
//        protected string Name;
//        public Pet(string name)
//        {
//            Name = name;
//        }

//        public abstract void PrintName();

//    }

//    public class Dog : Pet
//    {
//        public Dog(string name) : base(name)
//        {
//        }
//        public override void PrintName()
//        {
//            Console.WriteLine("Dog's name is:" + Name);
//        }
//        public static Dog operator +(Dog male, Dog female)
//        {
//            return new Dog(male.Name + " and " + female.Name + "'s child");
//        }
//    }

//    class Pro
//    {
//        static void Main(string[] args)
//        {
//            Dog jack = new Dog("jack");
//            Dog kitty = new Dog("kitty");
//            Dog haha = jack + kitty;
//            haha.PrintName();
//        }
//    }
//}

#endregion


#region 泛型类
//using System;
//using System.IO;
//namespace PetShop

//{
//    //泛型类和泛型方法
//    abstract public class Pet
//    {
//        protected string Name;
//        public Pet(string name)
//        {
//            Name = name;
//        }

//        public abstract void PrintName();

//    }

//    public class Dog : Pet
//    {
//        public Dog(string name) : base(name)
//        {
//        }
//        public override void PrintName()
//        {
//            Console.WriteLine("Dog's name is:" + Name);
//        }
//        public static Dog operator +(Dog male, Dog female)
//        {
//            return new Dog(male.Name + " and " + female.Name + "'s child");
//        }
//        //泛型方法
//        public void isHappy<T>(T target)
//        {
//            Console.WriteLine("Happy:" + target.ToString());
//        }
//    }

//    public class Cat : Pet
//    {
//        public Cat(string name) : base(name)
//        {

//        }
//        public override void PrintName()
//        {
//            Console.WriteLine("Cat's name is:" + Name);
//        }
//    }
//    //泛型类
//    public class Cage<T>
//    {
//        T[] array;
//        readonly int Size;
//        int num;
//        public Cage(int n)
//        {
//            Size = n;
//            num = 0;
//            array = new T[Size];
//        }
//        public void Putin(T pet)
//        {
//            if (num < Size)
//            {
//                array[num++] = pet;
//            }
//            else
//            {
//                Console.WriteLine("cage is full");
//            }
//        }
//        public T TakeOut()
//        {
//            if (num > 0)
//            {
//                return array[--num];
//            }
//            else
//            {
//                Console.WriteLine("cage is empty");
//                return default(T);
//            }
//        }
//    }
//    class Person
//    {

//    }
//    class Pro
//    {
//        static void Main(string[] args)
//        {
//            var dogCage = new Cage<Dog>(1);
//            dogCage.Putin(new Dog("A"));
//            dogCage.Putin(new Dog("B"));
//            var dog = dogCage.TakeOut();
//            dog.PrintName();


//            var catCage = new Cage<Cat>(2);
//            catCage.Putin(new Cat("A"));
//            catCage.Putin(new Cat("B"));
//            var cat = catCage.TakeOut();
//            var cat1 = catCage.TakeOut();
//            cat.PrintName();
//            cat1.PrintName();

//            var gaga = new Dog("hah");
//            gaga.PrintName();
//            gaga.isHappy<Person>(new Person());
//            gaga.isHappy<int>(3);
//        }
//    }
//}

#endregion


//using System;
//using System.IO;
//namespace PetShop

//{
//    //泛型接口
//    abstract public class Pet
//    {
//        protected string Name;
//        public Pet(string name)
//        {
//            Name = name;
//        }

//        public abstract void PrintName();

//    }

//    public class Dog : Pet
//    {
//        public Dog(string name) : base(name)
//        {
//        }
//        public override void PrintName()
//        {
//            Console.WriteLine("Dog's name is:" + Name);
//        }
//        public static Dog operator +(Dog male, Dog female)
//        {
//            return new Dog(male.Name + " and " + female.Name + "'s child");
//        }
//    }
//    public abstract class DogCmd
//    {
//        public abstract string GetCmd();
//    }
//    public class SitDogCmd : DogCmd
//    {
//        public override string GetCmd()
//        {
//            return "sit";
//        }
//    }
//    public class SpeakDogCmd : DogCmd
//    {
//        public override string GetCmd()
//        {
//            return "wangwang";
//        }
//    }
//    public interface IDogLearn<C> where C : DogCmd
//    {
//        void Act(C cmd);
//    }

//    public class labrador : Dog, IDogLearn<SitDogCmd>, IDogLearn<SpeakDogCmd>
//    {
//        public labrador(string name) : base(name)
//        {
//        }
//        public void Act(SitDogCmd cmd)
//        {
//            Console.WriteLine(cmd.GetCmd());
//        }
//        public void Act(SpeakDogCmd cmd)
//        {
//            Console.WriteLine(cmd.GetCmd());
//        }
//    }
//    class Pro
//    {
//        static void Main(string[] args)
//        {
//            //泛型接口实现简单学习各种指令
//            labrador dog = new labrador("A");
//            dog.Act(new SitDogCmd());
//            dog.Act(new SpeakDogCmd());
//        }
//    }
//}



//using System;
//using System.Collections.Generic;
//using System.IO;
//namespace PetShop

//{
//    //list
//    //ArrayList是类型不安全的，而且有装箱拆箱的性能问题。于是就出现了List<T>
//    abstract public class Pet
//    {
//        protected string Name;
//        public Pet(string name)
//        {
//            Name = name;
//        }

//        public abstract void PrintName();

//    }

//    public class Dog : Pet
//    {
//        public Dog(string name) : base(name)
//        {
//        }
//        public override void PrintName()
//        {
//            Console.WriteLine("Dog's name is:" + Name);
//        }
//        public static Dog operator +(Dog male, Dog female)
//        {
//            return new Dog(male.Name + " and " + female.Name + "'s child");
//        }
//    }
//    class Pro
//    {
//        static void Main(string[] args)
//        {
//            List<Dog> list = new List<Dog>();
//            list.Add(new Dog("A"));
//            list.Add(new Dog("B"));
//            list.Add(new Dog("C"));
//            list.RemoveAt(1);
//            for (int i = 0; i < list.Count; ++i)
//            {
//                list[i].PrintName();
//            }
//        }
//    }
//}


//using System;
//using System.Collections.Generic;
//using System.IO;
//namespace PetShop

//{
//    //dictionary字典
//    abstract public class Pet
//    {
//        protected string Name;
//        public Pet(string name)
//        {
//            Name = name;
//        }

//        public abstract void PrintName();

//    }

//    public class Dog : Pet
//    {
//        public Dog(string name) : base(name)
//        {
//        }
//        public override void PrintName()
//        {
//            Console.WriteLine("Dog's name is:" + Name);
//        }
//        public static Dog operator +(Dog male, Dog female)
//        {
//            return new Dog(male.Name + " and " + female.Name + "'s child");
//        }
//    }
//    class Pro
//    {
//        static void Main(string[] args)
//        {
//            Dictionary<string, Dog> dic = new Dictionary<string, Dog>();
//            dic.Add("A", new Dog("A"));
//            dic.Add("B", new Dog("B"));
//            dic.Add("C", new Dog("C"));
//            dic.Add("D", new Dog("D"));

//            dic["A"].PrintName();
//        }
//    }
//}



//using System;
//using System.Collections.Generic;
//using System.IO;
//namespace PetShop

//{
//    //Stack 栈   Queue队列
//    abstract public class Pet
//    {
//        protected string Name;
//        public Pet(string name)
//        {
//            Name = name;
//        }

//        public abstract void PrintName();

//    }

//    public class Dog : Pet
//    {
//        public Dog(string name) : base(name)
//        {
//        }
//        public override void PrintName()
//        {
//            Console.WriteLine("Dog's name is:" + Name);
//        }
//        public static Dog operator +(Dog male, Dog female)
//        {
//            return new Dog(male.Name + " and " + female.Name + "'s child");
//        }
//    }
//    class Pro
//    {
//        static void Main(string[] args)
//        {
//            Stack<Dog> god = new Stack<Dog>();
//            god.Push(new Dog("A"));
//            god.Push(new Dog("B"));
//            god.Push(new Dog("C"));
//            god.Push(new Dog("E"));
//            god.Peek().PrintName();//peek偷看一眼，不取只看
//            god.Pop().PrintName();
//            god.Pop().PrintName();

//            Console.WriteLine();

//            Queue<Dog> godd = new Queue<Dog>();
//            godd.Enqueue(new Dog("aa"));
//            godd.Enqueue(new Dog("bb"));
//            godd.Enqueue(new Dog("cc"));
//            Pet pet = godd.Dequeue();
//            pet.PrintName();
//            Pet pet1 = godd.Dequeue();
//            pet1.PrintName();
//            Pet pet2 = godd.Dequeue();
//            pet2.PrintName();
//        }
//    }
//}



#region delegate

//using System;
//using System.IO;
//using System.Threading;

//namespace PetShop

//{
//    //委托degelate
//    abstract public class Pet
//    {
//        protected string Name;
//        public Pet(string name)
//        {
//            Name = name;
//        }

//        public abstract void PrintName();

//    }

//    public class Dog : Pet
//    {
//        public Dog(string name) : base(name)
//        {
//        }
//        public override void PrintName()
//        {
//            Console.WriteLine("Dog's name is:" + Name);
//        }
//        public void WagTail()
//        {
//            Console.WriteLine(Name + "wag tail");
//        }
//    }

//    public class Cat : Pet
//    {
//        public Cat(string name) : base(name)
//        {

//        }
//        public override void PrintName()
//        {
//            Console.WriteLine("Cat's name is:" + Name);
//        }
//        public void InnocentLook()
//        {
//            Console.WriteLine(Name + "Innocent Look");
//        }
//    }
//    class Pro
//    {
//        //委托
//        delegate void ActCute();
//        static void Main(string[] args)
//        {
//            ActCute del = null;
//            ActCute del1 = null;
//            Dog dog = new Dog("haha");
//            Cat cat = new Cat("wawa");
//            //定义委托，吧所有的方法都加到委托上，一次性表达出来
//            del = dog.WagTail;
//            del += cat.InnocentLook;
//            //lambda表达式,匿名方法
//            del += () =>
//            {
//                Console.WriteLine("do nothing");
//            };
//            del -= cat.InnocentLook;
//            del();
//            Console.ReadKey();
//        }
//    }
//}

#endregion

#region event

//using System;
//namespace PetShop

//{
//    //事件：可以理解成一种封装的受限制的委托
//    abstract public class Pet
//    {
//        protected string Name;
//        public Pet(string name)
//        {
//            Name = name;
//        }

//        public abstract void PrintName();

//    }

//    public class Dog : Pet
//    {
//        public static int Num;
//        //事件和委托(订阅者和发布者)
//        public delegate void Handler();
//        //事件定义的时候NewDog为null
//        public static event Handler NewDog;
//        static Dog()
//        {
//            Num = 0;
//        }
//        public void PrintNum()
//        {
//            Console.WriteLine(Num) ;
//        }
//        public Dog(string name) : base(name)
//        {
//            ++Num;
//            //事件有人关注则不为空
//            if (NewDog != null)
//            {
//                NewDog();
//            }
//        }

//        public override void PrintName()
//        {
//            Console.WriteLine("Dog's name is:" + Name);
//        }
//        public void WagTail()
//        {
//            Console.WriteLine(Name + "wag tail");
//        }
//    }


//    class Client
//    {
//        private string value;


//        public void WantDog()
//        {
//            Console.WriteLine("Great,I want to see the new dog");
//        }
//    }
//    class Pro
//    {
//        static void Main(string[] args)
//        {
//            Client c1 = new Client();
//            Client c2 = new Client();
//            Dog.NewDog += c1.WantDog;
//            Dog.NewDog += c2.WantDog;

//            Dog dog = new Dog("Q");
//            dog.PrintNum();
//            Dog dog1 = new Dog("Q");
//            dog1.PrintNum();
//        }
//    }
//}

#endregion


//using System;

//namespace CalculatorApplication
//{
//    //阶乘测试
//    class NumberManipulator
//    {
//        public int factorial(int num)
//        {
//            /* 局部变量定义 */
//            int result;

//            if (num == 1)
//            {
//                return 1;
//            }
//            else
//            {
//                result = factorial(num - 1) * num;
//                return result;
//            }
//        }

//        static void Main(string[] args)
//        {
//            NumberManipulator n = new NumberManipulator();
//            //调用 factorial 方法
//            Console.WriteLine("6 的阶乘是： {0}", n.factorial(6));
//            Console.WriteLine("7 的阶乘是： {0}", n.factorial(7));
//            Console.WriteLine("8 的阶乘是： {0}", n.factorial(8));
//            Console.ReadLine();

//        }
//    }
//}




//using System;
//using System.Threading;

//public class Work
//{
//    public static void Main()
//    {
//        // Start a thread that calls a parameterized static method.
//        Thread newThread = new Thread(Work.DoWork);
//        newThread.Start(42);

//        // Start a thread that calls a parameterized instance method.
//        Work w = new Work();
//        newThread = new Thread(w.DoMoreWork);
//        newThread.Start("The answer.");
//    }

//    public static void DoWork(object data)
//    {
//        Console.WriteLine("Static thread procedure. Data='{0}'",
//            data);
//    }

//    public void DoMoreWork(object data)
//    {
//        Console.WriteLine("Instance thread procedure. Data='{0}'",
//            data);
//    }
//}
//// This example displays output like the following:
////       Static thread procedure. Data='42'
////       Instance thread procedure. Data='The answer.'



////线程
//using System;
//using System.Threading;

//public class Work
//{
//    static void Main(string[] args)
//    {
//        Thread oGetArgThread = new Thread(new ThreadStart(Test));
//        //oGetArgThread.IsBackground = true;
//        oGetArgThread.Start();
//        oGetArgThread.Priority = ThreadPriority.Highest;

//        for (var i = 0; i < 100; i++)
//        {
//            Console.WriteLine("主线程计数" + i);
//            Thread.Sleep(2000);
//        }
//    }

//    private static void Test()
//    {
//        for (var i = 0; i < 100; i++)
//        {
//            Console.WriteLine("后台线程计数" + i);
//            Thread.Sleep(300);
//        }
//    }
//}


////连线程会油系统分配轮番进行，但是用了join，正在进行的thread阻塞，join进来的thread执行完成
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;

//namespace Test
//{
//    class TestThread
//    {
//        private static void ThreadFuncOne()
//        {
//            for (int i = 0; i < 10; i++)
//            {
//                Console.WriteLine(Thread.CurrentThread.Name + "   i =  " + i);
//            }
//            Console.WriteLine(Thread.CurrentThread.Name + " has finished");
//        }

//        static void Main(string[] args)
//        {
//            Thread.CurrentThread.Name = "MainThread";
//            //Thread.CurrentThread.IsBackground = true;
//            Thread newThread = new Thread(new ThreadStart(TestThread.ThreadFuncOne));
//            newThread.Name = "NewThread";

//            for (int j = 0; j < 20; j++)
//            {
//                if (j == 10)
//                {
//                    Thread.Sleep(1000);
//                    newThread.Start();
//                    //newThread.Join();
//                }
//                else
//                {
//                    Console.WriteLine(Thread.CurrentThread.Name + "   j =  " + j);
//                }
//            }
//            Console.Read();
//        }
//    }
//}



////枚举和结构
//using static System.Console;
//using static System.Convert;

//namespace test
//{
//    enum Orientation : byte
//    {
//        north = 1,
//        south = 2,
//        east = 3,
//        west = 4,

//    }
//    struct Route
//    {
//        public Orientation direction;
//        public double distance;
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Route mroute;
//            byte mdirection = 9;
//            double mdistance;
//            WriteLine("1)\tnorth\n2)\tsouth\n3)\teast\n4)\twest\n");

//            do
//            {
//                WriteLine("select a direction use the numbe:");
//                mdirection = ToByte(ReadLine());
//            } while (mdirection > 4 && mdirection < 1);

//            WriteLine("please input the distance");
//            mdistance = ToDouble( ReadLine());
//            mroute.distance = mdistance;
//            mroute.direction = (Orientation)mdirection;
//            WriteLine("about {0} at the {1} direction", mroute.distance, mroute.direction);
//            ReadKey();
//        }
//    }




////params参数
//using static System.Console;
//namespace test{
//    class program
//    {
//        static int plus(params int[] a)
//        {
//            int sum = 0;
//            foreach(int aa in a)
//            {
//                sum += aa;
//            }
//            return sum;
//        }
//        static void Main(string[] args)
//        {
//            WriteLine(plus(1, 2, 5, 1, 3, 5));
//            string a = "haha";
//            WriteLine(a.Length);
//            WriteLine(sizeof(int));

//        }
//    }
//}


////定时器  未执行，待研究
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;

//namespace Test
//{
//    class TestThread
//    {
//        static void Main(string[] args)
//        {
//            System.Timers.Timer t = new System.Timers.Timer(1000);//实例化Timer类，设置间隔时间为10000毫秒；
//            t.Elapsed += new System.Timers.ElapsedEventHandler(theout);//到达时间的时候执行事件；
//            t.AutoReset = true;//设置是执行一次（false）还是一直执行(true)；
//            t.Enabled = true;//是否执行System.Timers.Timer.Elapsed事件；
//        }
//        public static void theout(object source, System.Timers.ElapsedEventArgs e)
//        {
//            Console.WriteLine("OK!");
//        }

//    }
//}

//字典排序
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace ConsoleApplication1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            Dictionary<int, string> test = new Dictionary<int, string> { };
//            test.Add(0, "000");
//            test.Add(4, "444");
//            test.Add(2, "222");
//            test.Add(6, "666");
//            test.Remove(6);
//            test.Add(6, "777");


//            Dictionary<int, string> test1 = new Dictionary<int, string> { };

//            foreach (KeyValuePair<int, string> k in test)
//            {
//                if (test1.ContainsKey(k.Key))
//                {
//                    Console.WriteLine("you" + k.Value);
//                }
//                else {
//                    Console.WriteLine("wu" );

//                }
//            }



//            Dictionary<int, string> dic1Asc = test.OrderBy(o => o.Key).ToDictionary(o => o.Key, p => p.Value);


//            Console.WriteLine("小到大排序");
//            foreach (KeyValuePair<int, string> k in dic1Asc)
//            {
//                Console.WriteLine("key:" + k.Key + " value:" + k.Value);
//            }

//            Console.WriteLine("大到小排序");
//            Dictionary<int, string> dic1desc = test.OrderByDescending(o => o.Key).ToDictionary(o => o.Key, p => p.Value);

//            foreach (KeyValuePair<int, string> k in dic1desc)
//            {
//                Console.WriteLine("key:" + k.Key + " value:" + k.Value);
//            }


//            while (true) ;

//            //DateTime now = DateTime.Now;

//            //byte[] bts = BitConverter.GetBytes(now.ToBinary());
//            //DateTime rt = DateTime.FromBinary(BitConverter.ToInt64(bts, 0));
//            //for(int i = 0; i <= bts.Length-1; i++)
//            //{
//            //    Console.WriteLine(bts[i]);

//            //}
//            //Console.WriteLine(bts.Length);
//            //Console.WriteLine(rt);

//        }
//    }
//}



