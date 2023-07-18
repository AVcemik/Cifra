using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_2
{
    internal class AddFunc
    {
        private double x1;
        private double x2;
        private double x3;
        private double y1;
        private double y2;
        private double y3;
        private byte count;

        public byte Count
        {
            get => count;
            set => count = value;
        }
        public double X1
        {
            get => x1; 
            set => x1 = value;
        }
        public double X2
        {
            get => x2;
            set => x2 = value;
        }
        public double X3
        {
            get => x3;
            set => x3 = value;
        }
        public double Y1
        {
            get => y1;
            set => y1 = value;
        }
        public double Y2
        {
            get => y2;
            set => y2 = value;
        }
        public double Y3
        {
            get => y3;
            set => y3 = value;
        }
        public void CreateTriangle()
        {
            Console.WriteLine("Создаем треугольник");
        }
        public void Area()
        {
            Triangle t = new (X1, X2, X3);
            Console.WriteLine($"Площадь: {t.getArea():F2}");
        }
        public void Perimetr()
        {
            Triangle t = new (X1, X2, X3);
            Console.WriteLine($"Периметр: {t.getPerimetr():F2}");
        }
        public void Mediana()
        {
            Triangle t = new (X1, Y1, X2, Y2, X3, Y3);
            Console.WriteLine($"Пересечение медиан: {t.getMedianPoint(Count):F2}");
        }
        public void StatsTriangle()
        {
            if (Count == 1)
            {
                Triangle t = new (X1, X2, X3);
                Console.WriteLine(t.getStateABC());
            }
            else if (Count == 2)
            {
                Triangle t = new (X1, Y1, X2, Y2, X3, Y3);
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
                    X1 = double.Parse(Console.ReadLine()!);

                    Console.Write("Введите сторону В: ");
                    X2 = double.Parse(Console.ReadLine()!);

                    Console.Write("Введите сторону С: ");
                    X3 = double.Parse(Console.ReadLine()!);
                    break;
                }
                else if (Count == 2)
                {
                    Console.Write("Введите координату х1: ");
                    X1 = double.Parse(Console.ReadLine()!);

                    Console.Write("Введите координату y1: ");
                    Y1 = double.Parse(Console.ReadLine()!);

                    Console.Write("Введите координату х2: ");
                    X2 = double.Parse(Console.ReadLine()!);

                    Console.Write("Введите координату y2: ");
                    Y2 = double.Parse(Console.ReadLine()!);

                    Console.Write("Введите координату х3: ");
                    X3 = double.Parse(Console.ReadLine()!);

                    Console.Write("Введите координату y3: ");
                    Y3 = double.Parse(Console.ReadLine()!);
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
