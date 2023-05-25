//当我们需要从一个集合中选择一些特定的元素，或者对集合中的元素进行过滤、排序、分组等操作时，可以使用 Language Integrated Query (LINQ)。LINQ 可以用于各种数据源，如数组、列表、集合、数据库等，通过一个统一的查询语法来对它们进行操作。

//LINQ 中的查询语句通常由一些操作符和关键字组成，这些操作符和关键字可以分为以下几类：

//用于从数据源中选择元素的操作符，如 Select、Where、Take、Skip 等。
//用于对数据源中的元素进行排序的操作符，如 OrderBy、OrderByDescending、ThenBy、ThenByDescending 等。
//用于对数据源中的元素进行分组的操作符，如 GroupBy。
//用于对数据源中的元素进行聚合操作的操作符，如 Sum、Max、Min、Average、Count 等。
//用于对数据源中的元素进行连接操作的操作符，如 Join、GroupJoin、Union、Intersect、Except 等。

//Linq defer and exhaust


#region Where
//Where 操作符用于从数据源中筛选出满足指定条件的元素。它接受一个 Lambda 表达式作为参数，该 Lambda 表达式返回一个布尔值，表示元素是否满足指定条件。

//int[] numbers = { 1, 2, 3, 4, 5 };
//var result = numbers.Where(x => x % 2 == 0);
//foreach (var item in result)
//{
//	Console.WriteLine(item);

//}

#endregion

#region Select
//Select 操作符用于对数据源中的每个元素进行投影操作，将其转换为新的类型或格式。它接受一个 Lambda 表达式作为参数，该 Lambda 表达式返回一个新的值，表示对元素的投影操作。KC

using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;

//string[] names = { "Alice", "Bob", "Charlie" };
//var result1 = names.Select(x => x.ToUpper().Replace('E', 'o'));
//foreach (var item in result1)
//{
//    Console.WriteLine(item);

//}

#endregion

#region OrderBy

//OrderBy 是 LINQ 中的一个操作符，用于对集合中的元素进行排序。它可以按照升序或降序排列元素。常见的用法是使用一个 lambda 表达式来指定排序规则。

//下面是一个使用 OrderBy 对数字集合进行升序排序的示例代码：

//var numbers = new List<int> { 5, 3, 8, 1, 9 };
////var sortedNumbers = numbers.OrderBy(x => x);
//var sortedNumbers = numbers.OrderByDescending(x => x);
//foreach (var item in sortedNumbers)
//{
//    Console.WriteLine(item);

//}

//var names = new List<string> { "John", "Alice", "Bob", "Peter", "Mary" };
//var sortedNames = names.OrderBy(name => name.Length, new StringLengthComparer());



#endregion

#region Take

//Take 是 LINQ 中的一个操作符，用于从集合中获取指定数量的元素。它可以用于分页、限制结果集大小等场景。

//Take 操作符需要接收一个整数参数，指定要获取的元素数量。它返回一个新的集合，其中包含原始集合中前 N 个元素。

//下面是一个使用 Take 从数字集合中获取前三个元素的示例代码：

//var numbers = new List<int> { 5, 3, 8, 1, 9 };
//var firstThreeNumbers = numbers.Take(3);
//foreach (var item in firstThreeNumbers)
//{
//    Console.WriteLine(item);

//}


#endregion

#region Skip

//var persons = new List<Person> { ... };
//var pageSize = 10;
//var pageIndex = 2;
//var page = persons.OrderBy(p => p.LastName).Skip(pageSize * pageIndex).Take(pageSize);
//int[] grades = { 59, 82, 70, 56, 92, 98, 85 };

//Console.WriteLine("All grades except the first three:");
//foreach (int grade in grades.Skip(3))
//{
//    Console.WriteLine(grade);
//}

/*
 This code produces the following output:

All grades except the first three:
 56
 92
 98
 85
*/
#endregion

#region InterSection

//first
//IEnumerable<TSource>
//一个 IEnumerable<T>，将返回其也出现在 second 中的非重复元素。

//second
//IEnumerable<TSource>
//一个 IEnumerable<T> 序列，其中的同时出现在第一个序列中的非重复元素将被返回。

//var arr1 = new int[] { 1, 2, 3, 4, 5, 6 };
//var arr2 = new int[] { 5, 6, 4, 5, 5, 7, 8 };
//var arr3 = arr1.Intersect(arr2);
//var arr4 = arr2.Intersect(arr1);
//foreach (var item in arr4)
//{
//    Console.WriteLine(item);

//}



#endregion

#region Groupby
////lambda express & query express

