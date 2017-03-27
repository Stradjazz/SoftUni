using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Flatten_Dictionary
{
    /*  You will be given several input lines containing info about a key, an inner key and inner value, separated by a SPACE.
Your task is to store every inner key and inner value, in every key’s value. Check the Examples for more info.
If you receive the command “flatten {key}”, you must flatten all the inner keys and inner values at the given key, or in other words, 
CONCATENATE them.
When you receive the command “end” the input ends. You must print all keys and their inner-keys and inner-values. 
Flattened inner keys and inner values, must be printed AFTER all else. The keys must be printed in descending order of their length. 
All inner-keys must be printed in ascending order of their length. Flattened Values must be printed in order of input.
If you receive an inner key that already exists, replace its value with the new given one. */
    class FlattenDictionary
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var dictionary = new Dictionary<string, Dictionary<string, string>>();

            while (input != "end")
            {
                var inputData = input.Split(' ').ToArray();
                if (inputData[0] != "flatten")
                {
                    var key = inputData[0];
                    var innerKey = inputData[1];
                    var innerValue = inputData[2];

                    if (!dictionary.ContainsKey(key))
                    {
                        dictionary[key] = new Dictionary<string, string>();
                    }
                    if (!dictionary[key].ContainsKey(innerKey))
                    {
                        dictionary[key][innerKey] = string.Empty;
                    }

                    dictionary[key][innerKey] = innerValue;
                }
                else
                {
                    var key = inputData[1];
                    dictionary[key] = dictionary[key]
                        .ToDictionary(x => x.Key + x.Value, x => "flatten");
                }
                input = Console.ReadLine();
            }
            var orderedKeys = dictionary
               .OrderByDescending(x => x.Key.Length)
               .ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in orderedKeys)
            {
                Console.WriteLine($"{item.Key}");

                var orderedInner = item.Value
                    .Where(x => x.Value != "flatten")
                    .OrderBy(x => x.Key.Length)
                    .ToDictionary(x => x.Key, x => x.Value);

                var flattenValue = item.Value
                    .Where(x => x.Value == "flatten")
                    .ToDictionary(x => x.Key, x => x.Value);

                var count = 1;
                foreach (var inner in orderedInner)
                {
                    Console.WriteLine($"{count}. {inner.Key} - {inner.Value}");
                    count++;
                }

                foreach (var flatten in flattenValue)
                {
                    Console.WriteLine($"{count}. {flatten.Key}");
                    count++;
                }
            }
        }
    }
}
