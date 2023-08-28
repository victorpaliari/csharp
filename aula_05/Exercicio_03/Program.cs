using System.Dynamic;

namespace Exercicio_03
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int[,] matriz01 = new int[3, 3];
            int numero = 0;


            for (int linha = 0; linha < (matriz01.GetLength(1); linha++)
            {

                for (int coluna = 0; coluna < Math.Sqrt(matriz01.Length); coluna++)
                {
                    Console.WriteLine($"Digite o número referente a posição {linha}, {coluna} nesta ordem: ");
                    matriz01[linha,coluna] = Convert.ToInt32(Console.ReadLine());
                }

            
            }

        }
    }
}
