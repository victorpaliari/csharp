namespace Exercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> valores = new HashSet<int>();
            int valor = 0;
            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite um valor: ");
                valor = Convert.ToInt32(Console.ReadLine());
                valores.Add(valor);

            }

            foreach (int valorAdc in valores)
            {
                Console.Write($"/ {valorAdc} ");
            }
        }
    }
}