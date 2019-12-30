using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 若想為多重的實作提供雷同的操作或功能，可以使用介面實作多型。
/// </summary>
namespace Ex_interface_05
{
    interface IExchange
    {
        double Rate { get; }    //匯率屬性
        void Convert();         //作為外幣兌換成台幣的方法原型
    }
    //-----------------------
    class UStoNT:IExchange
    {
        public double Rate      //實作 IExchange 介面屬性
        {
            get { return 29.9; }
        }        

        void IExchange.Convert()    //實作 IExchange 介面方法
        {
            Console.WriteLine("請輸入要兌換的美元： ");
            double USd = float.Parse(Console.ReadLine());
            double NTd = USd * Rate;
            Console.WriteLine("美元 {0}元，可兌換台幣 {1}元", USd, NTd.ToString("#.#"));
        }
    }

    class JPtoNT : IExchange
    {
        public double Rate
        { get { return 0.375; } }

        public void Convert()
        {
            Console.Write("請輸入要兌換的日幣： ");
            double JPd = float.Parse(Console.ReadLine());
            double NTd = JPd * Rate;
            Console.WriteLine("日幣 {0}元,可兌換台幣 {1}元", JPd, NTd.ToString("#.#"));
        }
    }
    //-----------------------------------
    class Program
    {
        static void Main(string[] args)
        {
            IExchange change;   // 建立屬於 IExchange 介面物件 change(不用 new)
            UStoNT cashUS = new UStoNT();   //建立屬於 UStoNT 類別的物件 cashUS 實體
            JPtoNT cashJP = new JPtoNT();
            while(true)
            {
                Console.WriteLine("選擇要兌換台幣的外幣？(1.美元 2.日幣 3.離開): ");
                int item = int.Parse(Console.ReadLine());
                if(item==1)
                {
                    // change 介面物件指到 cashUS 物件位址
                    change = cashUS;
                }
                else if(item==2)
                {
                    change = cashJP; // change 介面物件指到 cashJP 物件位址
                }
                else
                {
                    break;
                }

                //進行動態繫結 csahUS.Convert() 或 cashJP.Convert() 這叫多型
                change.Convert();
            }
            Console.Read();
        }
    }
}
