using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace Olymp
{
    internal class Program
    {
        static int result;
        
        static void Main(string[] args)
        {
            // Пример 1 (входные данные уже в переменных)

            //int bugs = 100;
            //int box = 5;
            //int[] capacityBug = new int[] { 75, 78, 44, 47, 42 };
            //int[] capacityPrice = new int[] { 67, 3, 67, 72, 17 };
            //int result = int.MaxValue;


            // Решение(Входные данные принимает с ввода)

            string[] str1 = Console.ReadLine().Split(' ');
            string[] str2 = Console.ReadLine().Split(' ');
            string[] str3 = Console.ReadLine().Split(' ');

            result = int.MaxValue;

            int bugs = int.Parse(str1[0]);
            int box = int.Parse(str1[1]);
            int[] capacityBug = Array.ConvertAll(str2, int.Parse);
            int[] capacityPrice = Array.ConvertAll(str3, int.Parse);

            for (int i = 0+2; i < box; i++)
            {
                capacityBug[i] = int.Parse(str2[i]);
            }
            for (int i = 0+2+box; i < box; i++)
            {
                capacityPrice[i] = int.Parse(str3[i]);
            }

            Price(bugs, 0, 0, box, capacityBug, capacityPrice);

            if (result == int.MaxValue)
            {
                Console.WriteLine(result);
            }
            Console.WriteLine(result);
        }
        static void Price(int capacityBugs, int capacityPrices, int i, int box, int[] capacityBug, int[] capacityPrice)
        {
            if (capacityBugs <= 0 && capacityPrices < result) result = capacityPrices;
            if (i == box) return;

            Price(capacityBugs, capacityPrices, i + 1, box, capacityBug, capacityPrice);
            Price(capacityBugs - capacityBug[i], capacityPrices + capacityPrice[i], i + 1, box, capacityBug, capacityPrice);
        }
    }
}
