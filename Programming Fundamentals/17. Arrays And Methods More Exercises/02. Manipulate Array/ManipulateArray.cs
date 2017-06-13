using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Manipulate_Array
{
    /*You will receive an array of strings and you have to execute some command upon it. You can receive three types of commands: 
    •	Reverse – reverse the array
    •	Distinct – delete all non-unique elements from the array
    •	Replace {index} {string} – replace the element at the given index with the string, which will be given to you
    Input
    •	On the first line, you will receive the string array
    •	On the second line, you will receive n – the number of lines, which will follow
    •	On the next n lines – you will receive commands
    Output
    At the end print the array in the following format: {1st element}, {2nd element}, {3rd element} … {nth element} */
    class ManipulateArray
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();
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
                        input[index] = replacement;
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", input));
        }
    }
}
