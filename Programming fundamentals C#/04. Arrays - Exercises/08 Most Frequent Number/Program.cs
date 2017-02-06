using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Most_Frequent_Number
{
    /*Write a program that finds the most frequent number in a given sequence of numbers. 
        •	Numbers will be in the range [0…65535].
        •	In case of multiple numbers with the same maximal frequency, print the leftmost of them.*/
    class MostFrequentNumber
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int count = 1;
            int mostFreqNum = inputArray[0];
            int bestLength = 0;

            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                for (int j = 1; j < inputArray.Length - i; j++)
                {
                    if (inputArray[i] == inputArray[i + j])
                    {
                        count++;
                    }

                    if (count > bestLength)
                    {
                        mostFreqNum = inputArray[i];
                        bestLength = count;
                    }
                }

                count = 1;
            }

            Console.WriteLine(mostFreqNum);
        }
    }
}
