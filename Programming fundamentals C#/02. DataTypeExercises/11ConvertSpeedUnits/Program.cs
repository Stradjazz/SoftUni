using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            float distanceInMeters = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            float totalTimeInSeconds = seconds + (minutes * 60) + (hours * 3600);
            float timeInHours = totalTimeInSeconds / 3600.0F;
            float km = distanceInMeters / 1000.0F;
            float miles = distanceInMeters / 1609.0F;

            Console.WriteLine("{0}", (distanceInMeters / totalTimeInSeconds));
            Console.WriteLine("{0}", (km / timeInHours));
            Console.WriteLine("{0}", (miles / timeInHours));
        }
    }
}
