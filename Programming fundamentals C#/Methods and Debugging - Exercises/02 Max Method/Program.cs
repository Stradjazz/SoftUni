using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputA = int.Parse(Console.ReadLine());
            int inputB = int.Parse(Console.ReadLine());
            int inputC = int.Parse(Console.ReadLine());

            int tempMax = GetMax(inputA, inputB);
            int max = Math.Max(tempMax, inputC);

            Console.WriteLine(max);
        }

        public static int GetMax(int inputA, int inputB)
        {
            return Math.Max(inputA, inputB);
        }
    }
}
