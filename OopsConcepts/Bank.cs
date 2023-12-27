using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts 
{
    internal class Bank //Encapsulation Code
    {
        private string AccountHolderName;
        private int MinimumBalance;
        private long Deposit;
        public void SetAccountHolderName(string PersonName)
        {
            this.AccountHolderName = PersonName;
        }
        public string GetAccountHolderName()
        {
            return AccountHolderName;
        }
        public void SetMinimumBalance(int MinBalance)
        {
            if (MinimumBalance < 500)
            {
                throw new Exception("You have low Minimum Balnce.You can't withdraw your money");
            }
            else
            {
                this.MinimumBalance = MinBalance;
            }
        }
        public long GetMinimumBalance()
        {
            return MinimumBalance;
        }
        public void SetDeposit(long MyDeposit)
        {
            if(Deposit <= 0)
            {
                throw new Exception("Your Deposit should be grater than zero");
                
            }
            else
            {
                this.Deposit = MyDeposit;
            }
        }
            
        public long GetDeposit()
        {
            return Deposit;
        } 
    }
    public class Person
    {
        static void Main(String[] args)
        {
            Bank b = new Bank();
            b.SetAccountHolderName("Srivani Durga");
            b.SetMinimumBalance(400);
            b.SetDeposit(0);
            Console.WriteLine($"Account Holder Name is {b.GetAccountHolderName()}");
            Console.WriteLine("Minum Balance is "+b.GetMinimumBalance());
            Console.WriteLine("Deposit is "+b.GetDeposit());
        }
    }
}
