using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Insertion_Sort_Using_List
{
    //Read a list of integers on the first line of the console. After that, sort the array, 
    //using the Insertion Sort algorithm, but instead of doing it in-place, add the result one by one to a list.

    class InsertionSortUsingList
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            for (int i = 0; i < input.Count - 1; i++)
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
