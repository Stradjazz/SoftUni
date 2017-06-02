using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Wormhole
{
    class Wormhole
    {
        static void Main(string[] args)
        {
            var wormholes = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var stepcount = 0;
            var transportation = 0;

            for (int holeIndex = 0; holeIndex < wormholes.Length; holeIndex++)
            {
                
                if (wormholes[holeIndex] != 0)
                {
                    transportation = wormholes[holeIndex];
                    wormholes[holeIndex] = 0;
                    holeIndex = transportation;
                }
                stepcount++;
            }
            Console.WriteLine(stepcount);
        }
    }
}
