﻿namespace TabuadaWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, contador = 1;
            Console.WriteLine("Digite a tabuada: \n");
            numero = Convert.ToInt32(Console.ReadLine());

            while (contador <= 10)
            {
                Console.WriteLine($"{numero} * {contador} = {numero * contador}");
                contador++;
            }
        }
    }
}