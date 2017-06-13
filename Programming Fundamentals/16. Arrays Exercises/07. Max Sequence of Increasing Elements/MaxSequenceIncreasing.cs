using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Max_Sequence_of_Increasing_Elements
{
    /*Write a program that finds the longest increasing subsequence in an array of integers. The longest increasing subsequence is a portion of 
    the array (subsequence) that is strongly increasing and has the longest possible length. If several such subsequences exist, find the left most of them.*/
    class MaxSequenceIncreasing
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int start = 0;
            int length = 1;
            int sequenceLength = 1;
            int sequenceStart = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > numbers[i - 1])
                {
                    length++;
                }
                else
                {
                    start = i;
                    length = 1;
                }
                if (length > sequenceLength)
                {
                    sequenceLength = length;
                    sequenceStart = start;
                }
            }
            for (int i = sequenceStart; i < sequenceStart + sequenceLength; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
