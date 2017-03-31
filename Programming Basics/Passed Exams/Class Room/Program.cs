using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            var w = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            var lines = Math.Truncate(w * 100 / 120);
            var raws = Math.Truncate((h * 100 - 100) / 70);

            var places = lines * raws - 3;
            Console.WriteLine(places);
            
        }
    }
}
