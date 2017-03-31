using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers1ToNStep3
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("num = ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("The numbers are:");
            for (int i = 1; i <= num; i+=3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
