using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Boxes
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public static double CalculateDistance(Point first, Point second)
        {
            double deltaX = second.X - first.X;
            double deltaY = second.Y - first.Y;
            double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            return distance;
        }
    }
}
