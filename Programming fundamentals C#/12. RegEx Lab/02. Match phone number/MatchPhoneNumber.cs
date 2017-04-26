using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Match_phone_number
{
    class MatchPhoneNumber
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var pattern = @"\+\d{3}(-|\s)\d\1\d{3}\1\d{4}\b";
            var regex = new Regex(pattern);

            var match = regex.IsMatch(input);
            Console.WriteLine(match);
        }
    }
}
