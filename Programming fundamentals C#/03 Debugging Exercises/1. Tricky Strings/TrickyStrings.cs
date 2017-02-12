using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Tricky_Strings
{
    /*You are given a delimiter. On the next line, you will receive a number N. On the next N lines, you will receive strings on each line. 
     * Your task is to print the strings, separated by the delimiter.
        Note: the delimiter and strings could be anything: whitespace and empty strings are acceptable input!
*/
    class TrickyStrings
    {
        static void Main(string[] args)
        {
            var delimiter = Console.ReadLine();
            var numberOfStrings = int.Parse(Console.ReadLine());
            var result = string.Empty;
            var currentString = string.Empty;

            for (int i = 0; i < numberOfStrings - 1; i++)
            {
                currentString = Console.ReadLine();
                result += currentString + delimiter;
            }
            currentString = Console.ReadLine();
            result += currentString;
            Console.WriteLine(result);
        }
    }
}
