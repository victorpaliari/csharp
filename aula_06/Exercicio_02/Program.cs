using System.Linq;

namespace Exercicio_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 2, 5, 1, 3, 4, 9, 7, 8, 10, 6 };
            int resContador = 0;
            int opcao = 0;

            do
            {


                Console.WriteLine("\n1- Verificar número.");
                Console.WriteLine("2- Sair.");
                opcao = Convert.ToInt32(Console.ReadLine());

                HashSet<int> contador = new HashSet<int>();

                switch (opcao)
                {

                    case 1:

                        Console.WriteLine("Digite o número que você deseja encontrar: ");
                        resContador = Convert.ToInt32(Console.ReadLine());


                        if (!numeros.Contains(resContador))
                            // if    (resContador!= numeros.Contains())


                            Console.WriteLine($"O número {resContador} não foi encontrado :/");

                        else
                            Console.WriteLine($"O número {resContador} foi encontrado :)");

                        break;

                    case 2:
                        System.Environment.Exit(0);
                        break;
                }

            }
            while (opcao != 2);
        }
    }

}
