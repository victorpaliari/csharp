namespace HelloWorld {
    internal class Program { // classe principal
        static void Main(string[] args) { // método principal

            int? n1, n2, soma;
            int op = 1, 2, 3, 4, 5, 6;

            Console.WriteLine("Escolha uma operação: ");
            Console.WriteLine("1. Soma");
            Console.WriteLine("2. Subtração");
            Console.WriteLine("3. Divisão");
            Console.WriteLine("4. Multiplicação");
            Console.WriteLine("5. Porcentagem");

            //if (Console.ReadLine(1)) {


           // }


           // else {
            //    Console.WriteLine("Insira uma opção válida.");
           // }
            Console.WriteLine("Insira um número: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira outro número: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            soma = (n1 + n2);
            Console.WriteLine("A soma dos números é " + soma + "."); 
           
        }
    }
}
