using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio04_Csharp.Interface
{
    class Livro:Produto,Imposto
    {
        private String _autor;
        private String _tema;
        private int _qtdPag;

        public Livro(String nome, double preco, int qtd, String autor, String tema, int qtdPag):base(nome,preco,qtd)
        {
            this.autor = autor;
            this.tema = tema;
            this.qtdPag = qtdPag;
        }

        public String autor { get; }
        public String tema { get; }
        public int qtdPag { get; }

        public double calculaImposto()
        {
            if (this.tema=="educativo")
            {
                return 0;
            }
            else
            {
                return this.qtdPag * 0.1;
            }
        }
    }
}
