namespace Lanchonete {
    internal class Program {
        static void Main(string[] args) {

            int opcao, , op1, op2, op3, op4, op5, op6, quantidade,total; 
           
            Console.WriteLine("Bem vindo a lanchonete!");
            Console.WriteLine("Esolha seu pedido: ");
            Console.WriteLine("1- Cachorro-quente R$10,00");
            Console.WriteLine("2- X-Salada R$15,00");
            Console.WriteLine("3- X-Bacon R$18,00");
            Console.WriteLine("4- Bauru R$12,00");
            Console.WriteLine("5- Refrigerante R$8,00");
            Console.WriteLine("6- Suco de laranjaR$13,00");

            opcao = Convert.ToInt32(Console.ReadLine());    
            
            switch (opcao) {

                case 1:
                    int resposta;
                    quantidade = Convert.ToInt32(Console.ReadLine());
                    quantidade = quantidade + 1;
                    Console.WriteLine("Você escolheu cachorro-quente, quer adicionar mais itens a seu pedido?");
                    bool sim = resposta.ToLower() == sim;
                    if (sim) {

                    }
                    
                    break; 
                
                
                
                case 2: 
                    Console.WriteLine();
            }
    }
    }
    }
