using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Safe_Manipulation
{
    /*Now we need to make our program safer and more user-friendly. Make the program print “Invalid input!” if we try to replace an element at a non-existent 
    index or an invalid command is written on the console. Also make the program work until the command “END” is given as an input. */
    class SafeManipulation
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            string[] command = Console.ReadLine().Split();
            while (command[0] != "END")
            {
                int index = 0;
                var replacement = string.Empty;
                switch (command[0])
                {
                    case "Reverse":
                        input = input.Reverse().ToArray();
                        break;

                    case "Distinct":
                        input = input.Distinct().ToArray();
                        break;

                    case "Replace":
                        index = int.Parse(command[1]);
                        replacement = command[2];
                        if (index < 0 || index > input.Length - 1)
                        {
                            Console.WriteLine($"Invalid input!");
                        }
                        else
                        {
                            input[index] = replacement;
                        }
                        break;

                    default:
                        Console.WriteLine($"Invalid input!");
                        break;
                }
                command = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(", ", input));
        }
    }
}
