using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Largest_N_Elements
{
    //Read a list of integers on the first line of the console. On the next line, you will receive an integer N. 
    //After that, find and print the largest N elements the array, sorted in descending order.
    class LargestNElements
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            int selectedNums = int.Parse(Console.ReadLine());

            for (int i = 0; i < input.Count - 1; i++)
            {
                var current = i + 1;
                while (current > 0)
                {
                    if (input[current] > input[current - 1])
                    {
                        var temp = input[current];
                        input[current] = input[current - 1];
                        input[current - 1] = temp;
                    }
                    current--;
                }
            }
            var result = new List<int>();
            for (int i = 0; i < selectedNums; i++)
            {
                result.Add(input[i]);
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
