namespace Exercicio_03
{
    internal class Program
    {
        static void Main(string[] args)


        {
            int idade; 
            int menor21 = 0;
            int mais50 = 0;
         
                while (true)
                {
                     Console.WriteLine("Digite sua idade: ");
                     idade = Convert.ToInt32(Console.ReadLine());

                if (idade < 0)
                {
                    Console.WriteLine("Valor não corresponde ao intervalo...");
                    break;
                }

                if (idade < 21)
                {
                    menor21++;
                }  

                if (idade > 50)
                {
                    mais50++;
                }
                        Console.WriteLine($"Menores de 21 anos: {menor21}");
                        Console.WriteLine($"Maiores de 50 anos: {mais50}");
            }
        
            }
    }
}