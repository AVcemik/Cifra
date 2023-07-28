using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_1
{
    internal class Facult
    {
        public string? Name { get;}

        private List<Abiturient> abiturients;
        public Facult(string? name)
        {
            Name=name;
            abiturients = new List<Abiturient>();
        }
    }
}
