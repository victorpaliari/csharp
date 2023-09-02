using Metodos_02.Namespace01;

namespace Metodos_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MetodoPublico();
            MetodoInternal();
            MetodoPrivado();
            MetodoProtegido();
            Class1.MetodoPublico();
            Class1.MetodoInternal();

            //metodo protegido só é acessado se houver relação de herança
            //Class1.MetodoProtegido();
            //método privado só funciona dentro da classe onde ele foi criado
            //Class1.MetodoPrivado();

            Class2.MetodoPublico();
            Class2.MetodoInternal();
        }

        public static void MetodoPublico()
        {
            Console.WriteLine($"Metodo Publico - Classe Program");
        }

        internal static void MetodoInternal()
        {
            Console.WriteLine($"Metodo Internal - Classe Program");
        }

        protected static void MetodoProtegido()
        {
            Console.WriteLine($"Metodo Protegido - Classe Program");
        }

        private static void MetodoPrivado ()
        {
            Console.WriteLine($"Metodo Privado - Classe Program");
        }
    }
}