// Домашнее задание. Тема 16. Урок 2.
// Двумерные массивы.

bool cheack = false;
string? result;
char[,] _mas = new char[11, 6];
_mas = Bulb(_mas);
_mas = BulbOff(_mas);

while (true)
{
    if (cheack == true)
    {
        _mas = BulbOn(_mas);
        OutputBulb(_mas);
        Console.Write("Выключить лампочку? ");
        result = Console.ReadLine().ToLower();

        if (result == "да")
        {
            cheack = false;
            continue;
        }
        else
        {
            Console.WriteLine("Состояния лампы \"Включено\"");
            break;

        }
    }
    if (cheack == false)
    {
        _mas = BulbOff(_mas);
        OutputBulb(_mas);
        Console.Write("Включить лампочку? ");
        result = Console.ReadLine().ToLower();

        if (result == "да")
        {
            cheack = true;
            continue;
        }
        else
        {
            Console.WriteLine("Состояния лампы \"Выключено\"");
            break;
        }
    }

}


ExitProgramm();

static void OutputBulb(char[,] mas)
{
    Console.Clear();
	for (int i = 0; i < mas.GetLength(0); i++)
	{
		for (int j = 0; j < mas.GetLength(1); j++)
		{
			Console.Write(mas[i,j]);
		}
		Console.WriteLine();
	}
}
static char[,] BulbOff(char[,] mas)
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            if (i == 1)
            {
                if (j == 1 || j  == 4) mas[i, j] = 'x';
                else mas[i, j] = ' ';
            }
            if (i == 2)
            {
                if (j == 0 || j  == 5) mas[i, j] = 'x';
                else mas[i, j] = ' ';
            }
        }
    }
    return mas;
}
static char[,] BulbOn(char[,] mas)
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            if (i == 1)
            {
                if (j >= 1 && j  <= 4) mas[i, j] = 'x';
                else mas[i, j] = ' ';
            }
            if (i == 2)
            {
                if (j >= 0 && j  <= 5) mas[i, j] = 'x';
                else mas[i, j] = ' ';
            }
        }
    }
    return mas;
}
static char[,] Bulb(char[,] mas)
{
	for (int i = 0; i < mas.GetLength(0); i++)
	{
		for (int j = 0; j < mas.GetLength(1); j++)
		{
			if (i == 0 || i >3 && i<10)
			{
				if (j == 2 || j == 3) mas[i, j] = 'x';
				else mas[i, j] = ' ';
			}
			if (i == 1 || i == 3 || i==10)
			{
				if (j >0 && j <5) mas[i, j] = 'x';
				else mas[i, j] = ' ';
			}
			if (i == 2) mas[i, j] = 'x';
		}
	}
    return mas;
}
static void ExitProgramm()
{
	Console.WriteLine("\n\nНажмите любую клавишу для завершения программы....");
	Console.ReadKey();
	Environment.Exit(0);
}