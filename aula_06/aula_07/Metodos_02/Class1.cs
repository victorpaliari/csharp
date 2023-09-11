using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_02
{
    public class Class1
    {
        public static void MetodoPublico()
        {
            Console.WriteLine($"Metodo Publico - Class1");
        }

        internal static void MetodoInternal()
        {
            Console.WriteLine($"Metodo Internal - Class1");
        }

        protected static void MetodoProtegido()
        {
            Console.WriteLine($"Metodo Protegido - Class1");
        }

        private static void MetodoPrivado()
        {
            Console.WriteLine($"Metodo Privado - Class1");
        }
    }
}
