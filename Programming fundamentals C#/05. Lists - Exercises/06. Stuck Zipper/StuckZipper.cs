using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Stuck_Zipper
{
    /*  You will be given two lists of integers on the first and second line of the input respectively (space-separated). 
        We want to zip these two lists together like a zipper, but one or several of the elements in either of the lists are too large to allow 
        that to happen. Being larger, they have more digits than the element with the smallest amount of digits in the two lists. 
        Your task is to find any elements which have more digits than the element with the least amount of digits in the list (if such exist) 
        and remove them, then zip the lists together as shown in the example.
        After you stack the lists, print the resulting list on the console (one line, space-separated).  */

    class StuckZipper
    {
        static void Main(string[] args)
        {
            var firstLine = Console.ReadLine().Split().Select(int.Parse).ToList();
            var secondLine = Console.ReadLine().Split().Select(int.Parse).ToList();
            
            var bothLines = firstLine.Select(el => el).Concat(secondLine);

            
            var minDigits = Math.Abs(bothLines.Min());

            ExtractingBadElements(minDigits, firstLine);
            ExtractingBadElements(minDigits, secondLine);
            
            var maxLenght = Math.Max(firstLine.Count, secondLine.Count);
            var result = new List<int>();

            for (int i = 0; i < maxLenght; i++)
            {
                
                if (i <= secondLine.Count - 1)
                {
                    result.Add(secondLine[i]);
                }

                if (i <= firstLine.Count - 1)
                {
                    result.Add(firstLine[i]);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
        public static void ExtractingBadElements(int minDigits, List<int> input)
        {
            for (int i = 0; i < input.Count; i++)
            {
                if (Math.Abs(input[i]).ToString().Length > minDigits.ToString().Length)
                {
                    input.Remove(input[i]);
                    i--;
                }
            }
        }
    }
}
