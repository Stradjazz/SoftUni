using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Append_Lists
{
    /*Write a program to append several lists of numbers.
    -	Lists are separated by ‘|’.
    -	Values are separated by spaces (‘ ’, one or several)
    -	Order the lists from the last to the first, and their values from left to right. */
    class AppendLists
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split('|').ToList();

            input.Reverse();

            var outputList = new List<int>();

            foreach (var item in input)
            {
                var numbers = item.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                for (int i = 0; i < numbers.Count; i++)
                {
                    outputList.Add(numbers[i]);
                }
            }
            Console.WriteLine(string.Join(" ", outputList));
        }
    }
}
