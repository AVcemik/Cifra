using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Event : ITask
    {
        public string Title { get; set; }
        public DateTime DueDate { get; set; }
        public Priority Priority { get; set; }
        public string Location { get; set; }

        public Event(string title, DateTime dueDate, Priority priority, string location)
        {
            Title = title;
            DueDate = dueDate;
            Priority = priority;
            Location = location;
        }

        public void Display()
        {
            Console.WriteLine($"Название: {0}\nДата и время: {1}\nПриоритет: {2}\nМесто проведения: {3}", Title, DueDate, Priority, Location);
        }
    }
}
