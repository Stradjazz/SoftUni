using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sum_Adjacent_Equal_Numbers
{
    /*Write a program to sum all adjacent equal numbers in a list of decimal numbers, starting from left to right.
    -	After two numbers are summed, the obtained result could be equal to some of its neighbors and should be summed as well (see the examples below).
    -	Always sum the leftmost two equal neighbors (if several couples of equal neighbors are available). */
    class SumAdjacentEqualNums
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                double firstNum = numbers[i];
                double secondNum = numbers[i + 1];
                if (firstNum == secondNum)
                {
                    numbers[i] = numbers[i] * 2;
                    numbers.RemoveAt(i + 1);
                    i -= 2;
                }

                if (i < -1)
                {
                    i = -1;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
