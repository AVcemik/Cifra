// 3.Создать класс «Платная автостоянка», включающий данные-элементы:
// название, место расположения, количество мест, тариф. Функции-элементы:
// •	создание и инициализация (конструктор),
// •	количество уехавших машин (в аргументе),
// •	количество машин, желающих встать на стоянку (в аргументе),
// •	выдача сообщения о количестве свободных мест,
// •	деструктор.

using _Work_3;

ParkingPay autoParking1 = new("Северная", "Калининград, ул. Вокзальная 43", 50, 60);

while (true)
{
    Console.WriteLine("Меню");
    Console.WriteLine("1 - Добавить автомобили");
    Console.WriteLine("2 - Убрать автомобилей");
    Console.WriteLine("3 - Кол-во свободных мест");
    Console.WriteLine("0 - Выход");
    Console.WriteLine();

    if (autoParking1.OccupiedSpot < 50)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        autoParking1.CountSpot();
        Console.ForegroundColor = ConsoleColor.Gray;
    }
    if (autoParking1.OccupiedSpot == 50)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        autoParking1.CountSpot();
        Console.ForegroundColor = ConsoleColor.Gray;
    }
    Console.Write("\nВведите номер меню: ");
    string number = Console.ReadLine()!;

    if (number == "1")
    {
        Console.Write("Введите кол-во автомобилей: ");
        autoParking1.AddAuto(int.Parse(Console.ReadLine()!));
    }
    else if (number == "2")
    {
        Console.Write("Введите кол-во убывших автомобилей: ");
        autoParking1.LeaveAuto(int.Parse(Console.ReadLine()!));
    }
    else if (number == "3")
    {
        autoParking1.CountSpot();
    }
    else if (number == "0")
    {
        Environment.Exit(0);
    }
    else
    {
        Console.WriteLine("Некоректно введен номер!!!");
    }
    Console.WriteLine("\nНажмите любую клавишу для продолжения...");
    Console.ReadKey();
    Console.Clear();
}

