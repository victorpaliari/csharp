namespace Exercicio_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeros = 0;
            double media = 0;
            int vezes = 0;
            double soma = 0;


            do
            {
                Console.WriteLine("Digite um número: ");
                numeros = Convert.ToInt32(Console.ReadLine());
                if (numeros != 0 && numeros % 3 == 0)
                {
                    soma += numeros; 
                    vezes++;
                }
                    //media = numeros / vezes;
            }
            while (numeros != 0);

            if (vezes > 0)
            {
                media = soma / vezes;
                Console.WriteLine($"A média dos números multiplos de 3 é igual a: {soma} ");
            }
            else
                Console.WriteLine("Nenhum multiplo de 3 foi digitado. ");
        }

    }
}
