using Biblioteca.Data;
using Biblioteca.Model;
using Biblioteca.View;

namespace Biblioteca.Controller
{
    public class LivroController
    {
        private LivroDao _dao;
        private IRetornodados _dados;

        public LivroController(LivroDao dao, IRetornodados dados)
        {
            _dao = dao;
            _dados = dados;
        }

        public void Adicionar()
        {
            var titulo = _dados.Titulo();
            var autor = _dados.Autor();
            var isbn = _dados.ISBN();
            var ano = _dados.Ano();
            var edicao = _dados.Edicao();
            var quantidade = _dados.Quantidade();

            var livro = new Livro(titulo, autor, isbn, ano, edicao, quantidade);
            _dao.Adicionar(livro);
        }

        public void Deletar()
        {            
            var id = _dados.ID();

            _dao.Deletar(id);
        }

        public Livro? Listar()
        {
            var id = _dados.ID();

            return _dao.Listar(id);
        }

        public IList<Livro> ListarTodos()
        {
            return _dao.ListarTodos();
        }

        public IList<Livro> Pesquisar()
        {            
            var pesquisa = _dados.Pesquisa();

            return _dao.Pesquisar(pesquisa);
        }
    }
}
