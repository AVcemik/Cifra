using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_1
{
    internal class Facult
    {
        public Exam? Exam { get; set; }
        public string? Name { get; private set; }
        public Facult(string name)
        {
            Name = name;
        }

        //private List<Abiturient> abiturients;
        //public Facult(string? name)
        //{
        //    Name=name;
        //    abiturients = new List<Abiturient>();
        //}
    }
}
