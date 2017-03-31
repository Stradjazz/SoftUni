using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // with do while
            Console.Write("Enter a number in the range [1...12] ");
            int n = int.Parse(Console.ReadLine());
            var factorial = 1;

            do
            {
                factorial = factorial * n;
                n--;

            } while (n > 0);

            Console.WriteLine(factorial);
            
        }
    }
}
