namespace CaixaEletronico {
    internal class Program {
        static void Main(string[] args) {

            float saldo = 1000;
            int opcao, saque, deposito;
            Console.WriteLine("BEM VINDO AO CAIXA ELETRÔNICO. ESCOLHA UMA OPERAÇÃO: ");
            Console.WriteLine("1 - VER SALDO ");
            Console.WriteLine("2 - SAQUE ");
            Console.WriteLine("3 - DEPÓSITO");
            opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {

                case 1: Console.WriteLine($"Seu saldo é: R$ {saldo}");
                    break;

                
                case 2: Console.WriteLine("Digite o valor do saque: ");
                    saque = Convert.ToInt32(Console.ReadLine());

                    if (saque > 1000)
                        Console.WriteLine($"Saldo insuficiente. \nValor disponível para saque: R${saldo}");

                    else
                    {
                        saldo = saldo - saque;
                        Console.WriteLine($"Saque realizado.");
                        Console.WriteLine($"Saldo atual = R${saldo}.");
                    }
                    break;
                
                case 3: Console.WriteLine("Qual o valor do depósito? ");
                    deposito = Convert.ToInt32(Console.ReadLine());
                    saldo = saldo + deposito;
                    Console.WriteLine($"Depósito realizado.");
                    Console.WriteLine($"Saldo atual = R${saldo}");
                    break;

                case 4: Console.WriteLine("Operação Inválida.");
                    break;
            }

        }
    }
}