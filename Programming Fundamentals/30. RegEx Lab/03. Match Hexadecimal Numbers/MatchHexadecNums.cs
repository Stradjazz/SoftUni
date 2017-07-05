using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Match_Hexadecimal_Numbers
{
    //Write a program, which finds all valid hexadecimal numbers in a string and print them space-separated.
    class MatchHexadecNums
    {
        static void Main(string[] args)
        {
            var pattern = @"\b(0x)?[0-9A-F]+\b";
            var regex = new Regex(pattern);

            var inputLine = Console.ReadLine();
            MatchCollection matches = Regex.Matches(inputLine, pattern);

            List<string> hexadecimals = matches
                .Cast<Match>()
                .Select(x => x.Value)
                .ToList();

            Console.WriteLine(string.Join(" ", hexadecimals));
        }
    }
}
