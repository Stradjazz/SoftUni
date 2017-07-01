using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Count_Substring_Occurrences
{
    /*Write a program to find how many times a given string appears in a given text as substring. The text is given at the first input line. The search string is given at the second input line. 
     The output is an integer number. Please ignore the character casing. Overlapping between occurrences is allowed.*/
    class CountSubstrOcurrences
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().ToLower();
            var word = Console.ReadLine().ToLower();

            var count = 0;
            var lastIndex = -1;
            var index = text.IndexOf(word, lastIndex + 1);

            while ((lastIndex = text.IndexOf(word, lastIndex + 1)) != -1)
            {
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
