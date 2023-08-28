namespace Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor01 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] vetor02 = new int[5];
            string[] vetor03 = { "Allan", "Ingrid", "João", "Gabriel", "Shomara", "Karina", "Jacque" };

             for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Vetor01 [{i}] = {vetor01[i]}");
            }
            
             
             
            Console.WriteLine("\n");

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Vetor02 [{i}] = ");
                vetor02[i] = Convert.ToInt32( Console.ReadLine()); 
            }

            Console.WriteLine("\n");
            //Array.Reverse(vetor02); //ordena o vetor decrescente 
            
           Array.Sort(vetor03); //ordena o vetor em ordem crescente
           

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Vetor03 [{i}] = {vetor03[i]}");
            }
            Console.WriteLine("A posição da Ingrid é igual a: " + Array.IndexOf(vetor03, "Ingrid"));
            Console.WriteLine("A posição da Ingrid é igual a: " + Array.BinarySearch(vetor03, "Ingrid"));

            for (int i = 0; i < vetor01.Length; i++)
            {
                //Console.WriteLine($"Vetor03 [{i}] = {vetor03[i]}");
                if (vetor01[i] % 2 == 0)
                {
                    Console.WriteLine($"Vetor01 [{i}] = {vetor01[i]}");
                }
            }
            

        }
    }
}