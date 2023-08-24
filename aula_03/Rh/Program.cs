namespace Rh {
    internal class Program {
        static void Main(string[] args) {


            float salario, reajuste;
            string? nome;
            int cargo;

                
            Console.WriteLine("Qual seu nome? "); // poderia adicionar uma verificação p/ nome não ser nulo
            nome = Console.ReadLine(); 
        
            Console.WriteLine("Selecione seu cargo:  ");
            Console.WriteLine("1 - Supervisor");
            Console.WriteLine("2 - Diretor");
            Console.WriteLine("3 - Gerente");
            Console.WriteLine("3 - Outro");

            cargo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite seu salário: ");
            salario = Convert.ToSingle(Console.ReadLine());

            switch (cargo) {

                case 1: reajuste = (salario * 0.07F);
                    break;
                case 2:
                    reajuste = (salario * 0.09F);
                    break;
                case 3:
                    reajuste = (salario * 0.05F);
                    break;
                default:
                    reajuste = (salario * 0.12F);
                    break;

            }

            Console.WriteLine($"Seu reajuste salarial é de R$ {salario + reajuste}.");
        }
    }
}