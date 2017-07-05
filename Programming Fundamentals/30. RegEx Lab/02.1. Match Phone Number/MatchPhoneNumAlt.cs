using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02._1.Match_Phone_Number
{
    class MatchPhoneNumAlt
    {
        static void Main(string[] args)
        {
            var pattern = @"\+359( |-)2\1[0-9]{3}\1[0-9]{4}\b";
            var regex = new Regex(pattern);
            var phoneNums = Console.ReadLine();

            MatchCollection phoneMatches = Regex.Matches(phoneNums, pattern);

            List<string> matchedNums = phoneMatches
                .Cast<Match>()
                .Select(x => x.Value.Trim())
                .ToList();

            Console.WriteLine(string.Join(", ", matchedNums));
        }
    }
}
