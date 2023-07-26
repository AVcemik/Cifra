using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _Work_3
{
    internal class ParkingPay
    {
        private string? name;
        private string? adress;
        private int totalSpot;
        private decimal tariff;
        private int occupiedSpot;
        public string? Name
        {
            get { return name; }
            private set { name = value; }
        }
        public string? Adress
        {
            get { return adress; }
            private set { adress = value; }
        }
        public int TotalSpot
        {
            get { return totalSpot; }
            set { totalSpot = value; }
        }
        public decimal Tariff
        {
            get { return tariff; }
            set { tariff = value; }
        }
        public int OccupiedSpot
        {
            get { return occupiedSpot; }
            set { occupiedSpot = value; }
        }

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
