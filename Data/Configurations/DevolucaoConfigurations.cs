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
    public class DevolucaoConfigurations : IEntityTypeConfiguration<Devolucao>
    {
        public void Configure(EntityTypeBuilder<Devolucao> builder)
        {
            builder.Property(d => d.Id)
                .ValueGeneratedOnAdd();
            builder.HasKey(d => d.Id);

            builder.Property(e => e.DataHora)
                .HasColumnType("timestamp without time zone")
                .IsRequired();

            builder.HasOne(d => d.Emprestimo)
                .WithOne(e => e.Devolucao)
                .HasForeignKey<Devolucao>(d => d.EmprestimoId);


        }
    }
}
