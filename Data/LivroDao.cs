using Biblioteca.Model;

namespace Biblioteca.Data
{
    internal class LivroDao
    {
        private BibliotecaContexto _contexto;

        public LivroDao(BibliotecaContexto contexto)
        {
            _contexto = contexto;
        }

        public void Adicionar(Livro livro)
        {
            _contexto.Add(livro);
            _contexto.SaveChanges();
        }

        public void Alterar(Livro livro)
        {
            _contexto.Update(livro);
            _contexto.SaveChanges();
        }

        public void Deletar(int id)
        {
            _contexto.Remove(Listar(id));
            _contexto.SaveChanges();
        }

        public Livro? Listar(int id)
        {
            return _contexto.Livros
                .FirstOrDefault(l => l.Id == id);
        }

        public IList<Livro> ListarTodos()
        {
            return _contexto.Livros.ToList();
        }

        public IList<Livro> Pesquisar(string pesquisa)
        {
            return ListarTodos()
                .Where(l => l.Titulo.Contains(pesquisa))
                .ToList();
        }
    }
}
