using Biblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Data
{
    public interface IDaoDevolucao : IDao<Devolucao>
    {
        Devolucao? PesquisarPorIdEmprestimo(int id);
    }
}
