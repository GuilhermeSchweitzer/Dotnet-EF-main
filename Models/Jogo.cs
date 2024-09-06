using System.ComponentModel.DataAnnotations.Schema;

namespace DotnetEF.Models
{
    public class Jogo
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public float Value { get; set; }
        public string? Description { get; set; }
        public int AgeRating { get; set; }

        public long CategoriaID { get; set; }
        [ForeignKey("CategoriaID")]

        public Categoria? Categoria { get; set; }
    }
}
