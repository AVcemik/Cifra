using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskList
{
    public enum Status
    {
        NotCompleted,
        Completed,
        Overdue
    }
    public enum Priority
    {
        Low, 
        Medium, 
        High
    }
    public class Tasks
    {
        [DisplayName("Название")]
        public string Name { get; set; }
        [DisplayName("Статус")]
        public Status StatusTask { get; set; }
        [DisplayName("Дата")]
        public DateTime Date { get; set; }
        [DisplayName("Приоритет")]
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
