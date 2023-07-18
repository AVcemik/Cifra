using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Work_2
{
    internal class Triangle
    {
        private double tempResult;
        private byte count;
        private double ab;
        private double bc;
        private double ca;
        private double xa;
        private double xb;
        private double xc;
        private double ya;
        private double yb;
        private double yc;

        public Triangle(double ab, double bc, double ca)
        {
            this.ab = ab; 
            this.bc = bc; 
            this.ca = ca;
        }
        public Triangle(double xa, double ya, double xb, double yb, double xc, double yc)
        {
            this.xa = xa;
            this.ya = ya;
            this.xb = xb;
            this.yb = yb;
            this.xc = xc;
            this.yc = yc;
            this.ab = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2));

        }

        public double SideAb
        {
            get => ab; 
            set => ab = value;
        }
        public double SideBc
        {
            get => bc;
            set => bc = value;
        }

        public double SideCa
        {
            get => ca;
            set => ca = value;
        }
        public double SideXa
        {
            get => xa;
            set => xa = value;
        }
        public double SideYa
        {
            get => ya;
            set => ya = value;
        }
        public double SideXb
        {
            get => xb;
            set => xb = value;
        }
        public double SideYb
        {
            get => yb;
            set => yb = value;
        }
        public double SideXc
        {
            get => xc;
            set => xc = value;
        }
        public double SideYc
        {
            get => yc;
            set => yc = value;
        }
        public double TempResult
        {
            get => tempResult;
            set => tempResult = value;
        }
        public byte Count
        {
            get => count;
            set => count = value;
        }

        public double getArea()
        {
            TempResult = (SideAb + SideBc + SideCa) / 2;
            return Math.Sqrt(TempResult * (TempResult - SideAb) * (TempResult - SideBc) * (TempResult - SideCa));
        }
        public double getPerimetr()
        {
            if (SideAb != 0 && SideBc != 0 && SideCa != 0) return SideAb + SideBc + SideCa;
            return 0;
        }
        public string getMedianPoint(byte count)
        {
            if (count == 1)
            {
                return "Недостаточно данных";
            }
            else if (count == 2)
            {
                return $"{(SideXa + SideXb + SideXc) / 3},{(SideYa + SideYb + SideYc) / 3}";
            }
            else return "Неизвестная ошибка упс :(";
        } 
        public string getStateABC()
        {
            return $"Стороны AB - {SideAb}, BC - {SideBc}, CA - {SideCa}";
        }
        public string getStatePointABC()
        {
            return $"Стороны AB - {SideAb}, BC - {SideBc}, CA - {SideCa}\nКоординаты вершин: A{SideXa}-{SideYa}, B{SideXb}-{SideYb}, C{SideXc}-{SideYc}";
        }
        
    }
}
