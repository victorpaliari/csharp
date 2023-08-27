namespace Exercicio02_ParOuImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int par = 0, impar = 0, numero;

            for (int contador = 1; contador <= 10; contador++)
            {
                Console.WriteLine("Insira um número: ");
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero % 2 == 0)
                    par++;
                if (numero % 2 != 0)
                    impar++;
            }

            Console.WriteLine($"A quantidade de pares é igual a {par}");
            Console.WriteLine($"A quantidade de ímpares é igual a {impar}");

        }
    }
}