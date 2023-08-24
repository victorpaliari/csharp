namespace ParEImpar {
    internal class Program {
        static void Main(string[] args) {



            int numero;
            Console.Write("Digite um número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero > 0 && numero % 2 == 0) {
                Console.WriteLine("O número é positivo e par.");
            }

            else if (numero < 0 && numero % 2 == 0) { 

                Console.WriteLine("O número é negativo e par.");
            }

            else if (numero > 0 && numero % 2 != 0) {
                Console.WriteLine("O número é positivo e ímpar.");
            }

            else {

                Console.WriteLine("O número é negativo e ímpar.");
            }












        }
    }
}