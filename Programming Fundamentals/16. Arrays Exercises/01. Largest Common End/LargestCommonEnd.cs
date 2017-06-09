using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Largest_Common_End
{
    //Read two arrays of words and find the length of the largest common end (left or right).
    class LargestCommonEnd
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split(' ');
            string[] secondArray = Console.ReadLine().Split(' ');

            int largestCommonLeft = ScanningFromLeft(firstArray, secondArray);
            int largestCommonRight = ScanningFromRight(firstArray, secondArray);

            if (largestCommonLeft == 0 && largestCommonRight == 0)
            {
                Console.WriteLine(0);
            }
            else if (largestCommonLeft < largestCommonRight)
            {
                Console.WriteLine(largestCommonRight);
            }
            else
            {
                Console.WriteLine(largestCommonLeft);
            }
        }

        private static int ScanningFromRight(string[] firstArray, string[] secondArray)
        {
            int count = 0;
            int maxCount = 0;

            int longerArrayIndex = 0;
            if (firstArray.Length > secondArray.Length)
            {
                longerArrayIndex = firstArray.Length - 1;
                for (int i = secondArray.Length - 1; i >= 0; i--)
                {
                    if (firstArray[longerArrayIndex] == secondArray[i])
                    {
                        count++;
                    }

                    else
                    {
                        if (maxCount < count)
                        {
                            maxCount = count;
                        }
                        count = 0;
                    }
                    longerArrayIndex--;
                }
            }
            else
            {
                longerArrayIndex = secondArray.Length - 1;
                for (int i = firstArray.Length - 1; i >= 0; i--)
                {
                    if (secondArray[longerArrayIndex] == firstArray[i])
                    {
                        count++;
                    }
                    else
                    {
                        if (maxCount < count)
                        {
                            maxCount = count;
                        }
                        count = 0;
                    }
                    longerArrayIndex--;
                }
            }
            if (maxCount < count)
            {
                maxCount = count;
            }
            return maxCount;
        }

        private static int ScanningFromLeft(string[] firstArray, string[] secondArray)
        {
            int shorterLength = Math.Min(firstArray.Length, secondArray.Length);
            int count = 0;
            int maxCount = 0;

            for (int i = 0; i < shorterLength; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    count++;
                }
                else
                {
                    if (maxCount < count)
                    {
                        maxCount = count;
                    }
                    count = 0;
                }
            }
            if (maxCount < count)
            {
                maxCount = count;
            }
            return maxCount;
        }
    }
}
