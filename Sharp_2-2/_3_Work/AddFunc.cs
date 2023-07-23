using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Work
{
    public class AddFunc
    {
        public static int InputNumber(string digital)
        {
            Console.Write($"Введите {digital} число: ");
            return int.Parse(Console.ReadLine());
        }

        public static void ExitProgramm()
        {
            Console.WriteLine("\n\nНажмите любую клавишу для завершения...");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
