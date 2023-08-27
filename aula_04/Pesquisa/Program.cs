namespace Pesquisa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome, continua = "S";
            int idade, esporte, futebol = 0, volei18 = 0, basquete = 0, outros = 0;

            do
            {
                Console.WriteLine("Digite seu nome: ");
                nome = Console.ReadLine();
                Console.WriteLine("Digite sua idade: ");
                idade = Convert.ToInt32(Console.ReadLine());

                do
                {
                    Console.WriteLine("Digite seu esporte favorito: \n");
                    Console.WriteLine("[1] Futebol ");
                    Console.WriteLine("[2] Volei ");
                    Console.WriteLine("[3] Basquete ");
                    Console.WriteLine("[4] Outros \n ");
                    esporte = Convert.ToInt32(Console.ReadLine());
                } while (esporte < 1 || esporte > 4);

                if (esporte == 1)
                    futebol++;
                if (esporte == 2 || idade > 18)
                    volei18++;
                if (esporte == 3 || idade < 18)
                    basquete++;
                if (esporte == 4)
                    outros++;

                Console.WriteLine("Deseja fazer uma nova pesquisa? [S]/[N]");
                continua = Console.ReadLine().ToUpper();
                Console.Clear();

            } while (continua.Equals("S"));


            Console.WriteLine($"{futebol} pessoas gostam de futebol.");
            Console.WriteLine($"{volei18} pessoas gostam de vôlei maiores de 18 anos.");
            Console.WriteLine($"{basquete} pessoas gostam de basquete menores de 18 anos.");

            






        }
    }
}