namespace Pilha
{
    namespace Pilha
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Stack<string> pilha = new Stack<string>();

                pilha.Push("Breno");
                pilha.Push("Eduardo");
                pilha.Push("Julia");
                pilha.Push("Leonardo Machado");
                pilha.Push("Gaspar");

                //Remove o último da pilha
                pilha.Pop();

                foreach (var nome in pilha)
                {
                    Console.WriteLine(nome);
                }

                Console.WriteLine("Quem é o último da pilha? " + pilha.Peek());
                Console.WriteLine("O Gaspar faz parte da pilha? " + pilha.Contains("Gaspar"));
                Console.WriteLine("Número de pessoas na pilha: " + pilha.Count());

            }
        }
    }
}