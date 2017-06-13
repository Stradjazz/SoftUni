using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Most_Frequent_Number
{
    /* Write a program that finds the most frequent number in a given sequence of numbers. 
    •	Numbers will be in the range [0…65535].
    •	In case of multiple numbers with the same maximal frequency, print the leftmost of them. */
    class MostFrequentNumber
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int mostFrequent = numbers[0];
            int count = 1;
            int maxLength = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 1; j < numbers.Length - i; j++)
                {
                    if (numbers[i] == numbers[j + i])
                    {
                        count++;
                    }

                    if (count > maxLength)
                    {
                        mostFrequent = numbers[i];
                        maxLength = count;
                    }
                }
                count = 1;
            }
            Console.WriteLine(mostFrequent);
        }
    }
}
