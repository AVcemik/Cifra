/*
                Домашнее задание 22 На закрепление материаала
            Проект: Система управления пользователями (обрезанная)
                    Заказчик: Компания “SofT industries”
 */

using SofT_industries;
List<User> users = new();

using (FileStream fileStream = new FileStream(User.GetPath(), FileMode.OpenOrCreate)) { };

while (true)
{
    Console.Clear();
    Console.WriteLine("Для выхода введиты \"выход\"");
    Console.Write("Введите Имя: ");
    string name = Console.ReadLine()!;
    if (name == "выход") Environment.Exit(0);
    Console.Write("Введите логин: ");
    string login = Console.ReadLine()!;
    if (login == "выход") Environment.Exit(0);
    Console.Write("Введите пароль: ");
    string password = Console.ReadLine()!;
    if (password == "выход") Environment.Exit(0);

    users.Add(new User(name, login, password));
}

