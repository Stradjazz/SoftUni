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

            var list = new List<int>();

            for (int i = 0; i < n; i++)
            {
                var sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                int rightMostElement = 0;
                int position = 0;
                bool isBroken = false;

                if (list.Count == 0)
                {
                    for (int j = 0; j < sequence.Count; j++)
                    {
                        list.Add(sequence[j]);
                    }
                }
                else
                {
                    for (int j = 0; j < sequence.Count; j++)
                    {
                        for (int k = 0; k < list.Count; k++)
                        {
                            if (list[k] <= sequence[j])
                            {
                                rightMostElement = list[k];
                                position = list.IndexOf(rightMostElement);
                            }
                            
                        }
                        break;
                    }

                    list.InsertRange(position + 1, sequence);
                }

                int brokenElement = 0;
                int breakPostion = 0;

                for (int j = 1; j < list.Count; j++)
                {
                    if (list[j] < list[j - 1])
                    {
                        brokenElement = list[j];
                        breakPostion = list.LastIndexOf(brokenElement);
                        isBroken = true;
                        break;
                    }
                }

                if (isBroken)
                {
                    for (int j = list.Count - 1; j >= breakPostion; j--)
                    {
                        list.RemoveAt(j);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
