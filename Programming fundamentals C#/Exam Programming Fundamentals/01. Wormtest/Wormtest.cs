using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Wormtest
{
    class Wormtest
    {
        static void Main(string[] args)
        {
            long wormsLength = int.Parse(Console.ReadLine()) * 100;
            double wormsWidth = double.Parse(Console.ReadLine());
            var product = wormsLength * wormsWidth;
            var percentage = (wormsLength / wormsWidth) * 100;

            double remainder = wormsLength % wormsWidth;

            if (remainder == 0 || Double.IsNaN(remainder) || Double.IsPositiveInfinity(remainder) || Double.IsNegativeInfinity(remainder))
            {
                Console.WriteLine($"{product:F2}");
            }
            else
            {
                Console.WriteLine($"{percentage:F2}%");
            }
        }
    }
}
