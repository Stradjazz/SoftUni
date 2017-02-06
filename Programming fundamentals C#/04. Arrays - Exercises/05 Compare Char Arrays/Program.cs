using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Compare_Char_Arrays
{
    //Compare two char arrays lexicographically (letter by letter).
    //Print them in alphabetical order, each on separate line.

    class CompareCharArrays
    {
        static void Main(string[] args)
        {
            char[] firstArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] secondArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            int minLength = Math.Min(firstArray.Length, secondArray.Length);
            AlphabeticalOrder(firstArray, secondArray, minLength);
        }
        static void AlphabeticalOrder(char[] firstArray, char[] secondArray, int minLength)
        {
            for (int i = 0; i < minLength; i++)
            {
                if (firstArray[i] < secondArray[i])
                {
                    Console.WriteLine(firstArray);
                    Console.WriteLine(secondArray);
                    break;
                }
                else if (firstArray[i] > secondArray[i])
                {
                    Console.WriteLine(secondArray);
                    Console.WriteLine(firstArray);
                    break;
                }
                else if (firstArray[i] == secondArray[i])
                {
                    checkingLengths(firstArray, secondArray, minLength);
                    break;
                }
            }
        }
        static void checkingLengths(char[] firstArray, char[] secondArray, int minLength)
        {
            if (firstArray.Length == secondArray.Length)
            {
                Console.WriteLine(firstArray);
                Console.WriteLine(secondArray);
            }
            else if (firstArray.Length != secondArray.Length)
            {
                Console.WriteLine(firstArray.Length > secondArray.Length ? secondArray : firstArray);
                Console.WriteLine(firstArray.Length < secondArray.Length ? secondArray : firstArray);
            }
        }
    }
}
