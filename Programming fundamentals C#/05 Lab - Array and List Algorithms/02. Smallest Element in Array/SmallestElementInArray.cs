using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Smallest_Element_in_Array
{
    //Read a list of integers on the first line of the console. After that, find the smallest element in the array and print it on the console.

    class SmallestElementInArray
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            var smallestNum = input[0];
            for (int i = 0; i < input.Length; i++)
            {
                if (smallestNum > input[i])
                {
                    smallestNum = input[i];
                }
            }
            Console.WriteLine(smallestNum);
        }
    }
}
