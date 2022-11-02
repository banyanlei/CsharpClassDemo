using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Test_Net5._0
{
    internal class BranchConfig { }
    internal class Program
    {
        static void Main(string[] args)
        {

            //IEnumerable<BranchConfig> branchesWithEnoughGain;
            ////string responsePower = "-54.581 -106.330  -54.730 -106.330  -54.864 -106.330  -54.875 -106.330";
            //string responsePower = "-54.581 -106.330  -54.730 -106.330";
            //var powers = Regex.Matches(responsePower, @"[\-\d.]+").Select(m => double.Parse(m.Value));
            //var powerPerBranch = Enumerable.Range(0, 2).Select(i => powers.Skip(i * 2).Take(2));
            ////var notConverged = branchesWithEnoughGain.Zip(powerPerBranch).Where(x => x.Second.Min() < -40 ||
            ////                                                                                x.Second.Max() - x.Second.Min() > 0.2)
            ////           .Select(x => x.First);

            int[] numbers = { 1, 2, 3, 4 };
            string[] words = { "one", "two", "three" };

            var numbersAndWords = numbers.Zip(words, (first, second) => first + " " + second);

            bool flag = numbersAndWords.Any(); 

            foreach (var item in numbersAndWords)
                Console.WriteLine(item);

            // This code produces the following output:

            // 1 one
            // 2 two
            // 3 three


            Console.WriteLine("Hello World!");
        }
    }
}
