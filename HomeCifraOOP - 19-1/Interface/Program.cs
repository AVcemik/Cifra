/*
 *          Домашнее задание 19-1
 */
using Interface;

TaskManager manager = new();

MainMenu();



void MainMenu()
{
    Console.Clear();
    Console.WriteLine("Меню:");
    Console.WriteLine("1 - Добавить задачу");
    Console.WriteLine("2 - Добавить событие");
    Console.WriteLine("3 - Удалить задачу");
    Console.WriteLine("4 - Вывести список всех задач/событий");
    Console.WriteLine("0 - Выход");
    Commands();
}
void Commands()
{
    Console.Write("Введите номер меню: ");
    string select = Console.ReadLine()!;
    switch (select)
    {
        case "1": manager.AddTask();
            break;
        case "2": manager.AddEvent();
            break;
        case "3": manager.DeleteTaskEvents();
            break;
        case "4": manager.Display();
            break;
        case "0": AdditionalFunc.ExitSoft();
            break;
        default: AdditionalFunc.ColorText("Такого номера нет!!!", Colors.Red);
            break;
    }
    MainMenu();
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