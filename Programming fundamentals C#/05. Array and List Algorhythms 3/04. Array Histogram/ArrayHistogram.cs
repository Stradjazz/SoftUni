using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  You will be given a string array on the console (single line, space-separated). Your task is to make statistics about the elements of the array. 
    Find out how many times each word occurs in the array. After which, sort the result by the count of occurrences in descending order and print statistics about every 
    word in the following format:
    {word} -> {count} times ({percentage:F2}%)  */
namespace _04.Array_Histogram
{
    class ArrayHistogram
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');

            List<string> countedWords = new List<string>();
            List<int> wordCounter = new List<int>();

            for (int i = 0; i < words.Length; i++)
            {
                var currentWord = words[i];
                if (countedWords.Contains(currentWord))
                {
                    int wordIndex = countedWords.IndexOf(currentWord);
                    wordCounter[wordIndex]++;
                }
                else
                {
                    countedWords.Add(currentWord);
                    wordCounter.Add(1);
                }
            }

            bool hasSwapped = true;
            while (hasSwapped)
            {
                hasSwapped = false;
                for (int i = 0; i < wordCounter.Count - 1; i++)
                {
                    if (wordCounter[i] < wordCounter[i + 1])
                    {
                        int temp = wordCounter[i];
                        wordCounter[i] = wordCounter[i + 1];
                        wordCounter[i + 1] = temp;

                        string tempWord = countedWords[i];
                        countedWords[i] = countedWords[i + 1];
                        countedWords[i + 1] = tempWord;
                        hasSwapped = true;
                    }
                }
            }
            for (int i = 0; i < wordCounter.Count; i++)
            {
                Console.WriteLine("{0} -> {1} times ({2:F2}%)", countedWords[i], wordCounter[i], (double)(wordCounter[i] * 100) / words.Length);
            }
        }
    }
}