//var rnd = new Random(2);
//var arr = Enumerable.Range(0,200).Select(a=>rnd.Next(50)) ;
////var res = arr.GroupBy(x => x).Select(g => new { g.Key, Count = g.Count() }).OrderBy(g=> g.Key);
////foreach (var item in res)
////{
////    Console.WriteLine("Key="+item.Key + "\tTotal:" + item.Count);

////}

//var res = arr.GroupBy(x => x).OrderBy(x=> x.Key).ToDictionary(x => x.Key, x => x.Count());
//foreach (var item in res)
//{
//    Console.WriteLine(item.Key + "\t" + item.Value);

//}

////var res =
////    from x in arr
////    group x by x into g
////    select new { g.Key, count = g.Count() };
////foreach (var item in res)
////{
////    Console.WriteLine(item.Key + "\t" + item.count);

////}

#endregion

#region Range
// Generate a sequence of integers from 1 to 10
// and then select their squares.
//IEnumerable<int> squares = Enumerable.Range(1, 10).Select(x => x * x);

//foreach (int num in squares)
//{
//    Console.WriteLine(num);
//}

/*
 This code produces the following output:

 1
 4
 9
 16
 25
 36
 49
 64
 81
 100
*/
#endregion

#region zip
//int[] numbers = { 1, 2, 3, 4 };
//string[] words = { "one", "two", "three" };

//var numbersAndWords = numbers.Zip(words, (first, second) => first + " " + second);

//foreach (var item in numbersAndWords)
//    Console.WriteLine(item);

// This code produces the following output:

// 1 one
// 2 two
// 3 three
#endregion

#region torpm R5A

//List<int> branchs = new List<int>() { 1,2 };
//Dictionary<int, List<double>> wawa = new Dictionary<int, List<double>>();

//for (int i = 0; i < 3; i++)
//{
//    //string responsePower = DutCommunication.SendReceive($"torpm {DutHelper.ConvertBranchesToEtswString(branches)} {samples}");
//    var responsePower = "1 2 3 4";
//    var powers = Regex.Matches(responsePower, @"[\-\d.]+").Select(m => double.Parse(m.Value, CultureInfo.InvariantCulture));

//    if (powers.Count() == branchs.Count() * 2)
//    {
//        //Select里的i和循环里的没有关系，i是Range的start:0 开始
//        var powerPerBranch = Enumerable.Range(0, branchs.Count()).Select(i => new List<double>(powers.Skip(i * 2).Take(2)));
//        wawa = branchs.Zip(powerPerBranch).ToDictionary(x => x.First, x => x.Second);
//        int a;
//    }
//}

#endregion

#region torpm R4A
//List<int> branches = new List<int>() { 1 };
//Dictionary<int, List<double>> wawa = new Dictionary<int, List<double>>();
//Dictionary<int, List<double>> branchPowers = new Dictionary<int, List<double>>();

//for (int i = 0; i < 3; i++)
//{
//    string answer = "-18.234 -18.233";
//    answer = answer.Replace("  ", " ");
//    List<string> answerList = new List<string>(answer.Split(' '));
//    if (answerList.Count != branches.Count * 2)
//        throw new AmbiguousMatchException($"Number of result list: {answerList.Count} need to be equal with branches count: {branches.Count} * 2");
//    //Split values into one list for each branch
//    List<double> tempValues = new List<double>();
//    foreach (string value in answerList)
//    {
//        tempValues.Add(Convert.ToDouble(value, CultureInfo.InvariantCulture));
//        if (answerList.IndexOf(value) % 2 != 0)
//        {
//            branchPowers.Add(branches[answerList.IndexOf(value) / 2], tempValues);
//            tempValues = new List<double>();
//        }
//    }

//    if (branchPowers.Count != 0)
//        break;
//}

//int a;

#endregion

#region Asparallel

//var arr = Enumerable
//    .Range(0, 10)
//    .AsParallel()   //多线程操作
//    .AsOrdered()    //保持顺序
//    .Select(i =>
//{
//    Thread.Sleep(500);
//    return i * i;
//})
//    .AsSequential() //把Converts a System.Linq.ParallelQuery`1 into an System.Collections.Generic.IEnumerable`1
//    ;
//foreach (var item in arr)
//    Console.WriteLine(item);
#endregion

#region SelectMany
//展平
var mat = new int[][] {
    new[]{1,2,3,4},
    new[]{5,6,7,8},
    new[]{9,10,11,12},
};
//var arr = 
//        from row in mat
//        from col in row 
//        select col;
var arr = mat.SelectMany(x => x);

foreach (var item in arr)
    Console.WriteLine(item);
#endregion