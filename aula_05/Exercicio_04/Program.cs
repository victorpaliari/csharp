namespace Exercicio_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[,] matriz = new float[2, 4];
            float[,] media = new float[2,0];
            float soma = 0.0F;

            for (int indiceLinha = 0; indiceLinha < matriz.GetLength(0); indiceLinha++)
            {
                for (int indiceColuna = 0; indiceColuna < matriz.GetLength(1); indiceColuna++)
                {
                    Console.WriteLine($"Digite a {indiceColuna + 1}º nota do Participante {indiceLinha + 1}");
                    matriz[indiceLinha, indiceColuna] = Convert.ToSingle(Console.ReadLine());
                }
            }

            for (int indiceLinha = 0; indiceLinha < matriz.GetLength(0); indiceLinha++)
            {
                for (int indiceColuna = 0; indiceColuna < matriz.GetLength(1); indiceColuna++)
                {
                    soma += matriz[indiceLinha, indiceColuna];
                }

                media[indiceLinha] = soma / matriz.GetLength(1);
                soma = 0.0F;
            }


            for (int indice = 0; indice < media.Length; indice++) ;
            {
                Console.WriteLine($"Média do participante {indice + 1}: {media[indice]}");

                }

            }

        }
    }
