using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_2
{
    internal class MenuClass
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
        }
    }
}
