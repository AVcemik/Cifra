using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskList
{
    enum Status
    {
        NotCompleted,
        Completed,
        Overdue
    }
    enum Priority
    {
        Low, 
        Medium, 
        High
    }
    internal class Tasks
    {
        public string Name { get; set; }
        public Status StatusTask { get; set; }
        public DateTime Date { get; set; }
        public Priority PriorityTask { get; set; }
        public Tasks(string name, DateTime date, Priority priority) 
        {
            Name = name;
            StatusTask = Status.NotCompleted;
            Date = date;
            PriorityTask = priority;
        }
    }
}
