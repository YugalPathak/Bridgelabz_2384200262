using System;

// Base class representing a general bank account
public class BankAccount
{
    public int AccountNumber { get; set; }
    public double Balance { get; set; }

    public BankAccount(int accountNumber, double balance)
    {
        AccountNumber = accountNumber;
        Balance = balance;
    }

    // Method to display general account information
    public virtual void DisplayAccountInfo()
    {
        Console.WriteLine($"Account Number: {AccountNumber}, Balance: ${Balance}");
    }
}

// Subclass representing a Savings Account
public class SavingsAccount : BankAccount
{
    public double InterestRate { get; set; }

    public SavingsAccount(int accountNumber, double balance, double interestRate): base(accountNumber, balance)
    {
        InterestRate = interestRate;
    }

    public override void DisplayAccountInfo()
    {
        base.DisplayAccountInfo();
        Console.WriteLine($"Account Type: Savings, Interest Rate: {InterestRate}%");
    }
}

// Subclass representing a Checking Account
public class CheckingAccount : BankAccount
{
    public double WithdrawalLimit { get; set; }

    public CheckingAccount(int accountNumber, double balance, double withdrawalLimit): base(accountNumber, balance)
    {
        WithdrawalLimit = withdrawalLimit;
    }

    public override void DisplayAccountInfo()
    {
        base.DisplayAccountInfo();
        Console.WriteLine($"Account Type: Checking, Withdrawal Limit: ${WithdrawalLimit}");
    }
}

// Subclass representing a Fixed Deposit Account
public class FixedDepositAccount : BankAccount
{
    public int DepositTerm { get; set; } // Term in months

    public FixedDepositAccount(int accountNumber, double balance, int depositTerm): base(accountNumber, balance)
    {
        DepositTerm = depositTerm;
    }

    public override void DisplayAccountInfo()
    {
        base.DisplayAccountInfo();
        Console.WriteLine($"Account Type: Fixed Deposit, Deposit Term: {DepositTerm} months");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Creating different types of bank accounts
        SavingsAccount savings = new SavingsAccount(123456, 50000, 4.5);
        CheckingAccount checking = new CheckingAccount(789456, 30000, 2000);
        FixedDepositAccount fixedDeposit = new FixedDepositAccount(123789, 10000, 12);

        // Displaying account details
        savings.DisplayAccountInfo();
        Console.WriteLine();
        checking.DisplayAccountInfo();
        Console.WriteLine();
        fixedDeposit.DisplayAccountInfo();
    }
}