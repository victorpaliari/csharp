namespace Exercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> pilha = new Stack<string>();
            int opcao;
            string titulo;

            while (true)
            {

                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("***********************************************************************");
                Console.WriteLine("     | 1 - Adicionar livro na pilha.                                   ");
                Console.WriteLine("     | 2 - Listar todos os livros da pilha.                            ");
                Console.WriteLine("     | 3 - Retirar livro da pilha.                                     ");
                Console.WriteLine("     | 0 - Sair.                                                       ");
                Console.WriteLine("***********************************************************************");
                Console.WriteLine("Entre com a opção desejada:                                            ");
                Console.ResetColor();

                opcao = Convert.ToInt32(Console.ReadLine());
                if (opcao == 0)
                {
                    Console.WriteLine("Operação finalizada, obrigado.");
                    System.Environment.Exit(0);
                }

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite o titulo do livro: ");
                        titulo = Console.ReadLine();

                        pilha.Push(titulo);

                        Console.WriteLine("Livro foi adicionado com sucesso. ");
                        break;

                    case 2:
                        Console.WriteLine("Lsta de livros: ");
                        foreach (var livro in pilha)
                        {
                            Console.WriteLine(livro);
                        }
                        break;

                        case 3:
                        if (pilha.Count == 0)
                        {
                            Console.WriteLine("A pilha está vazia");
                        }
                        else
          
                        pilha.Pop();
                        Console.WriteLine("O livro foi retirado com sucesso. ");
                        break;

                    default: Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }
    }
}