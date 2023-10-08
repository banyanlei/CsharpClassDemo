using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MD5加密
{
    class Program
    {
        static void Main(string[] args)
        {
            //202cb962ac59075b964b07152d234b70 123
            //202cb962ac5975b964b7152d234b70
            //202cb962ac59075b964b07152d234b70
            string s = GetMD5("123");
            Console.WriteLine(s) ;
        }

        public static string GetMD5(string str)
        {
            MD5 md5 = MD5.Create();
            byte[] buffer = Encoding.Default.GetBytes(str);
            byte[]  MD5Buffer = md5.ComputeHash(buffer);

            //将字节数组按照指定的编码格式解析成字符串
            //return Encoding.Default.GetString(MD5Buffer);

            //将字节数组的每一个元素toString()
            string strNew = null;
            for (int i = 0; i < MD5Buffer.Length; i++)
            {
                strNew += MD5Buffer[i].ToString("x2");//x:16进制 2：0x0A若没2就输出0xA
            }
            return strNew;
        }
    }
}
