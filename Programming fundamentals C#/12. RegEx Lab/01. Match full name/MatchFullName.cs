using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.Match_full_name
{
    class MatchFullName
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var pattern = @"\b[A-Z][a-z]+\s[A-Z][a-z]+\b";

            var regex = new Regex(pattern);
            var result = regex.IsMatch(input);

            Console.WriteLine(result);
        }
    }
}
