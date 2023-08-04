using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Work_1
{
    internal class Masiv
    {
        private string[] mas;
        private static int Length;

        public Masiv(int lenght)
        {
            this.mas = new string[lenght];
            Length=lenght;
        }

        public Masiv()
        {
            this.mas = new string[Length];
        }
        // Установка длины массивов
        public static void SetLength(int length)
        {
            Length = length;
        }
        public int GetLength()
        {
            return Length;
        }
        
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < Length)
                    return mas[index];
                else
                    throw new IndexOutOfRangeException("Индекс находится за пределами массива.");
            }
            set
            {
                if (index >= 0 && index < Length)
                    mas[index] = value;
                else
                    throw new IndexOutOfRangeException("Индекс находится за пределами массива.");
            }
        }
        // Метод для выполнения операции поэлементного сцепления двух массивов
        public void Concat(Masiv other)
        {
            if (Length != other.GetLength())
                throw new ArgumentException("Массивы должны иметь одинаковую длину для выполнения сцепления.");

            for (int i = 0; i < Length; i++)
                mas[i] = mas[i] + other[i];
        }

        // Метод для выполнения операции слияния двух массивов с исключением повторяющихся элементов
        public void MergeUnique(Masiv other)
        {
            if (Length != other.GetLength())
                throw new ArgumentException("Массивы должны иметь одинаковую длину для выполнения слияния.");

            for (int i = 0; i < Length; i++)
                mas[i] = string.Join("", mas[i], other[i]).Distinct().Aggregate("", (current, next) => current + next);
        }
        // Вывод всего массива
        public void Print(int number)
        {
            Console.WriteLine($"Массив: {number}");

            for (int i = 0; i < Length; i++)
            {
                Console.Write($"{i}-{mas[i]} | ");
            }
            Console.WriteLine();
        }
        // Вывод элемента массива по индексу
        public void PrintElement(int index)
        {
            Console.WriteLine($"{index}-{this[index]}");
            Console.WriteLine();
        }

        // Заполнение массива
        public void InputMasiv(int number)
        {
            Console.WriteLine($"Заполнение массива: {number}");

            for (int i = 0; i < GetLength(); i++)
            {
                Console.Write($"Введите элемент номер {i+1}: ");
                mas[i] = Console.ReadLine()!;
            }
            Console.WriteLine();
        }
    }
}
