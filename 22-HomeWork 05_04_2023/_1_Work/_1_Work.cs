using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Work
{
    class _1_Work
    {
        static void Main(string[] args)
        {
            //string _operators = "+";
            float value1 = 0;
            float value2 = 0;
            string oper = "";
            bool _success = true;

            string _line = Console.ReadLine();
            _line = _line.Replace(Operation.sum, " " + Operation.sum + " " || Operation);

            List<string> _items = GetItems(_line);

            value1 = TryParse(_items[0], ref _success);
            oper = _items[1].Trim();

            value2 = TryParse(_items[2], ref _success);

            if (_success == false)
            {
                Console.WriteLine("ОШИБКА (Вы что то ввели не верно)");
            }
            else
            {
                Console.WriteLine("Результат: "+Calculate());
            }

            ContinueProgramm();

            //------------------------------------------------------------------------------


            float Calculate()
            {
                if (oper == "+")
                {
                    return value1 + value2;
                }
                return 0;
            }
            float TryParse(string line, ref bool success)
            {
                float result = 0f;
                try
                {
                    result = float.Parse(line);
                }
                catch
                {
                    success = false;
                }
                return result;
            }
            //string CheckOperators(string operators, ref bool success)
            //{

            //}
            List<string> GetItems(string text)
            {
                List<string> items = text.Split(' ').ToList();
                foreach (var item in items.ToList())
                {
                    if (item != "") continue;
                    items.Remove(item);
                }
                return items;
            }
            
            void ContinueProgramm()
            {
                Console.WriteLine("Нажмите любую клавишу для продолжения...");
                Console.ReadKey();
            }
            void ExitProgramm()
            {
                Console.WriteLine("Нажмите любую клавишу для завершения...");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
    }
}