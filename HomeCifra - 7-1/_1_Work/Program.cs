// Домашнее задание. Тема 7. Урок 1-2. Ввод и вывод значений консоли.

// 1. Напишите программу, запрашивающую у пользователя радиус
// окружности и производящую просчет площади круга, используя
// заранее заданную константу числа PI.

// 2. Напишите программу, запрашивающую у пользователя данные о
// нем и выводящую его досье.
// Используйте для данного задания Интерполяцию.

// 3. Дополнительно изучите структуру DateTime.

// Внимательно следите за корректностью написания синтаксиса.
// Ответ отправить в виде документа, где прикрепить скрин экрана, в
// котором видно код и вывод в консоль


// Задание 1
using _1_Work;

Console.Write("Введите радиус окружности");
int radius = inputInt();

double s = Math.PI * Math.Sqrt(radius);

// Задание 2
addFunc name = new addFunc();
Console.Write("Введите ваше имя:");
name.setFirstName(Console.ReadLine()!);
Console.Write("Введите ваше фамилию:");
name.setLastName(Console.ReadLine()!);
Console.Write("Введите ваше отчество:");
name.setSecondName(Console.ReadLine()!);

Console.WriteLine($"Имя - {name.getFirstName()}\nФамилия - {name.getLastName()}\nОтчество - {name.getSecondName()}");




int inputInt()
{
    int digital = -1;
    while (true)
    {
        string str = Console.ReadLine()!;
        int.TryParse(str, out digital);
        if (digital != -1) break;
    }
    return digital;
}