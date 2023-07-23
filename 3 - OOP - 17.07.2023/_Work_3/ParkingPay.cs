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
        public int OccupiedSpot { get; set; }

        public ParkingPay(string name, string adress, int totalSpot, decimal tariff)
        {
            Name=name;
            Adress=adress;
            TotalSpot=totalSpot;
            Tariff=tariff;
            OccupiedSpot=0;
        }
        public void LeaveAuto(int carsLeave)
        {
            if (carsLeave < 0)
            {
                throw new ArgumentException("Число уехавших машин не может быть отрицательным.");
            }
            else if (carsLeave > OccupiedSpot)
            {
                throw new ArgumentException("Число уехавших машин не может превышать число занятых мест.");
            }
            else OccupiedSpot -= carsLeave;
        }
        public void AddAuto(int carsAdd)
        {
            if (carsAdd < 0)
            {
                throw new ArgumentException("Число прибывших машин не может быть отрицательным.");
            }
            else if (carsAdd > TotalSpot-OccupiedSpot)
            {
                throw new ArgumentException("Число прибывших машин не может превышать кол-во свободных мест.");
            }
            else OccupiedSpot += carsAdd;
        }
        public void CountSpot()
        {
            Console.WriteLine($"Кол-во свободных мест: {TotalSpot - OccupiedSpot}");
        }
    }
}
