using Biblioteca.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Data
{
    public class DevolucaoDao : IDaoDevolucao 
    { 
        private BibliotecaContexto _contexto;

        public DevolucaoDao(BibliotecaContexto contexto)
        {
            _contexto = contexto;
        }

        public void Adicionar(Devolucao devolucao)
        {
            _contexto.Devolucoes.Add(devolucao);
            _contexto.SaveChanges();
        }

        public Devolucao? Listar(int id)
        {
            return ListarTodos()
                .FirstOrDefault(d => d.Id == id);
        }

        public IList<Devolucao> ListarTodos()
        {
            return _contexto.Devolucoes
                .Include(d => d.Emprestimo)
                .ToList();
        }

        public Devolucao? PesquisarPorIdEmprestimo(int id)
        {
            return ListarTodos()
                .FirstOrDefault(d => d.EmprestimoId == id);
        }
    }
}
