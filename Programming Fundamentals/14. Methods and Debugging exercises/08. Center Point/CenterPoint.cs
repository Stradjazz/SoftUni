using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Center_Point
{
    /*You are given the coordinates of two points on a Cartesian coordinate system - X1, Y1, X2 and Y2. Create a method that prints the 
    point that is closest to the center of the coordinate system (0, 0) in the format (X, Y). If the points are on a same distance from 
    the center, print only the first one.*/
    class CenterPoint
    {
        static void Main(string[] args)
        {
            double coordX1 = double.Parse(Console.ReadLine());
            double coordY1 = double.Parse(Console.ReadLine());
            double coordX2 = double.Parse(Console.ReadLine());
            double coordY2 = double.Parse(Console.ReadLine());
            PointClosestToCenter(coordX1, coordY1, coordX2, coordY2);
        }
        public static void PointClosestToCenter(double coordX1, double coordY1, double coordX2, double coordY2)
        {
            double firstPoint = Math.Sqrt((coordX1 * coordX1) + (coordY1 * coordY1));
            double secondPoint = Math.Sqrt((coordX2 * coordX2) + (coordY2 * coordY2));

            if (firstPoint < secondPoint)
            {
                Console.WriteLine($"({coordX1}, {coordY1})");
            }
            else if (firstPoint > secondPoint)
            {
                Console.WriteLine($"({coordX2}, {coordY2})");
            }
            else
            {
                Console.WriteLine($"({coordX1}, {coordY1})");
            }
        }
    }
}
