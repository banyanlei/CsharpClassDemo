using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _file
{
    class Program
    {
        static void Main(string[] args)
        {
            //file类一下子全加载了，只能读小文件
            //ReadAllLines和ReadAllText只能读文本文件，精确每行操作则ReadAllLines

            //byte[] buffer = File.ReadAllBytes(@"C:\CAYA\cy\bili\bili\bin\Debug\youdao.xml");
            ////将字节数组中的每一个元素都按照我们指定的编码格式解码成字符串
            ////UTF-8 GB2312 UNICODE
            //foreach(byte a in buffer)
            //{
            //    Console.WriteLine(a);
            //}
            ////有个汉字占三位，有个英文字母一位
            ////string s = Encoding.GetEncoding("UTF-8").GetString(buffer);
            //string s = Encoding.UTF8.GetString(buffer);
            //Console.WriteLine(s);


            //string str = "今天天气真好";
            //byte[] buffer = Encoding.Default.GetBytes(str);
            //File.WriteAllBytes(@"youdao.xml", buffer);
            //Console.WriteLine("写入成功");

            //string[] contents = File.ReadAllLines(@"youdao.xml",Encoding.Default);
            //foreach (string item in contents)
            //{
            //    Console.WriteLine(item);
            //}

            //string str = File.ReadAllText(@"youdao.xml", Encoding.Default);
            //Console.WriteLine(str);

            //File.WriteAllLines("youdao.txt", new string[] { "hello", "world" });
            //Console.WriteLine("ok");

            File.AppendAllText("youdao.txt", @"加一行");
            Console.WriteLine("ok");

        }
    }
}
