using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var max = -10000000000;

            for (var i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (max < num)
                {
                    max = num;
                }
                
            }
            Console.WriteLine(max);
        }
    }
}
