using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio04_Csharp.Interface
{
    class Loja
    {
        private String _nome;
        private String _cnpj;
        private List<Livro> _livros;
        private List<Videogame> _videoGame;

        public Loja(String nome, String cnpj, List<Livro>livros,List<Videogame>videoGame)
        {
            this.nome = nome;
            this.cnpj = cnpj;
            this.livros = livros;
            this.videoGame = videoGame;
        }

        public String nome { get; }
        public String cnpj { get; }
        public List<Livro> livros { get; }
        public List<Videogame> videoGame { get; }

        public void listaLivros()
        {
            if (this.livros.Count == 0)
            {
                Console.WriteLine("A Loja não tem livros no seu estoque.");
            }
            else
            {
                foreach (Livro livro in this.livros)
                {
                    Console.WriteLine("Titulo: "+livro.nome+"  Autor: "+livro.autor+"  Tema: "+livro.tema+"  Preço: R$ "+livro.preco+"  Qtd no estoque: "+livro.qtd);
                }
            }
        }
        public void listaVideoGames()
        {
            if (this.videoGame.Count==0)
            {
                Console.WriteLine("A Loja não tem Video-Games no seu estoque.");

            }
            else
            {
                foreach (Videogame game in this.videoGame)
                {
                    Console.WriteLine("Console: " + game.nome+" "+game.modelo+", "+game.marca+"  Preço: R$ "+game.preco+"  Qtd no estoque: "+game.qtd);
                }
            }
        }
        public double calculaPatrimonio()
        {
            double soma=0;
            foreach (Videogame game in this.videoGame)
            {
                soma += game.preco*game.qtd;
            }
            foreach (Livro livro in this.livros)
            {
                soma += livro.preco*livro.qtd;
            }
            return soma;
        }
    }
}
