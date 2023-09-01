﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LojaDeGames
{
    public class Produto
    {
        //Atributos da classe Produto
        public string nome = String.Empty;
        public string marca = String.Empty;
        public string fabricante = String.Empty;
        public string dataFabricacao = String.Empty;
        public string garantia = String.Empty;
        public string especificacao = String.Empty;
        public decimal preco = 0;
        public decimal frete = 0;
        public string notaFiscal = String.Empty;

        public Produto(string nome, string marca, string fabricante, string dataFabricacao, string garantia, string especificacao, decimal preco, decimal frete, string notaFiscal)
        {

            //Método construtor da classe Produto
            //This se refere ao atributo da Classe Produto
            this.nome = nome;
            this.marca = marca;
            this.fabricante = fabricante;
            this.dataFabricacao = dataFabricacao;
            this.garantia = garantia;
            this.especificacao = especificacao;
            this.preco = preco;
            this.frete = frete;
            this.notaFiscal = notaFiscal;
        }


        public string GetNome()
        {
            return nome;

        }
        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public string GetMarca()
        {
            return marca;

        }
        public void SetMarca(string marca)
        {
            this.marca = marca;
        }

        public string GetFabricante()
        {
            return fabricante;

        }
        public void SetFabricante(string fabricante)
        {
            this.fabricante = fabricante;
        }
        public string GetDataFabricacao()
        {
            return dataFabricacao;

        }
        public void SetDataFabricacao(string dataFabricacao)
        {
            this.dataFabricacao = dataFabricacao;
        }
        public string GetGarantia()
        {
            return garantia;

        }
        public void SetGarantia(string garantia)
        {
            this.garantia = garantia;
        }
        public string GetEspecificacao()
        {
            return especificacao;

        }
        public void SetEspecificacao(string especificacao)
        {
            this.especificacao = especificacao;
        }

        public decimal GetPreco()
        {
            return preco;

        }
        public void SetPreco(decimal preco)
        {
            this.preco = preco;
        }
        public decimal GetFrete()
        {
            return frete;

        }
        public void SetFrete(decimal frete)
        {
            this.frete = frete;   
        }
        public string GetNotaFiscal()
        {
            return notaFiscal;

        }
        public void SetNotaFiscal(string notaFiscal)
        {
            this.notaFiscal = notaFiscal;
        }

        public void Visualizar()
        {
            Console.WriteLine("******************************************************");
            Console.WriteLine("Dados do Produto");
            Console.WriteLine("******************************************************");
            Console.WriteLine($"{this.nome}");
            Console.WriteLine($"{this.marca}");
            Console.WriteLine($"Fabricante {fabricante}");
            Console.WriteLine($"Data de fabricação: {this.dataFabricacao}");
            Console.WriteLine($"{garantia}");
            Console.WriteLine($"{especificacao}");
            Console.WriteLine($"Preço: {this.preco.ToString("C")}");
            Console.WriteLine($"Frete: {this.frete.ToString("C")}");
            Console.WriteLine($"Tipo de nota: {notaFiscal}");
        }

        public void Promocionar()
        {   
            decimal promocionar = preco * 0.2M;
            Console.WriteLine($"Leve hoje com 20% de desconto: R$ {this.preco - promocionar}");
            Console.WriteLine($"Você economiza: {promocionar.ToString("C")}");
        }
        // Get e Set




    }
}
