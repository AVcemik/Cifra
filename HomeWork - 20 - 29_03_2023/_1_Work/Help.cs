using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Work
{
    public static class Help
    {
        public static void CommandHelp()
        {
            Console.WriteLine("Список команд:");
            Console.WriteLine();
            Console.WriteLine("Help - Вызов справки");
            Console.WriteLine("Save - сохранит ваш файл");
            Console.WriteLine("NumLine - Показывает кол-во строк");
            Console.WriteLine("NumberLine - Показывет кол-во строк в котрых есть числа");
            Console.WriteLine("LengthLine - Показывает кол-во символов в строке (включая пробелы)");
            Console.WriteLine("NumChar - показывает номер каждого символа в строке (Указав сразу номер строки) {Пример: NumChar 3}");
            Console.WriteLine("EditNumChar - Заменить выбранную букву на другую");
            Console.WriteLine("EditLine - Заменить строку, новой строкой (Указав сразу номер строки) {Пример: EditLine 2}");
            Console.WriteLine("CalcLine - Калькулятор строк (Результят записывается новой строкой) (Если числа в строке отсутствуют, то строка = 0)");
            Console.WriteLine("Remove - Удаляет строку (Указав номер строки) {Пример: Remove 3}");
            Console.WriteLine("Exit - Завершение программы");
        }
    }
}
