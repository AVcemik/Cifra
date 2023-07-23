using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_2
{
    internal class Print
    {
        public byte Count { get; set; }

        public void ListMenu()
        {
            Console.WriteLine("Веберите пункт меню");
            Console.WriteLine("1 - Найти книгу по названию");
            Console.WriteLine("2 - Найти книгу по автору");
            Console.WriteLine("3 - Найти книгу по году");
            Console.WriteLine("4 - Отсортировать по названию");
            Console.WriteLine("5 - Отсортировать по автору");
            Console.WriteLine("6 - Отсортировать по году");
            Console.WriteLine("7 - Добавить книгу");
            Console.WriteLine("8 - Удалить книгу");
            Console.WriteLine("9 - Список книг");
            Console.WriteLine("10 - Выход");
        }
        public void RazdelitelStart()
        {
            Console.WriteLine();
            Console.WriteLine("------------------------------");
        }
        public void RazdelitelEnd()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine();
        }
        public void Pause()
        {
            RazdelitelStart();
            Console.WriteLine("Нажмите любую клавишу для продолжения: ");
            Console.ReadKey();
        }
    }
}
