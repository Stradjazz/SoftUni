using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Remove_Elements_at_Odd_Positions
{
    //Write a program which reads a list of space-separated strings and removes the elements at positions [1…3…5…7…etc.]. 
    //After that, print the elements with no delimiter. Note that positions are counted from 1.
    class RemoveElementsAtOddPos
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(' ')
                .ToList();
            var result = new List<string>();

            for (int i = 0; i < input.Count; i++)
            {
                if (i % 2 != 0)
                {
                    result.Add(input[i]);
                }
            }
            Console.WriteLine(string.Join("", result));
        }
    }
}
