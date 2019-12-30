using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 一個實作應用在兩個 interface 上
/// 如果類別實作了兩個介面包含相同名稱之方法，
/// 則在類別上實作該方法會導致兩個介面都將該方法當做實作(Implementation) 使用。
/// </summary>
namespace Ex_interface_04
{
    class Program
    {
        static void Main(string[] args)
        {
            SampleClass sc = new SampleClass();
            IControl ctrl = (IControl)sc;
            Isurface srfc = (Isurface)sc;

            sc.Paint();
            ctrl.Paint();
            srfc.Paint();
            Console.Read();
        }
    }

    interface IControl
    {
        void Paint();
    }
    interface Isurface
    {
        void Paint();
    }
    class SampleClass:IControl,Isurface
    {
        public void Paint()
        {
            Console.WriteLine("Paint method in SampleClass");
        }
    }
}
