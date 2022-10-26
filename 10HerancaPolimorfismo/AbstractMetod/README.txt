



Questionamento
• Se a classe Account não pode ser instanciada, por que simplesmente não criar somente SavingsAccount e
BusinessAccount?
• Resposta: • Reuso
• Polimorfismo: a superclasse classe genérica nos permite
tratar de forma fácil e uniforme todos os tipos de conta,
inclusive com polimorfismo se for o caso (como fizemos nos
últimos exercícios). Por exemplo, você pode colocar todos
tipos de contas em uma mesma coleção.
• Demo: suponha que você queira: • Totalizar o saldo de todas as contas.
• Sacar 10.00 de todas as contas.




Métodos abstratos
• São métodos que não possuem implementação.
• Métodos precisam ser abstratos quando a classe 
é genérica demais para conter sua 
implementação.
• Se uma classe possuir pelo menos um método 
abstrato, então esta classe também é abstrata.
• Notação UML: itálico
• Exercício resolvido
