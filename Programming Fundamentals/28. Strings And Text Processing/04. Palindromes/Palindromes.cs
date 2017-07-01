using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Palindromes
{
    /*Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe and prints them on the console on a single line, separated by comma and space. Use spaces, commas, dots, 
    question marks and exclamation marks as word delimiters. Print only unique palindromes, sorted lexicographically.*/
    class Palindromes
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().Split(" .,?!".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            var palindromes = new SortedSet<string>();

            foreach (var word in text)
            {
                var wordAsChars = word.ToCharArray();
                string firstHalf = string.Empty;
                string secondHalf = string.Empty;

                for (int i = 0; i < wordAsChars.Length / 2; i++)
                {
                    firstHalf += wordAsChars[i];
                }

                if (word.Length % 2 == 0)
                {
                    for (int i = wordAsChars.Length - 1; i >= wordAsChars.Length / 2; i--)
                    {
                        secondHalf += wordAsChars[i];
                    }
                }
                else
                {
                    for (int i = wordAsChars.Length - 1; i > wordAsChars.Length / 2; i--)
                    {
                        secondHalf += wordAsChars[i];
                    }
                }

                if (firstHalf == secondHalf)
                {
                    palindromes.Add(word);
                }
            }

            Console.WriteLine(string.Join(", ", palindromes));
        }
    }
}
