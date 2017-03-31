using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            var position = false;

            var vertX1 = 4;
            var vertX2 = 10;
            var vertY1 = -5;
            var vertY2 = 3;

            var horX1 = 2;
            var horX2 = 12;
            var horY1 = -3;
            var horY2 = 1;

            if (x >= vertX1 && x <= vertX2 && y >= vertY1 && y <= vertY2)
            {
                position = true;
            }
            else if (x >= horX1 && x <= horX2 && y >= horY1 && y <= horY2)
            {
                position = true;
            }

            if (position)
            {
                Console.WriteLine("in");
            }
            else
            {
                Console.WriteLine("out");
            }
        }
    }
}
