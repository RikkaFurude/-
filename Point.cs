using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace амогус
{
    public class Point
    {

        private double x;
        private double y;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;

        }
        public Point(Point parents)
        {
            x = parents.x;
            y = parents.y;
        }
        public string Tostring()
        {
            string s = $"{x}, {y}";
            return s;
        }
        public override string ToString()
        {
            base.ToString();
            string s = $"{x} , {y}";
            return s;
        }
        public double Range()
        {
            return (Math.Abs(x - y));
        }
        public static Point operator ++(Point a)
        {
            return new Point(a.x++, a.y);
        }
        public static Point operator --(Point a)
        {

            return new Point(a.x--, a.y);
        }
        public static explicit operator int(Point a)
        {
            return (int)a.x;
        }
        public static implicit operator double(Point a)
        {

            double z = a.y;
            return z;
        }
        public static double operator +(Point One, Point Two)
        {
            double a = Math.Sqrt((One.x - Two.x) * (One.x - Two.x) + (One.y - Two.y) * (One.y - Two.y));
            return a;
        }
        public static Point operator +(Point One, double q)
        {
            Point New = new Point(One.x + q, One.y);
            return New;
        }
        public static Point operator +(double q, Point One)
        {
            Point New = new Point(One.x + q, One.y);
            return New;
        }


    }
}
