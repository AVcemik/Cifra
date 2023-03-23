namespace Test
{
    internal class Test
    {
        static void Main(string[] args)
        {
            // Написать программу по определению категории числа.
            // То есть вводим чмсло, а программа отвечает
            // 15 - целое число
            // 123фыв - Неудалось определить число
            // -12 - Целое отрицательно число
            // 123.45 - Вещественное число

            // Требования к коду:
            // * Задача должна быть решена на сложных if ветвлениях
            // То есть в одном условии должен получиться полностью ответ.
            // if (условие_1) && (условие_2) то вывести "Целое положительное число.
            // * Все вычесления должны быть выполнены в функцияхd

            ReadValue("Введите число: ");

            string ReadValue(string mesasge)
            {
                int resultInt = 0;
                float resultFloat = 0F;
                Console.Write(mesasge);
                string result = null;

                string line = Console.ReadLine();

                Int32.TryParse(line, out resultInt);    //постарайся избавиться от инта, флоат тоже может быть целым
                Single.TryParse(line, out resultFloat); //а почему не флоат.ТрайПарс?

                if (resultInt != 0 && resultInt > 0 || resultInt == 0 && resultFloat == 0)
                {
                    result = resultInt + " - Целое положительное число.";  
                }
                else if (resultInt != 0 && resultInt < 0)
                {
                    result = resultInt + " - Целое отрицательное число.";
                }
                else if (resultFloat != 0 && resultFloat > 0)
                {
                    result = resultFloat + " - Вещественное положительное число.";
                }
                else if (resultFloat != 0 && resultFloat < 0)
                {
                    result = resultFloat + " - Вещественное отрицательное число.";
                }
                else
                {
                    badExit();
                }
                Console.WriteLine(result);
                return result;
            }

            void badExit()
            {
                Console.WriteLine("Не удалось определить число! \n\nНажмите любую клавишу для завершения...");
                Console.ReadKey();
                Environment.Exit(0);    //Прикольно, не знал такого )
            }
        }
    }
}
