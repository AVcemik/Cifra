// Домашнее задание. Тема 17. Урок 2.
// Многомерный массив и массив массивов.

// Создайте массив из трех одномерных массивов. [3][ ]
// Заполните его значениями чисел от 1 до 10 (можно вручную, можно рандомом)
// Далее добавьте вывод всех значений массива.
// каждый одномерный массив выводится построчно в консоль
// Далее выведите сумму каждого одномерного массива
// *Выведите в конце среднее арифметическое всех значений массива

int temp = 0;
Random random = new();
int[][] mas = new int[3][]
{
	new int[5],
    new int[5],
    new int[5],
};

for (int i = 0; i < mas.Length; i++)
{
	for (int j = 0; j < mas[i].Length; j++)
	{
		mas[i][j] = random.Next(10);
	}
}

Console.WriteLine("Массивы + сумма\n");

for (int i = 0; i < mas.Length; i++)
{
    temp = 0;
    for (int j = 0; j < mas[i].Length; j++)
    {
        temp += mas[i][j];
        if (mas[i].Length == j+1) Console.Write(" | " + mas[i][j] + " | сумма: " + temp + " | Средне арифмитическое значени: " + temp / mas[i].Length);
        else Console.Write(" | " + mas[i][j]);
    }
    Console.WriteLine();
}



Console.WriteLine("\n\nНажмите любую клавишу для завершения...");
Console.ReadKey();
Environment.Exit(0);