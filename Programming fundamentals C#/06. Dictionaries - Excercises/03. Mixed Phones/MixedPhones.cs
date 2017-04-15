using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*You will be given several phone entries, in the form of strings in format: {firstElement} : {secondElement}
The first element is usually the person’s name, and the second one – his phone number. The phone number consists ONLY of digits, while the person’s name can consist 
of any ASCII characters. 
Sometimes the phone operator gets distracted by the Minesweeper she plays all day, and gives you first the phone, and then the name. e.g. : 0888888888 : Pesho. 
You must store them correctly, even in those cases.
When you receive the command “Over”, you are to print all names you’ve stored with their phones. The names must be printed in alphabetical order. */

namespace _03.Mixed_Phones
{
    class MixedPhones
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            SortedDictionary<string, double> phonebook = new SortedDictionary<string, double>();

            while (input != "Over")
            {
                var tokens = input.Split(new[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);

                

                if (!IsNumber(tokens[0]) && IsNumber(tokens[1]))
                {
                    phonebook[tokens[0]] = double.Parse(tokens[1]);
                }
                else if (IsNumber(tokens[0]) && !IsNumber(tokens[1]))
                {
                    phonebook[tokens[1]] = double.Parse(tokens[0]);
                }

                
                input = Console.ReadLine();
            }
            foreach (var entry in phonebook)
            {
                Console.WriteLine($"{entry.Key} -> {entry.Value}");
            }
        }
        static private bool IsNumber(string str)
        {
            bool isNumber = str.All(char.IsDigit);
            return isNumber;
        }
    }
}
