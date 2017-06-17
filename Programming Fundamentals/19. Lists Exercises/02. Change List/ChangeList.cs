using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Change_List
{
    /* Write a program, which reads a list of integers from the console and receives commands, which manipulate the list. Your program may receive the following commands: 
    •	Delete {element} – delete all elements in the array, which are equal to the given element
    •	Insert {element} {position} – insert element and the given position
    You should stop the program when you receive the command Odd or Even. If you receive Odd  print all odd numbers in the array separated with single whitespace, otherwise print 
    the even numbers. */
    class ChangeList
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while (command != "Odd" && command != "Even")
            {
                var tokens = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                var operation = tokens[0];
                var element = int.Parse(tokens[1]);
                var index = 0;

                if (tokens.Length > 2)
                {
                    index = int.Parse(tokens[2]);
                }

                switch (operation)
                {
                    case "Delete":
                        while (nums.Contains(element))
                        {
                            nums.Remove(element);
                        }
                        break;

                    case "Insert":
                        nums.Insert(index, element);
                        break;
                }

                command = Console.ReadLine();
            }
            
            if (command == "Odd")
            {
                for (int i = 0; i < nums.Count; i++)
                {
                    if (nums[i] % 2 == 0)
                    {
                        nums.Remove(nums[i]);
                        i--;
                    }
                }
                Console.WriteLine(string.Join(" ", nums));
            }
            else if (command == "Even")
            {
                for (int i = 0; i < nums.Count; i++)
                {
                    if (nums[i] % 2 != 0)
                    {
                        nums.Remove(nums[i]);
                        i--;
                    }
                }
                Console.WriteLine(string.Join(" ", nums));
            }
        }    
    }
}
