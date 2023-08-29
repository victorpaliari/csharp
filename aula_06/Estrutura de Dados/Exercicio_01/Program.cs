using System.Runtime.CompilerServices;

namespace Exercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
       
            Queue<string> fila = new Queue<string>();

            int opcao = 0;
            string cliente;

            do 
            {

                Console.WriteLine("\n************************************************************");
                Console.WriteLine("\n\t| 1 - Adicionar Cliente na Fila");
                Console.WriteLine("\t| 2 - Listar Clientes");
                Console.WriteLine("\t| 3 - Retirar Cliente da Fila");
                Console.WriteLine("\t| 0 - Sair");
                Console.WriteLine("\n************************************************************");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:                       
                        Console.Write("Digite o nome do cliente: ");
                        cliente = (Console.ReadLine());
                        fila.Enqueue(cliente);
                        break;
                    case 2:
                        if (fila.Count == 0)
                        {
                            Console.WriteLine("Não tem ninguém na fila");
                        break; 
                        }
                        else
                        {
                            foreach (var nome in fila)
                            {
                                Console.WriteLine(nome);
                            }
                        }
                        break;
                    case 3:
                        if (fila.Count == 0)
                        {
                            Console.WriteLine("Não tem ninguém na fila");
                            break;
                        }
                        else
                        {
                            fila.Dequeue();
                            Console.WriteLine($"Cliente {fila.Peek()} retirado da fila.");
                        }
                        break;
                    case 0:
                        Console.Clear();
                        Console.WriteLine("Programa finalizado, obrigado!");
                        break;
                }
            }
            while (opcao != 0);
        }
    }
}
