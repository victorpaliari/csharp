namespace PlanoDeSaude {
    internal class Program {
        static void Main(string[] args) {

            string nome;
            int idade;

            Console.WriteLine("Qual seu nome? ");
            nome = Console.ReadLine();

            Console.WriteLine($"Olá {nome}, qual sua idade?");
            idade = Convert.ToInt32(Console.ReadLine());

            if (idade > 0 && idade <= 10) {
                Console.WriteLine("A mensalidade do plano para essa faixa etária é R$100,00.");

            }

            else if (idade >= 11) {
                Console.WriteLine("A mensalidade do plano para essa faixa etária é R$200,00.");
            }

            else if (idade >= 30 && idade >= 45) {
                Console.WriteLine("A mensalidade do plano para essa faixa etária é R$300,00.");
            }

            else if (idade >= 46 && idade >= 59) {
                Console.WriteLine("A mensalidade do plano para essa faixa etária é R$500,00.");
            }

            else if (idade >= 60 && idade >= 65) {
                Console.WriteLine("A mensalidade do plano para essa faixa etária é R$600,00.");
            }

            else {
            
                Console.WriteLine("A mensalidade do plano para essa faixa etária é R$1.000,00.");
            }
        }
    }
}