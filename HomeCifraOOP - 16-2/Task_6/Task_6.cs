/*
                Задача №6 Учет инвентаря:
    Разработайте приложение для учета инвентаря в магазине. 
    Используйте разные коллекции 
    (например, Dictionary для товаров и их количества, а HashSet для отслеживания, какие товары были проданы).
 */

Dictionary<string, int> item =  new Dictionary<string, int>();
HashSet<string> sell = new HashSet<string>();

item.Add("Веник", 2);

DisplayMenu();
string command = Console.ReadLine()!;
if (command == "1")
{
    Console.Write("Введите название товара: ");
    command = Console.ReadLine()!;
    foreach (KeyValuePair<string, int> i in item)
    {
        bool availability = false;
        if (i.Key != command && // проерка на длину массива)
        {
            
        }
        else
        {
            Console.WriteLine("Такой товар в списке уже есть");
        }
    }

    Console.Write("Введите кол-во товара: ");
    command = Console.ReadLine()!;
}



void DisplayMenu()
{
    Console.WriteLine("1 - Добавить товар и пополнить");
    Console.WriteLine("2 - Добавить товар в список");
    Console.WriteLine("3 - Пополнить товар");
    Console.WriteLine("4 - Продать товар");
}