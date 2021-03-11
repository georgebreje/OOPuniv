using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Globalization;

namespace lab3
{
    class Point
    {
        private double x;
        private double y;
        private static Random rnd = new Random();

        public Point() : this(rnd.Next(1,100), rnd.Next(1,100))
        {

        }

        public Point(string str)
        {
            
        }

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return $"({x}; {y})";
        }
        public double DistanceToOrigin()
        {
            return DistanceTo(new Point());
        }
        public void MoveBy(double dx, double dy)
        {
            this.x += dx;
            this.y += dy;
        }
        public double DistanceTo(Point p2)
        {
            double x1, y1, x2, y2;
            x1 = this.x;
            y1 = this.y;
            x2 = p2.x;
            y2 = p2.y;

            return Math.Sqrt(Math.Pow(x1 - x2, 2.0) + Math.Pow(y1 - y2, 2.0));
        }


    }
}
