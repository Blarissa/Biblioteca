using RepositorioDeLivros.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Model
{
    public class Emprestimo
    {
        public int Id { get; set; }
        public DateTime DataHora { get; set; }
        public int LivroId { get; set; }
        public int LeitorId { get; set; }
        public string Status { get; set; }

        public virtual Livro Livro { get; set; }
        public virtual Leitor Leitor { get; set; }
        public virtual Devolucao Devolucao { get; set; }

        public Emprestimo(DateTime dataHora, int livroId, int leitorId, string status)
        {
            DataHora = dataHora;
            LivroId = livroId;
            LeitorId = leitorId;
            Status = status;
        }

        public override string? ToString()
        {
            return $"\nEmpréstimo: {Id}\n" +
                $"Data/Hora: {DataHora:g}\n" +
                $"Livro: {Livro.Titulo}\n" +
                $"Leitor: {Leitor.Nome}\n" +
                $"Status: {Status}\n";
        }

        public void Emprestar()
        {
            Livro.Quantidade--;
        }

        public void Devolver()
        {
            Livro.Quantidade++;
            Status = "DESATIVO";
        }
    }
}
