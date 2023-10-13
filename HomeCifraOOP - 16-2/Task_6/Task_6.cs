/*
                Задача №6 Учет инвентаря:
    Разработайте приложение для учета инвентаря в магазине. 
    Используйте разные коллекции 
    (например, Dictionary для товаров и их количества, а HashSet для отслеживания, какие товары были проданы).
 */



Dictionary<string, int> item =  new Dictionary<string, int>();
HashSet<string> sell = new HashSet<string>();
string command;
int count = 0;
item.Add("веник", 2);

DisplayMenu();


void AddItemAndCountUp()
{
    command = CommandInput("Введите название товара: ");

    if (item.ContainsKey(command.ToLower()))
    {
        ColorTextDisplay(((int)ColorText.red), "\nТакой товар в списке уже имеется!!!");
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

    if (item.ContainsKey(command.ToLower()))
    {
        ColorTextDisplay(((int)ColorText.red), "\nТакой товар в списке уже имеется!!!");
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
    count = 1;
    foreach (var i in item)
    {
        Console.WriteLine($"{count} - {i.Key} - {i.Value} шт");
        count++;
    }
    int commandInt = int.Parse(CommandInput("Введите номер товара: "));
    if (commandInt > 0 && commandInt < item.Count)
    {
        string nameIteme = item.Keys.ToString()!;
        commandInt = Convert.ToInt32(item.Values);
        item.Remove(nameIteme);
        commandInt += int.Parse(CommandInput("Введите кол-во"));
        item.Add(nameIteme, commandInt);
    }
    else
    {
        ColorTextDisplay(((int)ColorText.red), "\nВы ввели не число");
        ContinueProgramm();
        DisplayMenu();
    }

    if (item.ContainsKey(command.ToLower()))
    {
        ColorTextDisplay(((int)ColorText.red), "\nТакой товар в списке уже имеется!!!");
    }
    else
    {
        item.Add(command, 0);
        ColorTextDisplay(((int)ColorText.green), "Товар успешно добавлен");
        ContinueProgramm();
    }
}
void DisplayMenu()
{
    Console.Clear();
    Console.WriteLine("1 - Добавить товар и пополнить");
    Console.WriteLine("2 - Добавить товар в список");
    Console.WriteLine("3 - Пополнить товар");
    Console.WriteLine("4 - Продать товар");
    Console.WriteLine("0 - Выход");

    command = CommandInput("Введите номер меню: ");
    if (command == "1") AddItemAndCountUp();
    else if (command == "2") AddItemInList();
    else if (command == "3") AddCountUpItem();

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