using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Altitude
{
    /*  You are an airplane pilot, trying to maneuver your airplane to safety from an unknown danger.
        An array holds a sequence of up / down commands and numbers. Its first element always holds the initial altitude. 
        The command up increases the altitude by the next number, while the command down decreases the altitude by the next number.
        If at any point the altitude becomes either zero or negative, print “crashed” and end the program. 
        If by the end, the altitude is positive, however, print “got through safely. current altitude: {altitude}m”.  */

    class Altitude
    {
        static void Main(string[] args)
        {
            
            string[] commands = Console.ReadLine().Split(' ').ToArray();
            double altitude = double.Parse(commands[0]);
            for (int i = 1; i < commands.Length; i++)
            {
                if (i % 2 != 0 && commands[i] == "up")
                {
                    altitude += double.Parse(commands[i + 1]);
                    
                }
                else if (i % 2 != 0 && commands[i] == "down")
                {
                    altitude -= double.Parse(commands[i + 1]);
                    if (altitude <= 0)
                    {
                        break;
                    }
                }
            }
            if (altitude <= 0)
            {
                Console.WriteLine("crashed");
            }
            else
            {
                Console.WriteLine($"got through safely. current altitude: {altitude}m");
            }
        }
    }
}
