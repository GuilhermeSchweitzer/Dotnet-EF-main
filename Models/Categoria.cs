namespace DotnetEF.Models
{
    public class Categoria
    {
        public long Id { get; set; }
        public string? Name { get; set; }

        public List<Jogo>? Jogos { get; set; }
    }
}
