using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace _03.Big_Factorial
{
    //Calculate and print n! (n factorial) for very big integer n (e.g. 1000).
    class BigFactorial
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger result = 1;

            for (int i = n; i > 0; i--)
            {
                result *= i;
            }

            Console.WriteLine(result);
        }
    }
}
