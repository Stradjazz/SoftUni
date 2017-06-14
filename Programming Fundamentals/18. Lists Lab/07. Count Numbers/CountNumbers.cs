using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Count_Numbers
{
    //Read a list of integers in range [0…1000] and print them in ascending order along with their number of occurrences.
    class CountNumbers
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var max = numbers.Max();
            int[] counter = new int[max + 1];

            foreach (var num in numbers)
            {
                counter[num]++;
            }

            for (int i = 0; i < counter.Length; i++)
            {
                if (counter[i] > 0)
                {
                    Console.WriteLine($"{i} -> {counter[i]}");
                }
            }
        }
    }
}
