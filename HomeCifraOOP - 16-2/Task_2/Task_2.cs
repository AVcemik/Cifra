/*
 *             Задача №2 Учет посещений:
    Разработайте программу для учета посещений магазина. 
    Используйте Dictionary для отслеживания количества посещений для каждого клиента.
    Пользователь вводит имя, а словарь увеличивает счетчик посещений.
    При вводе слова “выход”, выводится список всех клиентов и количества их посещений
 */

Dictionary<string, int> nameVisit = new Dictionary<string, int>();
nameVisit.Add("Administrator", 0);

string name = "";

while (true)
{
    int count = 1;

    Console.Write("Введите имя: ");
    name = Console.ReadLine()!;

    // Проверка на нулл (Человек без имени войти не может)
    if (name.Trim() == "") continue;

    // Выход из программы
    if (name.ToLower() == "выход")
    {
        break;
    }

    // Счетчик
    foreach (KeyValuePair<string, int> item in nameVisit)
    {
        if (item.Key == name)
        {
            count = item.Value;
            count++;
            nameVisit.Remove(item.Key);
            nameVisit.Add(name, count);
            count = 1;
            break;
        }
        else if (count == nameVisit.Count)
        {
            count = 1;
            nameVisit.Add(name, count);
            break;
        }
        count++;
    }  
}

Console.WriteLine();

// Информация по посещениям
foreach (KeyValuePair<string, int> item in nameVisit)
{
    Console.WriteLine($"Кол-во посещений у {item.Key}: {item.Value}");
}