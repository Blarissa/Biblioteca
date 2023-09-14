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
    public class LeitorConfigurations : IEntityTypeConfiguration<Leitor>
    {
        public void Configure(EntityTypeBuilder<Leitor> builder)
        {
            builder.Property(l => l.Id)
                .ValueGeneratedOnAdd();
            builder.HasKey(l => l.Id);

            builder.Property(l => l.Nome)
                .IsRequired();

            builder.Property(l => l.Email)
                .IsRequired();

            builder.Property(l => l.Telefone)
                .IsRequired();
        }
    }
}
