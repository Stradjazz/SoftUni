using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Hello_Name
{
    class HelloName
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            PrintTheName(name); 
        }
        static void PrintTheName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
