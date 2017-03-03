using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Equal_Sum_After_Extraction
{
    /*  You will be given two integer lists on the first two lines (space-separated). Remove the elements in the first list from the elements in 
        the second list. If an element from the first list occurs more than once in the second list, remove all occurrences.
        After you remove the elements, check the sum of both lists. If the sum of both of them is equal, print “Yes. Sum: {sum}”. 
        If not, print the absolute difference between the two lists in the format “No. Diff: {sum}”.  */


    class EqualSumAfterExtraction
    {
        static void Main(string[] args)
        {
            var firstLine = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            var secondLine = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            foreach (var number in firstLine)
            {
                secondLine.RemoveAll(x => x == number);
            }
            var sumFirstLine = SumTheListItems(firstLine);
            var sumSecondLine = SumTheListItems(secondLine);

            if (sumFirstLine == sumSecondLine)
            {
                Console.WriteLine($"Yes. Sum: {sumFirstLine}");
            }
            else
            {
                Console.WriteLine("No. Diff: {0}", Math.Abs(sumFirstLine - sumSecondLine));
            }

        }
        public static int SumTheListItems(List<int> firstLine)
        {
            int sum = 0;
            for (int i = 0; i < firstLine.Count; i++)
            {
                sum += firstLine[i];
            }
            return sum;
        }
    }
}
