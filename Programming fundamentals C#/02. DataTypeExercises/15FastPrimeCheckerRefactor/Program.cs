using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15FastPrimeCheckerRefactor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberLimit = int.Parse(Console.ReadLine());

            for (int number =2; number <= numberLimit; number++)

            {
                bool checker = true;

                for (int prime = 2; prime <= Math.Sqrt(number); prime++)
                    {
                    if (number % prime == 0)

                        {
                        checker = false;
                        break;
                        }
                    }
                Console.WriteLine($"{number} -> {checker}");
            }
        }
    }
}
