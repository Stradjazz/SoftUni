using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.Replace_a_Tag
{
    /*Write a program that replaces in a HTML document given as string all the tags <a href=…>…</a> with corresponding tags [URL href=…>…[/URL]. Read an input, until you receive the “end” command. 
    Print the lines on the console, but with the <a> tags replaced.*/
    class ReplaceATag
    {
        static void Main(string[] args)
        {
            var pattern = @"<a.*?href.*?=(.*)>(.*?)</a>";
            var replacement = @"[URL href=$1]$2[/URL]";
            string replaced = string.Empty;
            var codeList = new List<string>();
            
            var inputLine = Console.ReadLine();
            var r = new Regex(pattern, RegexOptions.Multiline);
            while (inputLine != "end")
            {
                if (Regex.IsMatch(inputLine, pattern))
                {
                    replaced = r.Replace(inputLine, replacement);
                    inputLine = replaced;
                }
                codeList.Add(inputLine);
                
                inputLine = Console.ReadLine();
            }

            Console.WriteLine(string.Join(Environment.NewLine, codeList));
        }
    }
}
