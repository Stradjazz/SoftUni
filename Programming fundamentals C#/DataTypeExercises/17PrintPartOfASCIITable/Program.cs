using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17PrintPartOfASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstChar = int.Parse(Console.ReadLine());
            int lastChar = int.Parse(Console.ReadLine());
            char symbols;

            for (int i = firstChar; i <= lastChar; i++)
            {
                symbols = Convert.ToChar(i);
                Console.Write(symbols);
            }
            Console.WriteLine();
        }
    }
}
