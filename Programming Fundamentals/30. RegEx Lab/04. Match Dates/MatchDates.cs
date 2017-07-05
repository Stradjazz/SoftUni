using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Match_Dates
{
    //Write a program, which matches a date in the format “dd{separator}MMM{separator}yyyy”. Use named capturing groups in your regular expression.
    class MatchDates
    {
        static void Main(string[] args)
        {
            var pattern = @"\b(?<day>\d{2})(\.|\/|\-)(?<month>[A-Z][a-z]{2})\1(?<year>[\d]{4})\b";
            var regex = new Regex(pattern);

            var datesAsString = Console.ReadLine();

            var dates = Regex.Matches(datesAsString, pattern);

            foreach (Match date in dates)
            {
                var day = date.Groups["day"].Value;
                var month = date.Groups["month"].Value;
                var year = date.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
