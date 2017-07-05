using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Match_Phone_Number
{
    /*Write a regular expression to match a valid phone number from Sofia. After you find all valid phones, print them on the console, separated by a comma and a space “, ”.*/
    class MatchPhoneNumber
    {
        static void Main(string[] args)
        {
            var pattern = @"\+359( |-)2\1[0-9]{3}\1[0-9]{4}\b";
            var regex = new Regex(pattern);
            var phoneNums = Console.ReadLine();
            
            MatchCollection matchedNums = Regex.Matches(phoneNums, pattern);
            List<string> numsForPrint = new List<string>();

            foreach (Match num in matchedNums)
            {
                numsForPrint.Add(num.Value);
            }
            Console.WriteLine(string.Join(", ", numsForPrint));
        }
    }
}
