using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Count_of_Odd_Numbers_in_Array
{
    //Write a program to read an array of integers and find how many odd elements it holds.
    class CountOddNums
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int counter = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
