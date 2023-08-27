namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numero;
            Console.WriteLine("Digite a tabuada: \n");
            numero = Convert.ToInt32(Console.ReadLine());

            for (int contador = 1; contador <= 10; contador ++)
            // para (inteiro contador igual a 10; enquanto contador for menor ou igual a 10; incremente 1)
            {
                Console.WriteLine($"{numero} * {contador} = {numero * contador}");
            }
        }
    }
}