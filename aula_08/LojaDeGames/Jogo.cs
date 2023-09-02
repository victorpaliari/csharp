using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDeGames
{
    public class Jogo : Produto
    {
        string plataforma = string.Empty;
        public Jogo(string nome, string marca, string fabricante, string dataFabricacao, string garantia, string especificacao, decimal preco, int frete, string plataforma)
            : base(nome, marca, fabricante, dataFabricacao, garantia, especificacao, preco, frete)
        {

            this.plataforma = plataforma;

        }

        public string GetPlataforma()
        {
            return plataforma;
        }

        public void SetPlataforma(string plataforma)
        {
            this.plataforma = plataforma;
        }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"Disponível para: {this.plataforma}");
        }
    }
}
