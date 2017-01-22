using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerToHexAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            var resultHex = Convert.ToString(input, 16).ToUpper();
            var resultBinary = Convert.ToString(input, 2);

            Console.WriteLine(resultHex);
            Console.WriteLine(resultBinary);
        }
    }
}
