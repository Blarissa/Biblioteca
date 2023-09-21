using Biblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Data
{
    public interface IDaoEmprestimo : IDao<Emprestimo>
    {
        IList<Emprestimo> PesquisarPorLeitor(string pesquisa);
        IList<Emprestimo> PesquisarPorLivro(string pesquisa);
    }
}
