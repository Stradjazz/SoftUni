using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Distinct_List
{
    //You will be given a list of integers on the first line of the input (space-separated). Remove all repeating elements from the list.
    class DistinctList
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var result = new List<int>();
            foreach (var number in numbers.Distinct())
            {
                result.Add(number);
            }
            
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
