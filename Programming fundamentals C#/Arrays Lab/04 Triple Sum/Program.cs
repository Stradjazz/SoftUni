using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Triple_Sum
{
    class TripleSum
    {
        //Write a program to read an array of integers and find all triples of elements a, b and c, such that a + b == c (where a stays left from b). 
        //Print “No” if no such triples exist.
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            bool matchCheck = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                var a = numbers[i];
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    var b = numbers[j];
                    var sum = a + b;

                    if (numbers.Contains(sum))
                    {
                        Console.WriteLine($"{a} + {b} == {sum}");
                        matchCheck = true;
                    }
                }//end for loop j
            }//end for loop i
            if (!matchCheck)
            {
                Console.WriteLine("No");
            }
        }
    }
}
