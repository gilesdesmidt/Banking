using Banking.Models.Domain;
using System;

namespace Banking
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BankAccount account = new BankAccount("123-4567890-12");
            account.Deposit(200);
            WriteTConsole(account);
            account.Withdraw(100);
            WriteTConsole(account);
        }

        private static void WriteTConsole(BankAccount account)
        {
            Console.WriteLine($"Balance: {account.Balance}");
        }
    }
}