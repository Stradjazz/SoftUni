using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Multiply_Evens_By_Odds
{
    class MultiplyEvensByOdds
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            input = Math.Abs(input);
            int result = GetMultipliedEvensByOdds(input);
            Console.WriteLine(result);
        }

        private static int GetMultipliedEvensByOdds(int input)
        {
            int sumEvens = GetSumOfEvens(input);
            int sumOdds = GetSumOfOdds(input);
            return sumEvens * sumOdds;
        }

        private static int GetSumOfEvens(int input)
        {
            int sum = 0;
            while (input > 0)
            {
                int lastDigit = input % 10;
                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }
                input /= 10;
            }
            return sum;
        }

        private static int GetSumOfOdds(int input)
        {
            int sum = 0;
            while (input > 0)
            {
                int lastDigit = input % 10;
                if (lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }
                input /= 10;
            }
            return sum;
        }
    }
}
