using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Worm_Ipsum
{
    class WormIpsum
    {
        static void Main(string[] args)
        {
            //\.\s[A-Z]
            var input = Console.ReadLine();
            var pattern = @"\.\s[A-Z]";
            var regex = new Regex(pattern);
            var wordRgx = new Regex(@"\w");
            List<string> outputLines = new List<string>();

            while (input != "Worm Ipsum")
            {
                bool isMatch = regex.IsMatch(input);

                if (!isMatch)
                {
                    var words = wordRgx.Matches(input).Cast<Match>().Select(x => x.Value).ToArray();
                    foreach (var word in words)
                    {
                        var charDictionary = new Dictionary<char, int>();

                        foreach (char ch in word)
                        {
                            if (!charDictionary.ContainsKey(ch))
                            {
                                charDictionary.Add(ch, 0);
                            }
                            charDictionary[ch]++;
                        }
                        var maxCharOccurance = charDictionary.Max(x => x.Value);
                        var maxChar = charDictionary.Where(x => x.Value == maxCharOccurance).First().Key;

                        if (maxCharOccurance >= 2)
                        {
                            var wordLength = word.Length;
                            var newWord = new string(maxChar, wordLength);
                            outputLines = 
                        }
                    }
                }


                input = Console.ReadLine();
            }
            for (int i = 0; i < lines.Count; i++)
            {
                if (lines[i].Contains)
                {

                }
            }
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}
