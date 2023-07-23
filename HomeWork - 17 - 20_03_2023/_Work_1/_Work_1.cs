namespace _Work_1
{
    internal class _Work_1
    {
        static void Main(string[] args)
        {
            //Всё тоже самое, только сначала считываем 2 значения, потом выводим 2 результата.
            //При этом код должен увеличиться на 3-5 строк, а методы стать универсальными.

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

            string _result = "";
            string _result2 = "";

            string _line = ReadLine();
            string _line2 = ReadLine();

            _result = boolNumber(_line) + boolNumberPositive(_line);
            _result2 = boolNumber(_line2) + boolNumberPositive(_line2);

            Console.WriteLine(_result);
            Console.WriteLine(_result2);

            string ReadLine()
            {
                Console.Write("Введите число: ");
                return Console.ReadLine().Replace(".", ",");
            }
            string boolNumber(string line)
            {

                float resultSingle;
                int resultInt;

                bool boolSingle = Single.TryParse(line, out resultSingle);

                if (boolSingle == true && resultSingle % 1 == 0)
                {
                    return line + " - " + "Число целое";
                }
                else if (boolSingle == true)
                {
                    return line + " - " + "Число вещественное";
                }

                return line + " - " + "Не удалось определить число";
            }
            string boolNumberPositive(string line)
            {

                if (Convert.ToSingle(line) >= 0)
                {
                    return " - " + "положительное";
                }
                else if (Convert.ToSingle(line) < 0)
                {
                    return " - " + "отрицательное";
                }
                return " - " + "не удалось определить знак";
            }

        }
    }
}