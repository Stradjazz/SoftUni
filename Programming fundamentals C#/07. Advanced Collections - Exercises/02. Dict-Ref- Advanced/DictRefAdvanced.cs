using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Dict_Ref__Advanced
{
    /*  You will begin receiving input lines containing information in one of the following formats:
        {key} -> {value1, value2, value3. . .}
        {key} -> {otherKey}
        The keys will always be strings, and the values will always be integers, separated by a comma and a space.
        If you are given a key and values, you must store the values to the given key. If the key already exists, you must add
        the given values to the old ones.
        If you are given a key and another key, you must copy the values of the other key to the first one. If the other key
        does not exist, this input line must be IGNORED.
        When you receive the command “end”, you must stop reading input lines, and you must print all keys with their
        values, in the following format:
        {key} === {value1, value2, value3. . .} */
    class DictRefAdvanced
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> dictionary = new Dictionary<string, List<int>>();
            string inputLine = Console.ReadLine();
            while (inputLine != "end")
            {
                string[] inputData = inputLine.Split(new[] { ' ', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries);
                string currentKey = inputData[0];
                var firstValue = -1;
                if (int.TryParse(inputData[1], out firstValue))
                {
                    if (!dictionary.ContainsKey(currentKey))
                    {
                        dictionary[currentKey] = new List<int>();
                    }
                    for (int i = 1; i < inputData.Length; i++)
                    {
                        dictionary[currentKey].Add(int.Parse(inputData[i]));
                    }
                }
                else
                {
                    string otherKey = inputData[1];
                    if (dictionary.ContainsKey(otherKey))
                    {
                        dictionary[currentKey] = new List<int>(dictionary[otherKey]);
                    }
                }
                inputLine = Console.ReadLine();
            }//end while
            foreach (var entry in dictionary)
            {
                Console.WriteLine("{0} === {1}", entry.Key, string.Join(", ", entry.Value));
            }
        }
    }
}
