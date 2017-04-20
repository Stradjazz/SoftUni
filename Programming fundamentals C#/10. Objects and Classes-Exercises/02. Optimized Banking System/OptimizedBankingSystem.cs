using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Remember the Ordered Banking System problem? Well, now you have to optimize it with classes. 
Create a class BankAccount which has a Name (string), Bank (string) and Balance (decimal). 
You will receive several input lines, containing information in the following way: {bank} | {accountName} | {accountBalance}
You need to store every given Account. When you receive the command “end” you must stop the input sequence.
Then you must print all Accounts, ordered by their balance, in descending order, and then by length of the bank name, in ascending order.
The accounts must be printed in the following way “{accountName} -> {balance} ({bank})”.
Note: Numbers must be printed, exactly as they are entered. No formatting is required. */

namespace _02.Optimized_Banking_System
{
    class BankAccount
    {
        public string Bank { get; set; }
        public string Name { get; set; }
        public decimal Balance { get; set; }
    }
    class OptimizedBankingSystem
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var accountsList = new List<BankAccount>();

            while (input != "end")
            {
                BankAccount currentAcc = ReadBankInfo(input);
                accountsList.Add(currentAcc);

                input = Console.ReadLine();
            }

            foreach (var account in accountsList.OrderByDescending(x => x.Balance).ThenBy(x => x.Bank.Length))
            {
                Console.WriteLine($"{account.Name} -> {account.Balance} ({account.Bank})");
            }
        }

        private static BankAccount ReadBankInfo(string input)
        {
            var tokens = input.Split(new[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            return new BankAccount
            {
                Bank = tokens[0],
                Name = tokens[1],
                Balance = decimal.Parse(tokens[2])
            };
        }
    }
}
