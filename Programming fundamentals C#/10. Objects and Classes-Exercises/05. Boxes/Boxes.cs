using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Create a class Box, which will represent a rectangular box. The Box should have UpperLeft (Point), UpperRight (Point), BottomLeft (Point), 
BottomRight (Point). Create, or use from the Lab, the class Point which has X (int) and Y (int) – coordinates in 2D space. 
Move the CalculateDistance() method in the Point class, exactly as it is. Then use “Point.CalculateDistance(point1, point2)” signature, 
to use the method. Create 2 methods in the Box class:
public static int CalculatePerimeter(int width, int height)
public static int CalculateArea(int width, int height). 
Make them return an integer, representing the perimeter and area of the box. The formulas are respectively – (2 * Width + 2 * Height) and 
(Width * Height).  The Width is the distance between the UpperLeft and the UpperRight Points, and ALSO – the Bottomleft and the 
BottomRight Points. The Height is the distance between the UpperLeft and the BottomLeft Points, and ALSO – the UpperRight and the BottomRight 
Points. You will receive several input lines in the following format:
{X1}:{Y1} | {X2}:{Y2} | {X3}:{Y3} | {X4}:{Y4}
Those will be the coordinates to UpperLeft, UpperRight, BottomLeft and BottomRight (IN THE SAME ORDER).
When you receive the command “end”. You must print all Boxes in the following format:
“Box: {width}, {height}
 Perimeter: {perimeter}
 Area: {area}”  */
namespace _05.Boxes
{
    class Boxes
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var boxes = new List<Box>();
            var currentBox = default(Box);

            while (input != "end")
            {
                currentBox = ReadNewBox(input);
                boxes.Add(currentBox);

                input = Console.ReadLine();
            }
            foreach (var box in boxes)
            {
                Console.WriteLine($"Box: {box.Width}, {box.Height}");
                Console.WriteLine($"Perimeter: {Box.CalculatePerimeter(box.Width, box.Height)}");
                Console.WriteLine($"Area: {Box.CalculateArea(box.Width, box.Height)}");
            }
        }
        public static Box ReadNewBox(string input)
        {
            var tokens = input.Split(new[] { ' ', '|', ':' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            return new Box
            {
                UpperLeft = new Point
                {
                    X = int.Parse(tokens[0]),
                    Y = int.Parse(tokens[1]),
                },
                UpperRight = new Point
                {
                    X = int.Parse(tokens[2]),
                    Y = int.Parse(tokens[3])
                },
                BottomLeft = new Point
                {
                    X = int.Parse(tokens[4]),
                    Y = int.Parse(tokens[5])
                },
                BottomRight = new Point
                {
                    X = int.Parse(tokens[6]),
                    Y = int.Parse(tokens[7])
                }
            };
        }
    }
}
