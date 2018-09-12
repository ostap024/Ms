using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalcLib
{
    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x,int y)
        {
            X = x;
            Y = y;
        }

        public static double Distance(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow((p2.X - p1.X),2) + Math.Pow((p2.Y - p1.Y),2));
        }


        public override string ToString()
        {
            return string.Format($"X - {X}, Y - {Y}");
        }
    }
}