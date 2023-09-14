using Biblioteca.Data;
using Biblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Controller
{
    public class EmprestimoController
    {
        private EmprestimoDao _dao;
        private LivroDao _livroDao;
        private LeitorDao _leitorDao;
        private IRetornodados _dados;

        public EmprestimoController(EmprestimoDao dao, LivroDao livroDao, LeitorDao leitorDao, IRetornodados dados)
        {
            _dao = dao;
            _livroDao = livroDao;
            _leitorDao = leitorDao;
            _dados = dados;
        }

        public void Adicionar()
        {
            var data = DateTime.Now;
            var idLivro = _dados.ID();
            var idLeitor = _dados.ID();

            var emprestimo = new Emprestimo(data, idLivro, idLeitor);
            emprestimo.Livro = _livroDao.Listar(idLivro);
            emprestimo.Livro.Quantidade--;

            emprestimo.Leitor = _leitorDao.Listar(idLeitor);

            _dao.Adicionar(emprestimo);
        }

        public IList<Emprestimo> ListarTodos()
        {
            return _dao.ListarTodos();
        }

        public IList<Emprestimo> PesquisaPorLivro()
        {
            var pesquisa = _dados.Pesquisa();

            return _dao.PesquisarPorLivro(pesquisa);
        }

        public IList<Emprestimo> PesquisaPorLeitor()
        {
            var pesquisa = _dados.Pesquisa();

            return _dao.PesquisarPorLeitor(pesquisa);
        }
    }
}
