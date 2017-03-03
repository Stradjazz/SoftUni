using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Tear_In_Half
{
    /*  You will receive a list of integers on the first input line (space-separated). 
        Your task is to separate the list into two parts and perform the following operations:
        Split the list into 2 equal parts and stack the right half on top of the left half:
        Place each digit of the upper list elements on either side of the lower list:
        After you perform the operations, print the resulting list on the console.  */

    class TearInHalf
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var firstHalf = input.Take(input.Length / 2).ToArray();
            var secondHalf = input.Skip(input.Length / 2).ToArray();
            var length = input.Length + (input.Length / 2);
            var result = new List<int>(length);


            for (int i = 0; i < firstHalf.Length; i++)
            {
                result.Add(secondHalf[i] / 10);
                result.Add(firstHalf[i]);
                result.Add(secondHalf[i] % 10);
            }

            Console.WriteLine(string.Join(" ", result));

        }
    }
}
