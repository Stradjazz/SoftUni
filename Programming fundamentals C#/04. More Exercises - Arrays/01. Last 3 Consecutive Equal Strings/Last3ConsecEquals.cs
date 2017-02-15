using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Last_3_Consecutive_Equal_Strings
{
    //Read an array of strings and find the last three consecutive equal strings.
    class Last3ConsecEquals
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ').ToArray();
            int counter = 1;
            
            for (int i = words.Length - 1; i > 0; i--)
            {
                if (words[i] == words[i - 1])
                {
                    counter++;
                    if (counter == 3)
                    {
                        Console.WriteLine("{0} {0} {0}", words[i]);
                        break;
                    }
                }
                else
                {
                    counter = 1;
                }
                
            }
            

        }
    }
}
