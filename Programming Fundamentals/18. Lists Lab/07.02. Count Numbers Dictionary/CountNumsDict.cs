using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._02.Count_Numbers_Dictionary
{
    class CountNumsDict
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            nums.Sort();
            Dictionary<int, int> countNums = new Dictionary<int, int>();

            foreach (var num in nums)
            {
                if (!countNums.ContainsKey(num))
                {
                    countNums[num] = 0;
                }
                countNums[num]++;
            }

            foreach (var number in countNums)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
