using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var leftSum = 0;
            var rightSum = 0;
            

            for (int i = 0; i < n; i++)
            {
                int leftNum = int.Parse(Console.ReadLine());
                leftSum += leftNum;
            }
            for (int k = 0; k < n; k++)
            {
                int rightNum = int.Parse(Console.ReadLine());
                rightSum += rightNum;
            }
            var sum = Math.Abs(leftSum - rightSum);
            if (sum == 0)
            {
                Console.WriteLine("Yes, sum = " + leftSum);
            }
            else
            {
                Console.WriteLine("No, diff = {0}", sum);
            }
        }
    }
}
