using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象
{
    class Program
    {
        static void Main(string[] args)
        {
            //如果父类中的方法有默认实现，并且父类需要被实例化，可以将父类定义成普通类，用虚方法实现多台
            //如果父类中的方法没有默认实现，父类也不需要被实例化，则可以将父类定义为抽象类

            //当父类中的方法不知道如何实现时，可以将父类写成抽象类，方法写成抽象方法
            //抽象类不能被实例化
            //抽象成员必须在抽象类中
            //子类必须实现抽象方法，签名（参数和返回值）必须和父类的一致
            //抽象类中可包含实例成员，子类可不实现它
            //子类也是抽象类的话，不必须实现抽象成员
            Animal[] a = { new Dog(),new Cat() };
            foreach (Animal item in a)
            {
                item.Bark();
                
            }
        }
        public abstract class Animal
        {

            private int _age;
            public Animal(int age)
            {
                this.Age = age;
            }
            public Animal() { }
            public abstract void Bark();//抽象方法没有方法体；有方法体没内容叫空实现
            public abstract string Name
            {
                get;
                set;
            }
            public int Age { get => _age; set => _age = value; }
        }
        public class Dog : Animal
        {
            public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public override void Bark()
            {
                Console.WriteLine("狗狗旺旺叫");
            }
        }  
        public class Cat : Animal
        {
            public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public override void Bark()
            {
                Console.WriteLine("猫咪喵喵叫");
            }
        }

        //子类也是抽象类的话，不必须实现抽象成员
        public abstract class Test : Animal
        {

        }
    }
}
