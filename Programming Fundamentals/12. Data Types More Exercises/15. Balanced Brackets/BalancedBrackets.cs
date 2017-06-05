using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Balanced_Brackets
{
    class BalancedBrackets
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int openingCount = 0;
            int closingCount = 0;
            string completeInput = string.Empty;

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                if (input == "(")
                {
                    openingCount++;
                }
                else if (input == ")")
                {
                    closingCount++;
                }
                else
                {
                    continue;
                }
                completeInput += input;
            }
            var indexOpening = completeInput.LastIndexOf('(');
            var indexClosing = completeInput.LastIndexOf(')');
            if (openingCount == closingCount)
            {
                if (indexOpening < indexClosing)
                {
                    Console.WriteLine("BALANCED");
                }
                else
                {
                    Console.WriteLine("UNBALANCED");
                }
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
