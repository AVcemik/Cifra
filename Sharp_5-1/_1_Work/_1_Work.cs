namespace _1_Work
{
    internal class _1_Work
    {
        static void Main(string[] args)
        {
            // Домашнее задание. Тема 5. Урок 1. Константы и литералы.
            // 1. Используя константы, напишите программу для перевода милиметров в:
            // А. Сантиметры
            // B. Метры
            // C. Километры
            // D. *Мили
            // E. **Ярды

            const int SANTIMETR = 10;
            const int METR = 1000;
            const int KILOMETR = 1000000;
            const double MILI = 1609344;
            const double YARD = 914.4;

            Console.Write("Введите кол-во милиметров: ");
            double milimetr = InputDigital();
            Console.WriteLine("");
            Console.Write($"Сантиметров: {milimetr / SANTIMETR}\n");
            Console.Write($"Метров: {milimetr / METR}\n");
            Console.Write($"Километров: {milimetr / KILOMETR}\n");
            Console.Write($"Миль: {milimetr / MILI}\n");
            Console.Write($"Ярдов: {milimetr / YARD}\n");

            Console.WriteLine("\nНажмите любую клавишу для завершения...");
            Console.ReadKey();

            double InputDigital()
            {

                while (true)
                {
                    string str = Console.ReadLine().Trim().Replace(",", ".");
                    bool check = double.TryParse(str, out double result);

                    if (check == true)
                    {
                        if (result > 0) return result;
                        else if (result == 0) return 0;
                        else Console.Write("Введите положительное число: ");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Вы ввели не число!!!");
                        Console.Write("Введите кол-во милиметров: ");
                    }
                }
            }
        }
    }
}