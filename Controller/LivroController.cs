using Biblioteca.Data;
using Biblioteca.Data.Dao;
using Biblioteca.Model;
using Biblioteca.View;

namespace Biblioteca.Controller
{
    public class LivroController
    {
        private IDaoComPesquisa<Livro> _dao;
        private IRetornodados _dados;

        public LivroController(IDaoComPesquisa<Livro> dao, IRetornodados dados)
        {
            _dao = dao;
            _dados = dados;
        }

        public void Adicionar()
        {
            //Solicitando dados do livro e adicionando no banco
            var titulo = _dados.Titulo();
            var autor = _dados.Autor();
            var isbn = _dados.ISBN();
            var ano = _dados.Ano();
            var edicao = _dados.Edicao();
            var quantidade = _dados.Quantidade();

            var livro = new Livro(titulo, autor, isbn, ano, edicao, quantidade);
            _dao.Adicionar(livro);
        }

        public Livro? Listar()
        {
            //Solicitando ID e retornando o livro
            var id = _dados.ID(0);

            return _dao.Listar(id);
        }

        public IList<Livro> ListarTodos()
        {
            //Retornando todos o livros
            return _dao.ListarTodos();
        }

        public IList<Livro> Pesquisar()
        {
            //Solicitando termo de pesquisa do livro e retornando o resultado
            var pesquisa = _dados.Pesquisa();

            return _dao.Pesquisar(pesquisa);
        }
    }
}
