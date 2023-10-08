using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _filestream
{
    class Program
    {
        static void Main(string[] args)
        {
            //FileStream File 的区别相当于倒一桶水和用勺舀水
            //1.FileStream 操作字节的-任何类型文件

            //FileStream fsRead = new FileStream("youdao.txt", FileMode.OpenOrCreate, FileAccess.Read); 
            //byte[] buffer = new byte[1024 * 1024 * 5];
            //int r = fsRead.Read(buffer, 0, buffer.Length);
            //string s = Encoding.UTF8.GetString(buffer, 0, r);
            //fsRead.Close();//关闭流
            //fsRead.Dispose();//释放占用的资源
            //Console.WriteLine(s);
            //Console.WriteLine(r);

            //将创建的文件流对象的过程写在using当中，会自动帮我们释放流所占用的资源
            //using (FileStream fsWrite = new FileStream("youdao.xml", FileMode.OpenOrCreate, FileAccess.Write))
            //{
            //    string str = "看我的";
            //    byte[] buffer = Encoding.UTF8.GetBytes(str);
            //    fsWrite.Write(buffer,0,buffer.Length);
            //}



            string source = @"C:\Users\caya\Desktop\射频和无线技术入门（第二版）.pdf";
            string target = @"C:\Users\caya\Desktop\射频和无线技术入门（第三版）.pdf";
            copy(source, target);
            //File.Copy(source,target);


        }
        public static void copy(string source, string target)
        {
            using (FileStream fsRead = new FileStream(source, FileMode.OpenOrCreate, FileAccess.Read))
            {
                using (FileStream fsWrite = new FileStream(target, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    byte[] buffer = new byte[1024 * 1024 * 5];
                    int r;
                    while (true)
                    {
                        r = fsRead.Read(buffer, 0, buffer.Length);
                        if (r == 0)
                        {
                            break;
                        }
                        fsWrite.Write(buffer, 0, r);
                    }
                    Console.WriteLine("完成");
                }
            }
        }
    }
}
