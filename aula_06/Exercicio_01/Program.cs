using System.Reflection.PortableExecutable;

namespace Exercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<string> cores = new List<string>();

            string? cor; 
         
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Insira uma cor: ");
                cor = Console.ReadLine();
                cores.Add(cor);
            }

            cores.Sort();
            Console.WriteLine("\nSuas cores em ordem crescente: ");

            foreach (string newCor in cores)
            {
                Console.WriteLine(newCor);

            }

            
               
           

            
            
            
          


        }
    }
}