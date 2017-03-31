using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InchToCentimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("inches = ");
            var inch = double.Parse(Console.ReadLine());
            var cm = inch * 2.54;
            Console.WriteLine("centimeters = " + cm);
        }
    }
}
