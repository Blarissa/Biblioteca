using Biblioteca.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Data
{
    internal class LivroConfigurations : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder)
        {
            builder.Property(l => l.Id)
                .ValueGeneratedOnAdd();
            builder.HasKey(l => l.Id);

            builder.Property(l => l.Titulo)
                .IsRequired();

            builder.Property(l => l.Autor)
                .IsRequired();

            builder.Property(l => l.ISBN)
                .IsRequired();

            builder.Property(l => l.Ano)
                .IsRequired();

            builder.Property(l => l.Edicao)
                .IsRequired();
        }
    }
}
