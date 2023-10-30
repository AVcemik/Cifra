using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallingObjects
{
    public class Payer
    {
        public int Scope { get; set; } = 0;

        public void UpScope(int upScope)
        {
            Scope += upScope;
        }
    }
}
