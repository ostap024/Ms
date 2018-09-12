using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalcLib
{
    public class Triangle
    {
        private Point p1, p2, p3;
        public Triangle(Point a, Point b, Point c)
        {
            p1 = a;
            p2 = b;
            p3 = c;
        }

        public double Perimeter()
        {
            return Point.Distance(p1,p2) + Point.Distance(p1, p3) + Point.Distance(p2, p3);
        }
        public double Square()
        {
            return Math.Sqrt(0.5 * this.Perimeter() * (0.5 * this.Perimeter() - Point.Distance(p1, p2)) * (0.5 * this.Perimeter() - Point.Distance(p1, p3)) * (0.5 * this.Perimeter() - Point.Distance(p2, p3)));
        }
        public void Print()
        {
            Console.WriteLine(ToString());
        }
        public override string ToString()
        {
            return String.Format($"Point 1 - {p1}, Point 2 - {p2}, Point 3 - {p3}, Perimetr - {Perimeter()}, Square - {Square()}");
        }
    }
}
