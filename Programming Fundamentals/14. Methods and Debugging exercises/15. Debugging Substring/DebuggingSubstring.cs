using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Debugging_Substring
{
    //Debugging exercises on broken code
    class DebuggingSubstring
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var jump = int.Parse(Console.ReadLine());

            const char search = 'p';
            var hasMatch = false;

            for (var i = 0; i < text.Length; i++)
            {
                if (text[i] == search)
                {
                    hasMatch = true;
                    var endIndex = jump + 1;

                    string matchedString = string.Empty;
                    if (i + endIndex <= text.Length)
                    {
                        matchedString = text.Substring(i, endIndex);
                    }
                    else
                    {
                        matchedString = text.Substring(i);
                    }

                    Console.WriteLine(matchedString);
                    i += jump;
                }
            }

            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}
