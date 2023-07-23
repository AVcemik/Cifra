// Программирование на C#
// Данный методический материал рассчитан на 4 уроков
// Урок 1/4
// Тема 20. Локальные функции. Домашнее задание.

// Задание.
// Напишите функцию, которая принимает два числа и выводит на экран их сумму.
// Числа передаются пользователем в переменные, которые затем передаются в функцию.
// Функция должна возвращать результат, который в последствии выводится на консоль


double a = InputDigital("Введите первое число: ");
double b = InputDigital("Введите второе число: ");

Console.WriteLine($"Рузультат суммы чисел {a} + {b} = {Result(a,b)}");




double Result(double a, double b)
{
	return a + b;
}
double InputDigital(string str)
{
	while (true)
	{
		try
		{
			Console.Write(str);
			double digital = double.Parse(Console.ReadLine()!);
			return digital;
		}
		catch (Exception)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("Неверный формат!!!");
			Console.ResetColor();
		}
	}
}