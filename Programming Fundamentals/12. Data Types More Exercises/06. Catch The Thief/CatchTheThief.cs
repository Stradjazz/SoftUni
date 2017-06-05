using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Catch_The_Thief
{
    /*In the future, a very dangerous thief has escaped. Your mission is to catch him, but the only thing you know is the numeral type, which 
     is his id. On the first line, you will receive the numeral type of thief’s id. On the second line, you will receive n – the number
     of ids you will receive. The person who has an id closest to the maximum value of the given numeral type without overflowing it is 
     the thief’s id.*/
    class CatchTheThief
    {
        static void Main(string[] args)
        {
            string numType = Console.ReadLine();
            long typeMax = 0;
            long thiefsID = 0;

            switch (numType)
            {
                case "sbyte":
                    typeMax = sbyte.MaxValue;
                    thiefsID = sbyte.MinValue;
                    break;
                case "int":
                    typeMax = int.MaxValue;
                    thiefsID = int.MinValue;
                    break;
                case "long":
                    typeMax = long.MaxValue;
                    thiefsID = long.MinValue;
                    break;
            }

            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {

                long currentID = long.Parse(Console.ReadLine());
                
                if (currentID <= typeMax && currentID >= thiefsID)
                {
                    thiefsID = currentID;
                }
            }
            Console.WriteLine(thiefsID);
        }
    }
}
