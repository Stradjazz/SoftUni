using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = double.Parse(Console.ReadLine());

            string measure1 = Console.ReadLine();
            string measure2 = Console.ReadLine();

            var measures = new Dictionary<string, double>
            {
                {"m", 1}, {"cm", 100}, {"mm", 1000}, {"km", 0.001},
                {"mi", 0.000621371192}, {"in", 39.3700787},
                {"ft", 3.2808399}, {"yd", 1.0936133}
            };

            var result = value / (measures[measure1] / measures[measure2]);
            Console.WriteLine("{0} {1}", result, measure2);
        }
    }
}
