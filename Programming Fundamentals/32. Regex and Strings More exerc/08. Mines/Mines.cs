using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Mines
{
    class Mines
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();
            int startIndex = 0;
            int endIndex = 0;

            while ((startIndex = path.IndexOf("<", startIndex)) != -1 && (endIndex = path.IndexOf(">", startIndex)) != -1)
            {
                string bombChars = path.Substring(startIndex + 1, 2);
                int bombStrength = CalculateBombStrength(bombChars);

                int leftFromTheBomb = Math.Max(0, startIndex - bombStrength);
                int rightFromTheBomb = Math.Min(path.Length - 1, endIndex + bombStrength);

                Console.WriteLine(leftFromTheBomb);
                Console.WriteLine(rightFromTheBomb);

                StringBuilder strb = new StringBuilder(path);


            }

            
        }

        private static int CalculateBombStrength(string bombChars)
        {
            return Math.Abs(bombChars[0] - bombChars[1]);
        }
    }
}
