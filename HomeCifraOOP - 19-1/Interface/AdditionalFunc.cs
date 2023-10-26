using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public static class AdditionalFunc
    {
        public static void ColorText(string str, Colors color)
        {
            if (color == Colors.Green)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(str);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else if (color == Colors.Red)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(str);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            AdditionalFunc.PauseSoft();
        }
        public static void PauseSoft()
        {
            Console.WriteLine("Нажмите любую клавишу для продолжения...");
            Console.ReadKey();
        }
        public static void ExitSoft()
        {
            Console.WriteLine("Нажмите любую клавишу для завершения...");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
