using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Increasing_Sequence_of_Elements
{
    //Read an array of integers and find out if it is an increasing sequence. Print Yes if it does and No if it doesn’t.
    class IncreasingSequence
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            
            bool isIncreasing = true;
            
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] >= numbers[i + 1])
                {
                    isIncreasing = false;
                }
                
            }
            if (isIncreasing)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            
            
            
        }
    }
}
