/*
 *          Домашнее задание 19-1
 */
using Interface;

List<TaskManager> manager = new();

MainMenu();



void MainMenu()
{
    Console.Clear();
    Console.WriteLine("Меню:");
    Console.WriteLine("1 - Добавить задачу");
    Console.WriteLine("2 - Добавить событие");
    Console.WriteLine("3 - Удалить задачу");
    Console.WriteLine("4 - Вывести список всех задач и событий");
    Commands("Введите номер меню: ");
    MainMenu();
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
void ListTaskEvent(TaskManager manager)
{
    for (int i = 0; i < manager.; i++)
    {

    }
}
void SetPriotitet(out Priority priority)
{
    Console.WriteLine("1 - Высокий");
    Console.WriteLine("2 - Средний");
    Console.WriteLine("3 - Низкий");
    Console.Write("Выберите приоритет: ");
    string command = Console.ReadLine()!;

    switch (command)
    {
        case "1":
            priority = Priority.High;
            break;
        case "2":
            priority = Priority.Medium;
            break;
        case "3":
            priority = Priority.Low;
            break;
        default:
            {
                ColorText("Приоритет не присвоен!!!", Colors.Red);
                priority = Priority.NotPriority;
            }
            break;
    }
}
void AddTaskEvent()
{
    Console.Clear();
    Console.Write("Введите название задачи или события: ");
    string titel = Console.ReadLine()!;
    DateTime date = ParseDate();
    Priority priority = new();
    SetPriotitet(out priority);
    Console.Write("Введите место мероприяти (если это задача ничего не вводите): ");
    string location = Console.ReadLine()!;
    if (location == "")
    {
        Task newTask = new(titel, date, priority);
        manager.AddTask(newTask);
        ColorText("Задача успешно добавлена", Colors.Green);
    }
    else
    {
        Event newEvent = new(titel, date, priority, location);
        manager.AddTask(newEvent);
        ColorText("Событие успешно добавлена", Colors.Green);
    }
    PauseSoft();
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
    NotPriority,
    Low,
    Medium,
    High
}
public enum Colors
{
    Green,
    Red
}