namespace Atividade_04 {
    internal class Program {
        static void Main(string[] args) {


            float n1, n2, n3, n4, resultado;

            Console.WriteLine("Entre com n1: ");
            n1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Entre com n2: ");
            n2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Entre com n3: ");
            n3 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Entre com n4: ");
            n4 = Convert.ToSingle(Console.ReadLine());

            resultado = ((n1 * n2) - (n3 * n4));
            Console.WriteLine("A diferença dos produtos é igual a: " + resultado);
          
            
        }
    }
}