using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Mining_Coins
{
    /*  In this problem you have to decrypt encrypted data and calculate its value. You will receive an integer N. On the next N lines, you will receive 3-digit integers.
The input integers will be indexed - starting from 1 to N. The integers represent characters of an encrypted message.
You must take the first and the last digit and form a 2-digit number from them, depending on the current index of the input number:
•	if the index is an odd number – subtract the middle digit from the 2-digit number.
•	If the index is even number – add the middle digit to the 2-digit number.
If the resulting number is an English alphabet letter (Lower or Uppercase) append it to a string. If it is not, ignore it.
After that, calculate the sum of the 3 digits and divide it by N.
The result from this operation should be a floating-point number, rounded to the 7-th digit after the decimal point.
Do the same for all input integers and sum the results. The sum is the value of the decrypted data.
The final result should be the decrypted string (the letters, appended together), and the value.
*/
    class MiningCoins
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string decrypted = "";
            float totalValue = 0;

            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                int digit1 = number / 100;
                int digit2 = (number % 100) / 10;
                int digit3 = number % 10;

                totalValue += (digit1 + digit2 + digit3) / (float)n;
                int ASCIIcode = 0;

                if (i % 2 == 1)
                {
                    ASCIIcode = ((digit1 * 10) + digit3) - digit2;
                }
                else
                {
                    ASCIIcode = ((digit1 * 10) + digit3) + digit2;
                }

                if ((ASCIIcode >= 65 && ASCIIcode <= 90)
                    || (ASCIIcode >= 97 && ASCIIcode <= 122))
                {
                    decrypted += (char)ASCIIcode;
                }
            }


            Console.WriteLine("Message: {0}", decrypted);
            Console.WriteLine("Value: {0:F7}", totalValue);
        }
    }
}
