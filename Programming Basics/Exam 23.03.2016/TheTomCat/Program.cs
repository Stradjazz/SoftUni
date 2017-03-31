using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheTomCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int hollidays = int.Parse(Console.ReadLine());
            int workdays = 365 - hollidays;
            int perfect = 30000;
            var workplay = workdays * 63;
            var hollplay = hollidays * 127;
            var play = workplay + hollplay;
            var result = perfect - play;
            int hours = result / 60;
            int minutes = result % 60;

            if (result >= 0)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", hours, minutes);
            }
            else
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", Math.Abs(hours), Math.Abs(minutes));
            }
        }
    }
}
