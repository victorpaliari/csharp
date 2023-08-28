namespace Exercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("Digite o 1º número do intervalo: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o 2º número do intervalo: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            if (n1 > n2)
            {
                Console.WriteLine("Intervalo Inválido.");
            }

            Console.WriteLine($"\nOs números divisiveis por 3 e 5, no intervalo entre {n1} e {n2} são:");
            for (int i = n1; i <= n2; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(i);
                }

            }
            
            
           

            




        }
    }
}