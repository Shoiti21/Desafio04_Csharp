using Desafio04_Csharp.Interface;
using System;
using System.Collections.Generic;

namespace Desafio04_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Livro l1 = new Livro("Harry Potter",40,50,"J. K. Rowling","fantasia", 300);
            Livro l2 = new Livro("Senhor dos Anéis",60,30,"J. R. R. Tolkien","fantasia",500);
            Livro l3 = new Livro("Java POO",20,50,"GFT","education",500);

            Videogame g1 = new Videogame("PS4",1800,100,"Sony","Slim",false);
            Videogame g2 = new Videogame("PS4", 1000, 7, "Sony", "Slim", true);
            Videogame g3 = new Videogame("XBOX", 1500, 500, "Microsoft", "One", false);

            var livros = new List<Livro>();
            livros.Add(l1);
            livros.Add(l2);
            livros.Add(l3);

            var games = new List<Videogame>();
            games.Add(g1);
            games.Add(g2);
            games.Add(g3);

            Loja americanas = new Loja("Americanas", "12345678", livros, games);

            foreach (Livro livro in livros)
            {
                if (livro.calculaImposto() == 0)
                {
                    Console.WriteLine("O livro "+livro.nome+" não contem imposto.");
                }
                else
                {
                    Console.WriteLine("O livro " + livro.nome + " tem R$ " + livro.calculaImposto() + " de imposto.");
                }         
            }
            foreach (Videogame game in games)
            {
                Console.WriteLine("O " + game.nome + " tem R$ " + game.calculaImposto() + " de imposto.");
            }
            Console.WriteLine("_____________________________________________");
            americanas.listaLivros();
            Console.WriteLine("_____________________________________________");
            americanas.listaVideoGames();
            Console.WriteLine("_____________________________________________");
            Console.WriteLine("O patrimonio da loja: A "+americanas.nome+" é de R$ "+ americanas.calculaPatrimonio());
        }
    }
}
