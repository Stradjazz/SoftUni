using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._1.Math_Power_alt
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            double result = RaiseToPower(number, power);
            Console.WriteLine(result);
        }
        static double RaiseToPower(double number, double power)
        {
            double result = 0d;
            double temp = number;
            for (int i = 0; i < power; i++)
            {
                result = temp;
                temp = result * number;
            }
            return result;
        }
    }
}
