using System;
using System.Collections.Generic;
using System.Text;

namespace geometrie1
{
    class point
    {

        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        public point(int x, int y, int z)
        {
            this.X = x;
            this.Y = y;
            this.Y = z;
        }
        public double Distance(point a)
        {
            double x1 = a.X, y1 = a.X;
            return (Math.Sqrt(((X - x1) * (X - x1)) + ((Y - y1) * (Y - y1)))); // Racine de( (X-x1)² + (Y-y1)² )
        }
        public bool egaliter(point p1)
        {
            if (X == p1.X && Y == p1.Y && Z == p1.Z)
            {
                return true;
            }
            else return false;                
        }
    }
}
