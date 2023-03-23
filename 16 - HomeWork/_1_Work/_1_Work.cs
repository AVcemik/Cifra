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

            bool _flag = false;
            byte _counter = 0;
            Console.Write("Введите число: ");
            string _line = Console.ReadLine();
            string _lineResult = "";

            

            _flag = boolNumberSingle();
            if(_flag == true) { _lineResult = _line + " Число вещественное"; }

            _flag = boolNumberInt();
            if(_flag == true) { _lineResult = _line + " Число целое"; }


            _flag = boolNumberTrue();
            if (_flag == true) { _lineResult = _lineResult + " положительно"; } //Отлично, хорошо практикуешься в написании функций. А теперь нужно избавиться от половины из них
                                                                                   // Так как boolNumberTrue например можно использовать и во втором примере, только заменить условие если _flag == false

            _flag = boolNumberFalse();
            if (_flag == true) { _lineResult = _lineResult + " отрицательное"; }



            

            Console.WriteLine(_lineResult);

            
            
            bool boolNumberSingle ()
            {

                float resultSingle;

                bool boolSingle = Single.TryParse(_line, out resultSingle);

                if (boolSingle == true)
                {
                    return true;
                }

                return false;
            }
            bool boolNumberInt()
            {
                int resultInt;

                bool boolInt = Int32.TryParse(_line, out resultInt);

                if (boolInt == true)
                {
                    return true;
                }

                return false;
            }
            bool boolNumberTrue()
            {

                if (_flag == true && Convert.ToSingle(_line) >=0)
                {
                    return true;
                }
                return false;
            }
            bool boolNumberFalse()
            {

                if (_flag == true && Convert.ToSingle(_line) < 0)
                {
                    return true;
                }
                return false;
            }

            void badExit()
            {
                Console.WriteLine("Не удалось определить число! \n\nНажмите любую клавишу для завершения...");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
    }
}
