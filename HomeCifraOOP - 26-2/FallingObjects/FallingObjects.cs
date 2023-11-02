using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFallingObj
{
    internal interface FallingObjects
    {
        public abstract Point Locations { get; set; }
        public abstract int Sizes { get; set; }
        public abstract Point Falling();
    }
}
