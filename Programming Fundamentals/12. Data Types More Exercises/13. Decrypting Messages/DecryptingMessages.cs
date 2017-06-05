using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Decrypting_Messages
{
    /*You will receive a key (integer) and n characters afterward. Add the key to each of the characters and append them to message. 
    At the end print the message, which you decrypted.*/
    class DecryptingMessages
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            char decriptedChar = '.';
            string word = string.Empty;

            for (int i = 0; i < n; i++)
            {
                char ch = char.Parse(Console.ReadLine());
                decriptedChar = (char)(ch + key);
                word += decriptedChar;
            }

            Console.WriteLine(word);
        }
    }
}
