using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入英制長度(吋): ");
            double len = float.Parse(Console.ReadLine());
            Console.WriteLine();
            CLen lenght = new CLen();      //本行亦可改寫成 IConvert lenght=new CLen();
            lenght.Convert(len);
            Console.Read();
        }
    }
}
