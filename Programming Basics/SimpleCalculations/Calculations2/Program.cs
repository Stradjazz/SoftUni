using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations2
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 25;
            Console.WriteLine(a / 4.0);
            Console.WriteLine(a / 4);
            Console.WriteLine(a / 4.00);
            Console.WriteLine(a / 0.0);
            Console.WriteLine(0.0 / 0.0);
        }
    }
}
