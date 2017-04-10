using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace _03.Word_Count
{
    /*Write a program that reads a list of words from the file words.txt and finds how many times each of the words is contained in another 
    file text.txt. Matching should be case-insensitive. The result should be written to another text file. Sort the words by frequency in 
    descending order.*/
    class WordCount
    {
        static void Main(string[] args)
        {
            string[] words = File.ReadAllText("words.txt")
                .ToLower()
                .Split(' ');
            string[] text = File.ReadAllText("text.txt")
                .ToLower()
                .Split(new[] { '\n', '\r', ' ', '.', ',', '!', '?', '-' }, StringSplitOptions.RemoveEmptyEntries);
            var wordCount = new Dictionary<string, int>();

            foreach (string word in words)
            {
                wordCount[word] = 0;
            }

            foreach (string word in text)
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
            }
            foreach (var word in wordCount.OrderByDescending(x => x.Value))
            {
                File.AppendAllText("results.txt", $"{word.Key} - {word.Value + Environment.NewLine}");
            }
        }
    }
}
