using System;
using System.Collections.Generic;

public class Bank
{
    public string Name;
    public List<Customer> customers = new List<Customer>();

    public Bank(string name)
    {
        Name = name;
    }

    public void OpenAccount(Customer customer, string accountType, string initialBalance)
    {
        BankAccount account = new BankAccount(this, accountType, initialBalance);
        customer.account.Add(account);
        customers.Add(customer);
        Console.WriteLine($"\n{customer.Name} is having {accountType} account with the initial balance of {initialBalance}\n");
    }

    public class BankAccount
    {
        public Bank bank;
        public string accountType;
        public string initialBalance;

        public BankAccount(Bank bank, string accountType, string initialBalance)
        {
            this.bank = bank;
            this.accountType = accountType;
            this.initialBalance = initialBalance;
        }
    }
}

// Move the Customer class outside the Bank class
public class Customer
{
    public string Name;
    public List<Bank.BankAccount> account = new List<Bank.BankAccount>();

    public Customer(string name)
    {
        Name = name;
    }

    public void ViewBalance()
    {
        Console.WriteLine($"\n{Name}'s account\n");
        foreach (var acc in account)
        {
            Console.WriteLine($"\nThe account type is {acc.accountType}\nThe bank name is {acc.bank.Name}\nThe initial balance is {acc.initialBalance}");
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Bank bank1 = new Bank("SBI");
        Bank bank2 = new Bank("HDFC");
        Bank bank3 = new Bank("PNB");

        Customer customer1 = new Customer("Yugal");
        Customer customer2 = new Customer("Shivang");
        Customer customer3 = new Customer("Chotu");

        bank1.OpenAccount(customer1, "Current", "5000");
        bank1.OpenAccount(customer3, "Saving", "6000");
        bank2.OpenAccount(customer1, "Saving", "7000");
        bank1.OpenAccount(customer2, "Current", "8000");
        bank3.OpenAccount(customer3, "Current", "100000");

        customer1.ViewBalance();
        customer2.ViewBalance();
        customer3.ViewBalance();
    }
}