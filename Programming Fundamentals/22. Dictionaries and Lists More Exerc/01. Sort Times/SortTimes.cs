using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace _01.Sort_Times
{
    /* Write a program, which receives a list of times (space-separated, 24-hour format) and sorts them in ascending order. Print the sorted times comma-separated.
    Example: 06:55, 02:30, 23:11  02:30, 06:55, 21:11 */

    class SortTimes
    {
        static void Main()
        {
            var datesList = Console.ReadLine().Split().OrderBy(time => time).ToList();

            Console.WriteLine(string.Join(", ", datesList));
        }
    }
}
