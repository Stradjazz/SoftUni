using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAfter5Days
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var year = 2015;
            DateTime input = new DateTime(year, m, d);
            DateTime future = input.AddDays(5);

            Console.WriteLine(future.ToString("d.MM"));
        }
    }
}
