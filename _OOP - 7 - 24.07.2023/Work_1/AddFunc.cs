using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Work_1.China;
using Work_1.Russia;
using Work_1.UAR;

namespace Work_1
{
    public static class AddFunc
    {
        public static void Printmax(Moscow moscow, Pekin pekin, Pretoria pretoria) 
        {
            int maxPopulation = Math.Max(moscow.Population, Math.Max(pekin.Population, pretoria.Population));
            if (moscow.Population == maxPopulation)
            {
                Console.WriteLine($"Самая густо населенная столица \"{moscow.Capital}\" с населением - {moscow.Population}");
            }
            else if (pekin.Population == maxPopulation)
            {
                Console.WriteLine($"Самая густо населенная столица \"{pekin.Capital}\" с населением - {pekin.Population}");
            }
            else if (pretoria.Population == maxPopulation)
            {
                Console.WriteLine($"Самая густо населенная столица \"{pretoria.Capital}\" с населением - {pretoria.Population}");
            }
            else Console.WriteLine("Не удалось определить самую густо населенную столицу");
        }
        public static void Printmin(Moscow moscow, Pekin pekin, Pretoria pretoria)
        {
            int maxPopulation = Math.Min(moscow.Population, Math.Min(pekin.Population, pretoria.Population));
            if (moscow.Population == maxPopulation)
            {
                Console.WriteLine($"Самая менее населенная столица \" {moscow.Capital} \" с населением - {moscow.Population}");
            }
            else if (pekin.Population == maxPopulation)
            {
                Console.WriteLine($"Самая менее населенная столица \" {pekin.Capital} \" с населением - {pekin.Population}");
            }
            else if (pretoria.Population == maxPopulation)
            {
                Console.WriteLine($"Самая менее населенная столица \" {pretoria.Capital} \" с населением - {pretoria.Population}");
            }
            else Console.WriteLine("Не удалось определить самую менее населенную столицу");
        }
    }
}
