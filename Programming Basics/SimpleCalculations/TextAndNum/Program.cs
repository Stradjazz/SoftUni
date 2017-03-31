using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAndNum
{
    class Program
    {
        static void Main(string[] args)
        {
            var FirstName = "Maria";
            var LastName = "Ivanova";
            var age = 25;
            var str = FirstName + " " + LastName + " @ " + age;
            Console.WriteLine(str);

            var a = 1.5;
            var b = 2.5;
            var sum = "The sum is: " + (a + b);
            Console.WriteLine(sum);
        }
    }
}
