using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Create a program, which receives sentences of words, and capitalizes the words in them. 
The sentences will follow a correct grammatical order. You must extract each word from the sentences, and you must capitalize it.
The capitalization of a word, is the process of making the first letter from it – Capital, and every other – lowercase.
You should read input lines, until you receive the command “end”. You might receive SEVERAL sentences on 1 input line.
After you’ve read a sentence, you extract the words, capitalize them, and print them, separated by a space and a comma. 
ONLY then you should read the next sentence.*/
namespace _05.Capitalize_Words
{
    class CapitalizeWords
    {
        static void Main(string[] args)
        {
            var sentence = Console.ReadLine();
            

            while (sentence != "end")
            {
                var words = new List<string>();
                var tokens = sentence
                    .Split(new[] { ' ', '.', '!', ',', '?', '(', ')', '{', '}', '[', ']', ':', ';', '-', '/' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var token in tokens)
                {
                    
                    var firstLetter = token.Substring(0, 1).ToUpper();
                    var restOfWord = token.Substring(1).ToLower();
                    var capitalizedWord = firstLetter + restOfWord;
                    words.Add(capitalizedWord);
                    
                }
                Console.WriteLine(string.Join(", ", words));

                sentence = Console.ReadLine();
            }
            
        }
    }
}
