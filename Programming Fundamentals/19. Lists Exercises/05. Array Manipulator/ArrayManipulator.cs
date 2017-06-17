using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Array_Manipulator
{
    /*Write a program that reads an array of integers from the console and set of commands and executes them over the array. The commands are as follows:
    •	add <index> <element> – adds element at the specified index (elements right from this position inclusively are shifted to the right).
    •	addMany <index> <element 1> <element 2> … <element n> – adds a set of elements at the specified index.
    •	contains <element> – prints the index of the first occurrence of the specified element (if exists) in the array or -1 if the element is not found.
    •	remove <index> – removes the element at the specified index.
    •	shift <positions> – shifts every element of the array the number of positions to the left (with rotation).
    o	For example, [1, 2, 3, 4, 5] -> shift 2 -> [3, 4, 5, 1, 2]
    •	sumPairs – sums the elements in the array by pairs (first + second, third + fourth, …).
    o	For example, [1, 2, 4, 5, 6, 7, 8] -> [3, 9, 13, 8].
    •	print – stop receiving more commands and print the last state of the array. */
    class ArrayManipulator
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string commands = Console.ReadLine();
            while (commands != "print")
            {
                var tokens = commands.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var operation = tokens[0];

                switch (operation)
                {
                    case "add":
                        int index = int.Parse(tokens[1]);
                        int element = int.Parse(tokens[2]);
                        nums.Insert(index, element);
                        break;
                    case "addMany":
                        index = int.Parse(tokens[1]);
                        AddingRange(nums, index, tokens);
                        break;
                    case "contains":
                        element = int.Parse(tokens[1]);
                        CheckingIfContainsElement(nums, element);
                        break;
                    case "remove":
                        index = int.Parse(tokens[1]);
                        nums.RemoveAt(index);
                        break;
                    case "shift":
                        int positions = int.Parse(tokens[1]);
                        ShiftingLeft(nums, positions);
                        break;
                    case "sumPairs":
                        CalculatingTheSumOfPairs(nums);
                        break;
                }

                commands = Console.ReadLine();
            }
            Console.WriteLine($"[{string.Join(", ", nums)}]");
        }

        private static void CalculatingTheSumOfPairs(List<int> nums)
        {
            for (int i = 0; i < nums.Count - 1; i++)
            {
                nums[i] = nums[i] + nums[i + 1];
                nums.RemoveAt(i + 1);
            }
            
        }

        private static void CheckingIfContainsElement(List<int> nums, int element)
        {
            if (!nums.Contains(element))
            {
                Console.WriteLine(-1);
            }
            else
            {
                Console.WriteLine(nums.IndexOf(element));
            }
        }

        private static void AddingRange(List<int> nums, int index, string[] tokens)
        {
            index = int.Parse(tokens[1]);
            var range = new List<int>();
            for (int i = 2; i < tokens.Length; i++)
            {
                range.Add(int.Parse(tokens[i]));
            }
            nums.InsertRange(index, range);
        }

        private static void ShiftingLeft(List<int> nums, int positions)
        {
            for (int steps = 0; steps < positions; steps++)
            {
                nums.Add(nums[0]);
                nums.RemoveAt(0);
            }
            
        }
    }
}
