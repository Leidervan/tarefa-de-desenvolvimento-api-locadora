using System.Collections.Generic;
using ApiLocadora;
using ApiLocadora.Dto;

namespace ApiLocadora.DbContext
{
    public static class ListaDb
    {
        // Lista estática de filmes
        public static List<FilmeDto> Filmes { get; } = new List<FilmeDto>
        {
            new FilmeDto
            {
                Id = 1,
                Titulo = "Fast & Furious",
                AnoLancamento = 2001,
                Diretor = "Rob Cohen",
                GeneroId = 1,
                EstudioId = 1,
                AvaliacaoImdb = 6.8
            },
            new FilmeDto
            {
                Id = 2,
                Titulo = "Fast & Furious ||",
                AnoLancamento = 2003,
                Diretor = "John Singleton",
                GeneroId = 1,
                EstudioId = 1,
                AvaliacaoImdb = 5.9
            },
            new FilmeDto
            {
                Id = 3,
                Titulo = "Fast & Furious: Desafio em Tóquio",
                AnoLancamento = 2006,
                Diretor = "Justin Lin   ",
                GeneroId = 1,
                EstudioId = 1,
                AvaliacaoImdb = 6.1
            }
        };

        // Lista estática de gêneros
        public static List<Genero> Generos { get; } = new List<Genero>
        {
            new Genero { Id = 1, Nome = "Ação" },
            new Genero { Id = 2, Nome = "Drama" }
        };

        // Lista estática de estúdios
        public static List<Estudio> Estudios { get; } = new List<Estudio>
        {
            new Estudio { Id = 1, Nome = "Warner Bros", Distribuidor = "Warner Distribution" },
            new Estudio { Id = 2, Nome = "Universal", Distribuidor = "Universal Pictures" }
        };
    }
}
