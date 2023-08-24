namespace MaiorMenor {
    internal class Program {
        static void Main(string[] args) {

            int a, b, c;

            Console.WriteLine("Digite o valor de A:");
            a = Convert.ToInt32(Console.ReadLine());
            
            
            Console.WriteLine("Digite o valor de B:");
            b = Convert.ToInt32(Console.ReadLine());
            
            
            Console.WriteLine("Digite o valor de C:");
            c = Convert.ToInt32(Console.ReadLine());

            if (a + b > c) {
                Console.WriteLine("A soma de A + B é maior que C.");
            }
            
            else if (a + b < c) {
                Console.WriteLine("A soma de A + B é menor que C.");
            }

            else {
                    Console.WriteLine("A soma de A + B é igual a C.");
                }
    

        }
    }
}