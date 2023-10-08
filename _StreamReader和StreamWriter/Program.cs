using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _StreamReader和StreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.StreamReader和StreamWriter 操作字符的-文本文件，小文件几百k用file

            //using (StreamReader sr = new StreamReader("youdao.xml",Encoding.Default))
            //{
            //    while (!sr.EndOfStream)
            //    {
            //        Console.WriteLine(sr.ReadLine());

            //    }

            //}

            using (StreamWriter sw = new StreamWriter("youdao.xml",true))
            {
                    sw.WriteLine("hahah");

            }
        }
    }
}
