// Домашнее задание. Тема 15. Урок 4. 
// Свойства и методы одномерных массивов. Тип Object.
// Создать 4 массива. Заполнить их случайными числами.
// Конечным результатом должен быть, выведенный на консоль, массив, хранящий следующее:
// Произведение средних арифметических (1и2) и(3и4) массивов поиндексно.

object[] mas1 = new object[2];
object[] mas2 = new object[2];
object[] mas3 = new object[2];
object[] mas4 = new object[2];
object[] result = new object[2];
Random random = new Random();

for (int i = 0; i < mas1.Length; i++)
{
    mas1[i] = random.Next(1, 20);
    mas2[i] = random.Next(1,20);
    mas3[i] = random.Next(1, 20);
    mas4[i] = random.Next(1,20);
}
Console.Write("Масив №1 - ");
OutputMas(mas1);
Console.Write("Масив №2 - ");
OutputMas(mas2);
Console.Write("Масив №3 - ");
OutputMas(mas3);
Console.Write("Масив №4 - ");
OutputMas(mas4);

for (int i = 0; i < mas1.Length; i++)
{
    mas1[i] = ((int)mas1[i] + (int)mas2[i]) / 2D;
    mas3[i] = ((int)mas3[i] + (int)mas4[i]) / 2D;
    result[i] = (double)mas1[i]*(double)mas3[i];
}
Console.Write("Средне арифметическая масивов 1 и 2 - ");
OutputMas(mas1);
Console.Write("Средне арифметическая масивов 3 и 4 - ");
OutputMas(mas3);
Console.Write("И их произведения - ");
OutputMas(result);


void OutputMas(object[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        Console.Write($"{mas[i]} ");
    }
    Console.WriteLine();
}