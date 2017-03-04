using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Sort_Array_Using_Insertion_Sort
{
    //Read a list of integers on the first line of the console. After that, sort the array, using the Insertion Sort algorithm.

    class SortArrayWithInsertionSort
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < input.Length - 1; i++)
            {
                var current = i + 1;
                while (current > 0)
                {
                    if (input[current] < input[current - 1])
                    {
                        var temp = input[current];
                        input[current] = input[current - 1];
                        input[current - 1] = temp;
                    }
                    current--;
                }
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
