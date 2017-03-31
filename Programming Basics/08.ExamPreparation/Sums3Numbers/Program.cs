using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sums3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int sum = a + b + c;

            int A = Math.Min(a, Math.Min(b, c));
            int C = Math.Max(a, Math.Max(b, c));
            int B = sum - A - C;

            if (A + B == C)
            {
                Console.WriteLine("{0} + {1} = {2}", A, B, C);
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
