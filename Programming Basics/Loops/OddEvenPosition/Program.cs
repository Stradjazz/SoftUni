using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double oddMax = -100000000000.0;
            double evenMax = -100000000000.0;
            double oddMin = 100000000000.0;
            double evenMin = 100000000000.0;
            var oddSum = 0.0d;
            var evenSum = 0.0d;

            
            if (n == 0)
            {
                Console.WriteLine("OddSum = 0");
                Console.WriteLine("OddMin = No");
                Console.WriteLine("OddMax = No");
                Console.WriteLine("EvenSum = 0");
                Console.WriteLine("EvenMin = No");
                Console.WriteLine("EvenMax = No");
            }
            else if (n == 1)
            {
                double num = double.Parse(Console.ReadLine());
                Console.WriteLine("OddSum = " + num);
                Console.WriteLine("OddMin = " + num);
                Console.WriteLine("OddMax = " + num);
                Console.WriteLine("EvenSum = 0");
                Console.WriteLine("EvenMin = No");
                Console.WriteLine("EvenMax = No");
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    double num = double.Parse(Console.ReadLine());

                    if (i % 2 != 0)
                    {
                        oddSum = oddSum + num;
                        if (oddMin > num) oddMin = num;
                        if (oddMax < num) oddMax = num;

                    }
                    else 
                    {
                        evenSum = evenSum + num;
                        if (evenMin > num) evenMin = num;
                        if(evenMax < num) evenMax = num;
                    }
                }
                
            }
            Console.WriteLine("OddSum = " + oddSum);
            Console.WriteLine("OddMin = " + oddMin);
            Console.WriteLine("OddMax = " + oddMax);
            Console.WriteLine("EvenSum = " + evenSum);
            Console.WriteLine("EvenMin = " + evenMin);
            Console.WriteLine("EvenMax = " + evenMax);
        }
    }
}
