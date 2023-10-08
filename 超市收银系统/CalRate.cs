using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市收银系统
{

    /// <summary>
    /// 按折扣率打折
    /// </summary>
    class CalRate : CalFather
    {
        public override double GetTotalMoney(double realMoney)
        {
            return realMoney * this.Rate;
        }
        public CalRate(double rate)
        {
            this.Rate = rate;
        }

        public double Rate
        {
            get;
            set;
        }
    }
   
}
