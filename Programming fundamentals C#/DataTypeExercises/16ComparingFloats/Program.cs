using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberA = double.Parse(Console.ReadLine());
            double numberB = double.Parse(Console.ReadLine());
            double eps = 0.000001;
            double difference = Math.Abs(numberA - numberB);
            bool equal = false;

            if (difference < eps)
            {
                equal = true;
            }

            Console.WriteLine(equal);
        }
    }
}
