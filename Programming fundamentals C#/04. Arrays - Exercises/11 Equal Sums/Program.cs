using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Equal_Sums
{
    /* Write a program that determines if there exists an element in the array such that the sum of the elements on its left is equal to 
      the sum of the elements on its right. If there are no elements to the left / right, their sum is considered to be 0. 
      Print the index that satisfies the required condition or “no” if there is no such index. */
    class EqualSums
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            bool equalSum = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                int leftSum = numbers.Take(i).Sum();
                int rightSum = numbers.Skip(i + 1).Sum();
                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    equalSum = true;
                    break;
                }
            }

            if (!equalSum)
            {
                Console.WriteLine("no");
            }
        }
    }
}
