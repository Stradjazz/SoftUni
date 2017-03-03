using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Flip_List_Sides
{
    /*  You will receive an integer list on the first line of the input (space-separated). Leave the first, middle and last elements as they are. 
        For every other element, exchange it with its opposite indexed element (list[1] -> list[length-2] and so on…). 
        After that, print the list on the console (space-separated). */

    class FlipListSides
    {
        static void Main(string[] args)
        {
            var inputNumbers = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToList();
            var firstNum = inputNumbers[0];
            var lastNum = inputNumbers[inputNumbers.Count - 1];
            ReverseTheList(inputNumbers, firstNum, lastNum);
            
        }
        public static void ReverseTheList(List<long> inputNumbers, long firstNum, long lastNum)
        {
            var outputNumbers = new List<long>();

            for (int i = 0; i < inputNumbers.Count; i++)
            {
                outputNumbers.Add(inputNumbers[i]);
            }

            outputNumbers.RemoveAt(0);
            outputNumbers.RemoveAt(outputNumbers.Count - 1);
            outputNumbers.Reverse();

            outputNumbers.Insert(0, firstNum);
            outputNumbers.Add(lastNum);

            Console.WriteLine(string.Join(" ", outputNumbers));
        }
        
    }
}
