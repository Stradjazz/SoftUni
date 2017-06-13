using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Pairs_by_Difference
{
    /*Write a program that count the number of pairs in given array which difference is equal to given number. 
    Input
    •	The first line holds the sequence of numbers.
    •	The second line holds the difference. */
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int difference = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (Math.Abs(numbers[j] - numbers[i]) == difference && i < j)
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
