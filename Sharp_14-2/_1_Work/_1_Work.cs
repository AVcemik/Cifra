﻿namespace _1_Work
{
    internal class _1_Work
    {
        static void Main(string[] args)
        {
            // Домашнее задание. Тема 14. Урок 2. Цикл For.
            //1.Напишите программу, случайным образом генерирующую температуры от 1 до 100.В случае превышения, устройство
            // останавливает работу с выводом значения критической температуры на экран.
            // Алгоритм работы:
            //      ● Создать экземпляр класса Random. (Random rnd = new Random();)
            //      ● Инициализировать переменную temperature значением 0.
            //      ● Запустить цикл, начиная с i = 1.
            //      ● В теле цикла:
            //      ● a.Сгенерировать случайное число в диапазоне от 1 до 100 и сохранить его в переменную temperature.
            //      ● b.Вывести на экран текущую температуру.
            //      ● c.Проверить, превышает ли текущая температура критическую (больше 90).
            //      ● d.Если текущая температура превышает критическую, вывести сообщение об остановке устройства и прервать цикл.

            Random random = new Random();
            int _temperature = 0;
            int _count = 10; // Кол-во циклов

            for (int i = 1; i < _count; i++) // По заданию не понял сколько бегать по циклу?...
            {
                _temperature = random.Next(1,101);
                Console.WriteLine($"Текущая температур: {_temperature}");

                if (_temperature > 90)
                {
                    Console.WriteLine("\nУстройство остановлено из за превышении температуры!!!");
                    break;
                }

            }

            Console.WriteLine("\nНажмите любую клавишу для завершения...");
            Console.ReadKey();
        }
    }
}