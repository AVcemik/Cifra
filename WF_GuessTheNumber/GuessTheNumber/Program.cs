int count = 0;
Console.WriteLine("\tЭто игра \"УГАДАЙ ЧИСЛО:\"");
Console.WriteLine("");

while (true)
{
    Random rnd = new Random();
    int result = rnd.Next(100);
	uint input = 101;
	while (true)
	{
		count++;
		try
		{
			while (true)
			{
				Console.Write("Введиет число: ");
				input = uint.Parse(Console.ReadLine()!);
				if (input <= 100) break;
				else Console.WriteLine("Вы ввели слишком большое значение");
			}
		}
		catch (Exception)
		{
			Console.WriteLine("Вводить можно только положительные целые числа от 0 до 100");
		}

		if (result == input)
		{
			Console.WriteLine("Вы угадали с попытки номер: "+count);
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("Вы победили!!!");
            Console.ForegroundColor = ConsoleColor.White;
            break;
		}
		else if (result < input)
		{
			Console.WriteLine("Загаданное число меньше "+ input);
		}
		else if (result > input)
		{
			Console.WriteLine("Загаданое число больше "+ input);
		}
	}
	break;
}