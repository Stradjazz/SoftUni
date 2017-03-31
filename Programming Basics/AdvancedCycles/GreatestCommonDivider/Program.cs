using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatestCommonDivider
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            var greater = Math.Max(a, b);
            var lesser = Math.Min(a, b);

            while (lesser !=0)
            {
                var rest = greater % lesser;

                greater = lesser;
                lesser = rest;

            }

            Console.WriteLine(greater);
        }
    }
}
