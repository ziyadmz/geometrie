using System;
using System.Collections.Generic;
using System.Text;

namespace geometrie1
{
    class ellipse
    {
        point centre;
        public double RX { get; set; }
        public double RY { get; set; }
        public point Centre
        {
            get { return centre; }
            set { centre = value; }
        }
        public ellipse (point centre, double Rx, double Ry)
        {
            this.centre = centre;
            this.RX = Rx;
            this.RY = Ry;
        }
        public bool Egalite(ellipse elli1)
        {
            if (centre.egaliter(elli1.Centre) && RX == elli1.RX && RY == elli1.RY)
            {
                return true;
            }
            else return false;
        }
        public virtual double Circonference()
        {
            double circonf;
            circonf = 2 * 3.14 * (Math.Sqrt(Math.Pow(2 * RX, 2) + Math.Pow(2 * RY, 2)) / 2);
            return circonf;
        }
        public virtual double Surface()
        {
            double surface;
            surface = RX * RY * 3.14;
            return surface;
        }
    }
}
