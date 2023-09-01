using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosEPoo
{
    public class Cliente

    {
        //Atributos 
        private string nome = String.Empty;
        private string rG = String.Empty;
        private int idade;
        private string endereco = String.Empty;
        private string email = String.Empty;
        private decimal credito = 0;

        //Método Construtor - Inicializa os atributos da classe com os valores passados como argumentos
        //(string nome, string rG, string endereco, string cadastro, int credito, int idade) - Parâmetros



        //Atribuir valor aos atributos
        public Cliente(string nome, string rG, int idade, string endereco, string email, decimal credito)
        {
            this.nome = nome;
            this.rG = rG;
            this.idade = idade;
            this.endereco = endereco;
            this.email = email;
            this.credito = credito;
        }


        //Métodos Get e Set

        public string GetNome()
        {
            return nome;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public string GetRg()
        {
            return rG;
        }

        public void SetRg(string nome)
        {
            this.nome = rG;
        }

        public int GetIdade()
        {
            return idade;
        }

        public void SetIdade(int idade)
        {
            this.idade = idade;
        }
        public string GetEmail()
        {
            return email;
        }

        public void SetEmail(string email)
        {
            this.email = email;
        }

        public string GetEndereço()
        {
            return endereco;
        }

        public void SetEndereco(string endereco)
        {
            this.endereco = endereco;
        }

        public decimal GetCredito()
        {
            return credito;
        }

        public void SetCredito(decimal credito)
        {
            this.credito = credito;
        }



        public void Visualizar()
        {
            Console.WriteLine("******************************************************");
            Console.WriteLine("Dados do cliente");
            Console.WriteLine("******************************************************");
            Console.WriteLine($"Nome: {this.nome}");
            Console.WriteLine($"RG:  {this.rG}");
            Console.WriteLine($"Idade: {this.idade}");
            Console.WriteLine($"Endereço: {this.endereco}");
            Console.WriteLine($"E-mail: {this.email}");
            Console.WriteLine($"Crédito pré-aprovado: {(this.credito).ToString("C")}");
        }

        /* public void Fatura()
        {
            decimal fatura = 0;
            Console.WriteLine($"Limite disponível: {this.credito - this.fatura} ");
        }
        */

    }
}
