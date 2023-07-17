using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_2
{
    internal class Triangle
    {
        private double a;
        private double b;
        private double c;

        public double getA()
        {
            return a;
        }

        public double getB()
        {
            return b;
        }

        public double getC()
        {
            return c;
        }

        public void setA(double ab)
        {
            if (ab > 0) a = ab;
        }
        public void setB(double bc)
        {
            if (bc > 0) b = bc;
        }
        public void setC(double ca)
        {
            if (ca > 0) c = ca;
        }
        public double getArea()
        {
            double s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }
        public double getPerimetr()
        {
            if (a != 0 && b != 0 && c != 0) return a + b +c;
            return 0;
        }
        public double getMedian()
        {

        }
    }
}
