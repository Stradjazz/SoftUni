using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Create a class User, which has a Username (string), and ReceivedMessages (Collection of Messages). 
Create a class Message, which has a Content (string) and a Sender (User).
You will have to store a messaging history for every user. The input consists of 2 commands:
“register {username}”
“{senderUsername} send {recipientUsername} {content}”

The register command, registers a user with the given username. 
The send command, sends a message, from the given sender, to the given recipient, with the given content. That means that you must add 
the message to the recipient’s ReceivedMessages. If even one of the given names does NOT exist, ignore the command.
When you receive the command “exit” you must end the input sequence. After that you will receive 2 usernames, separated by a space. 
You must print all messages, sent, between the two users, corresponding to the given usernames. The messages should be printed in a specified 
way. You should print first a message SENT from the first user, then a message SENT from the second user, then a message from the first user, 
and so on. If one of the collections of messages has more elements than the other, just print the remaining elements from it.
The first user’s messages must be printed in the following way: “{firstUser}: {content}”
The second user’s message must be printed in the following way: “{content} :{secondUser}”
When you print the whole output, it should look like this:
{firstUser}: {content1}
{content1} :{secondUser}
{firstUser}: {content2}
{content2} :{secondUser}
. . . 
In case there are NO messages between the two users, print “No messages”.  */
namespace _06.Messages
{
    class Messages
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var senders = new Dictionary<string, Message>();
            var users = new List<string>();

            while (input != "exit")
            {
                var tokens = input.Split(' ');
                if (tokens[0] == "register")
                {
                    users.Add(tokens[1]);
                }
                else
                {
                    var sender = tokens[0];
                    var recipient = tokens[2];
                    var content = tokens[3];
                    var currentUser = new User();
                    var message = new Message();

                    if (users.Contains(sender) && users.Contains(recipient))
                    {
                        if (!senders.ContainsKey(sender))
                        {
                            message.Sender = sender;
                            message.Content = new List<string>();
                            senders.Add(message.Sender, message);
                        }
                        if (!senders.ContainsKey(recipient))
                        {
                            var newMessage = new Message
                            {
                                Sender = recipient,
                                Content = new List<string>()
                            };
                            senders.Add(newMessage.Sender, newMessage);
                        }
                        senders[sender].Content.Add(content);
                    }
                }
                
                input = Console.ReadLine();
            }

            var newInput = Console.ReadLine().Split(' ');
            var firstUser = newInput[0];
            var secondUser = newInput[1];
            var hasMessages = false;

            if (senders.ContainsKey(firstUser) && senders.ContainsKey(secondUser))
            {
                var max = Math.Max(senders[firstUser].Content.Count, senders[secondUser].Content.Count);
                var firstCount = senders[firstUser].Content.Count;
                var secondCount = senders[secondUser].Content.Count;

                for (int i = 0; i < max; i++)
                {
                    if (senders.ContainsKey(firstUser) && firstCount > 0)
                    {
                        Console.WriteLine($"{senders[firstUser].Sender}: {senders[firstUser].Content[i]}");
                        hasMessages = true;
                    }
                    if (senders.ContainsKey(secondUser) && secondCount > 0)
                    {
                        Console.WriteLine($"{senders[secondUser].Content[i]} :{senders[secondUser].Sender}");
                        hasMessages = true;
                    }

                    firstCount--;
                    secondCount--;
                }
            }
            if (!hasMessages)
            {
                Console.WriteLine("No messages");
            }
        }
    }
}
