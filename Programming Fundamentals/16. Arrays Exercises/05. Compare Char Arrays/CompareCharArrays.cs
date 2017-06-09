using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Compare_Char_Arrays
{
    //Compare two char arrays lexicographically (letter by letter). Print them in alphabetical order, each on separate line.

    class CompareCharArrays
    {
        static void Main(string[] args)
        {
            char[] firstArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] secondArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            int shorterArray = Math.Min(firstArray.Length, secondArray.Length);
            ComparingAlphabeticallyTheArrays(firstArray, secondArray, shorterArray);
        }
        static void ComparingAlphabeticallyTheArrays(char[] firstArray, char[] secondArray, int shorterArray)
        {
            for (int i = 0; i < shorterArray; i++)
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
                    CheckingLengths(firstArray, secondArray);
                    break;
                }
            }
        }
        static void CheckingLengths(char[] firstArray, char[] secondArray)
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
