using AccountBusinessAccount.Entities;


namespace UpcastingDowncasting.Entities
{
    class SavingsAccount:Account
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

    }
}
