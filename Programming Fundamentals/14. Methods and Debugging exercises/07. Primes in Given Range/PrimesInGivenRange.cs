using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Primes_in_Given_Range
{
    /*Write a method that calculates all prime numbers in given range and returns them as list of integers:
     Write a method to print a list of integers. Write a program that enters two integer numbers (each at a separate line) and prints 
     all primes in their range, separated by a comma.*/
    class PrimesInGivenRange
    {
        static void Main(string[] args)
        {
            var startNum = int.Parse(Console.ReadLine());
            var endNum = int.Parse(Console.ReadLine());

            var primesInRange = FindPrimesInRange(startNum, endNum);
            Console.WriteLine(string.Join(", ", primesInRange));
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

        static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            var primes = new List<int>();
            for (int currentNum = startNum; currentNum <= endNum; currentNum++)
            {
                if (IsPrime(currentNum))
                {
                    primes.Add(currentNum);
                }
            }
            return primes;
        }
    }
}
