using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Short_Words_Sorted
{
    /*Read a text, extract its words, find all short words (less than 5 characters) and print them alphabetically, in lowercase.
    •	Use the following separators: . , : ; ( ) [ ] " ' \ / ! ? (space).
    •	Use case-insensitive matching.
    •	Remove duplicated words. */
    class ShortWordsSorted
    {
        static void Main(string[] args)
        {
            var separators = ".,:;()[]\"\'\\/!? ".ToCharArray();
            var inputLine = Console.ReadLine().ToLower().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> shortWords = inputLine.Where(x => x.Length < 5).OrderBy(x => x).Distinct().ToList();

            Console.WriteLine(string.Join(", ", shortWords));
        }
    }
}
