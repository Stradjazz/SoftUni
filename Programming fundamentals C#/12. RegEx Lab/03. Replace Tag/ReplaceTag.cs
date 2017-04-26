using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.Replace_Tag
{
    class ReplaceTag
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            while (input != "end")
            {
                var pattern = @"<a.*?href.*?=(.*)>(.*?)<\/a>";
                var regex = new Regex(pattern);

                var replacement = @"[URL href=$1]$2[/URL]";
                var result = Regex.Replace(input, pattern, replacement);

                Console.WriteLine(result);

                input = Console.ReadLine();

            }
        }
    }
}
