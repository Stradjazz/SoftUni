using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Short_Words_Sorted
{
    //Read a text, extract its words, find all short words (less than 5 characters) and print them alphabetically, in lowercase.
    class ShortWordsSorted
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
                .Split(new[] { '.', ',', ':', ';', '(', ')', '[', ']', '\"', '\'', '\\', '/', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Where(w => w.Length < 5)
                .Select(w => w.ToLower())
                .OrderBy(w => w)
                .Distinct()
                .ToList();

            Console.WriteLine(string.Join(", ", words));
        }
    }
}
