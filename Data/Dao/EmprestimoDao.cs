using Biblioteca.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Data
{
    public class EmprestimoDao
    {
        private BibliotecaContexto _contexto;

        public EmprestimoDao(BibliotecaContexto contexto)
        {
            _contexto = contexto;
        }

        public void Adicionar(Emprestimo emprestimo)
        {
            _contexto.Emprestimos.Add(emprestimo);
            _contexto.SaveChanges();
        }

        public Emprestimo? Listar(int id)
        {
            return ListarTodos()
                .FirstOrDefault(e => e.Id == id);
        }

        public IList<Emprestimo> ListarTodos()
        {
            return _contexto.Emprestimos
                .Include(e => e.Livro)
                .Include(e => e.Leitor)
                .ToList();
        }

        public IList<Emprestimo> PesquisarPorLeitor(string pesquisa)
        {
            return ListarTodos()
                .Where(e => e.Leitor.Nome.Contains(pesquisa))
                .ToList();
        }

        public IList<Emprestimo> PesquisarPorLivro(string pesquisa)
        {
            return ListarTodos()
                .Where(e => e.Livro.Titulo.Contains(pesquisa))
                .ToList();
        }
    }
}
