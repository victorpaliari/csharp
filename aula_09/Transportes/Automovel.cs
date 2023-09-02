using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportes
{
    internal class Automovel : Terrestre
    {
        public string cor;
        public int portas;
        public string placa;
        public int marcha;
        public Automovel(int capacidade, int rodas, int velocidade, string cor, int porta, string placa, int marcha) : base(capacidade, rodas, velocidade)
        {
            this.cor = cor;
            this.portas = porta;
            this.placa = placa;
            this.marcha = marcha;  
        }

        public string GetCor()
        {
            return cor;
        }
        public void SetCor()
        {
            cor = GetCor();
        }
        public int GetNumeroPortas()
        {
            return portas;
        }

        public void SetNumeroPortas(int numeroPortas)
        {
            this.portas = numeroPortas;
        }

        public string GetPlaca()
        {
            return placa;
        }

        public void SetPlaca(string placa)
        {
            this.placa = placa;
        }

        public int GetMarcha()
        {
            return marcha;
        }

        public void SetMarcha(int marcha)
        {
            this.marcha = marcha;
        }

        public override void Visualizar()
        {

            base.Visualizar();
            Console.WriteLine("cor: " + this.cor);
            Console.WriteLine("Número de portas: " + this.portas);
            Console.WriteLine("Placa: " + this.placa);
            Console.WriteLine("Marcha: " + this.marcha);

        }
    }
}
