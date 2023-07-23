using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Work_3
{
    internal class ParkingPay
    {
        public string Name { get; private set; }
        public string Adress { get; private set; }
        public int TotalSpot { get; set; }
        public decimal Tariff { get; set; }

        public ParkingPay(string name, string adress, int totalSpot, decimal tariff)
        {
            Name=name;
            Adress=adress;
            TotalSpot=totalSpot;
            Tariff=tariff;
        }


    }
}
