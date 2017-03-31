using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitcoin = int.Parse(Console.ReadLine()) * 1168;
            decimal yuan = decimal.Parse(Console.ReadLine());
            decimal fee = decimal.Parse(Console.ReadLine());

            yuan = Decimal.Multiply(yuan, (decimal)0.15);
            decimal dollar = Decimal.Multiply(yuan, (decimal)1.76);

            decimal euro = decimal.Divide((bitcoin + dollar), (decimal)1.95);
            var sum = euro - Decimal.Divide(fee, (decimal)100.00);

            Console.WriteLine(sum);

        }
    }
}
