using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Max_Sequence_of_Equal_Elements
{
    //Read a list of integers and find the longest sequence of equal elements. If several exist, print the leftmost.
    class MaxSequenceEqualElements
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int count = 1;
            int start = 0;
            int max = 0;

            for (int i = 0; i < nums.Count - 1; i++)
            {
                int firstNum = nums[i];
                int secondNum = nums[i + 1];
                if (firstNum == secondNum)
                {
                    count++;
                    if (count > max)
                    {
                        start = i - (count - 1);
                        max = count;
                    }
                }
                else
                {
                    count = 1;
                    
                }
            }

            
            if (max < 2)
            {
                Console.WriteLine(nums[0]);
            }
            else
            {
                var sequence = nums.Skip(start + 1).Take(max).ToList();

                Console.WriteLine(string.Join(" ", sequence));
            }
        }
    }
}
