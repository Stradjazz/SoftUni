using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.Match_Numbers
{
    //Write a program, which finds all integer and floating-point numbers in a string.
    class MatchNumbers
    {
        static void Main(string[] args)
        {
            var pattern = @"(^|(?<=\s))-?\d+(\.?\d*)($|(?=\s))";
            var regex = new Regex(pattern);

            var numbersString = Console.ReadLine();
            MatchCollection matchedNumbers = Regex.Matches(numbersString, pattern);

            var numbers = matchedNumbers.Cast<Match>().Select(x => x.Value).ToList();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
