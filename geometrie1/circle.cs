using System;
using System.Collections.Generic;
using System.Text;

namespace geometrie1
{
    class circle:ellipse
    {
        public circle(point centre, double rayon) : base(centre, rayon, rayon) { }

        public bool Egalite(circle crcl)
        {
            if (Centre.egaliter(crcl.Centre) && RX == crcl.RX)
            {
                return true;
            }
            else return false;
        }
        public override double Circonference()
        {
            double circonfc;
            circonfc = RX * 2 * 3.14;
            return circonfc;
        }
        public override double Surface()
        {
            double surfacec;
            surfacec = RX * RX * 3.14;
            return surfacec ;
        }

    }
}
