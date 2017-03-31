using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1 = int.Parse(Console.ReadLine());
            double N2 = double.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            double result = -1.0;
            string evenOdd = null;

            switch (operation)
            {
                case "+": result = N1 + N2; break;
                case "-": result = N1 - N2; break;
                case "*": result = N1 * N2; break;
                case "/": result = N1 / N2; break;
                case "%": result = N1 % N2; break;
                
            }

            if (operation == "+" || operation == "-" || operation == "*")
            {
                if (result % 2 == 0)
                {
                    evenOdd = "even";
                }
                else
                {
                    evenOdd = "odd";
                }

                Console.WriteLine($"{N1} {operation} {N2} = {result} - {evenOdd}");
            }
            else if (operation == "/")
            {
                if (N2 == 0)
                {
                    Console.WriteLine($"Cannot divide {N1} by zero");
                }
                else
                {
                    Console.WriteLine($"{N1} / {N2} = {result:F2}");
                }
            }

            else if (operation == "%")
            {
                if (N2 == 0)
                {
                    Console.WriteLine($"Cannot divide {N1} by zero");
                }
                else
                {
                    Console.WriteLine($"{N1} % {N2} = {result}");
                }
                
            }
            
        }
    }
}
