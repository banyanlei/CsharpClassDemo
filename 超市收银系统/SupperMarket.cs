using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市收银系统
{
    class SupperMarket
    {
        CangKu ck = new CangKu();

        public SupperMarket()
        {
            ck.JinPros("Acer", 1000);
            ck.JinPros("Samsung", 1000);
            ck.JinPros("JiangYou", 1000);
            ck.JinPros("Banana", 1000);
        }

        public void AskBuying()
        {
            Console.WriteLine("欢迎光临，请问您需要什么");
            Console.WriteLine("我们有Acer,Samsung,JiangYou,Banana");
            string strType = Console.ReadLine();
            Console.WriteLine("您需要多少");
            int count = Convert.ToInt32(Console.ReadLine());
            //去仓库取货
            ProductFather[] pros = ck.QuPros(strType, count);
            //计算价钱、
            double realMoney = GetMoney(pros);
            Console.WriteLine("您总共应付"+realMoney+"元");
            Console.WriteLine("请选择您的打着方式：1--不打折 2--打九折 3--打85折 4--买300送50 5--买500送100");
            string input = Console.ReadLine();
            //通过简单工厂设计模式根据用户的选择获得一个打折对象
            CalFather cal = GetCal(input);
            double totalMoney = cal.GetTotalMoney(realMoney);
            Console.WriteLine("打完折后，您应付{0}元",totalMoney);
            Console.WriteLine("以下是你的购物信息");
            foreach (var item in pros)
            {
                Console.WriteLine("货物名称：{0}\t货物单价：{1}\t货物编号：{2}",item.Name, item.Price, item.ID); ;
            }
        }


        /// <summary>
        /// 根据用户的选择打着方式返回一个打折对象
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public CalFather GetCal(string input)
        {
            CalFather cal = null;
            switch (input)
            {
                case "1": cal = new CalNormal();
                    break;
                case "2": cal = new CalRate(0.9);
                    break;
                case "3": cal = new CalRate(0.85);
                    break;
                case "4": cal = new CalMN(300,50);
                    break;
                case "5": cal = new CalMN(500,100);
                    break;
            }
            return cal;
        }
        public double GetMoney(ProductFather[] pros)
        {
            double realMoney = 0;
            for (int i = 0; i < pros.Length; i++)
            {
                realMoney += pros[i].Price;
            }
            return realMoney;
        }

        public void ShowPros()
        {
            ck.ShowPors();
        }
    }
}
