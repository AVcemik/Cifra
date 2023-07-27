using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_1
{
    internal class Teacher
    {
        public string? Name { get; set; }
        public Exam? ExamMark { get; private set; }

        public Teacher(string? name)
        {
            Name=name;
        }

        public void setMark(int mark)
        {
            
        }
    }
}
