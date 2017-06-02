using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Greeting
{
    //We want to read a name and then print that name with some additional text on the console.To accomplish this, we’ll use 
    //Console.ReadLine() and Console.WriteLine():
    class Greeting
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
