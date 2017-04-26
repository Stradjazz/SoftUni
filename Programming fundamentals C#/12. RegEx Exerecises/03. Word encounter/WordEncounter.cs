using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

/*You will be given a filter, in the form of a string of two characters – the first being an ASCII character, and the second – a digit. 
You will then receive a sequence of sentences. You must extract all words from those sentences, and print only the words that contain 
the given filter character, at least N times – N being the filter digit.
There are 2 types of sentences – Valid and Invalid. The valid ones, always start with a capital letter, and always end with one 
of the following characters: “.”, “!”, “?”. Invalid sentences, should be ignored.
Note: You WILL NOT be given more than 1 sentence on a single input line.
The input sequence ends, when you receive the command “end”. After that you must print all the filtered words, you’ve gathered.
The valid words must be printed, on a single line, separated by a comma and a space. */
namespace _03.Word_encounter
{
    class WordEncounter
    {
        static void Main(string[] args)
        {
            var filter = Console.ReadLine();
            var symbol = filter[0];
            var digit = int.Parse(filter[1].ToString());
            var words = new List<string>();

            var pattern = @"(?<!.)[A-Z](.*)[.!?](?!.)";
            var regex = new Regex(pattern);

            var input = Console.ReadLine();

            while (input != "end")
            {
                bool validSentence = regex.IsMatch(input);

                if (validSentence)
                {
                    var wordPattern = @"\W+";
                    var wordRegex = new Regex(wordPattern);
                    var wordsInSentence = wordRegex.Split(input).ToList();

                    foreach (var word in wordsInSentence)
                    {
                        
                        var count = 0;
                        for (int i = 0; i < word.Length; i++)
                        {
                            if (word[i] == symbol)
                            {
                                count++;
                            }
                        }
                        if (count >= digit)
                        {
                            words.Add(word);
                        }
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", words));
        }
    }
}
