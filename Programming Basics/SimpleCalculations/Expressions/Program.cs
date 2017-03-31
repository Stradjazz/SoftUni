using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, type a value for b1");
            var b1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please, type a value for b2");
            var b2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please, type a value for h");
            var h = double.Parse(Console.ReadLine());
            var area = (b1 + b2) * h / 2.0;
            Console.WriteLine("The trapezoid area is: " + area);
        }
    }
}
