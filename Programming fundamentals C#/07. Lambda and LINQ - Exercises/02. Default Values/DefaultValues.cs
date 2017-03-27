using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Default_Values
{
    /*  You will be given several key-value pairs in the following format: {key} -> {value}
Your task is to store all those pairs, until you receive the command “end”. When you receive the ending command, you must read one last line, 
containing the default value. Then you must change all values, which are equal to “null” with the given default value.
At the end you must print all key-value pairs, which have NOT been replaced with the default value, in descending order, by their value’s length. 
After them, you must print all key-value pairs which HAVE been replaced with the default value, in order of input.
Each key-value pair, must be printed in the following format: {key} <-> {value}
All variables in the program logic are strings.
Note: If you receive the same key twice or more times, you should update its value everytime.
*/
    class DefaultValues
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            string inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                string[] inputParams = inputLine.Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

                string key = inputParams[0];
                string value = inputParams[1];

                dictionary[key] = value;
                
                inputLine = Console.ReadLine();
            }
            string defaultValue = Console.ReadLine();

            Dictionary<string, string> unchangedValues = dictionary
                .Where(x => x.Value != "null")
                .OrderByDescending(x => x.Value.Length)
                .ToDictionary(x => x.Key, x => x.Value);

            Dictionary<string, string> changedValues = dictionary
                .Where(x => x.Value == "null")
                .ToDictionary(x => x.Key, x => defaultValue);

            foreach (var entry in unchangedValues)
            {
                Console.WriteLine($"{entry.Key} <-> {entry.Value}");
            }
            foreach (var entry in changedValues)
            {
                Console.WriteLine($"{entry.Key} <-> {entry.Value}");
            }
        }
    }
}
