using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_1
{
    internal class Abiturient
    {
        private string? name;
        public Facult? Facult { get; set; }

        public Abiturient(string? name)
        {
            this.name=name;
        }
    }
}
