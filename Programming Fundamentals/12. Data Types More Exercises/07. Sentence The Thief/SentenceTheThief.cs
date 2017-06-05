using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sentence_The_Thief
{
    /*In the last task, you caught the thief, but in the future, everyone is multitasking and you need to calculate his sentence as well.
    His sentence equals to the times his id overflows the numerical type sbyte. Round the years to the nearest larger integer value (5.01->6).
    Example: If the thief’s id is 5251, that means the sentence will equal: 5251 / 127 = 41.35 years. Rounded to the next integer value, 
    the final sentence would be 42 years.
    Notice that the id might be negative and can overflow the negative boundary of sbyte.*/
    class SentenceTheThief
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

            double sentence = 0.0;

            if (thiefsID > 0)
            {
                sentence = thiefsID / 127.0;
            }
            else if (thiefsID < 0)
            {
                sentence = Math.Abs(thiefsID / -128.0);
            }
            sentence = Math.Ceiling(sentence);

            if (sentence != 1)
            {
                Console.WriteLine($"Prisoner with id {thiefsID} is sentenced to {sentence} years");
            }
            else
            {
                Console.WriteLine($"Prisoner with id {thiefsID} is sentenced to {sentence} year");
            }
        }
    }
}
