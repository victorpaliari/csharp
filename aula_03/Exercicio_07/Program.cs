namespace Exercicio_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float? numero1, numero2;
            int? opcao;

            Console.WriteLine("Digite o 1º número :");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o 2º número :");
            numero2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escolha uma operação: ");
            Console.WriteLine("1 - SOMA");
            Console.WriteLine("2 - SUBTRAÇÃO");
            Console.WriteLine("3 - MULTIPLICAÇÃO");
            Console.WriteLine("4 - DIVISÃO");

            opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao) {         

                case 1: Console.WriteLine($"{numero1} + {numero2} = {numero1 + numero2} ");
                    break;

                case 2: Console.WriteLine($"{numero1} - {numero2} = {numero1 - numero2} ");
                        break;

                case 3: Console.WriteLine($"{numero1} * {numero2} = {numero1 * numero2} ");
                    break;
                
                case 4: Console.WriteLine($"{numero1} / {numero2} = {numero1 / numero2}");
                    break;

            }

            if (opcao > 4);
            Console.WriteLine("Opção inválida.");

        }
    }
}