using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Closest_Two_Points
{
    //Write a program to read n points and find the closest two of them.
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public string Print()
        {
            return $"({X}, {Y})";
        }
    }
    class ClosestTwoPoints
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var points = new List<Point>();
            for (int i = 0; i < n; i++)
            {
                var currentPoint = ReadPoint();
                points.Add(currentPoint);
            }

            var minDistance = double.MaxValue;
            Point firstPointResult = null;
            Point secondPointResult = null;

            for (int first = 0; first < points.Count; first++)//calculating distance
            {
                for (int second = first + 1; second < points.Count; second++)
                {
                    var firstPoint = points[first];
                    var secondPoint = points[second];

                    var distance = CalcDistance(firstPoint, secondPoint);
                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        firstPointResult = firstPoint;
                        secondPointResult = secondPoint;
                    }
                }
            }//end calculating distance

            Console.WriteLine($"{minDistance:F3}");
            Console.WriteLine(firstPointResult.Print());
            Console.WriteLine(secondPointResult.Print());
        }
        public static double CalcDistance(Point first, Point second)
        {
            var squareX = Math.Pow(first.X - second.X, 2);
            var squareY = Math.Pow(first.Y - second.Y, 2);

            var result = Math.Sqrt(squareX + squareY);
            return result;
        }
        public static Point ReadPoint()
        {
            var pointCoordinates = Console.ReadLine()
               .Split(' ')
               .Select(double.Parse)
               .ToArray();
            return new Point
            {
                X = pointCoordinates[0],
                Y = pointCoordinates[1]
            };
        }
    }
}
