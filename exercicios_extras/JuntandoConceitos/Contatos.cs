using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuntandoConceitos
{
    public class Contatos
    {
        public string nome = string.Empty;
        public string sobrenome = string.Empty;
        public int telefone = 0;

        public Contatos(string nome, string sobrenome, int telefone)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.telefone = telefone;
        }
        public string GetNome()
        {
            return this.nome;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public string GetSobrenome()
        {
            return this.sobrenome;
        }

        public void SetSobrenome(string sobrenome)
        {
            this.sobrenome = sobrenome;
        }
        public int Gettelefone()
        {
            return this.telefone;
        }

        public void SetTelefone(int telefone)
        {
            this.telefone = telefone;
        }

        public virtual void Visualizar()
        {

            int opcao = 0;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n             LISTA TELEFÔNICA        ");
            Console.WriteLine("\n ------------------------------------\n");
            Console.WriteLine("\t 1 - Adicionar contato");
            Console.WriteLine("\t 2 - Ver Contatos");
            Console.WriteLine("\t 3 - Excluir contato");
            Console.WriteLine("\t 0 - Sair");
            Console.WriteLine("\n ------------------------------------");

            switch (opcao)
            {

                case 1:
                    List<string> ListaDeContatos = new List<string>();
                    Console.WriteLine("Insira novo contato: ");
                    ListaDeContatos.Add(Console.ReadLine());

                    foreach (string contato in ListaDeContatos)
                    {

                        Console.WriteLine($"{contato} adicionado com sucesso");

                    }
                    break;

                case 2:
                    Console.WriteLine(ListaDeContatos);

                    break;
                case 0: System.Environment.Exit(0);
                    break;



            }
        }
    }
}

