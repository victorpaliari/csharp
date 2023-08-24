using System.ComponentModel.Design;

namespace Doador {
    internal class Program {
        static void Main(string[] args) {
            string? nome;
            int idade;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("É sua primeira doação de sangue?");
            string resposta = Console.ReadLine();
            bool sim = resposta.ToLower() == "sim";
            Console.Clear();

            if (idade >= 60 && idade <= 69 && (sim)) {
                Console.WriteLine($"{nome} não está apto para doar sangue.");
            }


            else if (idade >= 18 && idade <= 59) {
                Console.WriteLine($"{nome} está apto para doar sangue.");
            }

            else {
                Console.WriteLine($"{nome} não esta apto para doar sangue.");
            }
        }
    }
}