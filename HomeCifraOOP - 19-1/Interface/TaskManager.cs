using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
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
        public void AddTask()
        {
            Console.Clear();
            Console.Write("Введите название задачи: ");
            string title = Console.ReadLine()!;
            DateTime date = ParseDate();
            Priority priority = SelectPriority();
            DataList.Add((new Task(title, date, priority), null!));
            AdditionalFunc.ColorText("Задача успешно добавлена...", Colors.Green);
        }
        public void AddEvent()
        {
            Console.Clear();
            Console.Write("Введите название события: ");
            string title = Console.ReadLine()!;
            DateTime date = ParseDate();
            Priority priority = SelectPriority();
            Console.Write("Введите место проведения: ");
            string location = Console.ReadLine()!;
            DataList.Add((null!, new Event(title, date, priority, location)));
            AdditionalFunc.ColorText("Событие успешно добавлена...", Colors.Green);
        }
        public void DeleteTaskEvents()
        {
            Console.Clear();
            for (int i = 0; i < DataList.Count; i++)
            {
                if (DataList[i].Item1 != null)
                {
                    Console.WriteLine(i + 1 + " - " + DataList[i].Item1.Title);
                }
                else if (DataList[i].Item2 != null)
                {
                    Console.WriteLine(i + 1 + " - " + DataList[i].Item2.Title);
                }
                else
                {
                    AdditionalFunc.ColorText("Какая то ошибка!!!", Colors.Red);
                }
            }
            Console.Write("Введите номер задачи/события для удаления: ");
            string select = Console.ReadLine()!;
            if (int.TryParse(select, out int result))
            {
                if (result > 0 && result < DataList.Count)
                {
                    DataList.RemoveAt(result-1);
                    AdditionalFunc.ColorText("Задача успешно удалена...", Colors.Green);
                }
                else
                {
                    AdditionalFunc.ColorText("Введен неверный номер задачи/события!!!", Colors.Red);
                    
                }
            }
            
        }
        public void Display()
        {
            Console.Clear();
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
            AdditionalFunc.PauseSoft();
        }
        private DateTime ParseDate()
        {
            Console.Write("Введите день месяц год задачи через точку (Пример: 26.11.2023): ");
            string[] date = Console.ReadLine()!.Replace('.', '.').Split('.');
            try
            {
                return new DateTime(int.Parse(date[2]), int.Parse(date[1]), int.Parse(date[0]));
            }
            catch
            {
                AdditionalFunc.ColorText("Введен неверный формат даты!!!", Colors.Red);
                return ParseDate();
            }
        }
        private Priority SelectPriority()
        {
            Console.WriteLine("1 - Низкий");
            Console.WriteLine("2 - Средний");
            Console.WriteLine("3 - Высокий");
            Console.Write("Выберите номер приоритета: ");
            string select = Console.ReadLine()!;

            switch (select)
            {
                case "1": return Priority.Low;
                case "2": return Priority.Medium;
                case "3": return Priority.High;
                default:
                    {
                        AdditionalFunc.ColorText("Такого номера меню нет!!!", Colors.Red);
                        return SelectPriority();
                    }
            }
            
        }
    }
}
