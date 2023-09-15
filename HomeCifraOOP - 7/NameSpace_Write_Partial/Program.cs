// Домашняя работа
// 1. Разработать приложение, в котором бы сравнивалось население трёх столиц из разных стран.
// Причём страна бы обозначалась пространством имён, а город — классом в данном пространстве.

using System;
using System.Linq.Expressions;

namespace NameSpace_Write_Partial
{
    
    namespace Russia
    {
        class Moscow
        {
            public static string Name = "Москва";
            public static int Population = 13104177;
        }
    }

    namespace China
    {
        class Pekin
        {
            public static string Name = "Пекин";
            public static int Population = 21893095;
        }
    }

    namespace India
    {
        class NewDelhi
        {
            public static string Name = "Нью-Дели";
            public static int Population = 249998;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Russia.Moscow.Name + " = " + Russia.Moscow.Population);
            Console.WriteLine(China.Pekin.Name + " = " + China.Pekin.Population);
            Console.WriteLine(India.NewDelhi.Name + " = " + India.NewDelhi.Population);
            Console.WriteLine();

            Console.Write("Самая густо населенная столица: ");
            if (Russia.Moscow.Population > China.Pekin.Population && Russia.Moscow.Population > India.NewDelhi.Population)
            {
                Console.WriteLine(Russia.Moscow.Name);
            }
            else if (China.Pekin.Population > Russia.Moscow.Population && China.Pekin.Population > India.NewDelhi.Population)
            {
                Console.WriteLine(China.Pekin.Name);
            }
            else if (India.NewDelhi.Population > Russia.Moscow.Population && India.NewDelhi.Population > China.Pekin.Population)
            {
                Console.WriteLine(India.NewDelhi.Population);
            }
            else
            {
                Console.WriteLine(Russia.Moscow.Name + China.Pekin.Name + India.NewDelhi.Name);
            }

            Console.WriteLine($"{Russia.Moscow.Name} {Symbol(Russia.Moscow.Population, China.Pekin.Population)} {China.Pekin.Name} {Symbol(China.Pekin.Population, India.NewDelhi.Population)} {India.NewDelhi.Name}");

            
        }
        public static char Symbol(int value1, int value2)
        {
            if (value1 > value2) return '>';
            else if (value1 < value2) return '<';
            else return '=';
        }
    }
}
