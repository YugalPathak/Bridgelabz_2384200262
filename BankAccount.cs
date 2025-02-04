
using System;

class BankAccount
{
    // Public variable accountNumber
    public string accountNumber;

    // Protected variable accountHolder
    protected string accountHolder;

    // Private variable balance
    private double balance;

    // Constructor to initialize bank account details
    public BankAccount(string accountNumber, string accountHolder, double balance)
    {
        this.accountNumber = accountNumber;
        this.accountHolder = accountHolder;
        this.balance = balance;
    }

    // Public method to get the balance
    public double GetBalance()
    {
        return balance;
    }

    // Public method to modify the balance
    public void SetBalance(double newBalance)
    {
        if (newBalance >= 0)
        {
            balance = newBalance;
            Console.WriteLine("Balance updated successfully.");
        }
        else
        {
            Console.WriteLine("Invalid balance amount. Balance cannot be negative.");
        }
    }

    // Method to display bank account details
    public void DisplayBankAccountDetails()
    {
        Console.WriteLine($"Account Number: {accountNumber}");
        Console.WriteLine($"Account Holder: {accountHolder}");
        Console.WriteLine($"Balance: {balance}");
    }
}

class SavingsAccount : BankAccount
{
    // Constructor for SavingsAccount, calling the base class constructor
    public SavingsAccount(string accountNumber, string accountHolder, double balance)
        : base(accountNumber, accountHolder, balance)
    {
    }

    // Method to display the savings account details (demonstrates access to accountNumber and accountHolder)
    public void DisplaySavingsAccountDetails()
    {
        Console.WriteLine($"Account Number: {accountNumber} (Savings Account)");
        Console.WriteLine($"Account Holder: {accountHolder} (Savings Account)");
        Console.WriteLine($"Balance: {GetBalance()}");
    }
}

class Program
{
    static void Main()
    {
        // Create a regular BankAccount object
        BankAccount account1 = new BankAccount("123456789", "Yugal Pathak", 100000);
        account1.DisplayBankAccountDetails();

        // Modify the balance using SetBalance method
        account1.SetBalance(70000.00);
        Console.WriteLine($"Updated Balance: {account1.GetBalance()}\n");

        // Create a SavingsAccount object
        SavingsAccount savingsAccount1 = new SavingsAccount("987654321", "Neelanshu Pathak", 800000);
        savingsAccount1.DisplaySavingsAccountDetails();

        // Modify the balance for the SavingsAccount object
        savingsAccount1.SetBalance(20000);
        Console.WriteLine($"Updated Balance: {savingsAccount1.GetBalance()}\n");

        // Display Savings Account details again after modifying the balance
        savingsAccount1.DisplaySavingsAccountDetails();
    }
}

