using Biblioteca.Data;
using Biblioteca.Model;

namespace Biblioteca.Controller
{
    internal class LivroController
    {
        private LivroDao _dao;

        public LivroController(LivroDao dao)
        {
            _dao = dao;
        }

        public void Adicionar()
        {
            Console.WriteLine("Insira o título:");
            var titulo = Console.ReadLine() + "";

            Console.WriteLine("Insira o autor:");
            var autor = Console.ReadLine() + "";

            Console.WriteLine("Insira o ISBN:");
            var isbn = long.Parse(Console.ReadLine() + "");

            Console.WriteLine("Insira o ano:");
            var ano = int.Parse(Console.ReadLine() + "");

            Console.WriteLine("Insira a edição:");
            var edicao = int.Parse(Console.ReadLine() + "");

            var livro = new Livro(titulo, autor, isbn, ano, edicao);
            _dao.Adicionar(livro);

        }

        public void Deletar()
        {
            Console.WriteLine("Insira o id:");
            var id = int.Parse(Console.ReadLine() + "");

            _dao.Deletar(id);
        }

        public Livro? Listar()
        {
            Console.WriteLine("Insira o id:");
            var id = int.Parse(Console.ReadLine() + "");

            return _dao.Listar(id);
        }

        public IList<Livro> ListarTodos()
        {
            return _dao.ListarTodos();
        }

        public IList<Livro> Pesquisar()
        {
            Console.WriteLine("Insira a pesquisa:");
            var pesquisa = Console.ReadLine() + "";

            return _dao.Pesquisar(pesquisa);
        }
    }
}
