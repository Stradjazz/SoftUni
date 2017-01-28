using System;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Factorial
{
    class Factorial
    {
        static void Main(string[] args)
        {
            //Write a program that calculates and prints the factorial n! for any number in the range [1…1000].

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
