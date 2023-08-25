namespace Lanchonete {
    internal class Program {
        static void Main(string[] args) {

            int quantidade, opcao, valor;

            Console.WriteLine("Bem vindo a lanchonete!");
            Console.WriteLine("Esolha seu pedido: ");
            Console.WriteLine("1- Cachorro-quente R$10,00");
            Console.WriteLine("2- X-Salada        R$15,00");
            Console.WriteLine("3- X-Bacon         R$18,00");
            Console.WriteLine("4- Bauru           R$12,00");
            Console.WriteLine("5- Refrigerante    R$8,00");
            Console.WriteLine("6- Suco de laranja R$13,00");

            opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao) {

                case 1:

                    Console.WriteLine("Quantidade: ");
                    quantidade = Convert.ToInt32(Console.ReadLine());
                    valor = quantidade * 10;
                    Console.WriteLine($"Você escolheu ({quantidade}) cachorro(s)-quente(s), ");
                    Console.WriteLine($"total = R${valor}");
                    
                    break;

                case 2:

                    Console.WriteLine("Quantidade: ");
                    quantidade = Convert.ToInt32(Console.ReadLine());
                    valor = quantidade * 15;
                    Console.WriteLine($"Você escolheu ({quantidade}) X-salada(s), ");
                    Console.WriteLine($"total = R${valor}");

                    break;

                case 3:

                    Console.WriteLine("Quantidade: ");
                    quantidade = Convert.ToInt32(Console.ReadLine());
                    valor = quantidade * 18;
                    Console.WriteLine($"Você escolheu ({quantidade}) X-bacon(s), ");
                    Console.WriteLine($"total = R${valor}");

                    break;
                
                case 4:

                    Console.WriteLine("Quantidade: ");
                    quantidade = Convert.ToInt32(Console.ReadLine());
                    valor = quantidade * 12;
                    Console.WriteLine($"Você escolheu ({quantidade}) Bauru(s), ");
                    Console.WriteLine($"total = R${valor}");

                    break;

                case 5:

                    Console.WriteLine("Quantidade: ");
                    quantidade = Convert.ToInt32(Console.ReadLine());
                    valor = quantidade * 8;
                    Console.WriteLine($"Você escolheu ({quantidade}) Refrigerante(s), ");
                    Console.WriteLine($"total = R${valor}");

                    break;

                case 6:

                    Console.WriteLine("Quantidade: ");
                    quantidade = Convert.ToInt32(Console.ReadLine());
                    valor = quantidade * 13;
                    Console.WriteLine($"Você escolheu ({quantidade}) Suco(s) de laranja, ");
                    Console.WriteLine($"total = R${valor}");

                    break;
            }
        }
    }
}