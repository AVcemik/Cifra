// Домашняя работа

// 1.	Составить описание класса для представления времени.
// Предусмотреть возможности установки времени и изменения
// его отдельных полей (час, минута, секунда) с проверкой
// допустимости вводимых значений.
// В случае недопустимых значений полей выбрасываются исключения.
// Создать методы изменения времени на заданное количество
// часов, минут и секунд.

using _12._07._2023___1___HomeCifra;

Times t = new();

while (true)
{
    Console.WriteLine($"Время: {t.getTimes()}");
    Console.WriteLine();
    Console.WriteLine("Меню: ");
    Console.WriteLine("1 - Установить время");
    Console.WriteLine("2 - Установить часы");
    Console.WriteLine("3 - Установить минуты");
    Console.WriteLine("4 - Установить секнды");
    Console.WriteLine("5 - Выход");
    Console.WriteLine();
    Console.Write("Выберите действие: ");
    t.Menu = byte.Parse(Console.ReadLine()!);

    if (t.Menu == 1)
    {
        Console.Write("Введите часы: ");
        t.Hours = byte.Parse(Console.ReadLine()!);
        Console.Write("Введите минуты: ");
        t.Minutes = byte.Parse(Console.ReadLine()!);
        Console.Write("Введите секунды: ");
        t.Secundes = byte.Parse(Console.ReadLine()!);
    }
    else if (t.Menu == 2)
    {
        Console.Write("Введите часы: ");
        t.Hours = byte.Parse(Console.ReadLine()!);
    }
    else if (t.Menu == 3)
    {
        Console.Write("Введите минуты: ");
        t.Minutes = byte.Parse(Console.ReadLine()!);
    }
    else if (t.Menu == 4)
    {
        Console.Write("Введите секунды: ");
        t.Secundes = byte.Parse(Console.ReadLine()!);
    }
    else if (t.Menu == 5) Environment.Exit(0);
    else
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Нет такого номера меню!!!");
        Console.ForegroundColor = ConsoleColor.White;
        continue;
    }
    Console.Clear();
}



