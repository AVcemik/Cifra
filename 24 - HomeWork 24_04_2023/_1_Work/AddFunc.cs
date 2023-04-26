using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Work
{
    internal class AddFunc
    {
        public static double CheckDouble()
        {
            double digital;
            string stDigital = Console.ReadLine().Replace('.', ',');
            if (double.TryParse(stDigital, out digital) == true)
            {
                return digital;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Вы ввели не число (Число может быть как целым так и вещественным)"); 
                Console.Write("Введите число: ");
                return CheckDouble();
            }
        }
        public static int CheckInt()
        {
            int digital;
            string stDigital = Console.ReadLine().Replace('.', ',');
            if (int.TryParse(stDigital, out digital) == true)
            {
                return digital;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Вы ввели не число!!! (Число может быть только целым)");
                Console.Write("Введите число: ");
                return CheckInt();
            }
        }
            public static void ExitProgramm()
        {
            Console.WriteLine("\n\nНажмите любую клавишу для завершнеия...");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
