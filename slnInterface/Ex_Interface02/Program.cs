using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Interface02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入學期成續：");
            int keyin = int.Parse(Console.ReadLine());
            Console.WriteLine();
            CStudent stu = new CStudent();
            Console.WriteLine("分數：{0}",stu.Pass(keyin));
            Console.WriteLine("評語：{0}",stu.Level(keyin));
            Console.Read();
        }
    }
}
