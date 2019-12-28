using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Interface02
{
    public interface IPass
    {
        int Score { get; set; }     //分數屬性
        string Pass(int grade);     //判斷及格
    }
}
