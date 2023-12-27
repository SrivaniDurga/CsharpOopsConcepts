using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    
    // Abstraction and Encapsulation
    public abstract class Account
    {
        // Encapsulated attributes (fields)
        private string accountNumber;
        private double balance;
        private string owner;

        // Public property for read-only access to account number
        public string AccountNumber
        {
            get { return accountNumber; }
        }

        // Protected property for balance with encapsulation
        protected double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        // Public property for read-only access to owner
        public string Owner
        {
            get { return owner; }
        }

        // Constructor for initializing account details
        public Account(string accountNumber, double initialBalance, string owner)
        {
            this.accountNumber = accountNumber;
            this.balance = initialBalance;
            this.owner = owner;
        }

        // Abstract method for withdrawal (Abstraction)
        public abstract void Withdraw(double amount);

        // Public method for deposit
        public void Deposit(double amount)
        {
            balance += amount;
            Console.WriteLine($"{owner}'s account ({accountNumber}) has been credited with {amount} Rs. New balance: {balance} Rs");
        }
        //Method Overloading
        public void Deposit(double amount,string message)
        {
            balance += amount;
            Console.WriteLine($"{owner}'s account ({accountNumber}) has been credited with {message} amount{amount} Rs. New balance: {balance} Rs");
        }
        // Public method to check balance
        public void CheckBalance()
        {
            Console.WriteLine($"Available balance in your account is {balance} Rs");
        }
    }

    // Inheritance
    public class SavingsAccount : Account
    {
        // Constants for specific account type
        private const double WithdrawalFee = 2.0d;

        // Constructor to initialize SavingsAccount
        public SavingsAccount(string accountNumber, double initialBalance, string owner)
            : base(accountNumber, initialBalance, owner)
        {
        }

        // Polymorphism: Overriding the Withdraw method
        public override void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Balance -= WithdrawalFee; // Apply withdrawal fee
                Console.WriteLine($"{Owner}'s savings account ({AccountNumber}) has been debited with {amount} Rs. New balance: {Balance} Rs");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount or insufficient funds.");
            }
        }
    }

    // Interface for a feature shared by some accounts
    public interface ILoan
    {
        void ApplyForLoan(double amount);
    }

    // Polymorphism: Implementing ILoan interface
    public class LoanAccount : Account, ILoan
    {
        // Constructor to initialize LoanAccount
        public LoanAccount(string accountNumber, double initialBalance, string owner)
            : base(accountNumber, initialBalance, owner)
        {
        }

        // Implementing the ApplyForLoan method from the ILoan interface
        public void ApplyForLoan(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"{Owner} has applied for a loan. Loan amount {amount} Rs has been credited to the account. New balance: {Balance} Rs");
            }
            else
            {
                Console.WriteLine("Invalid loan amount.");
            }
        }

        // Polymorphism: Overriding the Withdraw method
        public override void Withdraw(double amount)
        {
            Console.WriteLine("Cannot withdraw from a loan account directly.");
        }
    }

    // Client code
    public class Program1
    {
        static void Main()
        {
            // Using SavingsAccount
            SavingsAccount savingsAccount = new SavingsAccount("SA123", 1000.0d, "Srivani");
            savingsAccount.CheckBalance();
            savingsAccount.Deposit(22500.0d, "Rent");
            savingsAccount.Withdraw(200.0d);// Overridden method
            savingsAccount.CheckBalance();

            Console.WriteLine();

            // Using LoanAccount
            LoanAccount loanAccount = new LoanAccount("LA456", 5000.0d, "Srivani");
            loanAccount.CheckBalance();
            loanAccount.ApplyForLoan(2000.0d); //Interface method
            loanAccount.Withdraw(500.0d); // Overridden method
            loanAccount.CheckBalance(); 
        }
    }
}

