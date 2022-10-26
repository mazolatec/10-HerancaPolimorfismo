Polimorfismo
Em Programação Orientada a Objetos, polimorfismo é recurso que permite
que variáveis de um mesmo tipo mais genérico 
possam apontar para objetos de tipos específicos diferentes, 
tendo assim comportamentos diferentes
conforme cada tipo específico.
exemplo 
 //instancia com mesmo tipo
Account acc1 = new Account(1001, "Alex", 500.0);

//instancia class base (generico) com subclass(especifico)
Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);
acc1.Withdraw(10.0);

acc2.Withdraw(10.0);

Console.WriteLine(acc1.Balance);
Console.WriteLine(acc2.Balance);
