using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

/*You have been tasked to create a program which represents a Console interface for creating HTML files.
Every HTML file naturally holds the following elements:
“<!DOCTYPE html>
 <html>
 <head>
 </head>
 <body>
 </body>
 </html>”
You will need to add them at the end in order to form the file...
You will start receiving input lines in the following format: {tag} {content}
You should generate a string from every input line – like this: <{tag}>{content}</{tag}> …
If the tag is “title” you should add the generated string between the <head> and </head> tags with a tabulation (“\t”) before it. 
If you receive the “title” tag MORE than ONCE, you should CHANGE its value.
In any other case you should APPEND the generated string between the <body> and </body> tags with a tabulation (“\t”) before it.
When you receive the command “exit” the input ends. The content you have generated should be stored in a file 
called “index.html” (.html extension).*/
namespace _02.HTML_Contents
{
    class HTMLContents
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines("input.txt");
            var title = string.Empty;
            var bodyLines = new List<string>();

            foreach (var line in lines)
            {
                if (line == "exit")
                {
                    break;
                }
                var lineParts = line.Split(' ');
                var tag = lineParts[0];
                var tagContent = lineParts[1];

                if (tag == "title")
                {
                    title = tagContent;
                }
                else
                {
                    bodyLines.Add($"\t<{tag}>{tagContent}</{tag}>");
                }
            }
            var result = new StringBuilder();
            result.AppendLine("<!DOCTYPE html>");
            result.AppendLine("<html>");
            result.AppendLine("<head>");

            if (title != string.Empty)
            {
                result.AppendLine($"\t<title>{title}</title>");
            }
            result.AppendLine("</head>");
            result.AppendLine("<body>");

            if (bodyLines.Any())
            {
                result.AppendLine(string.Join(Environment.NewLine, bodyLines));
            }
            result.AppendLine("</body>");
            result.AppendLine("</html>");

            File.WriteAllText("index.html", result.ToString().Trim());
            

        }
    }
}
