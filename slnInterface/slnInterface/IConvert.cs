using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnInterface
{
    interface IConvert
    {
        double Mult { get; set; }   //倍率屬性
        void Convert(double l);
    }
}
