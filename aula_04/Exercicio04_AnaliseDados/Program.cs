namespace Exercicio04_AnaliseDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade, identGen, cargo, total = 0;
            int backend = 0, frontend = 0, mobile = 0, fullstack = 0;
            int mulhercis = 0, mulhertrans = 0, homemcis = 0, homemtrans = 0, naobinario = 0, outro = 0, mulherFrontend = 0, homemMobileMais40 = 0, naoBinarioMenos30 = 0;
            string? sim = "S";

            while (sim == "S") { 
            
            Console.WriteLine("Insira idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual seu cargo: ");
            Console.WriteLine("[1] Backend");
            Console.WriteLine("[2] Frontend");
            Console.WriteLine("[3] Mobile");
            Console.WriteLine("[4] Fullstack");
            cargo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Identidade de Gênero a qual se identifica: ");
            Console.WriteLine("[1] Mulher Cis");
            Console.WriteLine("[2] Mulher Trans");
            Console.WriteLine("[3] Homem Cis");
            Console.WriteLine("[4] Homem Trans");
            Console.WriteLine("[5] Não binário");
            Console.WriteLine("[5] Outro.");
            identGen = Convert.ToInt32(Console.ReadLine());

            if (idade != 0)
            {
                total++;
            }

            if (identGen == 1 || identGen == 2 && cargo == 2)
            {
                mulherFrontend++;
            }

            if (identGen == 3 || identGen == 4 && cargo == 3 && idade > 40)
            {
                homemMobileMais40++;
            }

            if (identGen == 5 && cargo == 4 && idade < 30)
            {
                naoBinarioMenos30++;
            }

                Console.WriteLine("Deseja fazer uma nova pesquisa? ");
                sim = Console.ReadLine().ToUpper();
                if (sim != "S")
                    break;
            }

            Console.WriteLine($"Mulheres desenvolvedoras frontend: {mulherFrontend}");
            Console.WriteLine($"Pessoas desenvolvedoras backend: {backend}");
            Console.WriteLine($"Homens desenvolvedores mobile maiores de 40: {homemMobileMais40}");
            Console.WriteLine($"Pessoas não bináries desenvolvedoras fullstack com menos de 30 anos: {naoBinarioMenos30}");
            Console.WriteLine($"Total de pessoas que responderam a pesquisa: {total}");

        }
    }
}