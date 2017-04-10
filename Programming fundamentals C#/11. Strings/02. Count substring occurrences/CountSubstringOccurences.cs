using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Count_substring_occurrences
{
    /*  Write a program to find how many times a given string appears in a given text as substring. The text is given at the first input line. 
        The search string is given at the second input line. The output is an integer number. Please ignore the character casing. 
        Overlapping between occurrences is allowed. */
    class CountSubstringOccurences
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string pattern = Console.ReadLine().ToLower();
            var counter = 0;
            int index = text.IndexOf(pattern);
            
            while (index != -1)
            {
                counter++;
                index = text.IndexOf(pattern, index + 1);
            }
            Console.WriteLine(counter);
        }
    }
}
