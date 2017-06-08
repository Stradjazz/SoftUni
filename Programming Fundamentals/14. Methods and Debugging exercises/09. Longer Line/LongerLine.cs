using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Longer_Line
{
    /*You are given the coordinates of four points in the 2D plane. The first and the second pair of points form two different lines. 
    Print the longer line in format "(X1, Y1)(X2, Y2)" starting with the point that is closer to the center of the coordinate system (0, 0) 
    (You can reuse the method that you wrote for the previous problem). If the lines are of equal length, print only the first one.*/
    class LongerLine
    {
        static void Main(string[] args)
        {
            //first line
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            //second line
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double firstLine = GetDistanceBetweenPoints(x1, y1, x2, y2);
            double secondLine = GetDistanceBetweenPoints(x3, y3, x4, y4);

            if (firstLine > secondLine)
            {
                PointCloserToCenter(x1, y1, x2, y2);
            }
            else if (secondLine > firstLine)
            {
                PointCloserToCenter(x3, y3, x4, y4);
            }
            else
            {
                PointCloserToCenter(x1, y1, x2, y2);
            }
        }
        public static double GetDistanceBetweenPoints(double x1, double y1, double x2, double y2)
        {
            return (Math.Sqrt((Math.Pow(Math.Abs(x2 - x1), 2)) + Math.Pow((y2 - y1), 2)));
        }
        public static void PointCloserToCenter(double x1, double y1, double x2, double y2)
        {
            int x0 = 0;
            int y0 = 0;
            double pointOneToCenter = GetDistanceBetweenPoints(x1, y1, x0, y0);
            double pointTwoToCenter = GetDistanceBetweenPoints(x2, y2, x0, y0);


            if (pointOneToCenter < pointTwoToCenter)
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else if (pointOneToCenter > pointTwoToCenter)
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }

        }
    }
}
