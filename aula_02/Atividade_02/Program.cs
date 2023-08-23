namespace Atividade_02 {
    internal class Program {
        static void Main(string[] args) {

            float n1, n2, n3, n4, media;
            string aluno; 
            Console.WriteLine("Bem vindo ao programa de médias de aluno!");
            Console.Write("Insira o nome do aluno: ");
            aluno = Console.ReadLine();

            Console.WriteLine("Insira a nota do 1º bimestre: ");
            n1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Insira a nota do 1º bimestre: ");
            n2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Insira a nota do 1º bimestre: ");
            n3 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Insira a nota do 1º bimestre: ");
            n4 = Convert.ToSingle(Console.ReadLine());

            media = ((n1 + n2 + n3 + n4) / 4);

            Console.WriteLine("A média final do aluno " + aluno + " é: " + media + ".");








        }
    }
}