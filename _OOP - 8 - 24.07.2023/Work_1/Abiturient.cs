using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_1
{
    internal class Abiturient
    {
        public string Name { get; private set; }
        public Facult? Facult { get; set; }

        public Abiturient(string? name)
        {
            Name=name!;
        }
    }
}
