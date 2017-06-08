using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Prime_Checker
{
    /*Write a Boolean method IsPrime(n) that check whether a given integer number n is prime*/
    class PrimeChecker
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            bool primeCheck = IsPrime(input);
            Console.WriteLine(primeCheck);
        }
        public static bool IsPrime(double number)
        {
            if (number == 0) return false;
            if (number == 1) return false;
            if (number == 2) return true;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
