using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_1.Russia
{
    public class Moscow
    {
        public string Capital { get; private set; }
        public int Population { get; set; }

        public Moscow(int population)
        {
            Capital = "Москва";
            Population=population;
        }
        public void PrintPopulation()
        {
            Console.WriteLine($"Население \"{Capital.Replace("а", "ы")}\" - {Population}");
        }
    }
}
