using System.Drawing;

Teacher teacher = new(173, 65, 'M', "Человек", Color.Chocolate, 1, "Учитель", 30000, new DateTime(2013, 11, 30), "История", 10);
Student student = new(173, 82, 'М', "Человек", Color.Brown, 2, "Студент", 3000, new DateTime(2023, 01, 15), 1, "Основы програмирования", 10);
Manager manager = new(149, 43, 'Ж', "Человек", Color.Magenta, 3, "Менеджер", 30000, new DateTime(2017, 07, 30), "Область управления", 7, 5);
Programmer programmer = new(35, 8, 'Ж', "Кот", Color.Black, 4, "Програмист", 75000, new DateTime(1, 01, 01), "Общий", new List<string>() { "Христианство", "Религия"}, "Человечество");

Console.WriteLine("Студент:\nРост: {0}\nВес: {1}\nПол: {2}\nРасса: {3}\nЦвет глаз: {4}\nИндетификатор: {5}\nДолжность: {6}\nСтепендия: {7}\nДата поступления: {8}\nКурс: {9}\nСпециализация: {10}\nСредний бал: {11}", student.Height, student.Weight, student.Sex, student.Race, student.EyeColor, student.Id, student.Position, student.Salary, student.WorkUp, student.CourseExp, student.Specialty, student.MarkAvery);

public abstract class People<TCharecteristic, TSex, TRace, TColor>
{
    public abstract TCharecteristic Height { get; set; }
    public abstract TCharecteristic Weight { get; set; }
    public abstract TSex Sex { get; set; }
    public abstract TRace Race { get; set; }
    public abstract TColor EyeColor { get; set; }
}

public class Person : People<double, char, string, Color>
{
    public override double Height { get; set; }
    public override double Weight { get; set; }
    public override char Sex { get; set; }
    public override string? Race { get; set; }
    public override Color EyeColor { get; set; }
}

public class Employee : Person
{
    public int Id { get; set; }
    public string? Position { get; set; }
    public decimal Salary { get; set; }
    public DateTime WorkUp {  get; set; }
}

public class Teacher : Employee
{
    public string Course { get; set; }
    public int Experiance { get; set; }
    
    public Teacher(double height, double weight, char sex, string race, Color eyeColor, int id, string position, decimal salary, DateTime workUp, string course, int experiance)
    {
        Height = height;
        Weight = weight;
        Sex = sex;
        Race = race;
        EyeColor = eyeColor;
        Id = id;
        Position = position;
        Salary = salary;
        WorkUp = workUp;
        Course = course;
        Experiance = experiance;
    }
}
public class Student : Employee
{
    public int CourseExp { get; set; }
    public string Specialty { get; set; }
    public double MarkAvery { get; set; }
    public Student(double height, double weight, char sex, string race, Color eyeColor, int id, string position, decimal salary, DateTime workUp, int courseExp, string specialty, double markAvery)
    {
        Height = height;
        Weight = weight;
        Sex = sex;
        Race = race;
        EyeColor = eyeColor;
        Id = id;
        Position = position;
        Salary = salary;
        WorkUp = workUp;
        CourseExp = courseExp;
        Specialty = specialty;
        MarkAvery = markAvery;
    }
}

public class Manager : Employee
{
    public string Management { get; set; }
    public int QuantityPersons { get; set; }
    public int ExperianceManagement { get; set; }
    public Manager(double height, double weight, char sex, string race, Color eyeColor, int id, string position, decimal salary, DateTime workUp, string management, int quantityPersons, int experianceManagement)
    {
        Height = height;
        Weight = weight;
        Sex = sex;
        Race = race;
        EyeColor = eyeColor;
        Id = id;
        Position = position;
        Salary = salary;
        WorkUp = workUp;
        Management = management;
        QuantityPersons = quantityPersons;
        ExperianceManagement = experianceManagement;
    }
}
public class Programmer : Employee
{
    public string ProgrammingLanguage { get; set; }
    public List<string> Project { get; set; }
    public string Specialty { get; set; }
    public Programmer(double height, double weight, char sex, string race, Color eyeColor, int id, string position, decimal salary, DateTime workUp, string language, List<string> project, string specialty)
    {
        Height = height;
        Weight = weight;
        Sex = sex;
        Race = race;
        EyeColor = eyeColor;
        Id = id;
        Position = position;
        Salary = salary;
        WorkUp = workUp;
        ProgrammingLanguage = language;
        Project = project;
        Specialty = specialty;
    }
}