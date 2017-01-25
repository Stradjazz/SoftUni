using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            ReversedNumber(number);
        }
        static void ReversedNumber(string number)
        {
            number = new string(number.ToCharArray().Reverse().ToArray());
            Console.WriteLine(number);
        }
    }
}
