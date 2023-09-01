using System.Dynamic;

namespace Exercicio_03
{
    internal class Program
    {
        static void Main(string[] args)

        {
            //declaração de uma matriz nula de tamanho 3x3
            int[,] matriz01 = new int[3, 3];

            //criando a condição do loop para icrementar e caminhar pela array linha;
            //matriz01.GetLength(linha), matriz01.Length e Math.Sqrt(matriz01.Length) são usados para o mesmo objetivo e é seguro dizer que fazem 
            //a mesma coisa: caminha pelos indices da array, baseado em seu tamanho, que nesse caso não foi especificado. 
            for (int linha = 0; linha < (matriz01.GetLength(linha)); linha++)
            {
                //criando a condição do loop para icrementar e caminhar pela array coluna, que deve estar dentro do loop de linha;
                for (int coluna = 0; coluna < Math.Sqrt(matriz01.Length); coluna++)
                {
                   //imprima [linha],[coluna] nesta ordem, para o usuário saber que dados ele está fornecendo
                    Console.WriteLine($"Digite o número referente a posição [{linha}], [{coluna}] nesta ordem: ");
                    matriz01[linha,coluna] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine()

                
            }

        }
    }
}
