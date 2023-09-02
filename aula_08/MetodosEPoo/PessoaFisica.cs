using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosEPoo
{
    public class PessoaFisica : Cliente
    {
        public string cpf = string.Empty;

        public PessoaFisica(string nome, string rG, int idade, string endereco, string email, decimal credito, string cpf) 
            : base(nome, rG, idade, endereco, email, credito)
        {
            this.cpf = cpf;
        }

        public string GetCpf()
        {
            return this.cpf;
        }
        public void SetCpf(string cpf)
        {
            this.cpf = cpf;
        }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"Pessoa Física (CPF): {this.cpf} ");
        }


    }


}
