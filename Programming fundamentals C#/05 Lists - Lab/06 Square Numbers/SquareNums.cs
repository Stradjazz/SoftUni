using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Square_Numbers
{
    //Read a list of integers and extract all square numbers from it and print them in descending order. 
    //A square number is an integer which is the square of any integer. For example, 1, 4, 9, 16 are square numbers.

    class SquareNums
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> squareNums = new List<int>();

            foreach (var number in numbers)
            {
                double currentNum = Math.Sqrt(number);

                if (currentNum == (int)currentNum)
                {
                    squareNums.Add(number);
                }
            }

            squareNums.Sort((a, b) => b.CompareTo(a));

            Console.WriteLine(string.Join(" ", squareNums));
        }
    }
}
