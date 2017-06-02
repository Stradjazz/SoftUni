using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Add_Two_Numbers
{
    /* Write a program, which reads 2 whole numbers and adds them together. Then, print them in the following format: “a + b = sum” */
    class AddTwoNumbers
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            int sum = firstNum + secondNum;

            Console.WriteLine($"{firstNum} + {secondNum} = {sum}");
        }
    }
}
