using AccountBusinessAccount.Entities;


namespace UpcastingDowncasting.Entities
{
  sealed  class SavingsAccount:Account
    {
        public double Interestrate { get; set; } //Taxa de juros

        public SavingsAccount(int nunber, string holder, double balance,double interestrate)
            :base(nunber,holder,balance)
        {
            Interestrate = interestrate;
        }
        public void UpdateBalance()
        {
            Balance += Balance * Interestrate;
        }

        public override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2.0;
        }
    }
}
