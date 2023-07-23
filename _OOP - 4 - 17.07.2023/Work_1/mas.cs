using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_1
{
    internal class masiv
    {
        private string[] mas;
        public int Lenght { get; private set; }

        masiv (int lenght)
        {
            this.mas = new string[lenght];
            Lenght = lenght;
        }
        public void GetMas(string str)
        {
            mas = str;
        }

        public void Print()
        {
            Console.WriteLine("Массив:");

            for (int i = 0; i < Lenght; i++)
            {
                Console.WriteLine($"{i}: {mas[i]}");
            }
        }
    }
}
