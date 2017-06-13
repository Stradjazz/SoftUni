using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Grab_and_Go
{
    /*Write a program, which receives an array of integers and an integer as input. Find the last occurrence of the integer in the given array and print the sum of all elements before the number. 
Example: if we receive the array 10 20 30 40 20 30 40 and we receive on the next line the integer 20 we have to print the sum the elements 10 20 30 40, which is 100.
If no such number exists in the array – print “No occurrences were found!”.
*/
    class GrabAndGo
    {
        static void Main(string[] args)
        {
            long[] numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long num = long.Parse(Console.ReadLine());
            long sum = 0;

            if (numbers.Contains(num))
            {
                sum = CalculatingSum(numbers, num, sum);
                Console.WriteLine(sum);
            }

            else
            {
                Console.WriteLine("No occurrences were found!");
            }     
        }

        private static long CalculatingSum(long[] numbers, long num, long sum)
        {
            int numIndex = 0;

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                if (numbers[i] == num)
                {
                    numIndex = i;
                    for (int j = 0; j < numIndex; j++)
                    {
                        sum += numbers[j];
                    }
                    break;
                }
            }

            return sum;
        }
    }
}
