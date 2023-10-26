using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Task : ITask
    {
        public string Title { get; set; }
        public DateTime DueDate { get; set; }
        public Priority Priority { get; set; }

        public Task(string title, DateTime dueDate, Priority priority)
        {
            Title = title;
            DueDate = dueDate;
            Priority = priority;
        }

        public void Display()
        {
            Console.WriteLine($"Название: {0}\nДата и время: {1}\nПриоритет: {2}", Title, DueDate, Priority);
        }
    }
}
