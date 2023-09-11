using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuntandoConceitos
{
    public class GerenciadorDeContatos : Contatos
    {
        string testar = string.Empty;
        public GerenciadorDeContatos(string nome, string sobrenome, int telefone, string testar)
            : base(nome, sobrenome, telefone)
        {
            this.testar = testar;
        }
 
        public string GetTestar()
        {
            return testar;
        }

        public void SetTestar(string testar)
        {
            this.testar = testar;
        }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine("Gerenciador de contatos funcionando");
        }

    }
    }



