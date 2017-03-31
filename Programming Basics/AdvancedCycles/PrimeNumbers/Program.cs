using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var sum = true;
            if (n < 2)
            {
                sum = false;
                
            }

            for (int divisor = 2; divisor <= Math.Sqrt(n); divisor++)
            {
                
                if (n % divisor == 0)
                {
                    sum = false;
                    break;
                }

             }
            if (sum)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }
        }
    }
}
