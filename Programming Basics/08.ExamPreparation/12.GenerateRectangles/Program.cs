using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.GenerateRectangles
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            var rectangle = 0;
            var area = 0;

            for (int left = -n; left <= n; left++)
            {
                for (int right = n; right > left; right--)
                {
                    for (int top = -n; top <= n; top++)
                    {
                        for (int bottom = n; bottom > top; bottom--)
                        {
                            area = (right - left) * (bottom - top);
                            if (area >= m)
                            {
                                Console.WriteLine("({0}, {1}) ({2}, {3}) -> {4}", left, top, right, bottom, area);
                                rectangle++;
                            }
                        }
                    }
                }
            }//end for left
            if (rectangle == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
