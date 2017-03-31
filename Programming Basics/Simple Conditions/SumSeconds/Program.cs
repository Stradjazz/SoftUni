using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int player1 = int.Parse(Console.ReadLine());
            int player2 = int.Parse(Console.ReadLine());
            int player3 = int.Parse(Console.ReadLine());

            var totalTime = player1 + player2 + player3;
            var seconds = totalTime % 60;
            var minutes = totalTime / 60;

            if (seconds >= 10)
            {
                Console.WriteLine("{0}:{1}", minutes, seconds);
            }
            else
            {
                Console.WriteLine("{0}:0{1}", minutes, seconds);    
            }
        }
    }
}
