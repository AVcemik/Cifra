using System.Security.Cryptography.X509Certificates;

namespace _1_Work
{
    internal class _1_Work
    {
        static void Main(string[] args)
        {
            // Написать программу по определению категории числа.
            // То есть вводим чмсло, а программа отвечает
            // 15 - целое число
            // 123фыв - Неудалось определить число
            // -12 - Целое отрицательно число
            // 123.45 - Вещественное число

            // Требования к коду:
            // * Задача должна быть решена на сложных if ветвлениях
            // То есть в одном условии должен получиться полностью ответ.
            // if (условие_1) && (условие_2) то вывести "Целое положительное число.
            // * Все вычесления должны быть выполнены в функцияхd

            byte _counter = 0;
            Console.Write("Введите число: ");
            string _line = Console.ReadLine().Replace(".", ",");
            string _lineResult = "";



            _counter = boolNumber();
            if (_counter == 1)
            {
                _lineResult = _line + " - " + "Число целое";
                _counter = 0;
            }
            else if (_counter == 2)
            {
                _lineResult = _line + " - " + "Число вещественное";
                _counter = 0;
            }
            else
            {
                _lineResult = _line + " - " + "Не удалось определить число";
            }




            _counter = boolNumberPositive();
            if (_counter == 1)
            {
                _lineResult = _lineResult + " - " + "положительное";
                _counter = 0;
            }
            else if (_counter == 2)
            {
                _lineResult = _lineResult + " - " + "отрицательное";
                _counter = 0;
            }
            else
            {
                _lineResult = _lineResult + " - " + "не удалось определить знак числа";
            }


            Console.WriteLine(_lineResult);


            byte boolNumber()
            {

                float resultSingle;

                bool boolSingle = Single.TryParse(_line, out resultSingle);

                if (boolSingle == true && resultSingle % 1 == 0)
                {
                    return 1;
                }
                else if (boolSingle == true)
                {
                    return 2;
                }

                return 0;
            }
            byte boolNumberPositive()
            {

                if (Convert.ToSingle(_line) >= 0)
                {
                    return 1;
                }
                else if (Convert.ToSingle(_line) < 0)
                {
                    return 2;
                }
                return 0;
            }


        }
    }
}