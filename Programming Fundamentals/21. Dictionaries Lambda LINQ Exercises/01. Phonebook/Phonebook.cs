using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Phonebook
{
    /*Write a program that receives some info from the console about people and their phone numbers. Each entry should have just one name and one number (both of them strings). 
    On each line, you will receive some of the following commands:
    •	A {name} {phone} – adds entry to the phonebook. In case of trying to add a name that is already in the phonebook you should change the existing phone number with the new one provided.
    •	S {name} – searches for a contact by given name and prints it in format "{name} -> {number}". In case the contact isn't found, print "Contact {name} does not exist.".
    •	END – stop receiving more commands.*/
    class Phonebook
    {
        static void Main(string[] args)
        {
            var phonebook = new Dictionary<string, string>();
            var commandLine = Console.ReadLine();

            while (commandLine != "END")
            {
                var tokens = commandLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var command = tokens[0];
                var name = tokens[1];

                if (command == "A")
                {
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
                    if (!phonebook.ContainsKey(name))
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                    else
                    {
                        Console.WriteLine($"{name} -> {phonebook[name]}");
                    }
                }


                commandLine = Console.ReadLine();
            }
        }
    }
}
