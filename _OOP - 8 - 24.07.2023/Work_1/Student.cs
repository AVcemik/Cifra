using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_1
{
    internal class Student
    {
        public string? Name { get; set; }
        public Facult Facult { get; set; }
        public List<Exam> Examen { get; set; }

        public Student(string? name)
        {
            Name = name;
        }
    }
}
