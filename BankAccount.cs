using System;

class BankAccount
{
    // Static variable shared across all accounts
    public static string bankName = "SBI Bank"; // Default bank name
    private static int totalAccounts = 0; // Keeps track of total accounts created

    // Readonly variable to ensure the account number cannot be changed after initialization
    public readonly int AccountNumber;
    public string AccountHolderName;
    public double Balance;

    private const double MinimumBalance = 2000; // Minimum balance required in the account

    // Constructor to initialize account details
    public BankAccount(string accountHolderName, int accountNumber, double initialBalance)
    {
        this.AccountHolderName = accountHolderName; // Using 'this' to resolve ambiguity
        this.AccountNumber = accountNumber;
        this.Balance = initialBalance >= MinimumBalance ? initialBalance : MinimumBalance; // Ensures minimum balance is maintained
        totalAccounts++; // Increment total account count
    }

    // Static method to get the total number of accounts
    public static int GetTotalAccounts()
    {
        return totalAccounts;
    }

    // Method to manage account operations using switch case
    public void ManageAccount()
    {
        bool exit = false;
        while (!exit)
        {
            // Display menu options
            Console.WriteLine("\nSelect an option:\n");
            Console.WriteLine("1. Deposit Amount");
            Console.WriteLine("2. Withdraw Amount");
            Console.WriteLine("3. Check Current Balance");
            Console.WriteLine("4. Change Bank Name");
            Console.WriteLine("5. Exit");
            int choice = Convert.ToInt32(Console.ReadLine());
            
            switch (choice)
            {
                case 1:
                    // Deposit amount into account
                    Console.Write("Enter amount to deposit: ");
                    double deposit = Convert.ToDouble(Console.ReadLine());
                    Balance += deposit;
                    Console.WriteLine("Amount Deposited Successfully.");
                    break;
                case 2:
                    // Withdraw amount from account
                    Console.Write("Enter amount to withdraw: ");
                    double withdraw = Convert.ToDouble(Console.ReadLine());
                    if (Balance - withdraw >= MinimumBalance)
                    {
                        Balance -= withdraw;
                        Console.WriteLine("Amount Withdrawn Successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Insufficient Balance. Minimum balance of " + MinimumBalance + " must be maintained.");
                    }
                    break;
                case 3:
                    // Display current balance
                    Console.WriteLine("Current Balance: " + Balance);
                    break;
                case 4:
                    // Change bank name at runtime
                    Console.Write("Enter new bank name: ");
                    bankName = Console.ReadLine();
                    Console.WriteLine("Bank name updated successfully to: " + bankName);
                    Console.WriteLine("\nWelcome to " + bankName);
                    break;
                case 5:
                    // Exit the account management system
                    exit = true;
                    Console.WriteLine("Exiting Account Management.");
                    break;
                default:
                    // Handle invalid input
                    Console.WriteLine("Invalid Choice. Try Again.");
                    break;
            }
        }
    }

    public static void Main()
    {
        // Display welcome message with the current bank name
        Console.WriteLine("\nWelcome to " + bankName);

        // Create a new bank account
        BankAccount acc1 = new BankAccount("Yugal", 10811912, 8500);

        // Check if acc1 is an instance of BankAccount before proceeding
        if (acc1 is BankAccount)
        {
            Console.WriteLine("\nAccount Holder: " + acc1.AccountHolderName);
            Console.WriteLine("Account Number: " + acc1.AccountNumber);
            Console.WriteLine("Current Balance: " + acc1.Balance);
        }
        else
        {
            Console.WriteLine("Invalid account object.");
        }

        // Start account management
        acc1.ManageAccount();

        // Display total number of accounts created
        Console.WriteLine("Total Accounts: " + BankAccount.GetTotalAccounts());
    }

}