using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Rectangle_Position
{
    /*Write a program to read two rectangles {left, top, width, height} and print whether the first is inside the second. The input is given as two lines, each holding a rectangle, described by 4 integers: 
    left, top, width and height.*/

    class Rectangle
    {
        public int Top { get; set; }

        public int Left { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public int Bottom
        {
            get
            {
                return Top + Height;
            }
        }

        public int Right
        {
            get
            {
                return Left + Width;
            }
        }

        public bool IsInside(Rectangle rectangle)
        {
            var leftIsValid = rectangle.Left <= Left;
            var topIsValid = rectangle.Top <= Top;
            var rightIsValid = rectangle.Right >= Right;
            var bottomIsValid = rectangle.Bottom >= Bottom;

            return leftIsValid && topIsValid && rightIsValid && bottomIsValid;
        }
    }
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
