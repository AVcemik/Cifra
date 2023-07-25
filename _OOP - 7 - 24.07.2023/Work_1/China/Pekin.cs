using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_1.China
{
    public class Pekin
    {
        public string Capital { get; private set; }
        public int Population { get; set; }

        public Pekin(int population)
        {
            Capital = "Пекин";
            Population=population;
        }
        public void PrintPopulation()
        {
            Console.WriteLine($"Население \"{Capital}а\" - {Population}");
        }
    }
}
