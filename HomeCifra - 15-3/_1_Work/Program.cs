// Домашнее задание. Тема 15. Урок 3. 
// Свойства и методы одномерных массивов.

// Напишите программу, которая запрашивает у пользователя 10 целых
// чисел и сохраняет их в массиве. Затем программа сортирует массив по
// возрастанию и выводит отсортированный массив на экран.
// Далее программа запрашивает у пользователя число и находит его индекс в массиве.
// Если число не найдено, программа выводит сообщение об ошибке

bool cheak = false;
int temp = 0;
int[] mas = new int[10];
Console.WriteLine("Введите 10 целых чисел...\n");

for (int i = 0; i < 10; i++)
{
    mas[i] = InputInt($"Введите число № {i+1}: ");
}

for (int i = 0; i < mas.Length - 1; i++)
{
    for (int j = 0; j < mas.Length - i - 1; j++)
    {
        if (mas[j] > mas[j+1])
        {
        temp = mas[j];
        mas[j] = mas[j+1];
        mas[j+1] = temp;
        }
    }
}

for (int i = 0; i < mas.Length; i++)
{
    Console.Write($"{mas[i]} ");
}
Console.WriteLine("\n");

temp = InputInt("Введите число для проверки его индекса: ");
for (int i = 0; i < mas.Length; i++)
{
    if (mas[i] == temp)
    {
        Console.WriteLine($"Индекс числа {temp} = {i}");
        cheak = true;
    }
}
if (cheak == false) Console.WriteLine("Такого числа в данном массиве нет!!");

Console.WriteLine("\n\nНажмите любую клавишу для завершения...");
Console.ReadKey();
Environment.Exit(0);



static int InputInt(string text)
{
    while (true)
    {
        Console.Write(text);
        string? temp = Console.ReadLine();
        bool cheack = int.TryParse(temp.Replace('.', ','), out int result);

        if (cheack == true) return result;
        else
        {
            Console.WriteLine("\nВы ввели недопустимое значение...");
            continue;
        }
    }
}