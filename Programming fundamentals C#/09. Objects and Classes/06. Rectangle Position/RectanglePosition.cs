using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Rectangle_Position
{
    /*Write a program to read two rectangles {left, top, width, height} and print whether the first is inside the second.
    The input is given as two lines, each holding a rectangle, described by 4 integers: left, top, width and height.*/
    class RectanglePosition
    {
        static void Main(string[] args)
        {
            var firstRectangle = ReadRectangle();
            var secondRectangle = ReadRectangle();

            var result = firstRectangle.IsInside(secondRectangle);

            if (result)
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }
        }

        public static Rectangle ReadRectangle()
        {
            var rectangleParams = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            return new Rectangle
            {
                Left = rectangleParams[0],
                Top = rectangleParams[1],
                Width = rectangleParams[2],
                Height = rectangleParams[3]
            };
        }
    }
}
