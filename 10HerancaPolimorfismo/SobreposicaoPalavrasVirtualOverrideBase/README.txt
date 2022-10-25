

Account: 
//virtual significa que metodo pode ser sobrescrito na class subclass
public virtual void Withdraw(double amount) {
Balance -= amount + 5.0;
}


SavingsAccount:
public override void Withdraw(double amount) {
Balance -= amount;
}






