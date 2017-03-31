using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add15Min
{
    class Program
    {
        static void Main(string[] args)
        {
            int hoursIn = int.Parse(Console.ReadLine()) * 60;
            int minutesIn = int.Parse(Console.ReadLine());

            int total = hoursIn + minutesIn + 15;
            var hours = total / 60;
            var minutes = total % 60;

            if (hours == 24)
            {
                Console.WriteLine("0:{0:00}", minutes);
            } 
            else
            {
                Console.WriteLine("{0:0}:{1:00}", hours, minutes);
            }
        }
    }
}
