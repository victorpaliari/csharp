using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_02.Namespace01
{
    public class Class2
    {
        public static void MetodoPublico()
        {
            Console.WriteLine($"Metodo Publico - Class2");
        }

        internal static void MetodoInternal()
        {
            Console.WriteLine($"Metodo Internal - Class2");
        }

        protected static void MetodoProtegido()
        {
            Console.WriteLine($"Metodo Protegido - Class2");
        }

        private static void MetodoPrivado()
        {
            Console.WriteLine($"Metodo Privado - Class2");
        }
    }
}
