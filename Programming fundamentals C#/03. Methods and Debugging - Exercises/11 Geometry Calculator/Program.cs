using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Geometry_Calculator
{
    class GeometryCalc
    {
        //Write a program that can calculate the area of four different geometry figures - triangle, square, rectangle and circle.
        //On the first line you will get the figure type.Next you will get parameters for the chosen figure, each on a different line:
        //	Triangle - side and height, Square - side, Rectangle - width and height, Circle - radius.
        //The output should be rounded to the second digit after the decimal point:

        static void Main(string[] args)
        {
            string figure = Console.ReadLine().ToLower();

            if (figure == "triangle")
            {
                double triangleSide = double.Parse(Console.ReadLine());
                double triangleHeight = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(AreaOfTriangle(triangleSide, triangleHeight), 2));
            }
            else if (figure == "square")
            {
                double squareSide = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:00}", AreaOfSquare(squareSide));
            }
            else if (figure == "rectangle")
            {
                double rectangleSide = double.Parse(Console.ReadLine());
                double rectangleHeight = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(AreaOfRectangle(rectangleSide, rectangleHeight), 2));
            }
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round((AreaOfCircle(radius)), 2));
            }
 
        }
        public static double AreaOfTriangle(double side, double height)
        {
            return (side * height) / 2.00d;
        }
        public static double AreaOfSquare(double side)
        {
            return side * side;
        }
        public static double AreaOfRectangle(double side, double height)
        {
            return side * height;
        }
        public static double AreaOfCircle(double radius)
        {
            return (Math.PI * Math.Pow(radius, 2));
        }
    }
}
