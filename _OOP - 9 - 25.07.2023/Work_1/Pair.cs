using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_1
{
    internal class Pair
    {
        private int value1;
        private int value2;

        public Pair()
        {
            value1 = 1;
            value2 = 1;
        }

        public Pair(int value1, int value2)
        {
            this.value1=value1;
            this.value2=value2;
        }

        public void SetPair(int x, int y) 
        {
            value1 = x;
            value2 = y;
        }
        public int Multiplya()
        {
            return value1 * value2;
        }


    }
}
