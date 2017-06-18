using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Count_Real_Numbers
{
    //Read a list of real numbers and print them in ascending order along with their number of occurrences.
    class CountRealNumbers
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            var realNumCount = new SortedDictionary<double, int>();

            foreach (var num in numbers)
            {
                if (!realNumCount.ContainsKey(num))
                {
                    realNumCount[num] = 0;
                }

                realNumCount[num]++;
            }

            foreach (var num in realNumCount)
            {
                Console.WriteLine($"{num.Key} -> {num.Value}");
            }
        }
    }
}
