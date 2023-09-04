using Biblioteca.Data;
using Biblioteca.Model;
using Biblioteca.View;

namespace Biblioteca.Controller
{
    internal class LivroController
    {
        private LivroDao _dao;
        private IInput _input;

        public LivroController(LivroDao dao, IInput input)
        {
            _dao = dao;
            _input = input;
        }

        public void Adicionar()
        {
            var titulo = _input.Titulo();
            var autor = _input.Autor();
            var isbn = _input.ISBN();
            var ano = _input.Ano();
            var edicao = _input.Edicao();

            var livro = new Livro(titulo, autor, isbn, ano, edicao);
            _dao.Adicionar(livro);
        }

        public void Deletar()
        {            
            var id = _input.ID();

            _dao.Deletar(id);
        }

        public Livro? Listar()
        {
            var id = _input.ID();

            return _dao.Listar(id);
        }

        public IList<Livro> ListarTodos()
        {
            return _dao.ListarTodos();
        }

        public IList<Livro> Pesquisar()
        {            
            var pesquisa = _input.Pesquisa();

            return _dao.Pesquisar(pesquisa);
        }
    }
}
