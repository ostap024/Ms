using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCalcLib;
namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Triangle> Triangles = new List<Triangle>();
            Triangles.Add(new Triangle(new Point(1, 2), new Point(-1, 4), new Point(3, 6)));
            Triangles.Add(new Triangle(new Point(4, 2), new Point(-10, 4), new Point(-3, 11)));
            Triangles.Add(new Triangle(new Point(6, -2), new Point(3, 8), new Point(0, -5)));

            foreach (Triangle item in Triangles)
            {
                
                            
            }
        }
    }
}
