using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  The city is breaking down on a camel back. You will receive a sequence of N integers, (space-separated), which will represent the buildings 
    in the city.  You will then receive an integer M, indicating the camel back's size. 
    The camel back is a linear structure standing below the city, in such a way that it has an equal amount of buildings to its left and right.
    The idea is, if every round – one building falls from the left side of the city, and one from the right side, how many rounds will it take 
    for the city to stop breaking down? As output you must print how many rounds it took before the city stopped breaking down as 
    “{rounds} rounds”. On the next line, print what’s left of the city (space-separated). Format: “remaining: {buildings (space-separated)}”
    If no buildings have fallen, print “already stable: {buildings (space-separated)}”  */
namespace _03.Camel_s_Back
{
    class CamelsBack
    {
        static void Main(string[] args)
        {
            var buildings = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int camelBack = int.Parse(Console.ReadLine());
            int rounds = 0;

            while (buildings.Count > camelBack)
            {
                buildings.RemoveAt(0);
                buildings.RemoveAt(buildings.Count - 1);
                rounds++;
            }
            
            if (rounds == 0)
            {
                Console.WriteLine($"already stable: {string.Join(" ", buildings)}");
            }
            else
            {
                Console.WriteLine($"{rounds} rounds");
                Console.WriteLine($"remaining: {string.Join(" ", buildings)}");
            }
        }
    }
}
