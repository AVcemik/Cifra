using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_1
{
    internal class Liquid
    {
        public string? Name { get; set; }
        public double Density { get; set; }
        public void setDensity(double density)
        {
            Density = density;
        }
    }
}
