// Программирование на C#
// Данный методический материал рассчитан на 4 урока
// Урок 3/4
// Тема 20. Локальные функции. Домашнее задание.

// Напишите программу, которая выполняет логическое побитовое
// умножение, сложение, шифрование по ключу и инверсию.
// Пользователь вводит число, затем вид операции с числом и получает
// результат в зависимости от своего выбора
int _number;
while (true)
{
	try
	{
		Console.Write("Введите число: ");
		_number = int.Parse(Console.ReadLine()!);
		break;
	}
	catch (Exception)
	{
		Console.ForegroundColor = ConsoleColor.Red;
		Console.WriteLine("\nНеверный формат!!!");
		Console.ResetColor();
	}
}
Console.WriteLine();
byte _operation = 0;
Console.WriteLine("1 - Логическое побитовое умножение");
Console.WriteLine("2 - Логическое побитовое сложение");
Console.WriteLine("3 - Шифрование по ключу");
Console.WriteLine("4 - Инверсия");

while (true)
{
	try
	{
        Console.Write("Введите номер необходимой операции: ");
        byte x = byte.Parse(Console.ReadLine()!);
		if (x > 0 && x <= 4)
		{
			_operation = x;
			break;
		}
		else
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("Данного номера нет в списке");
			Console.ResetColor();
		}
    }
	catch (Exception)
	{
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nНеверный формат!!!");
        Console.ResetColor();
    }
}

switch (_operation)
{
	case 1:
		Console.WriteLine($"Результат логического умножения: {Multiply(_number)}");
		break;
    case 2:
        Console.WriteLine($"Результат логического сложения: {Sum(_number)}");
        break;
    case 3:
        Console.WriteLine($"Результат логического сложения: {EncryptedNumber(_number)}");
        break;
    case 4:
        Console.WriteLine($"Результат логической инверсии: {~_number}");
        break;
}

int EncryptedNumber(int number)
{
    int x;
    while (true)
    {
        try
        {
            Console.Write("Введите ключ шифрования: ");
            x = int.Parse(Console.ReadLine()!);
            break;
        }
        catch (Exception)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nНеверный формат!!!");
            Console.ResetColor();
        }
    }
    int result = number ^ x;
    return result;
}

int Sum(int number)
{
    int x;
    while (true)
    {
        try
        {
            Console.Write("Введите число которое необходимо сложить: ");
            x = int.Parse(Console.ReadLine()!);
            break;
        }
        catch (Exception)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nНеверный формат!!!");
            Console.ResetColor();
        }
    }
    int result = number | x;
    return result;
}
int Multiply(int number)
{
	int x;
	while (true)
	{
        try
        {
            Console.Write("Введите число на которое необходимо умножить: ");
            x = int.Parse(Console.ReadLine()!);
            break;
        }
        catch (Exception)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nНеверный формат!!!");
            Console.ResetColor();
        }
    }
	int result = number & x;

	return result;
}