using System.Numerics;

namespace Exercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor01 = { 2, 5, 1, 3, 4, 9, 7, 8, 10, 6};
            int compara = 0; 


            for (int i = 0; i < vetor01.Length; i++)
            {
                
                Console.Write(vetor01[i] + " ");
            }
            
            Console.WriteLine("\nDigite um número para ver sua posição: ");
            compara = Convert.ToInt32(Console.ReadLine());

            if (Array.IndexOf(vetor01, compara) != -1)
            {
                Console.WriteLine($"A posição de {compara} é igual a:  " + Array.IndexOf(vetor01, compara));
            }
            
            else
            {
                Console.WriteLine($"O número {compara} não foi encontrado. ");
            }       
        }
    }
}