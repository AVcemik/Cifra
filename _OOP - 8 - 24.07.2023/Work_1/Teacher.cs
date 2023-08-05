using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_1
{
    internal class Teacher
    {
        public string Name { get; private set; }
        public Facult? Facult { get; set; }
        public Mark? Mark { get; set; }

        public Teacher(string? name)
        {
            Name=name!;
        }

        public void SetMark(int marks)
        {
            Mark mark = new(marks);
        }
    }
}
