using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumsNTo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            for (int i = n; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
