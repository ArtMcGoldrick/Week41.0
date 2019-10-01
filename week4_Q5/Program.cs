using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4_Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Starter
            CashReg cash1 = new CashReg();
            CashReg cash2 = new CashReg();

            //Adding cash1

            cash1.TotalPrice(2.00);
            Console.WriteLine("Add 2.00 to cash 1");
            cash1.TotalPrice(5.50);
            Console.WriteLine("Add 5.50 to cash 1");
            cash1.TotalPrice(1.10);
            Console.WriteLine("Add 1.10 to cash 1");
            cash1.TotalPrice(1.80);
            Console.WriteLine("Add 1.80 to cash 1");
            //Adding cash2
            cash2.TotalPrice(2.00);
            Console.WriteLine("Add 2.00 to cash 2");
            cash2.TotalPrice(2.00);
            Console.WriteLine("Add 6.00 to cash 2");
            cash2.TotalPrice(6.80);
            Console.WriteLine("Add 6.80 to cash 2");
            //Output
            Console.WriteLine("Total cash1 : {0}", cash1.Total);
            Console.WriteLine("Total cash2 : {0}", cash2.Total);
            Console.WriteLine("Total items cash1 : {0}", cash1.NumItems);
            Console.WriteLine("Total items cash2 : {0}", cash2.NumItems);
            //Extra 
            double all = cash1.Total + cash2.Total;
            int allItem = cash1.NumItems + cash2.NumItems;
            Console.WriteLine("Total cash : {0}", all);
            Console.WriteLine("Total items : {0}", allItem);
        }
    }
}
