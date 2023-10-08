using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市收银系统
{

    abstract class CalFather
    {
      /// <summary>
      /// 计算打折后应付的多少钱
      /// </summary>
      /// <param name="realMoney">打着前应付的价钱</param>
      /// <returns>打折后的价钱</returns>
        public abstract double GetTotalMoney(double realMoney);
    }

}
