using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Search_for_a_Number
{
    /*On the first line, you will receive a list of integers. On the next line, you will receive an array with exactly three numbers. First number represents the number of 
    elements you have to take from the list (starting from the first one). Second number represents the number of elements you have to delete from the numbers you 
    took (starting from the first one). Last number is the number we search in our collection after the manipulations. If it is present print: “YES!”, otherwise print “NO!”. */
    class SearchForANumber
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int[] modifyers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            nums = nums.Take(modifyers[0]).Skip(modifyers[1]).ToList();

            if (nums.Contains(modifyers[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
