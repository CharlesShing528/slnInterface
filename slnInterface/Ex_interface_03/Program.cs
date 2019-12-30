using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_interface_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point(2, 3);
            Console.WriteLine("My Point:");
            PrintPoint(p);
            Console.Read();
        }

        static void PrintPoint(IPoint p)
        {
            Console.WriteLine("x={0},y={1}",p.x,p.y);
        }
    }

    interface IPoint
    {
        // Property signatures:
        int x { get; set; }
        int y { get; set; }
    }

    class Point:IPoint
    {
        // 欄位 Fields
        private int _myX;
        private int _myY;

        // 建構式  Constructor
        public Point(int a , int b)
        {
            _myX = a;
            _myY = b;
        }

        public int x
        {
            get { return _myX; }
            set { _myY = value; }
        }

        public int y
        {
            get { return _myY; }
            set { _myY = value; }
        }
    }
}
