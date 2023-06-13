// Программирование на C#
// Данный методический материал рассчитан на 4 урока
// Урок 4/4
// Тема 20. Локальные функции. Домашнее задание.

// Проинициализируйте вручную два массива 4х4, значениями от -50 до 50.
// Напишите функции:
// 1.Суммирующую массивы и возвращающую в качестве результата новый массив суммы.
// 2. Поиска максимального значения массива.

int[,] _mas1 = new int[4, 4] 
{{ 45, -20, 8, 6 },
{-20, -50, 48, 32},
{43, -32, 12, 26 },
{-31, -12, 42, -6 }};

int[,] _mas2 = new int[4, 4]
{{11,23,34,50},
{-41,-12,-36,-28},
{-16,47,38,-4},
{2,34,-3,-44}};

InputMas(_mas1);
Console.WriteLine();
InputMas(_mas2);
Console.WriteLine();
InputMas(SumMas(_mas1, _mas2));
Console.WriteLine();
Console.WriteLine($"Максимальное значение в массиве 3: {MaxMas(SumMas(_mas1, _mas2))}");
ProgramExit();


int MaxMas(int[,] mas)
{
	int result = -51;
	for (int i = 0; i < mas.GetLength(0); i++)
	{
		for (int j = 0; j < mas.GetLength(1); j++)
		{
			if (mas[i, j] > result) result = mas[i, j];
		}
	}
	return result;
}
int[,] SumMas(int[,] mas1, int[,] mas2)
{
	int[,] result = new int[4, 4];

	for (int i = 0; i < result.GetLength(0); i++)
	{
		for (int j = 0; j < result.GetLength(1); j++)
		{
			result[i, j] = mas1[i, j] + mas2[i, j];
		}
	}
	return result;
}
void InputMas(int[,] mas)
{
	for (int i = 0; i < mas.GetLength(0); i++)
	{
		for (int j = 0; j < mas.GetLength(1); j++)
		{
			Console.Write($"{mas[i,j]} ");
		}
		Console.WriteLine();
	}
}

void ProgramExit()
{
	Console.WriteLine("Нажмите любую клавишу для завершения...");
	Console.ReadKey();
	Environment.Exit(0);
}