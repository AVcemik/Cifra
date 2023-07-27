using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_1
{
    internal class Rectangle:Pair
    {
        private int value1;
        private int value2;

        public Rectangle()
        {
            value1 = 1;
            value2 = 1;
        }

        public Rectangle(int value1, int value2)
        {
            this.value1=value1;
            this.value2=value2;
        }
        public int Perimtr()
        {
            return (value1 + value2) * 2;
        }
    }
}
