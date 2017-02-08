using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Append_Lists
{
    /*  Write a program to append several lists of numbers.
        Lists are separated by ‘|’.
        Values are separated by spaces (‘ ’, one or several)
        Order the lists from the last to the first, and their values from left to right.  */
    class AppendLists
    {
        static void Main(string[] args)
        {
            char[] delimiter = " ".ToCharArray();

            List<string> inputLists = Console.ReadLine()
                .Split('|')
                .Reverse()
                .ToList();

            List<string> reversedTokens = new List<string>();

            for (int i = 0; i < inputLists.Count; i++)
            {
                List<string> tempList = inputLists[i]
                    .Split(delimiter,StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                reversedTokens.AddRange(tempList);
            }

            Console.WriteLine(string.Join(" ", reversedTokens));
        }
    }
}
