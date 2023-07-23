namespace _3_Work
{
    internal class _3_Work
    {
        static void Main(string[] args)
        {
            string _line;
            List<string> _expression = new List<string>();
            float result = 0f;

            Console.Write("Введите выражение: ");
            _line = Console.ReadLine().Replace(',', '.').Trim();

            string number = "";
            foreach (char c in _line)
            {

                if (char.IsDigit(c) || c == '.')
                {
                    number += c;
                }
                else if (c == '+' || c == '-' || c == '*' || c == '/')
                {
                    _expression.Add(number);
                    number = "";
                    _expression.Add(c.ToString());
                }
                else
                {
                    Console.WriteLine(c + " - не является числом либо оператором!!!");
                }
                _expression.Add(number);
            }

            result = float.Parse(_expression[0]);
            for (int i = 1; i <= _expression.Count - 1; i += 2)
            {
                if (_expression[i] == "+")
                {
                    result += float.Parse(_expression[i + 1]);
                }
                else if (_expression[i] == "-")
                {
                    result -= float.Parse(_expression[i + 1]);
                }
                else if (_expression[i] == "*")
                {
                    result *= float.Parse(_expression[i + 1]);
                }
                else if (_expression[i] == "/")
                {
                    result /= float.Parse(_expression[i + 1]);
                }
            }

            Console.WriteLine("Результат: " + result);

            //---------------------------------------------------------------------------
        }
    }
}