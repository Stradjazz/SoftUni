using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Remove_Negatives_and_Reverse
{
    //Read a list of integers, remove all negative numbers from it and print the remaining elements in reversed order.
    //In case of no elements left in the list, print “empty”.
    class RemoveNegativesAndReverse
    {
        static void Main(string[] args)
        {
            List<int> listOfNumbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            listOfNumbers.RemoveAll(x => x < 0);
            if (listOfNumbers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                listOfNumbers.Reverse();
                Console.WriteLine(string.Join(" ", listOfNumbers));
            }
        }
    }
}
