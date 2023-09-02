using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosEPoo
{
    public class PessoaJuridica : Cliente
    {
        public string cnpj = string.Empty;
        public PessoaJuridica(string nome, string rG, int idade, string endereco, string email, decimal credito, string cnpj) 
            : base(nome, rG, idade, endereco, email, credito)
        {
            this.cnpj = cnpj;
        }
        public string GetCnpj()
        {
            return this.cnpj;
        }
        public void SetCnpj(string cnpj)
        {
            this.cnpj = cnpj;
        }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"Pessoa Jurídica (CNPJ): {this.cnpj} ");
        }



    }
}
