using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Fold_and_Sum
{
    //Read an array of 4*k integers, fold it like shown below, and print the sum of the upper and lower rows (2*k integers):
    class FoldAndSum
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine().Split().Select(int.Parse).ToList();
            int k = inputLine.Count / 4;

            var leftPart = inputLine.Take(1 * k).Reverse().ToList();
            inputLine.Reverse();
            var rightPart = inputLine.Take(1 * k).ToList();
            inputLine.Reverse();

            List<int> row1 = new List<int>();

            row1.AddRange(leftPart);
            row1.AddRange(rightPart);

            List<int> row2 = new List<int>(inputLine);
            row2 = row2.Skip(1 * k).Take(2 * k).ToList();

            var sums = row1.Select((x, index) => x + row2[index]);

            Console.WriteLine(string.Join(" ", sums));
        }
    }
}
