﻿/*
 *          Домашнее задание 19-1
 */
TaskManager manager = new TaskManager();



void Menu()
{
    Console.Clear();
    Console.WriteLine("Меню:");
    Console.WriteLine("1 - Добавить задачу или событие");
    Console.WriteLine("2 - Удалить задачу");
    Console.WriteLine("3 - Вывести список всех задач и событий");
    Commands("Введите номер меню: ");
    Menu();
}
void Commands(string str)
{
    Console.Write(str);
    string command = Console.ReadLine()!;
    switch (command)
    {
        case "1": AddTaskEvent();
            break;
        case "2":
            break;
        case "3":
            break;
        default: ColorText("Вы ввели не число", Colors.Red);
            break;
    }
}
T CommandPriotitet()
{
    Console.WriteLine("1 - Высокий");
    Console.WriteLine("2 - Средний");
    Console.WriteLine("3 - Низкий");
    Console.Write("Выберите приоритет (Если это событие через пробел введите место проведение события): ");
    string[] command = Console.ReadLine()!.Split(' ', 2);

    switch (command[0])
    {
        case "1": return Priority.High;
        case "2": return Priority.Medium;
        case "3": return Priority.Low;
        default:
            {
                ColorText("Неправильно указан приоритет", Colors.Red);
                return CommandPriotitet();
            }
    }
    
}
void AddTaskEvent()
{
    Console.Clear();
    Console.Write("Введите название задачи или события: ");
    string titel = Console.ReadLine()!;
    DateTime date = ParseDate();
    manager.AddTask(CommandPriotitet());
    
    
    
}
void PauseSoft()
{
    Console.WriteLine("Нажмите любую клавишу для продолжения...");
    Console.ReadKey();
}
DateTime ParseDate()
{
    Console.Write("Введите день месяц год через точку (Пример: 26.11.2023)");
    string[] date = Console.ReadLine()!.Replace('.', '.').Split('.');
    try
    {
        return new DateTime(int.Parse(date[2]), int.Parse(date[1]), int.Parse(date[0]));
    }
    catch 
    {
        ColorText("Введен неверный формат даты!!!", Colors.Red);
        return ParseDate();
    }
}
void ColorText(string str, Colors color)
{
    if (color == Colors.Green)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(str);
        Console.ForegroundColor = ConsoleColor.Gray;
    }
    else if (color == Colors.Red)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(str);
        Console.ForegroundColor = ConsoleColor.Gray;
    }
}
public enum Priority
{
    Low,
    Medium,
    High
}
public enum Colors
{
    Green,
    Red
}

interface ITask
{
    string Title { get; set; } // Название задачи или события
    DateTime DueDate { get; set; } // Дата выполнение задачи или события.
    Priority Priority { get; set; } // Приоритет задачи или события


    void Display(); // Метод для отображения информации о задачи или событии.
}

public class Task : ITask
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
public class Event : ITask
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

public class TaskManager
{
    public List<(Task, Event)> DataList { get; set; }
    public TaskManager()
    {
        DataList = new List<(Task, Event)>();
    }
    public void AddTask(Task task)
    {
        DataList.Add((task, null));
    }
    public void AddTask(Event someEvent)
    {
        DataList.Add((null, someEvent));
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