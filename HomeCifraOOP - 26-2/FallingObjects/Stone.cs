using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFallingObj
{
    internal class Stone : FallingObjects
    {
        public Point Locations { get; set; }
        public int Sizes { get; set; }

        public Stone(int location, int size)
        {
            Locations = new Point(location, -30);
            Sizes = size;

        }
        public Point Falling()
        {
            return Locations;
        }
    }
}
