using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Split_by_Word_Casing
{
    /*  Read a text, split it into words and distribute them into 3 lists.
        Lower-case words like “programming”, “at” and “databases” – consist of lowercase letters only.
        Upper-case words like “PHP”, “JS” and “SQL” – consist of uppercase letters only.
        Mixed-case words like “C#”, “SoftUni” and “Java” – all others.
        Use the following separators between the words: , ; : . ! ( ) " ' \ / [ ] space
        Print the 3 lists as shown in the example below.  */
    class SplitByWordCasing
    {
        static void Main(string[] args)
        {
            char[] delimiters = ",;:.!()\"\'\\/[] ".ToCharArray();

            List<string> inputText = Console.ReadLine()
                .Split(delimiters, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> lowerCase = new List<string>();
            List<string> mixedCase = new List<string>();
            List<string> upperCase = new List<string>();

            foreach (var word in inputText)
            {
                if  (word.Any(x => !char.IsLetter(x)))
                {
                    mixedCase.Add(word);
                }
                else if (word.ToLower().Equals(word))
                {
                    lowerCase.Add(word);
                }
                else if (word.ToUpper().Equals(word))
                {
                    upperCase.Add(word);
                }
                else
                {
                    mixedCase.Add(word);
                }
            }
            Console.WriteLine($"Lower-case: {string.Join(", ", lowerCase)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCase)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upperCase)}");
        }
    }
}
