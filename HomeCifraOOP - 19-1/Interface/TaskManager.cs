using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class TaskManager
    {
        public List<(Task, Event)> DataList { get; set; }
        public TaskManager()
        {
            DataList = new List<(Task, Event)>();
        }
        public void AddTask(Task task)
        {
            DataList.Add((task, null!));
        }
        public void AddTask(Event someEvent)
        {
            DataList.Add((null!, someEvent));
        }
        public void Display()
        {
            for (int i = 0; i < DataList.Count; i++)
            {
                if (DataList[i].Item1 != null)
                {
                    Console.WriteLine("Название: " + DataList[i].Item1.Title);
                    Console.WriteLine("Дата: " + DataList[i].Item1.DueDate.ToShortDateString());
                    Console.WriteLine("Приоритет: " + DataList[i].Item1.Priority);
                    Console.WriteLine();
                }
                else if (DataList[i].Item2 != null)
                {
                    Console.WriteLine("Название: " + DataList[i].Item2.Title);
                    Console.WriteLine("Дата: " + DataList[i].Item2.DueDate.ToShortDateString());
                    Console.WriteLine("Приоритет: " + DataList[i].Item2.Priority);
                    Console.WriteLine("Место проведения: " + DataList[i].Item2.Location);
                    Console.WriteLine();

                }
                else
                {
                    Console.WriteLine("Какая то ошибка");
                }
            }
        }
    }
}
