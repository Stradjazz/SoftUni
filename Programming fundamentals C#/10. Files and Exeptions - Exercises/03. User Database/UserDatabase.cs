using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*You have been tasked to create a database for several users, using … Text files.
The client will give you several input commands. There are two main commands:
•	register {username} {password} {confirmPassword}
•	login {username} {password}
•	logout
If you receive the register command, you must store the user in your database of users, with the given password. 
•	If there is already a user with the given username, you must print “The given username already exists.”, and ignore the command.
•	If the password and confirmPassword, do NOT match, print on the console “The two passwords must match.”, and ignore the command.
If you receive the login command, you must log in the user with the given username and password. 
•	If there is already a logged in user, you must print “There is already a logged in user.”, and ignore the command.
•	If there is NO user, with the given username you must print “There is no user with the given username.”, and ignore the command.
•	If the password is does NOT match the one with which the user was registered, you must print “The password you entered is incorrect.”, and ignore the command.
If you receive the logout command, you must logout the currently logged in user.
•	If there is NO currently logged in user, you must print “There is no currently logged in user.”, and ignore the command.
When you receive the command “exit”, the input sequence ends. You must store the current database of REGISTERED users, in a file 
called “users.txt”. The way you store them is up to you. You must load it, every time the program is ran. */
namespace _03.User_Database
{
    public class UserDatabase
    {
        private static string dbPath = "users.txt";
        private static Dictionary<string, string> users = new Dictionary<string, string>();
        private static string loggedUser = null;
        public static void Main(string[] args)
        {
            if (!File.Exists(dbPath))
            {
                File.Create(dbPath).Close();
            }

            var dbLines = File.ReadAllLines(dbPath);
            foreach (var line in dbLines)
            {
                var tokens = line.Split(' ').ToArray();
                var currentUser = tokens[0];
                var currentPass = tokens[1];
                if (!users.ContainsKey(currentUser))
                {
                    users.Add(currentUser, currentPass);
                }
            }

            var commands = File.ReadAllLines("../../input.txt");
            foreach (var command in commands)
            {
                var commandParts = command.Split(' ');
                
                switch (commandParts[0])
                {
                    case "register":
                        var username = commandParts[1];
                        var pass = commandParts[2];
                        var confirmPass = commandParts[3];
                        Register(username, pass, confirmPass);
                        break;
                    case "login":
                        username = commandParts[1];
                        pass = commandParts[2];
                        Login(username, pass);
                        break;
                    case "logout":
                        Logout();
                        break;
                }
            }
        }

        private static void Logout()
        {
            if (loggedUser == null)
            {
                Console.WriteLine("There is no currently logged in user.");
            }
            else
            {
                loggedUser = null;
            }
        }

        private static void Login(string username, string pass)
        {
            if (loggedUser != null)
            {
                Console.WriteLine("There is already a logged in user.");
                return;
            }
            if (!users.ContainsKey(username))
            {
                Console.WriteLine("There is no user with the given username.");
                return;
            }
            if (users[username] != pass)
            {
                Console.WriteLine("The password you entered is incorrect.");
                return;
            }
            loggedUser = username;
        }

        private static void Register(string username, string pass, string confirmPass)
        {
            if (users.ContainsKey(username))
            {
                Console.WriteLine("The given username already exists.");
            }
            else
            {
                if (pass != confirmPass)
                {
                    Console.WriteLine("The two passwords must match.");
                }
                else
                {
                    users[username] = pass;

                    File.AppendAllLines(dbPath, new[] { $"{username} {pass}" });
                }
            }
        }
    }
}
