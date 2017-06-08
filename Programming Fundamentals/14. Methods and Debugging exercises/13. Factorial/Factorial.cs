using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _13.Factorial
{
    //Write a program that calculates and prints the n! for any n in the range [1…1000].
    class Factorial
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(GetFactorial(number));
        }
        static public BigInteger GetFactorial(int number)
        {
            BigInteger factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }
            return factorial;
        }
    }
}
