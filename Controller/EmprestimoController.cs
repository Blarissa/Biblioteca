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
        private IDaoEmprestimo _dao;
        private IDao<Livro> _livroDao;
        private IDao<Leitor> _leitorDao;
        private IRetornodados _dados;
        private IValidacaoBanco _validacaoBanco;

        public EmprestimoController(IDaoEmprestimo dao, IDao<Livro> livroDao, IDao<Leitor> leitorDao, IRetornodados dados, IValidacaoBanco validacaoBanco)
        {
            _dao = dao;
            _livroDao = livroDao;
            _leitorDao = leitorDao;
            _dados = dados;
            _validacaoBanco = validacaoBanco;
        }

        public void Adicionar()
        {
            var data = DateTime.Now;
            var idLivro = _dados.ID();
            var idLeitor = _dados.ID();

            //se o livro existe, se o leitor existe e se não existe uma empréstimo igual ao que está sendo adicionado
            if(_validacaoBanco.ExisteLivro(idLivro)
                && !_validacaoBanco.QuantidadeLimite(idLivro)
                && _validacaoBanco.ExisteLeitor(idLeitor)
                && !_validacaoBanco.ExiteEmprestimoIgual(idLeitor, idLivro))
            {
                var emprestimo = new Emprestimo(data, idLivro, idLeitor, "ATIVO");
                emprestimo.Livro = _livroDao.Listar(idLivro);
                emprestimo.Emprestar();

                emprestimo.Leitor = _leitorDao.Listar(idLeitor);

                _dao.Adicionar(emprestimo);
            }
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
