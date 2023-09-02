using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDeGames
{
    internal class Consoles : Produto
    {
        string capacidade;

        public Consoles(string nome, string marca, string fabricante, string dataFabricacao, string garantia, string especificacao, decimal preco, int frete, string capacidade) 
            : base(nome, marca, fabricante, dataFabricacao, garantia, especificacao, preco, frete)
        {
            this.capacidade = capacidade;
        }

        public string GetCapacidade()
        {
            return capacidade;
        }

        public void SetCapacidade(string capacidade)
        {
            this.capacidade = capacidade;
        }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"Capacidade de Armazenamento: {this.capacidade}");
        }

        public override void Promocionar()
        {
            base.Promocionar();
        }

    }

}
