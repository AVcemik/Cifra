/*
 *              Домашнее задание 19-2
 */
using System.Collections;
using System.Threading.Tasks;
using System.Xml.Linq;

List<Empoyee> employee = new List<Empoyee>();
employee.Add(new Empoyee("Елена", 1, new List<Task>
    {
        new Task ("Следить за ребенком", Priority.Hight, new DateTime(2023, 10, 30) )
    }
));
employee.Add(new Empoyee("Александр", 2, new List<Task>
    {
        new Task ("Идти на работу", Priority.Low, new DateTime(2023, 10, 25) ),
        new Task ("Заняться спортом", Priority.Midlle, new DateTime(2023, 10, 20) ),
        new Task ("Идти на учебу", Priority.Hight, new DateTime(2023, 10, 18) )
    }
));
employee.Add(new Empoyee("Иван", 3, new List<Task>
    {
        new Task ("Валять дурака", Priority.Hight, new DateTime(2023, 10, 25) ),
        new Task ("Заняться делом", Priority.Low, new DateTime(2023, 10, 20) )
    }
));

DisplayList(employee);
employee.Sort();
employee.Reverse();
Console.WriteLine("\nОтсортированный список по кол-во задач\n");
DisplayList(employee);



void DisplayList(List<Empoyee> list)
{
    for (int i = 0; i < list.Count; i++)
    {
        Console.WriteLine(list[i].Id + " - " + list[i].Name);
        for (int j = 0; j < list[i].Tasks.Count; j++)
        {
            Console.WriteLine("     - " + list[i].Tasks[j].Prioritys + " - " + list[i].Tasks[j].DueData.ToShortDateString() + " - " + list[i].Tasks[j].Titel);
        }
    }
}
public class Empoyee : IComparable<Empoyee>
{
    public string Name { get; set; }
    public int Id { get; set; }
    public List<Task> Tasks { get; set; }
    public Empoyee(string name, int id, List<Task> tasks)
    {
        Name = name;
        Id = id;
        Tasks = tasks;
    }
    public int CompareTo(Empoyee other)
    {
        return Tasks.Count.CompareTo(other.Tasks.Count);
    }
}

public class Task : ICloneable
{
    public string Titel { get; set; }
    public Priority Prioritys { get; set; }
    public DateTime DueData { get; set; }
    public Task(string titel, Priority prioritys, DateTime dueData)
    {
        Titel = titel;
        Prioritys = prioritys;
        DueData = dueData;
    }

    public object Clone()
    {
        return new Task(Titel, Prioritys, DueData);
    }
}

public enum Priority
{
    Hight,
    Midlle,
    Low
}