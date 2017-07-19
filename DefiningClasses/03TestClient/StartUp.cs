using System;
using System.Collections.Generic;

public class StartUp
{
    public static void Main()
    {
        Dictionary<int, BankAccount> accounts = new Dictionary<int, BankAccount>();

        string input = Console.ReadLine();
        while (input != "End")
        {
            string[] commands = input.Split();
            string commandType = commands[0];
            switch (commandType)
            {
                case "Create":
                    Create(commands, accounts);
                    break;
                case "Deposit":
                    Deposit(commands, accounts);
                    break;
                case "Withdraw":
                    Withdraw(commands, accounts);
                    break;
                case "Print":
                    Print(commands, accounts);
                    break;
            }
            input = Console.ReadLine();
        }
    }

    private static void Print(string[] commands, Dictionary<int, BankAccount> accounts)
    {
        int id = int.Parse(commands[1]);
        if (!accounts.ContainsKey(id))
        {
            Console.WriteLine("Account does not exist");
        }
        else
        {
            Console.WriteLine($"Account ID{accounts[id].ID}, balance {accounts[id].Balance:f2}");
        }
    }

    private static void Withdraw(string[] commands, Dictionary<int, BankAccount> accounts)
    {
        int id = int.Parse(commands[1]);
        double amount = double.Parse(commands[2]);
        if (!accounts.ContainsKey(id))
        {
            Console.WriteLine("Account does not exist");
        }
        else if (accounts[id].Balance < amount)
        {
            Console.WriteLine("Insufficient balance");
        }
        else
        {
            accounts[id].Balance -= amount;
        }
    }

    private static void Deposit(string[] commands, Dictionary<int, BankAccount> accounts)
    {
        int id = int.Parse(commands[1]);
        double amount = double.Parse(commands[2]);
        if (!accounts.ContainsKey(id))
        {
            Console.WriteLine("Account does not exist");
        }
        else
        {
            accounts[id].Balance += amount;
        }
    }

    private static void Create(string[] commands, Dictionary<int, BankAccount> accounts)
    {
        int id = int.Parse(commands[1]);
        if (accounts.ContainsKey(id))
        {
            Console.WriteLine("Account already exist");
        }
        else
        {
            BankAccount acc = new BankAccount()
            {
                ID = id
            };
            accounts.Add(id, acc);
        }
    }
}
