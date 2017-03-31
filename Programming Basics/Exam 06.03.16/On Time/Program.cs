using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace On_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            var examHours = int.Parse(Console.ReadLine());
            var examMinutes = int.Parse(Console.ReadLine());
            var studHours = int.Parse(Console.ReadLine());
            var studMinutes = int.Parse(Console.ReadLine());

            var examTime = examHours * 60 + examMinutes;
            var studTime = studHours * 60 + studMinutes;
            var difference = studTime - examTime;

            if (difference < -30)
                Console.WriteLine("Early");
            else if (difference <= 0)
                Console.WriteLine("On time");
            else
                Console.WriteLine("Late");

            if (difference != 0)
            {
                var hours = Math.Abs(difference / 60);
                var minutes = Math.Abs(difference % 60);

                if (hours > 0)
                {
                    if (minutes < 10)
                        Console.Write(hours + ":0" + minutes + " hours");
                    else
                        Console.Write(hours + ":" + minutes + " hours");
                }
                else
                    Console.Write(minutes + "minutes");
                if (difference < 0)
                    Console.WriteLine(" before the start");
                else
                    Console.WriteLine(" after the start");

            }

        }
    }
}
