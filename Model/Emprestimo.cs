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

        public virtual Livro Livro { get; set; }
        public virtual Leitor Leitor { get; set; }

        public Emprestimo(DateTime dataHora, int livroId, int leitorId)
        {
            DataHora = dataHora;
            LivroId = livroId;            
            LeitorId = leitorId;
        }

        public override string? ToString()
        {
            return $"\nEmpréstimo: {Id}\n" +
                $"Data/Hora: {DataHora:g}\n" +
                $"Livro: {Livro.Titulo}\n" +
                $"Leitor: {Leitor.Nome}\n";
        }
    }
}
