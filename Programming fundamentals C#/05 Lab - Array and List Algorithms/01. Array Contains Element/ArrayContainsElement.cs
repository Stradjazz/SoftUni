using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Array_Contains_Element
{
    //Read a list of integers on the first line of the console and an integer N from the second line of the console and print 
    //whether the element is contained in the array. If it is, print “yes”, otherwise print “no”.
    class ArrayContainsElement
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int numberToFind = int.Parse(Console.ReadLine());
            bool found = false;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == numberToFind)
                {
                    found = true;
                    Console.WriteLine("yes");
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("no");
            }
        }
    }
}
