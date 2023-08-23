using System.Runtime.Serialization;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float numero1, numero2;

            
         
            Console.WriteLine("Digite o primeiro número: ");
            numero1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite o primeiro número: ");
            numero2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine($"{numero1} + {numero2} = " + (numero1 + numero2)); // {} o colchetes serve para concatenar os valores
            Console.WriteLine($"{numero1} - {numero2} = " + (numero1 - numero2));
            Console.WriteLine($"{numero1} * {numero2} = " + (numero1 * numero2));
            Console.WriteLine($"{numero1} / {numero2} = " + (numero1 / numero2));
            Console.WriteLine($"{numero1} ^ {numero2} = " + Math.Pow(numero1, numero2)); // ^ 
            Console.WriteLine($"Raiz quadrada de {numero1} = " + Math.Sqrt(numero1));


        }
    }
}