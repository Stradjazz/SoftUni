using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Increasing_Crisis
{
    /*  You will be given N – an integer. On the next N lines, you will receive sequences of integers, separated by a space.
        Your task is to add each sequence’s integers to a list, so that it forms an increasing sequence.
        If there are already elements inside the list, you must find the right-most element, lower by value, than the first element from 
        the given sequence, and start INSERTING, the sequence’s elements at the position, AFTER the found element.
        If the increasing sequence is BROKEN, during the addition of new elements, you must IGNORE the element that breaks it and all others 
        after it.You must also remove all elements from the list, AFTER the LAST ADDED element.
        When you process all input lines, you must print the list’s elements, separated by a single space.*/
    class IncreasingCrisis
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                if (sequence.Count == 0)
                {
                    sequence.Add(input[i]);
                }
                else
                {
                    for (int j = sequence.Count - 1; j >= 0; j--)
                    {
                        if (sequence[j] < input[0])
                        {

                        }
                    }
                }
            }//end for loop i
        }
    }
}
