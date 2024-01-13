

namespace Work_1
{
    internal class Student
    {
        public string? Name { get; set; }
        public Facult Facult { get; set; }
        public List<Exam> Examen { get; set; } = new();

        public  Student(string? name, Facult facult)
        {
            Name = name;
            Facult = facult;
        }
    }
}
