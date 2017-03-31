using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terracotta
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = double.Parse(Console.ReadLine());
            var W = double.Parse(Console.ReadLine());
            var L = double.Parse(Console.ReadLine());
            var M = double.Parse(Console.ReadLine());
            var O = double.Parse(Console.ReadLine());

            var area = (N * N) - (M * O);
            var brick = W * L;
            double time = 0.2;

            var bricks = area / brick;
            var totalTime = bricks * time;
            Console.WriteLine(bricks);
            Console.WriteLine(totalTime); 
        }
    }
}
