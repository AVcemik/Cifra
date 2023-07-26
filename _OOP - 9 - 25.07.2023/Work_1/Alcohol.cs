using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_1
{
    internal class Alcohol:Liquid
    {
        public double Strong { get; set; }
        public new  void setDensity(double strong)
        {
            Strong = strong;
        }
    }
}
