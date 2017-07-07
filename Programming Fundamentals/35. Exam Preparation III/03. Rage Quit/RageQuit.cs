using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Rage_Quit
{
    class RageQuit
    {
        static void Main(string[] args)
        {
            var pattern = @"(?<symbols>[^\d]+)(?<multiplyer>\d*)";
            var regex = new Regex(pattern);

            var inputText = Console.ReadLine();
            var rageQuit = new StringBuilder();
            
            var matches = Regex.Matches(inputText, pattern).Cast<Match>().ToArray();

            foreach (Match strNumPair in matches)
            {
                string symbols = strNumPair.Groups["symbols"].Value.ToUpper();
                int multiplyer = int.Parse(strNumPair.Groups["multiplyer"].Value);
                
                for (int i = 0; i < multiplyer; i++)
                {
                    rageQuit.Append(symbols);
                }
            }

            List<char> uniqueSymbols = new List<char>();
            uniqueSymbols.AddRange(rageQuit.ToString().ToCharArray());
            uniqueSymbols = uniqueSymbols.Distinct().ToList();

            Console.WriteLine($"Unique symbols used: {uniqueSymbols.Count}");
            Console.WriteLine(rageQuit);
        }
    }
}
