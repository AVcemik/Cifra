// Программирование на C#
// Данный методический материал рассчитан на 4 урока
// Урок 1/4
// Тема 21. Работа с файловой системой. Домашнее

// задание.
// Создайте вручную папку с домашним заданием.
// Напишите программу, которая просит пользователя ввести путь к файлу и текст,
// который необходимо записать в него.
// После записи вывести на экран информацию “Файл успешно записан”.
// Создать еще 2 файла с названиями “Файл2” и “Файл3” программно
// Вывести на экран содержимое 1го файла.


Console.Write("Введите путь, куда сохранить файл: ");
string _Path = Console.ReadLine()!;
string? str = null;
string? str2 = null;

try
{
	for (int i = 1; i <= 3; i++)
	{
		using (StreamWriter writer = File.CreateText(_Path + "\\Файл" + i + ".txt"))
		{
			if (i == 1)
			{
				Console.Write("Введите текст: ");
				str = Console.ReadLine()!;
			}
			writer.WriteLine(str);
		}

		if (i == 1)
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("Файл успешно создан");
			Console.ForegroundColor= ConsoleColor.White;
		}
	}
}
catch (Exception ex)
{
	Console.WriteLine("Ошибка при создании файла " + ex.Message);
}
Console.WriteLine();
Console.WriteLine("Содержимое файла: ");

using (StreamReader reader = File.OpenText(_Path + "\\Файл1.txt"))
{
	foreach (char item in reader.ReadToEnd())
	{
		Console.Write(item);
	}
}