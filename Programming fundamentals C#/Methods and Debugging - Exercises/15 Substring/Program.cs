using System;

public class Substring
{
    public static void Main()
    {


        var text = Console.ReadLine();
        var jump = int.Parse(Console.ReadLine());

        const char Search = 'p';
        var hasMatch = false;

        for (var i = 0; i < text.Length; i++)
            {
            if (text[i] == Search)
                {
                    hasMatch = true;

                    var endIndex = jump + 1;
                
                    string matchedString = string.Empty;
                    if (i + endIndex <= text.Length)
                        matchedString = text.Substring(i, endIndex);
                    else
                        matchedString = text.Substring(i);

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
