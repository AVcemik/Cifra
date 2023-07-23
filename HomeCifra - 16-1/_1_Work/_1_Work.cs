// Домашнее задание. Тема 16. Урок 1. Двумерные массивы.

// 1. Создать двумерный массив 3х3. Заполнить его дробными числами от 0 до 20.
// Оформить вывод на экран всех чисел.
// Добавить возможность замены значения пользователем. Вывод нового массива.

int x, y;
double[,] mas = new double[3,3];
Random random = new();

for (int i = 0; i < mas.GetLength(0); i++)
{
	for (int j = 0; j < mas.GetLength(1); j++)
	{
		mas[i, j] = random.NextDouble() * 20;
	}
}

while (true)
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            Console.Write($"{mas[i, j]:F2} \t".Replace(',', '.'));
        }
        Console.WriteLine();
    }
    Console.WriteLine();

    Console.Write("Введите номер строки: ");
    x = InputNumber();

    if (x < mas.GetLength(0) && x >= 0) { break; }
    else if (x == -404)
    {
        Console.Clear();
        Console.WriteLine("Вы ввели недопустимый символ!!!\n");
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Вы ввели неверный номер строки...\n");
    }
}

Console.Clear();
while (true)
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            Console.Write($"{mas[i, j]:F2} \t".Replace(',', '.'));
        }
        Console.WriteLine();
    }
    Console.WriteLine();

    Console.Write("Введите номер строки: ");
    y = InputNumber();

    if (y < mas.GetLength(0) && y >= 0) { break; }
    else if (y == -404)
    {
        Console.Clear();
        Console.WriteLine("Вы ввели недопустимый символ!!!\n");
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Вы ввели неверный номер строки...\n");
    }
}

Console.Clear();
mas[x,y] = InputDouble();

Console.Clear();
for (int i = 0; i < mas.GetLength(0); i++)
{
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        Console.Write($"{mas[i, j]:F2} \t".Replace(',', '.'));
    }
    Console.WriteLine();
}

Console.WriteLine("\n\nНажмите любую клавишу для завершения...");
Console.ReadKey();
Environment.Exit(0);

//////////////////////////////////////////////////////

static int InputNumber()
{
	while (true)
	{
	    string? inputDigital = Console.ReadLine();
		bool check = int.TryParse(inputDigital, out int result);

		if (check == true) { return result -= 1; }
		else break;
	}
	return -404;
}

double InputDouble()
{
    while(true)
    {
        for (int i = 0; i < mas.GetLength(0); i++)
        {
            for (int j = 0; j < mas.GetLength(1); j++)
            {
                Console.Write($"{mas[i, j]:F2} \t");
            }
            Console.WriteLine();
        }
        Console.WriteLine($"\nВыбраны | строка: {x+1} | столбец: {y+1}");
        Console.WriteLine();

        Console.Write("Введите новое значение (в диапозоне 0-20): ");

        string? inputDigital = Console.ReadLine().Replace('.', ',');
        bool check = double.TryParse(inputDigital, out double result);

        if (check == true && result < 20 && result >= 0) { return result; }
        else if (check == true)
        {
            Console.Clear();
            Console.WriteLine("Вы ввели недопустимое значение...\n");
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Вы ввели недопустимый символ...\n");
        }
    }
}