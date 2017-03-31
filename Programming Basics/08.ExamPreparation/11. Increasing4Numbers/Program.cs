using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Increasing4Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            

            for (var n1 = a; n1 <= b; n1++)
            {
                for (var n2 = a; n2 <= b; n2++)
                {
                    for (var n3 = a; n3 <= b; n3++)
                    {
                        for (var n4 = a; n4 <= b; n4++)
                        {
                            if (n1 < n2 && n2 < n3 && n3 < n4)
                            {
                                Console.WriteLine("{0} {1} {2} {3}", n1, n2, n3, n4);
                            }
                        }
                    }
                }//end for n2
            }//end for n1
            if ((b-a) < 3)
            {
                Console.WriteLine("No");
            }
        }
    }
}
