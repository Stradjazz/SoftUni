using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Sort_Numbers
{
    //Read a list of decimal numbers and sort them in increasing order. Print the output as shown in the examples below.
    class SortNumbers
    {
        static void Main(string[] args)
        {
            List<double> inputNums = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            inputNums.Sort();

            Console.WriteLine(string.Join(" <= ", inputNums));
        }
    }
}
