// Домашнее задание. Тема 17. Урок 1.
// Многомерный массив и массив массивов.

// Создать числовой массив одномерных числовых массивов.
// Вручную заполнить его значениями от 1 до 10.
// Взять от пользователя число 200 и присвоить его одному из элементов массива.
// Вывести весь массив на консоль.

Random random = new();

int[][] mas = new int[][]
{
    new int[] {1},
    new int[] {2},
    new int[] {3},
    new int[] {4},
    new int[] {5},
    new int[] {6},
    new int[] {7},
    new int[] {8},
    new int[] {9},
    new int[] {10},
};

int x = Input200("Введите число 200: ");
mas[random.Next(10)][0] = x;

for (int i = 0; i < mas.Length; i++)
{
    Console.WriteLine(mas[i][0]);
}

Console.WriteLine("\n\nНажмите любую клавишу для завершения...");
Console.ReadKey();
Environment.Exit(0);


static int Input200(string text)
{
    while (true)
    {
        Console.Write(text);
        string input = Console.ReadLine()!;
        bool cheack = int.TryParse(input, out int result);

        if (cheack == true)
        {
            if (result == 200)
            {
                return result;
            }
            else Console.WriteLine("Введите число 200!!!");
        }
        else Console.WriteLine("Вы ввели не число!!!");

    }
}