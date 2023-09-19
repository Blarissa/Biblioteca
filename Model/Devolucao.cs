using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Model
{
    public class Devolucao
    {
        public int Id { get; set; }
        public DateTime DataHora { get; set; }
        public int EmprestimoId { get; set; }
        public virtual Emprestimo Emprestimo { get; set; }        

        public Devolucao(DateTime dataHora, int emprestimoId)
        {
            DataHora = dataHora;
            EmprestimoId = emprestimoId;
        }

        public override string ToString()
        {
            return $"\nDevolução: {Id}\n" +
                $"Data/Hora: {DataHora:g}\n" +
                $"Código do empréstimo: {EmprestimoId}\n";
        }
    }
}
