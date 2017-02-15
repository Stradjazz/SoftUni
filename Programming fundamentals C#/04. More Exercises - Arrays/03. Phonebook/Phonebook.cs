using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Phonebook
{
    /*  You will be given an array of phone numbers (strings) and an array of names (strings). 
        After which, you will be given strings on new lines, until you receive the command “done”. 
        Find the numbers, which correspond to the names and print them on the console in the following format:
        •	{name} -> {number}
        A number corresponds to a name when it’s located on the same position as its corresponding name in both arrays.  */
    class Phonebook
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(' ').ToArray();
            string[] names = Console.ReadLine().Split(' ').ToArray();
            string input = Console.ReadLine();

            while (input != "done")
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (input == names[i])
                    {
                        Console.WriteLine($"{names[i]} -> {numbers[i]}");
                    }
                }
                input = Console.ReadLine();
            }
        }
    }
}
