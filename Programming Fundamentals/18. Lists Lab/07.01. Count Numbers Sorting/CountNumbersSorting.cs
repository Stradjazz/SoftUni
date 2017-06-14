using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._01.Count_Numbers_Sorting
{
    class CountNumbersSorting
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            numbers.Sort();
            int count = 1;
            

            for (int pos = 0; pos < numbers.Count; pos++)
            {
                int num = numbers[pos];
                if (pos < numbers.Count - 1 && numbers[pos] != numbers[pos + 1] || pos == numbers.Count - 1)
                {
                    Console.WriteLine($"{num} -> {count}");
                    count = 0;
                }
                count++;
            }
        }
    }
}
