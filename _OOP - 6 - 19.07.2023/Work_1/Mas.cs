using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_1
{
    internal static class Mas
    {

        public static double AverageSum(int[] mas)
        {
            if (mas.Length == 0 || mas == null)
            {
                throw new ArgumentException("Массив не должен быть пустым");
            }

            for (int i = 1; i < mas.Length; i++)
            {
                mas[0] += mas[i];
            }
            return (double)mas[0] / mas.Length;
        }

        public static void InversiaMas(char[] mas)
        {
            if (mas.Length == 0 || mas == null)
            {
                throw new ArgumentException("Массив не должен быть пустым");
            }
            
            for (int i = 0; i < mas.Length/2; i++)
            {
                char temp = mas[i];
                mas[i] = mas[mas.Length-1-i];
                mas[mas.Length-1-i] = temp;
            }

            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(mas[i] + " ");
            }
            Console.WriteLine();
        }



    }
}
