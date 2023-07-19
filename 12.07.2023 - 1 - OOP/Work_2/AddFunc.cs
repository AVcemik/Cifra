using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_2
{
    internal class AddFunc
    {
        private byte count;
        Triangle t = new();

        public byte Count
        {
            get => count;
            set => count = value;
        }
        public void CreateTriangle()
        {
            Console.WriteLine("Создаем треугольник");
        }
        public void Area()
        {
            Console.WriteLine($"Площадь: {t.getArea():F2}");
        }
        public void Perimetr()
        {
            Console.WriteLine($"Периметр: {t.getPerimetr():F2}");
        }
        public void Mediana()
        {
            Console.WriteLine($"Пересечение медиан: {t.getMedianPoint(Count):F2}");
        }
        public void StatsTriangle()
        {
            if (Count == 1)
            {
                Console.WriteLine(t.getStateABC());
            }
            else if (Count == 2)
            {
                Console.WriteLine(t.getStatePointABC());
            }
        }
        public void InputData()
        {
            while (true)
            {
                Console.WriteLine("Выберите вариант ввода данных\n1 - Длины сторон\n2 - Координаты точек");
                Count = byte.Parse(Console.ReadLine()!);

                if (Count == 1)
                {
                    Console.Write("Введите сторону А: ");
                    t.SideAb = double.Parse(Console.ReadLine()!);

                    Console.Write("Введите сторону В: ");
                    t.SideBc = double.Parse(Console.ReadLine()!);

                    Console.Write("Введите сторону С: ");
                    t.SideCa = double.Parse(Console.ReadLine()!);
                    break;
                }
                else if (Count == 2)
                {
                    Console.Write("Введите координату х1: ");
                    t.SideXa = double.Parse(Console.ReadLine()!);

                    Console.Write("Введите координату y1: ");
                    t.SideYa = double.Parse(Console.ReadLine()!);

                    Console.Write("Введите координату х2: ");
                    t.SideXb = double.Parse(Console.ReadLine()!);

                    Console.Write("Введите координату y2: ");
                    t.SideYb = double.Parse(Console.ReadLine()!);

                    Console.Write("Введите координату х3: ");
                    t.SideXc = double.Parse(Console.ReadLine()!);

                    Console.Write("Введите координату y3: ");
                    t.SideYc = double.Parse(Console.ReadLine()!);
                    t.getSideABC();
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Такой номер отсутствует!!!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                }
            }
        }
    }
}
