using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNum = int.Parse(Console.ReadLine());
            var secondNum = int.Parse(Console.ReadLine());
            if (firstNum > secondNum)
            {
                Console.WriteLine(firstNum);
            }
            else if (firstNum == secondNum)
            {
                Console.WriteLine("equals");
            }
            else
            {
                Console.WriteLine(secondNum);
            }
        }
    }
}
