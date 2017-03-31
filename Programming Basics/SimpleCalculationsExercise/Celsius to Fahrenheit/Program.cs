using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celsius_to_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            var celsius = double.Parse(Console.ReadLine());
            var fahrenheit = celsius * 1.8000 + 32.00;

            Console.WriteLine(Math.Round(fahrenheit, 2));
        }
    }
}
