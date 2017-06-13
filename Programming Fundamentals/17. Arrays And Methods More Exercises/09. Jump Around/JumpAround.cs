using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Jump_Around
{
    /*You will receive an integer array from the console. You start from the beginning of the array and try to move right by a step, equal to the value at position 0. If that 
    is possible you should collect the value from the index on which you landed, and try to move to the right by its value, if that is not possible – try to move to the left. 
    If that is also not possible stop the program and print the sum of the collected values. */
    class JumpAround
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var index = 0;
            var sum = numbers[index];
            var length = numbers.Length - 1;

            while (true)
            {
                if (index + numbers[index] <= length)
                {
                    index += numbers[index];
                    sum += numbers[index];
                }
                else if (index + numbers[index] >= 0)
                {
                    if (length - 1 - numbers[index] >= 0)
                    {
                        index -= numbers[index];
                        sum += numbers[index];
                    }
                    else
                    {
                        break;
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}
