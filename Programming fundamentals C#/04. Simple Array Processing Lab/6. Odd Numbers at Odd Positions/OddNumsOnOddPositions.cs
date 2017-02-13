using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Odd_Numbers_at_Odd_Positions
{
    //Write a program to read an array of integers and find how many odd numbers at odd positions the array holds. 
    //If there are no numbers which match this criteria, do not print anything
    class OddNumsOnOddPositions
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (i % 2 != 0 && inputArray[i] % 2 != 0)
                {
                    Console.WriteLine($"Index {i} -> {inputArray[i]}");
                }
            }
        }
    }
}
