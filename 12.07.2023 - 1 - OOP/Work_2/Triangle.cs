using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Work_2
{
    internal class Triangle
    {
        private double a;
        private double b;
        private double c;
        private double xa;
        private double xb;
        private double xc;
        private double ya;
        private double yb;
        private double yc;


        public double getA()
        {
            return a;
        }
        public double getB()
        {
            return b;
        }

        public double getC()
        {
            return c;
        }

        public void setA(double ab)
        {
            if (ab > 0) a = ab;
        }
        public void setB(double bc)
        {
            if (bc > 0) b = bc;
        }
        public void setC(double ca)
        {
            if (ca > 0) c = ca;
        }
        public double getArea()
        {
            double s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }
        public double getPerimetr()
        {
            if (a != 0 && b != 0 && c != 0) return a + b +c;
            return 0;
        }
        public double getMedianPoint(byte point)
        {
            double[] medianaPoint = new double[2];
            medianaPoint[0] = (double)(a * a + c * c - b * b) / (2 * a);
            medianaPoint[1] = (double)Math.Sqrt(b * b - (medianaPoint[0] - a) * (medianaPoint[0] - a));
            return medianaPoint[point];
        }
        public string getState()
        {
            return $"Треугольник со сторонами: a: {a}, b: {b}, c: {c}";
        }
        public void InputData()
        {

            Console.WriteLine("Выберите вариант ввода данных\n1 - Длины сторон\n2 - Координаты точек");
            if (byte.Parse(Console.ReadLine()!) == 1)
            {
                Console.Write("Введите сторону А: ");
                setA(double.Parse(Console.ReadLine()!));

                Console.Write("Введите сторону В: ");
                setB(double.Parse(Console.ReadLine()!));

                Console.Write("Введите сторону С: ");
                setC(double.Parse(Console.ReadLine()!));
            }
            else if (byte.Parse(Console.ReadLine()!) == 2)
            {
                Console.Write("Введите координату х1: ");
                xa = double.Parse(Console.ReadLine());

                Console.Write("Введите координату y1: ");
                ya = double.Parse(Console.ReadLine());

                Console.Write("Введите координату х2: ");
                xb = double.Parse(Console.ReadLine());

                Console.Write("Введите координату y2: ");
                yb = double.Parse(Console.ReadLine());

                Console.Write("Введите координату х3: ");
                xc = double.Parse(Console.ReadLine());

                Console.Write("Введите координату y3: ");
                yc = double.Parse(Console.ReadLine());
            }
        }
    }
}
