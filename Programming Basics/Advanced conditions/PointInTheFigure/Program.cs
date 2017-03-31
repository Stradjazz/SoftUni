using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInTheFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int horX1 = 0;
            int horX2 = h * 3;
            int horY1 = h;
            int horY2 = 0;

            int verX1 = h;
            int verX2 = h * 2;
            int verY1 = h * 4;
            int verY2 = h;

            bool horUp = ((x >= horX1 && x <= verX1 && y == horY1) ||
                          (x >= verX2 && x <= horX2 && y == horY1));
            bool horDown = (x >= horX1 && x <= horX2 && y == horY2);
            bool horLeft = (x == horX1 && y >= horY2 && y <= horY1);
            bool horRight = (x == horX2 && y >= horY2 && y <= horY1);

            bool verUp = (x >= verX1 && x <= verX2 && y == verY1);
            bool verDown = (x >= verX1 && x <= verX2 && y == verY2);
            bool verLeft = (x == verX1 && y >= verY2 && y <= verY1);
            bool verRight = (x == verX2 && y >= verY2 && y <= verY1);

            if (horUp || horDown || horLeft || horRight || 
                verUp || verLeft || verRight)
            {
                Console.WriteLine("border");
            }

            else if ((x > horX1 && x < horX2 && y < horY1 && y > horY2) ||
                     (x > verX1 && x < verX2 && y < verY1 && y > verY2) ||
                      verDown)
            {
                Console.WriteLine("inside");
            }

            else
            {
                Console.WriteLine("outside");
            }
        }
    }
}
