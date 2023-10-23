/*
                            Тема 21. Урок 1.
                            Домашнее задание.
Анонимные методы, лямбда, подробнее о делегатах. Данное домашнее задание дается на 2 урока.
Просто прикрепляйте один и тот же ответ к текущему и следующему.

Задача 1. Создайте анонимный метод, который принимает два аргумента
(числа) и возвращает их сумму. Затем создайте делегат, который может
вызывать этот анонимный метод, и используйте его для выполнения
сложения чисел.

Задача 2. Создайте массив строк и отфильтруйте его с использованием
лямбда-выражения. Отфильтруйте строки, чтобы получить только те,
которые начинаются с определенной буквы (например, "A").

Задача 3. Создайте массив делегатов, представляющих различные
математические операции (сложение, вычитание, умножение, деление).
Запросите у пользователя числа и операцию, которую он хочет выполнить.
Затем используйте массив делегатов, чтобы выполнить выбранную
операцию с введенными числами.
*/

// Задание №1
MyDelegateOne myDelegateOne = delegate (int x, int y) { return x + y; };
Console.WriteLine("Задание №1: " + myDelegateOne(2, 3));

// Задание №2
string[] masiv = new string[]
{
    "Апладисменты",
    "Паладин",
    "Учеба",
    "Авангард",
    "Цифра",
    "азбука",
    "смешарики"
};
MyDelegateTwo myDelegateTwo = (string[] masivString) =>
{
    for (int i = 0; i < masivString.Length; i++)
    {
        if (masivString[i][0] == 'А' || masivString[i][0] == 'а' || masivString[i][0] == 'A' || masivString[i][0] == 'a')
        {
            Console.WriteLine(masivString[i]);
        }
    }
};
Console.WriteLine("\nЗадание №2:");
myDelegateTwo(masiv);


Console.WriteLine("\nЗадание №3:");
Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("1 - Сложение\n2 - Вычитание\n3 - Умножение\n4 - Деление\nВыберите номер меню: ");
string operation = Console.ReadLine()!;


switch (operation)
{
    case "1":
        {
            Summation(firstNumber, secondNumber);
            break;
        }
    case "2":
        {
            Subtraction(firstNumber, secondNumber);
            break;
        }
    case "3":
        {
            Multiplication(firstNumber, secondNumber);
            break;
        }
    case "4":
        {
            Division(firstNumber, secondNumber);
            break;
        }

}


// Задание №3
MyDelegateThre[] myDelegateThree = new MyDelegateThre[4];
myDelegateThree[0] = Summation;
myDelegateThree[1] = Subtraction;
myDelegateThree[2] = Multiplication;
myDelegateThree[3] = Division;


static void Division(int x, int y)
{
    Console.WriteLine($"{(double)x / y:F2}");
}

static void Multiplication(int x, int y)
{
    Console.WriteLine(x * y);
}
static void Subtraction(int x, int y)
{
    Console.WriteLine(x - y);
}

static void Summation(int x, int y)
{
    Console.WriteLine(x + y);
}


public delegate int MyDelegateOne(int firstValue, int secondValue);
public delegate void MyDelegateTwo(string[] masivString);
public delegate void MyDelegateThre(int firstValue, int secondValue);

