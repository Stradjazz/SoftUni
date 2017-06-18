using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Odd_Occurrences
{
    /*Write a program that extracts from a given sequence of words all elements that present in it odd number of times (case-insensitive).
    •	Words are given in a single line, space separated.
    •	Print the result elements in lowercase, in their order of appearance.*/
    class OddOccurences
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
                .ToLower()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var result = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (!result.ContainsKey(word))
                {
                    result[word] = 0;
                }
                result[word]++;
            }
            var oddOccurences = new List<string>();

            foreach (var kvp in result)
            {
                var value = kvp.Value;
                if (value % 2 != 0)
                {
                    oddOccurences.Add(kvp.Key);
                }
            }
            Console.WriteLine(string.Join(", ", oddOccurences));
        }
    }
}
