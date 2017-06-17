using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Bomb_Numbers
{
    /*Write a program that reads sequence of numbers and special bomb number with a certain power. Your task is to detonate every occurrence of the special bomb number and according to 
    its power its neighbors from left and right. Detonations are performed from left to right and all detonated numbers disappear. 
    Finally print the sum of the remaining elements in the sequence*/
    class BombNumbers
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            var bomb = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int detonator = bomb[0];
            int power = bomb[1];

            while (nums.Contains(detonator))
            {
                for (int i = 0; i < nums.Count; i++)
                {
                    var maxLength = nums.Count - 1;
                    int wholeRange = power + 1 + power;

                    if (nums[i] == detonator)
                    {
                        int bombIndex = i;

                        int rangeLeft = bombIndex - power;
                        int rangeRight = bombIndex + power;

                        if (rangeRight <= maxLength && rangeLeft >= 0)
                        {
                            nums.RemoveRange(rangeLeft, wholeRange);
                        }
                        else if (rangeRight <= maxLength && rangeLeft < 0)
                        {
                            wholeRange = wholeRange - Math.Abs(rangeLeft);
                            rangeLeft = 0;
                            nums.RemoveRange(rangeLeft, wholeRange);
                        }
                        else if (rangeRight > maxLength && rangeLeft >= 0)
                        {
                            wholeRange = wholeRange - Math.Abs(maxLength - rangeRight);
                            nums.RemoveRange(rangeLeft, wholeRange);
                        }
                        else if (rangeRight > maxLength && rangeLeft < 0)
                        {
                            nums.RemoveRange(0, nums.Count);
                        }
                    }
                }
            }
            
            long sum = 0;

            foreach (var num in nums)
            {
                sum += num;
            }
            Console.WriteLine(sum);
        }   
    }
}
