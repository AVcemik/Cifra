using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_1
{
    internal class masiv
    {
        private string[] Mas { get; set; }
        public int Lenght { get; private set; }

        masiv (int lenght)
        {
            Mas = new string[lenght];
            Lenght = lenght;
        }


        public void Print()
        {
            Console.WriteLine("Массив:");

            for (int i = 0; i < Lenght; i++)
            {
                Console.WriteLine($"{i}: {Mas[i]}");
            }
        }
    }
}
