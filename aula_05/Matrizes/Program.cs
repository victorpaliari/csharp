﻿using System.Xml.Linq;

namespace Matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz01 = { { 1, 2, 3, }, { 4, 5, 6, }, { 7, 8, 9, } };
            int[,] matriz02 = new int[4, 4];
            int[,] matriz03 = { { 1, 2, 3 }, { 4, 5, 6 } };
            int[,] vetor = { { 1, 2, 3, 5, 6 } };
            int soma = 0;

            /*
            for (int indiceLinha = 0; indiceLinha < Math.Sqrt(matriz01.Length); indiceLinha++)
            {
                for (int indiceColuna = 0; indiceColuna < Math.Sqrt(matriz01.Length); indiceColuna++)
                {
                    Console.WriteLine($"matriz01 [{indiceLinha},{indiceColuna}] = {matriz01[indiceLinha, indiceColuna]}");
                    Console.WriteLine($"matriz02 [{indiceLinha},{indiceColuna}] = {matriz01[indiceLinha, indiceColuna]}");
                    
                    matriz02[indiceLinha, indiceColuna] = Convert.ToInt32(Console.ReadLine());  
                }
            }
            

            for (int indiceLinha = 0; indiceLinha < (matriz03.GetLength(0)); indiceLinha++)
            {
                for (int indiceColuna = 0; indiceColuna < (matriz03.GetLength(1)); indiceColuna++)
                {
                    Console.WriteLine($"matriz03 [{indiceLinha},{indiceColuna}] = {matriz03[indiceLinha, indiceColuna]}");
                }
            }

             foreach (int elemento in vetor) // ve a posição, joga pra variavel e imprime (sucessivamente)
                // o for it simplifica porque não precisa passar o 
            {
                Console.WriteLine(elemento);
            } */

            foreach (int elemento in matriz01) // ve a posição, joga pra variavel e imprime (sucessivamente), de forma simplificada
                                               // é a mesma coisa de escrever >> for (int indiceLinha = 0; indiceLinha < (matriz03.GetLength(0)); indiceLinha++)
                                               // elemento = matriz01[indiceLinha, indiceColuna];
                                               // foreach sempre decrementa, e não permite decrementar

            {
                Console.WriteLine(elemento);
            }

           
        }
    }
}