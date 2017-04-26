using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Happiness_Index
{
    class HappinessIndex
    {
        static void Main(string[] args)
        {
            Regex happyPattern = new Regex (@"(:\)|:D|;\)|:\*|:\]|;\]|:\}|;\}|\(:|\*:|c:|\[:|\[;)");
            Regex sadPattern = new Regex(@"(:\(|D:|;\(|:\[|;\[|:\{|;\{|\):|:c|\]:|\];)");

            string input = Console.ReadLine();

            int happyCount = happyPattern.Matches(input).Count;
            int sadCount = sadPattern.Matches(input).Count;

            double happyIndex = happyCount / (double)sadCount;
            var status = string.Empty;

            if (happyIndex >= 2)
            {
                status = ":D";
            }
            else if (happyIndex > 1)
            {
                status = ":)";
            }
            else if (happyIndex == 1)
            {
                status = ":|";
            }
            else if (happyIndex < 1)
            {
                status = ":(";
            }

            Console.WriteLine($"Happiness index: {happyIndex:F2} {status}");
            Console.WriteLine($"[Happy count: {happyCount}, Sad count: {sadCount}]");
        }
    }
}
