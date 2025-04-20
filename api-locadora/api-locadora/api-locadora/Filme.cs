namespace ApiLocadora.Models
{
    public class Filme
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int AnoLancamento { get; set; }
        public string Diretor { get; set; }

        // Associações
        public Genero Genero { get; set; }
        public Estudio Estudio { get; set; }

        // Avaliação por IMDB
        public double AvaliacaoImdb { get; set; }
    }
}
