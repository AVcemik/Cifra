namespace _1_Work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Лубенец Problem2 (156-10)

            // 1.Ввести значение и проверить, является ли оно данными типа время.
            // 2.Разработать систему, отложения начала выполнения программы
            // посудомоечной машинки на указанное количество часов.
            // Систему представить в виде программы, в которой пользователь
            // вводит длительность работы посудомоечной машинки в минутах и
            // время отсрочки начала запуска программы в часах.
            // Определить дату и время начала мойки, а также дату и время ее
            // окончания относительно текущих значений даты и времени в момент нажатия кнопки «Пуск».

            // Задача №1
            Console.Write("Введите время для проверки: ");
            string? test = Console.ReadLine();
            TimeOnly testTime;
            bool testCheck = TimeOnly.TryParse(test, out testTime);

            if (testCheck == true) Console.WriteLine($"Значение {testTime} является типом - {testTime.GetType()}");
            else Console.WriteLine($"Значение {test} не является данными типа время");
            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для продолжения...");
            Console.ReadKey();

            // Задача №2
            Console.Clear();
            Console.WriteLine("Настрока посудомоечной машины\n");
            Console.Write("Введите длительность работы посудомоечной машины (в минутах): ");
            int startMinute = InputDigital();

            Console.Clear();
            Console.WriteLine("Настрока посудомоечной машины");
            Console.WriteLine($"Время работы посудомоечной машины {startMinute} минут\n");
            Console.Write("Укажите на сколько отсрочить запуск (в часах): ");
            int delayedStartHour = InputDigital();

            Console.Clear();
            Console.WriteLine("Посудомоечная машина настроена успешно\n");
            Console.WriteLine("Текущие настройки: ");
            Console.WriteLine($"Время работы посудомоечной машины: {startMinute} минут");
            Console.WriteLine($"Отсроченное время старта: {delayedStartHour} часов\n");
            Console.WriteLine("Для запуска нажмите любую клавишу...");
            Console.ReadKey();


            DateTime timeNow = DateTime.Now;
            DateTime startTime = DateTime.Now.AddHours(delayedStartHour);
            DateTime endTime = startTime.AddMinutes(startMinute);
            Console.Clear();
            Console.WriteLine($"Текущая дата и время: \t{timeNow.ToShortDateString()} {timeNow.ToShortTimeString()}");
            Console.WriteLine($"Начало мойки в: \t{startTime.ToShortDateString()} {startTime.ToShortTimeString()}");
            Console.WriteLine($"Окончание мойки в: \t{endTime.ToShortDateString()} {endTime.ToShortTimeString()}");



            void ExitProgramm()
            {
            Console.WriteLine("\n\nНажмите любую клавишу для завершения...");
            Console.ReadKey();
            Environment.Exit(0);
            }

            int InputDigital()
            {
                bool cheack = false;
                int result;

                while (true)
                {
                    string str = Console.ReadLine();
                    cheack = int.TryParse(str, out result);

                    if (cheack == true && result >= 0)
                    {
                        return result;
                        break;
                    }
                    else if (cheack == true && result < 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Время не может быть отрицательным!!!\n");
                        Console.WriteLine("Настрока посудомоечной машины\n");
                        Console.Write("Введите длительность работы посудомоечной машины (в минутах): ");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Вы указали не верный формат времени!!!\n");
                        Console.WriteLine("Настрока посудомоечной машины\n");
                        Console.Write("Введите длительность работы посудомоечной машины (в минутах): ");
                    }
                }
            }
        }
    }
}