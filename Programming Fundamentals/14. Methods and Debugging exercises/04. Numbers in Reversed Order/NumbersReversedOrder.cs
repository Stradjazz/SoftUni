using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Numbers_in_Reversed_Order
{
    /*Write a method that prints the digits of a given decimal number in a reversed order.*/
    class NumbersReversedOrder
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
