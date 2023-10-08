using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _out
{
    class Program
    {

        /// <summary>
        /// 如果在一个方法中，返回多个相同类型的值的时候，可以返回一个数组。
        /// 但是，如果返回多个不同类型的值的时候，返回数组不行了，就可以考虑使用out。
        /// out侧重于在一个方法中返回多个不同类型的值。
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int max1;
            int min1;
            int sum1;
            int avg1;
            bool b;
            string s;
            double d;
            Test(numbers, out max1, out min1, out sum1, out avg1, out b, out s, out d);

            Console.WriteLine(max1);
            Console.WriteLine(min1);
            Console.WriteLine(sum1);
            Console.WriteLine(avg1);
            Console.WriteLine(b);
            Console.WriteLine(s);
            Console.WriteLine(d);
        }

        private static void Test(int[] nums, out int max, out int min, out int sum, out int avg, out bool b,out string s,out double d)
        {
            max = nums[0];
            min = nums[0];
            sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                { max = nums[i]; }
                if (nums[i] < min)
                { min = nums[i]; }
                sum += nums[i];
            }
            avg = sum / nums.Length;
            b= true;
            s = "124";
            d = 3.12;

        }
    }
}
