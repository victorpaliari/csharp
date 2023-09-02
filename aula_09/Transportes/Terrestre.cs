using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportes
{
    //Dois pontos indica uma herança, Transporte é o nome da classe que queremos herdar
    public class Terrestre : Transporte
    {
        private int rodas;
        private int velocidade;

        // Base é a classe herdada, com o parâmetro capacidade > base está chamando o método construtor da superclasse
        //Capacidade é o método construtor da superclasse Transporte
        //Herança herda tudo que está na classe principal, se tivesse mais atributos na classe Transporte, essa classe (Terrestre) teria herdado tudo.  
        public Terrestre(int capacidade, int rodas, int velocidade) : base(capacidade)
        {
            //this indica o atributo da classe
            this.rodas = rodas;
            this.velocidade = velocidade;
        }
        public int GetRodas()
        {
            return rodas;
        }

        public void SetNumeroRodas(int numeroRodas)
        {
            this.rodas = numeroRodas;
        }

        public float GetVelocidade()
        {
            return velocidade;
        }

        public void SetVelocidade(int velocidade)
        {
            this.velocidade = velocidade;
        }

        //de acordo com o tipo do meu objeto, ele sabe que objeto ele vai chamar = polimofrismo
        //override = transcrever o virtual
        public override void Visualizar()
        {

            base.Visualizar();
            Console.WriteLine($"Número de rodas: {rodas}");
            Console.WriteLine($"Velocidade Máxima: {velocidade}km/h");

        }
    }
}
