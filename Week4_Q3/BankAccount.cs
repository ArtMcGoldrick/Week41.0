using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_Q3
{
    class BankAccount
    {
        //Constructers
        public string AccNumber { get; set; }
        public string AccHolder { get; set; }
        public decimal Balance { get; set; }

        public BankAccount(string accNumber, string accHolder, decimal balance)
        {
            AccNumber = accNumber;
            AccHolder = accHolder;
            Balance = balance;
        }
        //Adds to amount total
        public void Deposit(decimal amount)
        {
            Balance += amount;
        }
        //Used to allow money to be taken
        public void Withdrawl(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
            }
        }
        //To string that displays all values
        public string GetAccountDetails()
        {
            return $"Account number : {AccNumber}" + $"Account holder : {AccHolder}" + $"Account balance : {Balance}";
        }
    }
}

