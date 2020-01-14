using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio04_Csharp.Interface
{
    class Videogame:Produto,Imposto
    {
        private String _marca;
        private String _modelo;
        private bool _isUsado;

        public Videogame(String nome, double preco, int qtd, String marca, String modelo, bool isUsado):base(nome,preco,qtd)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.isUsado = isUsado;
        }

        public String marca { get; }
        public String modelo { get; }
        public bool isUsado { get; }

        public double calculaImposto()
        {
            if (this.isUsado==true)
            {
                return this.preco * 0.25;
            }
            else
            {
                return this.preco * 0.45;
            }
        }
    }
}
