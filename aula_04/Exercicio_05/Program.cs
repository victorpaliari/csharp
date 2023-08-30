namespace Exercicio_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeros =0 ;
            int positivos = 0;

            do
            {
                Console.WriteLine("Digite um número: ");
                numeros = Convert.ToInt32(Console.ReadLine());
               
                if (numeros > 0) 
                positivos +=numeros;
                
            }
            while (numeros != 0);
                Console.WriteLine($"A soma dos positivos é igual a: {positivos} ");
                

            }

    }
}