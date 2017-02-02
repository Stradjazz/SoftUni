using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05BooleanVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            bool test = bool.Parse(Console.ReadLine().ToLower());
            if (test == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
