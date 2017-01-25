using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Hello_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            
            Console.WriteLine(PrintTheName(name));
        }
        static string PrintTheName(string name)
        {
            
            string greeting = $"Hello, {name}!";
            return greeting;
            
        }
    }
}
