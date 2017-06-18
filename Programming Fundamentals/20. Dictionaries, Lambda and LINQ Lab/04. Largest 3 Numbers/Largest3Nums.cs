using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Largest_3_Numbers
{
    //Read a list of real numbers and print largest 3 of them. If less than 3 numbers exit, print all of them.
    class Largest3Nums
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            if (nums.Count > 3)
            {
                nums = nums.OrderByDescending(x => x).Take(3).ToList();
            }
            else
            {
                nums = nums.OrderByDescending(x => x).ToList();
            }
            

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
