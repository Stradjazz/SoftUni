using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Sino is one of those people that lives in SoftUni. He leaves every now and then, but when he leaves he always takes a different route, 
so he needs to know how much time it will take for him to go home. Your job is to help him with the calculations.
You will receive the time that Sino leaves SoftUni, the steps taken and time for each step in seconds. 
You need to print the exact time that he will arrive at home in the format specified. */

namespace _01.Sino_The_Walker
{
    class SinoTheWalker
    {
        static void Main(string[] args)
        {
            var timeFormat = @"hh\:mm\:ss";
            int secondsPerDay = 60 * 60 * 24;
            var leavingTime = TimeSpan.ParseExact(Console.ReadLine(), timeFormat, CultureInfo.InvariantCulture);
            var steps = int.Parse(Console.ReadLine()) % secondsPerDay;
            var secondsPerStep = int.Parse(Console.ReadLine()) % secondsPerDay;

            
            var totalSeconds = (steps * secondsPerStep);
            var arrivalTime = leavingTime.Add(new TimeSpan(0, 0, (int)totalSeconds));

            Console.WriteLine($"Time Arrival: {arrivalTime.ToString(timeFormat)}");


        }
    }
}
