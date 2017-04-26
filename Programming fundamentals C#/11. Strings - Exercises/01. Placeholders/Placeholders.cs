using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Placeholders in C# are really comfortable for use, right? How about you implement them to see just how easy they are.
You will be given input lines containing a string with placeholders, i.e. “This is {0}. And that is {1}.”.
The input lines will be in the following format: {someString} -> {someElement}, {someElement2}
You have to replace the placeholders in the string, with the elements given after that, separated by a comma and a space. Each element 
has an index, so you must give them the right order. The first given element goes where the 0 is, the second to the 1, and so on…
Print each string, with its replaced placeholders, RIGHT after you’ve read it, and BEFORE reading the next one.
The input ends when you receive the command “end”. */
namespace _01.Placeholders
{
    class Placeholders
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();
            
            while (inputLine != "end")
            {
                var inputParts = inputLine.Split(new[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                var sentence = inputParts[0];
                var elements = inputParts[1].Split(new[] { ',', ' '},StringSplitOptions.RemoveEmptyEntries).ToArray();

                for (int i = 0; i < elements.Length; i++)
                {
                    sentence = sentence.Replace("{" + $"{i}" + "}", elements[i]);
                }

                Console.WriteLine(sentence);

                inputLine = Console.ReadLine();
            }
        }
    }
}
