using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio04_Csharp.Interface
{
    abstract class Produto
    {
        private String _nome;
        private double _preco;
        private int _qtd;

        public Produto(String nome, double preco, int qtd)
        {
            this.nome = nome;
            this.preco = preco;
            this.qtd = qtd;
        }

        public String nome { get; }
        public double preco { get; }
        public int qtd { get; }
    }
}
