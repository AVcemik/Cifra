/*
 *              Домашнее задание 19-2
 */
using System.Collections;
using System.Threading.Tasks;
using System.Xml.Linq;

List<Empoyee> employee = new List<Empoyee>();
employee.Add(new Empoyee("Елена", 1, new List<Task>
    {
        new Task ("Идти на работу", Priority.Midlle, new DateTime(2023, 10, 27) ),
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
employee.Add(new Empoyee("Иван", 1, new List<Task>
    {
        new Task ("Валять дурака", Priority.Hight, new DateTime(2023, 10, 25) ),
        new Task ("Заняться делом", Priority.Low, new DateTime(2023, 10, 20) ),
        new Task ("ничего не делать", Priority.Midlle, new DateTime(2023, 10, 23) )
    }
));

for (int i = 0; i < employee.Count; i++)
{
    for (int j = 0; j < employee[i].Tasks.Count; j++)
    {

    }
}



public class Empoyee : IComparable<Empoyee>, IEnumerable
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
        if (Tasks.Count != other.Tasks.Count)
        {
            return Tasks.Count.CompareTo(other.Tasks.Count);
        }
        if (Tasks.Count > 0)
        {
            int priorityComparison = String.Compare(Tasks[0].Prioritys.ToString(), other.Tasks[0].Prioritys.ToString());
            if (priorityComparison != 0)
                return priorityComparison;
        }
        return string.Compare(Name, other.Name);
    }
    public IEnumerator GetEnumerator()
    {
        return Tasks.GetEnumerator();
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
        DateTime dueDataCopy = new DateTime(DueData.Year, DueData.Month, DueData.Day);
        return new Task(Titel, Prioritys, dueDataCopy);
    }
}

public enum Priority
{
    Hight,
    Midlle,
    Low
}