


public class Empoyee
{
    public string Name { get; set; }
    public int Id { get; set; }
    public Task Tasks { get; set; }

}

public class Task : ICloneable
{
    public string Titel { get; set; }
    public Priority Prioritys { get; set; }
    public DateTime DueData { get; set; }
    
}

public enum Priority
{
    Hight,
    Midlle,
    Low
}