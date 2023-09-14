using Biblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Data
{
    public class LeitorDao
    {
        private BibliotecaContexto _contexto;

        public LeitorDao(BibliotecaContexto contexto)
        {
            _contexto = contexto;
        }

        public void Adicionar(Leitor leitor)
        {
            _contexto.Leitores.Add(leitor);
            _contexto.SaveChanges();
        }

        public Leitor? Listar(int id)
        {
            return _contexto.Leitores
                .FirstOrDefault(l => l.Id == id);
        }

        public IList<Leitor> ListarTodos() 
        {
            return _contexto.Leitores.ToList();
        }

        public IList<Leitor> Pesquisar(string pesquisa) 
        {
            return ListarTodos()
                .Where(l => l.Nome.Contains(pesquisa))
                .ToList();
        }

    }
}
