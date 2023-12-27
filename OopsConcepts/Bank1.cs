using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    internal class Bank1 //Encapsulation
    {
        private string AccountHolderName;
        private int MinimumBalance;
        private long Deposit;
        public string PersonName { get; set; }
        public int MinBalance
        {
            get { return MinBalance; }
            set
            {
                if(value < 500)
                {
                    throw new Exception("You have low Minimum Balance. You can't withdraw your money");
                }
                else
                {
                    MinBalance = value;
                }
            }
            
        }
        public long MyDeposit
        {
            get { return MyDeposit; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Your Deposit should be greater than zero");
                }
                else
                {
                    MyDeposit = value;
                }
            }
        }
    }
    class Person1
    {
        static void Main(String[] args)
        {
            Bank1 b = new Bank1();
            b.PersonName = "Srivani Durga";
            b.MinBalance = 400;
            b.MyDeposit = 0;
            Console.WriteLine($"Account Holder Name is {b.PersonName}");
            Console.WriteLine("Minum Balance is " + b.MinBalance);
            Console.WriteLine("Deposit is " + b.MyDeposit);
        }
    }
}
