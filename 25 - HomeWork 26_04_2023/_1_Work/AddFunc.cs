using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Work
{
    public class AddFunc
    {
        public static int[,] Fill2DArray(int x, int y)
        {
            Random rnd = new Random();
            int[,] array = new int[x,y];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1) - 1; j++)
                {
                    if (j == 0) array[i, j] = i+1;
                    else array[i, j] = rnd.Next(10, 100);
                }
            }
            return array;
        }
        public static int[,] Input2DArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (j == 0) Console.Write(array[i, j] + "\t");
                    else if (j == array.GetLength(1) - 1) { array[i, 3] = array[i, 1] + array[i, 2]; Console.Write(" = " + array[i, j]); }
                    else Console.Write(array[i, j] + " ");
                }
                Console.WriteLine("");
            }
            return array;
        }
        public static void ExitProgramm()
        {
            Console.WriteLine("\n\nНажмите любую клавишу для продолжения...");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
