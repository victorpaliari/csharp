namespace Notas {
    internal class Program {
        static void Main(string[] args) {

            float? n1, n2, media;
            
            Console.Write("Digite a primeira nota: ");
            n1 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            n2 = Convert.ToSingle(Console.ReadLine());

            media = (n1 + n2) / 2;
            Console.WriteLine((media >= 6 ? "Aprovado" : "Reprovado")) ;

            // condição ? ação verdade : ação mentira
        }
    }
}