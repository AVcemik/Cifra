// Домашнее задание. Тема 16. Урок 1. Двумерные массивы.

// 2. Создать массив символов 5х2. Заполнить его символами по желанию в разнобой.
// Вывести на экран понятное слово

char[,] mas = new char[2, 5] {{ 'П','и','в','р','е'}, {'р',' ','т','М','и'}};
string result = "Привет Мир";

for (int i = 0, n =0; i < mas.GetLength(0); i++)
{
	for (int j = 0; j < mas.GetLength(1) && n < 10; j++)
	{
		if (result[n] == mas[i,j])
		{
			Console.Write(mas[i,j]);
			i = 0;
			j = 0;
			n++;
		}
	}
}

Console.WriteLine("\n\nНажмите любую клавишу для завершения...");
Console.ReadKey();
Environment.Exit(0);