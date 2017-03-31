using System;
using System.Collections.Generic;
using System.Linq;



namespace _02.Randomize_Words
{
    //You are given a list of words in one line. Randomize their order and print each word at a separate line.
    class RandomizeWords
    {
        public static void Main()
        {
            var words = Console.ReadLine()
                .Split(' ')
                .ToList();
            var random = new Random();

            for (int i = 0; i < words.Count; i++)
            {
                var currentWord = words[i];
                var randomPosition = random.Next(0, words.Count);
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
