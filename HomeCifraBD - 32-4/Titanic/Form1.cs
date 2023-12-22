using Microsoft.EntityFrameworkCore;
using System;

namespace Titanic
{
    public partial class Form1 : Form
    {
        private static List<Passenger> _passengers = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void SurvivedPassengerBT_Click(object sender, EventArgs e)
        {
            FindDataSurvived();

            foreach (Passenger item in _passengers)
            {
                string survived = "";
                if (item.Survived == 0)
                    survived = "Умер";
                else if (item.Survived == 1)
                    survived = "Выжил";

                ListPassengerDGV.Rows.Add(item.Name, survived, item.Age, item.Pclass);
            }
        }
        private static List<Passenger> ReadData()
        {
            List<Passenger>? temp = null;
            using (TitanicDbContext dBContext = new())
            {
                temp = dBContext.Passengers.ToList();
            }
            return temp;
        }
        private static async void FindDataSurvived()
        {
            _passengers.Clear();
            using (TitanicDbContext dBContext = new())
            {
                List<Passenger> passengers = ReadData();

                foreach (Passenger item in passengers)
                {
                    if (item.Survived == 1)
                        _passengers.Add(item);
                }
            }
        }

        private void AgePassengerBT_Click(object sender, EventArgs e)
        {
            FindDataSurvived();

            foreach (Passenger item in _passengers)
            {
                ListPassengerDGV.Rows.Add(item.Survived, item.Age, item.Pclass);
            }
        }
    }
}