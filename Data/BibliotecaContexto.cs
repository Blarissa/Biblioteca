using Biblioteca.Model;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Data
{
    public class BibliotecaContexto : DbContext
    {
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Leitor> Leitores { get; set; }
        public DbSet<Emprestimo> Emprestimos { get; set; }

        public BibliotecaContexto()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseNpgsql(@"Host=localhost;Database=Biblioteca;Username=postgres;Password=mypass")
                .UseSnakeCaseNamingConvention();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new LivroConfigurations());
            modelBuilder.ApplyConfiguration(new LeitorConfigurations());
            modelBuilder.ApplyConfiguration(new EmprestimoConfigurations());
        }
    }
}
