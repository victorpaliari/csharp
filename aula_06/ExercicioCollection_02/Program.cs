namespace ExercicioCollection_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 2, 5, 1, 3, 4, 9, 7, 8, 10, 6 };
            int procura = 0;
            
            Console.WriteLine("Digite o número que deseja encontrar: ");
            procura = Convert.ToInt32(Console.ReadLine());

            List<int> lista = new List<int>(numeros);

            int posicao = lista.IndexOf(procura);


            if (posicao != -1)
            {
                Console.WriteLine($"\n 2, 5, 1, 3, 4, 9, 7, 8, 10, 6. ");
                Console.WriteLine($"\nO numero {procura} está localizado na posição {posicao}.");
            }


            else
            {
                Console.WriteLine($"\n 2, 5, 1, 3, 4, 9, 7, 8, 10, 6. ");
                Console.WriteLine($"\nO número {procura} não foi encontrado. ");
            }

                
            



        }
    }
}