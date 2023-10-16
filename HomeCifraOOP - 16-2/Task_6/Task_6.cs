/*
                Задача №6 Учет инвентаря:
    Разработайте приложение для учета инвентаря в магазине. 
    Используйте разные коллекции 
    (например, Dictionary для товаров и их количества, а HashSet для отслеживания, какие товары были проданы).
 */


// Не понял как через HashSet отслеживать проданные товары...

Dictionary<string, int> item = new Dictionary<string, int>();
HashSet<string> sell = new HashSet<string>();
string command;
int count = 0;
item.Add("веник", 2);

DisplayMenu();


void AddItemAndCountUp()
{
    command = CommandInput("Введите название товара: ");
    Console.Clear();
    if (item.ContainsKey(command.ToLower()))
    {
        ColorTextDisplay(((int)ColorText.red), "\nТакой товар в списке уже имеется!!!");
        ContinueProgramm();
    }
    else
    {
        Console.Write("Введите кол-во товара: ");
        int commandCount = int.Parse(Console.ReadLine()!);
        item.Add(command, commandCount);
        ColorTextDisplay(((int)ColorText.green), "Товар успешно добавлен");
        ContinueProgramm();
    }
}
void AddItemInList()
{
    command = CommandInput("Введите название товара: ");
    Console.Clear();
    if (item.ContainsKey(command.ToLower()))
    {
        ColorTextDisplay(((int)ColorText.red), "\nТакой товар в списке уже имеется!!!");
        ContinueProgramm();
    }
    else
    {
        item.Add(command, 0);
        ColorTextDisplay(((int)ColorText.green), "Товар успешно добавлен");
        ContinueProgramm();
    }
}
void AddCountUpItem()
{
    Console.Clear();
    foreach (var i in item)
    {
        Console.WriteLine($"{i.Key} - {i.Value} шт");
    }
    command = CommandInput("Введите название товара: ");
    Console.Clear();
    if (item.ContainsKey(command.ToLower()))
    {
        int countItem = item[command];
        countItem += int.Parse(CommandInput("Введите кол-во: "));
        item[command] = countItem;
        ColorTextDisplay(((int)ColorText.green), "Товар успешно добавлен");
        ContinueProgramm();
    }
    else
    {
        ColorTextDisplay(((int)ColorText.red), "\nТакого товара нет!!!");
        ContinueProgramm();
    }
}
void SellItem()
{
    Console.Clear();
    foreach (var i in item)
    {
        Console.WriteLine($"{i.Key} - {i.Value} шт");
    }
    command = CommandInput("Введите название товара: ");
    Console.Clear();
    if (item.ContainsKey(command.ToLower()))
    {
        int countItem = item[command];
        Console.Write("Введите кол-во: ");
        int sellCount = int.Parse(Console.ReadLine()!);
        if (countItem - sellCount >= 0)
        {
            item[command] = countItem - sellCount;
            sell.Add(command);
            ColorTextDisplay(((int)ColorText.green), "\nТовар успешно продан");
            ContinueProgramm();
        }
        else
        {
            ColorTextDisplay(((int)ColorText.red), "\nТакого кол-во нет в наличии!!!");
            ContinueProgramm();
        }
    }
    else
    {
        ColorTextDisplay(((int)ColorText.red), "\nТакого товара нет!!!");
        ContinueProgramm();
    }
}
void ListItem()
{
    Console.Clear();
    foreach (var i in item) 
    {
        Console.WriteLine(i.Key + " - " + i.Value);
    }
    ContinueProgramm();
}
void ExitProgramm()
{
    Console.Clear();
    Console.WriteLine("Проданные товары: ");
    foreach (var i in sell)
    {
        Console.WriteLine("     - " + i);
    }
    ContinueProgramm();
    Environment.Exit(0);
}
void DisplayMenu()
{
    Console.Clear();
    Console.WriteLine("1 - Добавить товар и пополнить");
    Console.WriteLine("2 - Добавить товар в список");
    Console.WriteLine("3 - Пополнить товар");
    Console.WriteLine("4 - Продать товар");
    Console.WriteLine("5 - Список товаров");
    Console.WriteLine("0 - Выход");

    command = CommandInput("Введите номер меню: ");
    switch (command)
    {
        case "1":
            AddItemAndCountUp();
            break;
        case "2":
            AddItemInList();
            break;
        case "3":
            AddCountUpItem();
            break;
        case "4":
            SellItem();
            break;
            case "5":
            ListItem();
            break;
        case "0":
            ExitProgramm();
            break;
        default:
            break;
    }
    DisplayMenu();
}

string CommandInput(string wordSelect)
{
    Console.Write(wordSelect);
    return Console.ReadLine()!.ToLower();
}
void ColorTextDisplay(int color, string world)
{
    if (color == 0)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(world);
        Console.ForegroundColor = ConsoleColor.Gray;
    }
    if (color == 1)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(world);
        Console.ForegroundColor = ConsoleColor.Gray;
    }
}
void ContinueProgramm()
{
    Console.WriteLine("\nНажмите любую клавишу для проделжения...");
    Console.ReadKey();
}
enum ColorText
{
    green,
    red
};