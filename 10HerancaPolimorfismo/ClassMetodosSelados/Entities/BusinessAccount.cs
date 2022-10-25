using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountBusinessAccount.Entities
{
    //subclass ou class derivada
    class BusinessAccount:Account
    {
        public double LoanLimit{ get; set; }

        public BusinessAccount() { }

        public BusinessAccount(int nunber, string holder, double balance,double loadlimit):
            base(nunber,holder,balance)
        {
            LoanLimit = loadlimit;
        }
        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
       
    }
}

