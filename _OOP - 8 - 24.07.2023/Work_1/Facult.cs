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
        public List<Student> Students { get; private set; }
        public List<Exam> Exam { get; set; }
        public Facult(string name)
        {
            FacultName = name;
            Students = new();
            Exam = new();
        }
        public void AddExam(Exam exam)
        {
            Exam.Add(exam);
        }
        public void RegistrationStudent(Student student)
        {
            Students.Add(student);
        }

    }
}
