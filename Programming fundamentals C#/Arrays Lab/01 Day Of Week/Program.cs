using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Day_Of_Week
{
    class DayOfWeek
    {
        //Enter a day number [1…7] and print the day name (in English) or “Invalid Day!”. Use an array of strings.
        static void Main(string[] args)
        {
            int numberOfDay = int.Parse(Console.ReadLine());

            var daysOfWeek = new string[7];
            daysOfWeek[0] = "Monday";
            daysOfWeek[1] = "Tuesday";
            daysOfWeek[2] = "Wednesday";
            daysOfWeek[3] = "Thursday";
            daysOfWeek[4] = "Friday";
            daysOfWeek[5] = "Saturday";
            daysOfWeek[6] = "Sunday";

            switch (numberOfDay)
            {
                case 1:
                    Console.WriteLine(daysOfWeek[0]);
                    break;
                case 2:
                    Console.WriteLine(daysOfWeek[1]);
                    break;
                case 3:
                    Console.WriteLine(daysOfWeek[2]);
                    break;
                case 4:
                    Console.WriteLine(daysOfWeek[3]);
                    break;
                case 5:
                    Console.WriteLine(daysOfWeek[4]);
                    break;
                case 6:
                    Console.WriteLine(daysOfWeek[5]);
                    break;
                case 7:
                    Console.WriteLine(daysOfWeek[6]);
                    break;
                default: Console.WriteLine("Invalid Day!");
                    break;
            }
        }
    }
}
