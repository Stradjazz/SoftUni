using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolPipes
{
    class Program
    {
        static void Main(string[] args)
        {
            int V = int.Parse(Console.ReadLine());
            int P1 = int.Parse(Console.ReadLine());
            int P2 = int.Parse(Console.ReadLine());
            double H = double.Parse(Console.ReadLine());

            var pipe1 = P1 * H;
            var pipe2 = P2 * H;
            var water = pipe1 + pipe2;
           
            
            if (water <= V)
            {
                var pool = Math.Floor((water / V) * 100);
                var partPipe1 = Math.Floor((pipe1 / water) * 100);
                var partPipe2 = Math.Floor((pipe2 / water) * 100);
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.",
                    Math.Floor(pool), Math.Floor(partPipe1), Math.Floor(partPipe2));
                
            }
            else
            {
                var overflow = water - V;
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.",
                    H, overflow);
            }
            
        }
    }
}
