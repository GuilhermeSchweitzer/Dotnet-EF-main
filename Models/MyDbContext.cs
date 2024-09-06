using Microsoft.EntityFrameworkCore;

namespace DotnetEF.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Jogo> Jogos { get; set; }

        public DbSet<Categoria> Categorias { get; set; }
    }
}
