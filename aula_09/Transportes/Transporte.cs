using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportes
{
    public class Transporte
    {
        private int capacidade;

        public Transporte(int capacidade)
        {
            this.capacidade = capacidade;
        }

        public int getCapacidade()
        {
            return capacidade;
        }

        public void SetCapacidade(int capacidade)
        {
            this.capacidade = capacidade;
        }

        // Virtual = (modificar non-access) Pode ser sobescrito na classe filha - Se a classe filha tiver escrito "override" caso contrario a classe filha tera herdado as propriedades desse metodo, sem alterações 
        //de acordo com o tipo do meu objeto, ele sabe que objeto ele vai chamar = polimofrismo
        public virtual void Visualizar()
        {
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("\tMeio de transporte                                 ");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine($"Capacidade: {this.capacidade}");
            
            
        }
    }
}
