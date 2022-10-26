using System;
using System.Collections.Generic;
using System.Globalization;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> list = new List<Account>();
            list.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 500.0,400.00));
            
            list.Add(new SavingsAccount(1003, "Bob", 500.0, 0.01));
            list.Add(new BusinessAccount(1004, "Anna", 500.0,500.00));
          
            double sum = 0.0;
            foreach (Account acc1 in list)
            {
                sum += acc1.Balance;
               // Console.WriteLine(acc2.Balance);
            }
            Console.WriteLine("Total saldo todas as contas "+sum.ToString("F2", CultureInfo.InvariantCulture));

            foreach (Account acc in list)
            {  
                //Palavra is procura nas instancias da list qual classe
                if (acc is SavingsAccount)
                {
                    acc.Withdraw(100);
                }
                else if (acc is BusinessAccount)
                {
                    acc.Withdraw(10);
                }
               
            }
            foreach (Account acc in list)
            {
                Console.WriteLine("Cliente: " 
                    +acc.Holder
                    +"      "
                    +acc.Number
                    +"      "
                    +acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}
