using System;
using System.Linq;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ');
            int K = int.Parse(str[0]);
            int counte = 0;
            for (int i = 1; i != K + 1; i++)
            {
                counte += int.Parse(str[i]);
            }
            K--;
            Console.WriteLine(counte - K);
        }
    }
}
