using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Randomize_Words
{
    //You are given a list of words in one line. Randomize their order and print each word at a separate line.
    class RandomizeWords
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split().ToList();

            var randomGen = new Random();

            for (int i = 0; i < words.Count; i++)
            {
                var currentWord = words[i];
                var randomPosition = randomGen.Next(0, words.Count);
                var tempWord = words[randomPosition];
                words[randomPosition] = currentWord;
                words[i] = tempWord;
            }

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
