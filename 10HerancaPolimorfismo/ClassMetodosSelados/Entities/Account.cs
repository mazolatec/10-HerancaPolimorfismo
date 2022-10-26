
using System.Globalization;


namespace AccountBusinessAccount.Entities
{
    //super class ou class base
    class Account
    {
        public int Nunber { get; private set; }
        // Holder Titular
        public string Holder { get; private set; }
        //Saldo Balance
        //protected consigo modificar em outras classes do mesmo assembly
        public double Balance { get; protected set; } 

        public Account() { }

        public Account(int nunber, string holder, double balance)
        {
            Nunber = nunber;
            Holder = holder;
            Balance = balance;
        }

        public virtual void Withdraw(double amount)
        {
          Balance -= amount +5.0;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public override string ToString()
        {
            return "Client :"
                + Holder
                + " Saldo $"
                + Balance.ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
