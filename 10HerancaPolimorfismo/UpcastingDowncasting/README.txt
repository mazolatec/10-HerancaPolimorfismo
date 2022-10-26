Checklist
• Upcasting
• Casting da subclasse para superclasse
• Uso comum: polimorfismo

• Downcasting
• Casting da superclasse para subclasse
• Palavra as
• Palavra is
• Uso comum: métodos que recebem parâmetros genéricos (ex: Equals


            //is chek se variavel cc3 é instancia de (BusinessAccount )
            //vai retornar false pois acc3 é SavingsAccount

            if (acc3 is BusinessAccount)
            {
                //BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount;
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }

            //neste caso vai retornar true pois acc3 é SavingsAccount
            if (acc3 is SavingsAccount)
            {
                //SavingsAccount acc5 = (SavingsAccount)acc3;
                SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }