using Biblioteca.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Biblioteca.Data
{
    internal class EmprestimoConfigurations : IEntityTypeConfiguration<Emprestimo>
    {
        public void Configure(EntityTypeBuilder<Emprestimo> builder)
        {
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd();
            builder.HasKey(e => e.Id);

            builder.Property(e => e.DataHora)
                .HasColumnType("timestamp without time zone")
                .IsRequired();

            builder.HasOne(e => e.Livro)
                .WithMany(l => l.Emprestimos)
                .HasForeignKey(e => e.LivroId);

            builder.HasOne(e => e.Leitor)
                .WithMany(l => l.Emprestimos)
                .HasForeignKey(e => e.LeitorId);

            builder.Property(e => e.Status).IsRequired();
        }
    }
}