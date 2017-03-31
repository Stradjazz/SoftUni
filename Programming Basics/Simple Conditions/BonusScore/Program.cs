using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            double bonus = 0;

            if (num <= 100)
            {
                bonus = 5;
            }
            else if (num > 100 && num < 1000)
            {
                bonus = num / 5.0;
            }
            else if (num > 1000)
            {
                bonus = num / 10.0;
            }
            if (num % 2 == 0)
            {
                bonus = bonus +1;
            }
            else if (num % 5 == 0)
            {
                bonus = bonus + 2;
            }
            Console.WriteLine("Bonus score: {0}", bonus);
            Console.WriteLine("Total score: {0}", bonus + num);
        }
    }
}
