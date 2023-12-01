using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAccount
{
    public static class Other
    {
        public static void DisplayTextRed(string word) // Вывести текст красного цвета
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(word);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        public static void DisplayTextGreen(string word) // Вывести текст зеленым цветом
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(word);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        public static void PausedApp() // Приостановить выполнение программы
        {
            Console.WriteLine("\n\nНажмите любую клавишу для продолжения...");
            Console.ReadKey();
        }
        public static void ExitApp() // Завершить выполнение программы
        {
            Console.WriteLine("Нажмите любую клавишу для завершения программы...");
            Program.SerializationXML();
            Environment.Exit(0);
        }
    }
}
