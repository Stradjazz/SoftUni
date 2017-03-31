using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var time = Console.ReadLine();
            var taxiDay = 0.70 + (n * 0.79);
            var taxiNight = 0.70 + (n * 0.90);
            var bus = 0.09 * n;
            var train = 0.06 * n;

            var check1 = Math.Min(bus, taxiDay);
            var check2 = Math.Min(bus, taxiNight);
            var check3 = Math.Min(bus, train);
            var check4 = Math.Min(check1, check3);
            var check5 = Math.Min(check2, check3);

            if (time == "day" && n < 20)
            {
                Console.WriteLine(taxiDay);
            }
            else if (time == "night" && n < 20)
            {
                Console.WriteLine(taxiNight);
            }
            else if (time == "day" && n < 100)
            {
                Console.WriteLine(check1);
            }
            else if (time == "night" && n < 100)
            {
                Console.WriteLine(check2);
            }
            else if (time == "day" && n < 5000)
            {
                Console.WriteLine(check4);
            }
            else if (time == "night" && n < 5000)
            {
                Console.WriteLine(check5);
            }

        }
    }
}
