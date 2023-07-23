namespace _1_Work
{
    internal class _1_Work
    {
        static void Main(string[] args)
        {
            // Написать программу по определению категории.
            // 1123 - целое число
            // 123.534 - вещественное число
            // фывоарпфп - слово.Длина слова = ХХ
            // Оыфвоап фывлар офывпаи - предложение.Количество слов = ХХ

            // Требования к коду:
            // *Написать код так, чтобы считывание 2 - х строк увеличивало код на 5 - 7 строк.
            // Совет1: определение типа(число целое, вещ., слово, предложение) храните как integer.Для себя обусловьте какой-нибудь свой шаблон например:
            // int inputType = 0; (не определено)
            // inputType == 1 - число целое
            // inputType == 2 - число вещ.
            // и тд.

            string _result = "";

            string _line = ReadLine();

            _result = boolString(_line);

            Console.WriteLine(_result);

            string ReadLine()
            {
                Console.Write("Введите число или текст: ");
                return Console.ReadLine().Replace(".", ",");
            }
            string boolString(string line)
            {

                char[] separator = new char[] { ' ', ',', '.'};
                float resultSingle;
                int resultInt;
                string[] resultString;

                bool boolSingle = Single.TryParse(line, out resultSingle);
                resultString = line.Split(separator, StringSplitOptions.RemoveEmptyEntries);

                if (boolSingle == true && resultSingle % 1 == 0)
                {
                    return line + " - " + "Число целое";
                }
                else if (boolSingle == true)
                {
                    return line + " - " + "Число вещественное";
                }
                else if(resultString.Length > 1)
                {
                    return line + " - Предложение - " + "кол-во слов - " + resultString.Length;
                }
                else if(resultString.Length == 1)
                {
                    return line + " - Слово - " + "длина слова - " + line.Length;
                }

                return line + " - " + "Не удалось определить строку " +
                                    "\nОбратитесь в службу поддержки для решения данной проблемы";
            }
        }
    }
}