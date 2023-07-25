using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_1.UAR
{
    public class Pretoria
    {
        public int Population { get; set; }
        public string Capital { get; private set; }

        public Pretoria(int population)
        {
            Capital = "Претория";
            Population=population;
        }
        public void PrintPopulation()
        {
            Console.WriteLine($"Население \"{Capital.Replace("я", "и")}\" - {Population}");
        }
    }
}
