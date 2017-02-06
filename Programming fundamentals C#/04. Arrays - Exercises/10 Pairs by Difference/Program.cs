using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Pairs_by_Difference
{
    /*  Write a program that count the number of pairs in given array which difference is equal to given number.
        Input
        •	The first line holds the sequence of numbers.
        •	The second line holds the difference. */
    class PairsByDifference
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int k = i + 1; k < numbers.Length; k++)
                {
                    if (Math.Abs(numbers[k] - numbers[i]) == n && i < k)
                    {
                        counter++;
                    }
                }
            }//end of for loop

            Console.WriteLine(counter);
        }
    }
}
