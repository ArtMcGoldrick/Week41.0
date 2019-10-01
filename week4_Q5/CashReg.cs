using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4_Q5
{
    class CashReg
    {
        //get and set
        public double Total { get; private set; }
        public int NumItems { get; set; }

        //Adding price
        public void TotalPrice(double amount)
        {
            Total += amount;
            NumItems++;
        }

    }
}
