using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace _01.Day_of_Week
{
    //You are given a date in format day-month-year. Calculate and print the day of week in English.
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            var dateAsStr = Console.ReadLine();
            var date = DateTime.ParseExact(dateAsStr, "d-M-yyyy", CultureInfo.InvariantCulture);
            var dayOfWeek = date.DayOfWeek;

            Console.WriteLine(dayOfWeek);
        }
    }
}
