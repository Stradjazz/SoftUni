using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Phonebook_Upgrade
{
    //Add functionality to the phonebook from the previous task to print all contacts ordered lexicographically when receive the command “ListAll”.
    class PhonebookUpgrade
    {
        static void Main(string[] args)
        {
            var phonebook = new SortedDictionary<string, string>();
            var commandLine = Console.ReadLine();

            while (commandLine != "END")
            {
                var tokens = commandLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var command = tokens[0];
                

                if (command == "A")
                {
                    var name = tokens[1];
                    var number = tokens[2];
                    if (!phonebook.ContainsKey(name))
                    {
                        phonebook.Add(name, number);
                    }
                    else
                    {
                        phonebook[name] = number;
                    }
                }

                else if (command == "S")
                {
                    var name = tokens[1];
                    if (!phonebook.ContainsKey(name))
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                    else
                    {
                        Console.WriteLine($"{name} -> {phonebook[name]}");
                    }
                }

                else if (command == "ListAll")
                {
                    

                    foreach (var entry in phonebook)
                    {
                        Console.WriteLine($"{entry.Key} -> {entry.Value}");
                    }
                }


                commandLine = Console.ReadLine();
            }
        }
    }
}
