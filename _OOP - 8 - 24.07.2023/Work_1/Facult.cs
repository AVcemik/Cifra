using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_1
{
    internal class Facult
    {
        public string? FacultName { get; set; }
        public List<Exam> Exam { get; set; }
        public Facult(string name)
        {
            FacultName = name;
            Exam = new();
        }
        public void AddExam(Exam exam)
        {
            Exam.Add(exam);
        }
    }
}
