using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace _01.Day_Of_Week
{
    //You are given a date in format day-month-year. Calculate and print the day of week in English.
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            string inputDate = Console.ReadLine();
            DateTime date = DateTime.ParseExact(inputDate, "d-M-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(date.DayOfWeek);
        }
    }
}
