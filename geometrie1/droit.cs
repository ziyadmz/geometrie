using System;
using System.Collections.Generic;
using System.Text;

namespace geometrie1
{
    class droit
    {
        point a;
        point b;
        public int DX { get; set; }
        public int DY { get; set; }
        public int DZ { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="DX"></param>
        /// <param name="DY"></param>
        /// <param name="DZ"></param>
        public droit (point p1, point p2)
        {
            a = p1;
            b = p2;
            DX = b.X - a.X;
            DY = b.Y - a.Y;
            DZ = b.Z - a.Z;
        }
        public bool Parallele(droit d1)
        {
            int k = d1.DX / DX ;
            if (k == d1.DY / DY && k == d1.DZ / DZ)
            {
                return true;
            }
            else return false;
        }
        public bool Appartient(point pt1)
        {
            int t = (pt1.X - a.X) / DX;
            if (t == (pt1.Z - a.Z) / DZ && t == (pt1.Y - a.Y) / DY)
            {
                return true;
            }
            else return false;
        }
    }
}
