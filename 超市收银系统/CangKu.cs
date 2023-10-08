using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市收银系统
{
    class CangKu
    {
        List<List<ProductFather>> list = new List<List<ProductFather>>();

        /// <summary>
        /// 向用户展示货物
        /// </summary>
        public void ShowPors()
        {
            foreach (var item in list)
            {
                Console.WriteLine("我们仓库有：" + item[0].Name + "," + "\t" + "有" + item.Count + "个," + "\t" + "每个" + item[0].Price + "元" ); ;
            }
        }

        /// <summary>
        /// 在创建仓库的时候，向仓库中添加货架
        /// </summary>
        public CangKu()
        {
            list.Add(new List<ProductFather>());
            list.Add(new List<ProductFather>());
            list.Add(new List<ProductFather>());
            list.Add(new List<ProductFather>());
        }
        /// <summary>
        /// 进货
        /// </summary>
        /// <param name="strType">货物的类型</param>
        /// <param name="count">货物的数量</param>
        public  void JinPros(string strType, int count)
        {
            for (int i = 0; i < count; i++)
            {
                switch (strType)
                {
                    case "Acer": list[0].Add(new Acer(Guid.NewGuid().ToString(), 1000, "宏基笔记本"));
                        break; 
                    case "Samsung": list[1].Add(new Samsung(Guid.NewGuid().ToString(), 2000, "三星笔记本"));
                        break;
                    case "JiangYou": list[2].Add(new JiangYou(Guid.NewGuid().ToString(), 10, "酱油"));
                        break;
                    case "Banana": list[3].Add(new Banana(Guid.NewGuid().ToString(), 2, "香蕉"));
                        break;

                }
            }
        }
        /// <summary>
        /// 取货
        /// </summary>
        /// <param name="strType"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public ProductFather[] QuPros(string strType, int count)
        {
            ProductFather[] pros = new ProductFather[count];
            for (int i = 0; i < count; i++)
            {
                switch (strType)
                {
                    case "Acer": pros[i] = list[0][0];
                        list[0].RemoveAt(0);
                        break;
                    case "Samsung": pros[i] = list[1][0];
                        list[1].RemoveAt(0);
                        break;
                    case "JiangYou": pros[i] = list[2][0];
                        list[2].RemoveAt(0);
                        break;
                    case "Banana": pros[i] = list[3][0];
                        list[3].RemoveAt(0);
                        break;
                }
            }
            return pros;
        }
    }
}
