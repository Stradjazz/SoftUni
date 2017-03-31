using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Green_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = decimal.Parse(Console.ReadLine());
            var M = decimal.Parse(Console.ReadLine());
            var vegetables = Convert.ToInt32(Console.ReadLine());
            var fruits = Convert.ToInt32(Console.ReadLine());

            var sold = (N * vegetables) + (M * fruits);
            var result = decimal.Divide(sold, 1.94M);
            Console.WriteLine(result);
        }
    }
}
