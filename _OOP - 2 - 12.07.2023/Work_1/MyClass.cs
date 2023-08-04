using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _12._07._2023___2___OOP
{
    internal class MyClass
    {
        private int[] mas;
        
        public MyClass(int size) 
        {
            mas = new int[size];
        }

        public void FillRandom()
        {
            Random r = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = r.Next(20);
            }
        }
        public void Shuffle()
        {
            Random r = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                int j = r.Next(mas.Length);
                int temp = mas[i];
                mas[i] = mas[j];
                mas[j] = temp;
            }
        }
        public int CountElement()
        {
            return mas.Distinct().Count();
        }

        public void InputMas()
        {
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write($"{mas[i]} ");
            }
            Console.WriteLine();
        }
    }
}
