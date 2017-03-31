using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOnSegment
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = int.Parse(Console.ReadLine());
            var second = int.Parse(Console.ReadLine());
            var point = int.Parse(Console.ReadLine());
            

            var distance1 = Math.Abs(first - point);
            var distance2 = Math.Abs(second - point);
            var nearest = Math.Min(distance1, distance2);

            
            if (point >= Math.Min(first, second) && point <= Math.Max(first, second))
            {
                Console.WriteLine("in");
                Console.WriteLine(nearest);
            }
            else
            {
                Console.WriteLine("out");
                Console.WriteLine(nearest);
            }
        }
    }
}
