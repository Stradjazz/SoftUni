using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirclePerimeter
{
    class CirclePerimeter
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F12}", 2 * Math.PI * r);
        }
    }
}
