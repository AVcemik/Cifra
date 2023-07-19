using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._07._2023___1___HomeCifra
{
    internal class Times
    {
        private byte h;
        private byte m;
        private byte s;
        private byte menu;

        public Times()
        {
            this.h = 0;
            this.m = 0;
            this.s = 0;
            this.menu = 0;
        }

        public byte Hours
        {
            get => h;
            set
            {
                if (value >= 0 && value <= 24) h = value;
                else
                {
                    throw new ArgumentOutOfRangeException("Вышли за диапозон часов (0-24)");
                }
            }
        }
        public byte Minutes
        {
            get => m;
            set
            {
                if (value >=0 && value <= 59) m = value;
                else
                {
                    throw new ArgumentOutOfRangeException("Вышли за диапозон минут (0-59)");
                }
            }
        }
        public byte Secundes
        {
            get => s;
            set
            {
                if (value >=0 && value <= 59) s = value;
                else
                {
                    throw new ArgumentOutOfRangeException("Вышли за диапозон секунд (0-59)");
                }
            }
        }
        public byte Menu
        {
            get => menu;
            set
            {
                if (value >= 1 && value <= 5) menu = value;
                else if (value == 255) menu = value;
                else
                {
                    throw new ArgumentOutOfRangeException("Вышли за диапозон меню (1-5)");
                }
            }
        }
        public void setHours(byte h) 
        {
            Hours = h;
        }
        public void setMinutes(byte m)
        {
            Minutes = m;
        }
        public void setSecundes(byte s) 
        {
            Secundes = s;
        }
        public void setTimes(byte h, byte m, byte s)
        {
            Hours = h;
            Minutes = m;
            Secundes = s;
        }
        public string getTimes()
        {
            return $"{Hours}:{Minutes}:{Secundes}";
        }

    }
}
