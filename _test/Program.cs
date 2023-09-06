using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //int haha = Add(1, 2, 3);
            //string[] aa = {"haha","biterror","aa","ww","bit error" };
            //int a = aa.ToList().IndexOf("bit error");




            //int aq = int.MaxValue;
            //int re = 30;
            //byte[] date = BitConverter.GetBytes(re);
            //int haha = date.Length;
            //Array.Reverse(date);

            //int a = System.BitConverter.ToInt32(date,0);


            //string deviceType, val;
            //val = RunAisgDeviceScan(out deviceType);
            //uint max = uint.MaxValue;//4294967295

            ////string responsePower = "-54.581 -106.330  -54.730 -106.330  -54.864 -106.330  -54.875 -106.330  -55.501 -106.330  -55.406 -106.330";
            //var responsePower = new List<double>(){ 1,2};
            //var result = responsePower.Skip(2).Take(2);

            ////var powers = Regex.Matches(responsePower, @"[\-\d.]+").Select(m => double.Parse(m.Value));



            //string deviceType, val;
            //val = RunAisgDeviceScan(out deviceType);
            //uint max = uint.MaxValue;//4294967295

            ////Func<int, int> square = x => x * x;
            //Func<int, int> square = x => x * x;
            //int result = square(5); // 使用 Lambda 表达式计算 5 的平方，结果为 25

            //var numbers = new List<int> { 1, 2, 3, 4, 5 };
            //var evenNumbers = numbers.Where(x => x % 2 == 0);
            //foreach (var number in evenNumbers)
            //{
            //Console.WriteLine(number);

            //}

            //Action<string> printMessage = message => Console.WriteLine(message);
            //printMessage("Hello, Lambda!"); // 输出：Hello, Lambda!

            string[] names = { "Alice", "Bob", "Charlie", "David" };
            var result = from name in names
                         where name.Contains("a")
                         select name;

            var result1 = names.Where(x => x.ToLower().Contains("av"));
            foreach ( var result2 in result1)
            {
                Console.WriteLine(result2);
            }


            string from = "60";
            from.Replace(newChar: ((num % intValue3 == 0) ? (num % intValue3 + intValue3) : (num % intValue3)).ToString()[0], oldChar: from[0]);
            Console.WriteLine(from);

            Console.WriteLine(string.Compare("haha", "hahA", ignoreCase: false));
        }



        static string value;
        private static int num = 6;
        private static int intValue3 = 4;

        public static string RunAisgDeviceScan(out string deviceType)
        {
            GetStatus(out deviceType, out value);
            return value;
        }

        private static void GetStatus(out string deviceType, out string statusValues)
        {
            GetStatus1(out deviceType, out statusValues);
        }

        private static void GetStatus1(out string deviceType, out string statusValues)
        {
            deviceType = "hello";
            statusValues = "world";
        }

        public static int Add(int a,int b,int c)
        {

            return a+b;
        }
    }
}
