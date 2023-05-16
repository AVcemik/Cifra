using System.Threading.Channels;

namespace _1_Work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // В некотрых языках программирования (например, в Паскале)
            // не предусмотрена операция возведения в степень.
            // Написать рекурсивную функцию для расчета степени
            // n вещественного числа (n - натуральное число). 

            double _digital;
            int _extent;

            Console.Write("Введите число: ");
            _digital = AddFunc.CheckDouble();

            Console.Write("Укажите в какую степень возвести число: ");
            _extent = AddFunc.CheckInt();

            Console.WriteLine("{0} в степени {1} = {2}",
                _digital.ToString().Replace(',', '.'),
                _extent,
                Extent(_digital, _extent).ToString().Replace(',', '.'));

            double Extent(double digital, int count)
            {
                if (count == 0) return 1;
                return digital * Extent(digital, count - 1);
            }


            AddFunc.ExitProgramm();
        }
    }
}