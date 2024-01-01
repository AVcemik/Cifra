using Microsoft.EntityFrameworkCore;
using System;
using System.Runtime.CompilerServices;

namespace Titanic
{
    public partial class Form1 : Form
    {
        enum SortPassanger
        {
            ������������,
            ��������,
            ����������������,
            �����������������������
        }
        private static List<Passenger> _passengers = new();
        public Form1()
        {
            InitializeComponent();
            _passengers = ReadData();
            Task.Run(TimerLabel);
        }

        private void AllPasangerBT_Click(object sender, EventArgs e)    // ��� ���������
        {
            SortedDisplay(SortPassanger.������������);
        }
        private void SurvivedPassengerBT_Click(object sender, EventArgs e)  // ��������
        {
            SortedDisplay(SortPassanger.��������);
        }
        private void AgePassengerBT_Click(object sender, EventArgs e)   // ����������������
        {
            SortedDisplay(SortPassanger.����������������);
        }
        private void PclassPassengerBT_Click(object sender, EventArgs e)    // ��������� 3-�� ������
        {
            SortedDisplay(SortPassanger.�����������������������);
        }
        private async void SortedDisplay(SortPassanger sort)    // ���������� ������ ����������
        {
            ButtonEnable(false);
            {
                await Task.Run(() =>
                {
                    ListPassengerDGV.Rows.Clear();
                    if (sort == SortPassanger.������������)
                    {
                        foreach (Passenger item in _passengers)
                            ListPassengerDGV.Rows.Add(item.Name, SurvivedWord(item.Survived), item.Age, item.Pclass);
                    }
                    else if (sort == SortPassanger.��������)
                    {
                        foreach (Passenger item in _passengers)
                        {
                            if (item.Survived == 1)
                            {
                                ListPassengerDGV.Rows.Add(item.Name, SurvivedWord(item.Survived), item.Age, item.Pclass);
                            }
                        }
                    }
                    else if (sort == SortPassanger.����������������)
                    {
                        foreach (Passenger item in _passengers)
                        {
                            double.TryParse(item.Age!.Replace('.', ','), out double age);
                            if (age >= 18)
                                ListPassengerDGV.Rows.Add(item.Name, SurvivedWord(item.Survived), item.Age, item.Pclass);
                        }
                    }
                    else if (sort == SortPassanger.�����������������������)
                    {
                        foreach (Passenger item in _passengers)
                        {
                            if (item.Pclass == 3)
                            {
                                ListPassengerDGV.Rows.Add(item.Name, SurvivedWord(item.Survived), item.Age, item.Pclass);
                            }
                        }
                    }
                });
                ButtonEnable(true);
            }
        }
        private async Task TimerLabel() // ������ �� 23:59:59
        {
            int h = 0;
            int m = 0;
            int s = 0;
            string hh = "00";
            string mm = "00";
            string ss = "00";
            await Task.Run(() =>
            {
                for (int i = 0; i < 86400; i++)
                {
                    if (h < 10) hh = "0" + h.ToString(); else hh = h.ToString();
                    if (m < 10) mm = "0" + m.ToString(); else mm = m.ToString();
                    if (s < 10) ss = "0" + s.ToString(); else ss = s.ToString();
                    TimerLB.Text = $"{hh}:{mm}:{ss}";
                    Task.Delay(10);
                    s++;
                    if (s >= 60) { s = 0; m++; }
                    if (m >= 60) { m = 0; h++; }
                }
            });                    
        }
        private static List<Passenger> ReadData()   // ���������� ������ �� ��
        {
            List<Passenger>? temp = null;
            using (TitanicDbContext dBContext = new())
            {
                temp = dBContext.Passengers.ToList();
            }
            return temp;
        }
        private static string SurvivedWord(int survived) // ���������� ���������� �������� ����� ��� ���
        {
            if (survived == 1)
                return "�����";
            else if (survived == 0)
                return "����";
            else
                return "����������";
        }
        private void ButtonEnable(bool block)   // ��������� ������
        {
            AllPasangerBT.Enabled = block;
            SurvivedPassengerBT.Enabled = block;
            AgePassengerBT.Enabled = block;
            PclassPassengerBT.Enabled = block;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)   // �������� ���������� (�������)
        {
            Application.Exit();
        }

    }
}