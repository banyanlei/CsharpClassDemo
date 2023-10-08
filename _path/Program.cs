using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _path
{
    class Program
    {
        static void Main(string[] args)
        {

            string str = @"G:\刷图\搞笑图资源\图片\盗.jpg";
            Console.WriteLine(Path.GetFileName(str));
            Console.WriteLine(Path.GetFileNameWithoutExtension(str));
            Console.WriteLine(Path.GetExtension(str));
            Console.WriteLine(Path.GetDirectoryName(str));
            Console.WriteLine(Path.GetFullPath(str));
            Console.WriteLine(Path.Combine(@"c:\a\","c.txt"));
            
            //int index = str.LastIndexOf("\\");//@"\"
            //str = str.Substring(index + 1);
            //Console.WriteLine(str);
        }
    }
}
