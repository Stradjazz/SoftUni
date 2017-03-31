using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double w = 0;
            double h = 0;
            double area = 0;

            if (figure == "square")
            {
                w = double.Parse(Console.ReadLine());
                area = w * w;
            }
            else if (figure == "circle")
            {
                w = double.Parse(Console.ReadLine());
                area = Math.PI * w * w;
            }
            else if (figure == "rectangle")
            {
                w = double.Parse(Console.ReadLine());
                h = double.Parse(Console.ReadLine());
                area = w * h;
            }
            else if (figure == "triangle")
            {
                w = double.Parse(Console.ReadLine());
                h = double.Parse(Console.ReadLine());
                area = w * h / 2;
            }
            Console.WriteLine(Math.Round(area, 3));
        }
    }
}
