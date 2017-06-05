using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.String_Concatenation
{
    /* Write a program, which reads three lines from the console. On the first line, there will be delimiter (char) – you
    have to separate the strings by this delimiter. The second line will be either “even” or “odd”. If you receive “odd”,
    you have to take every odd string and vice versa if you receive “even”. The last line will be the number of lines – n
    which you will receive. The first iteration of the loop starts from 1.
    Print the newly created string on a new line.*/
    class StringConcatenation
    {
        static void Main(string[] args)
        {
            char delimiter = char.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string outputText = string.Empty;

            for (int i = 1; i <= n; i++)
            {
                string currentStr = Console.ReadLine();
                if (type == "odd")
                {
                    if (i % 2 != 0)
                    {
                        outputText += currentStr + delimiter;
                    }
                }
                else
                {
                    if (i % 2 == 0)
                    {
                        outputText += currentStr + delimiter;
                    }
                }
            }

            outputText = outputText.Remove(outputText.Length - 1);
            Console.WriteLine(outputText);
        }
    }
}
