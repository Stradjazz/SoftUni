using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*You have been tasked to create a referenced dictionary, or in other words a dictionary, which knows how to reference itself.
You will be given several input lines, in one of the following formats:
•	{name} = {value}
•	{name} = {secondName}
The names will always be strings, and the values will always be integers. In case you are given a name and a value, you must store the given name and its value. 
If the name already EXISTS, you must CHANGE its value with the given one. In case you are given a name and a second name, you must store the given name with the 
same value as the value of the second name.  If the given second name DOES NOT exist, you must IGNORE that input.
When you receive the command “end”, you must print all entries with their value, by order of input, in the following format: {entry} === {value} */

namespace _2.Dict_Ref
{
    class DictRef
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var dictionary = new Dictionary<string, int>();

            while (input != "end")
            {
                var inputData = input.Split();
                var name = inputData[0];
                var lastElement = inputData[inputData.Length - 1];

                bool isNumber = lastElement.All(char.IsDigit);
                if (isNumber)
                {
                    dictionary[name] = int.Parse(lastElement);
                }
                else
                {
                    if (dictionary.ContainsKey(lastElement))
                    {
                        var value = dictionary[lastElement];
                        dictionary[name] = value;
                    }
                }
                 
                input = Console.ReadLine();
            }
            foreach (var entry in dictionary)
            {
                Console.WriteLine($"{entry.Key} === {entry.Value}");
            }
        }
    }
}
