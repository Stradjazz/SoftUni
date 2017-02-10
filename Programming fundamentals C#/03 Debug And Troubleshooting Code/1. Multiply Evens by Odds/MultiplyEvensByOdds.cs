using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Multiply_Evens_by_Odds
{
    //Create a program that reads an integer number and multiplies the sum of all its even digits by the sum of all its odd digits:

    class MultiplyEvensByOdds
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var result = GetMultipleOfOddEvenDigits(num);
            Console.WriteLine(result);
        }

        private static long GetMultipleOfOddEvenDigits(int num)
        {
            var oddSum = SumOddDigits(num);
            var evenSum = SumEvenDigits(num);
            return oddSum * evenSum;
        }

        private static long SumEvenDigits(int num)
        {
            num = Math.Abs(num);
            var sum = 0;
            while (num > 0)
            {
                var digit = num % 10;
                if (digit % 2 == 0)
                {
                    sum = sum + digit;
                }
                num = num / 10;
            }
            return sum;
        }

        private static long SumOddDigits(int num)
        {
            num = Math.Abs(num);
            var sum = 0;
            while (num > 0)
            {
                var digit = num % 10;
                if (digit % 2 != 0)
                {
                    sum = sum + digit;
                }
                 num = num / 10;
            }
            return sum;
        }
    }
}
