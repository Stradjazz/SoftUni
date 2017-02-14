using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Ballistics_Training
{
    /*  You are the anti-aircraft operator, trying to shoot down the airplane from the previous problem. 
        You’ll be given instructions to get to the current coordinates of the plane. Shoot it down.
        You will be given an array which holds 2 numbers – the target X and Y coordinates of the plane.
        Afterwards, you will be given a second array, which holds a sequence of left / right / up / down commands and numbers. 
        We start at position {x=0, y=0}. Manipulate the firing position in the following way:
            •	Up increases y by the next number.
            •	Down decreases y by the next number.
            •	Left decreases x by the next number.
            •	Right increases x by the next number.
        After you process all the commands, print “firing at [{x}, {y}]”. After that, check if the firing position coordinates line up with the target coordinates. 
        If they do, print “got 'em!”. If not – print “better luck next time...”  */
    class BallisticsTraining
    {
        static void Main(string[] args)
        {
            int[] coordinates = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string[] commands = Console.ReadLine().Split(' ').ToArray();
            int[] shooting = new int[2];         //x = shooting[0], y = shooting[1]

            for (int i = 0; i < commands.Length; i++)
            {
                if (i % 2 == 0 && commands[i] == "up")
                {
                    shooting[1] += int.Parse(commands[i + 1]);
                }
                else if (i % 2 == 0 && commands[i] == "down")
                {
                    shooting[1] -= int.Parse(commands[i + 1]);
                }
                else if (i % 2 == 0 && commands[i] == "left")
                {
                    shooting[0] -= int.Parse(commands[i + 1]);
                }
                else if (i % 2 == 0 && commands[i] == "right")
                {
                    shooting[0] += int.Parse(commands[i + 1]);
                }
            }
            Console.WriteLine($"firing at [{shooting[0]}, {shooting[1]}]");

            if (coordinates[0] == shooting[0] && coordinates[1] == shooting[1])
            {
                Console.WriteLine("got 'em!");
            }
            else
            {
                Console.WriteLine("better luck next time...");
            }
        }
    }
}
