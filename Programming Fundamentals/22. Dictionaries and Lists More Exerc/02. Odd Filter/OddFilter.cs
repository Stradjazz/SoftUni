using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Odd_Filter
{
    /*  Write a program, which receives an array of integers (space-separated), removes all the odd numbers, then converts the remaining numbers to odd numbers, based on these conditions:
    •	If the number is larger than the average of the collection of remaining numbers, add 1 to it.
    •	If the number is smaller than the average of the collection of remaining numbers, subtract 1 from it.
    After you convert all of the elements to odd numbers, print them on the console (space-separated). */
    class OddFilter
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).Where(num => num % 2 == 0).ToList();
            var numbersAverage = numbers.Average();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > numbersAverage)
                {
                    numbers[i] += 1;
                }
                else
                {
                    numbers[i] -= 1;
                }
            }

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
