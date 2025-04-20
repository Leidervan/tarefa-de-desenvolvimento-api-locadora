namespace ApiLocadora.Dto
{
    public class FilmeDto
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int AnoLancamento { get; set; }
        public string Diretor { get; set; }
        public int GeneroId { get; set; }
        public int EstudioId { get; set; }
        public double AvaliacaoImdb { get; set; }
    }
}
