using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnInterface
{
    class CLen:IConvert
    {
        private double mult = 2.54;     //linch=2.54 cm
        public double Mult              //實作倍率屬性
        {
            get { return mult; }
            set { mult = value; }
        }

        /// <summary>
        /// 實作 Convert()方法
        /// </summary>
        /// <param name="inch"></param>
        public void Convert(double inch)
        {
            double cm = inch * Mult;
            Console.WriteLine("英制單位 {0}吋 =公制單位 {1}公分",inch,cm.ToString("#.##"));
        }
    }
}
