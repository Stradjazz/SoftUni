using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Hello_Name
{
    //Write a method that receives a name as parameter and prints on the console. “Hello, <name>!”
    class HelloName

    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Greeting(name);
        }

        private static void Greeting(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
