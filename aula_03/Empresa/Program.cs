namespace Empresa {
       
    internal class Program {
       
        static void Main(string[] args) {

            string nomeColab;
            float reajuste, salario;
            int cargo;

            Console.WriteLine("Bem vindo a empresa, por favor identifique-se:\n");
            nomeColab = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Olá {nomeColab}, digite seu cargo: \n");

            Console.WriteLine("1- Gerente\n");
            Console.WriteLine("2- Vendedor \n");
            Console.WriteLine("3- Supervisor\n");
            Console.WriteLine("4-Motorista\n");
            Console.WriteLine("5-Estoquista\n");
            Console.WriteLine("6-Técnico de TI\n");
            
            cargo = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.Write("Digite seu salário atual: "); 
            salario = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (cargo) {

                case 1:
                    reajuste = salario * 10/100;
                    Console.WriteLine("Gerentes possuem 10% de reajuste salarial.");
                    Console.WriteLine($"Seu salário reajustado é igual a {salario + reajuste}.");

                    break;

                case 2:
                    reajuste = salario * 7 / 100;
                    Console.WriteLine("Vendedores possuem 7% de reajuste salarial.");
                    Console.WriteLine($"Seu salário reajustado é igual a {salario + reajuste}.");

                    break;

                case 3:
                    reajuste = salario * 9 / 100;
                    Console.WriteLine("Supervisores possuem 9% de reajuste salarial.");
                    Console.WriteLine($"Seu salário reajustado é igual a {salario + reajuste}.");

                    break;
                
                case 4:
                    reajuste = salario * 6 / 100;
                    Console.WriteLine("Motoristas possuem 6% de reajuste salarial.");
                    Console.WriteLine($"Seu salário reajustado é igual a {salario + reajuste}.");

                    break;
               
                case 5:
                    reajuste = salario * 5 / 100;
                    Console.WriteLine("Estoquistas possuem 5% de reajuste salarial.");
                    Console.WriteLine($"Seu salário reajustado é igual a {salario + reajuste}.");

                    break;

                case 6:
                    reajuste = salario * 8 / 100;
                    Console.WriteLine("Técnicos de TI possuem 8% de reajuste salarial.");
                    Console.WriteLine($"Seu salário reajustado é igual a {salario + reajuste}.");

                    break;


            }


        }
    }
}