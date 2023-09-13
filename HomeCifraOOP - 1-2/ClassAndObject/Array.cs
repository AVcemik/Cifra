using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    internal class Array
    {
        private int[] _array;

        public Array(int length)
        {
            if (length > 0)
            {
                for (int i = 0; i < length; i++)
                {
                    _array[i] = 0;
                }
            }
            else throw new ArgumentOutOfRangeException("Массив должен содержать хотя бы один элемент");
        }
        ~Array()
        {
            Console.WriteLine($"Объект был удален при значении someValue = {_array}");
        }


        public void PrintArray()
        {
            for (int i = 0; i < _array.Length; i++)
            {
                if (i == 0) Console.Write($"| {_array[0]} | ");
                else
                {
                    Console.Write($"{_array[i]} | ");
                }
            }
        }
        public void FillArrayRandom()
        {
            Random random = new Random();

            for (int i = 0; i < _array.Length; i++)
            {
                _array[i] = random.Next(11);
            }
        }

        public void ShuffleArray()
        {
            Random random = new Random();
            int temp;
            int randomTemp;

            for (int i = 0; i < _array.Length; i++)
            {
                randomTemp = random.Next(_array.Length);

                temp = _array[i];
                _array[i] = _array[randomTemp];
                _array[randomTemp] = temp;
            }
        }

        public int CountElementsArray(int digital)
        {
            int count = 0;
            for (int i = 0; i < _array.Length; i++)
            {
                if (digital == _array[i]) count++;
            }
            return count;
        }
        public int DifferentElementsArray()
        {
            int count = _array.Length + 1;
            int maxVallue = _array.Max();
            int[] temp = new int[maxVallue + 1];
            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = i;
            }

            for (int i = 0; i < _array.Length; i++)
            {
                for (int j = 0; j < temp.Length; j++)
                {
                    if (_array[i] == temp[j])
                    {

                    }
                }
            }
            return count;
        }
    }
}
