using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Placing values into accounts
            BankAccount acc1 = new BankAccount("123113", "Tom", 1000);
            BankAccount acc2 = new BankAccount("422333", "Mary", 5000);
            //Writing out values
            Console.WriteLine(acc1.GetAccountDetails());
            Console.WriteLine(acc2.GetAccountDetails());
            //Adding on 1000
            acc1.Deposit(1000);
            Console.WriteLine(acc1.GetAccountDetails());
            //Taking away 500
            acc2.Withdrawl(500);
            Console.WriteLine(acc2.GetAccountDetails());
        }
    }
}
