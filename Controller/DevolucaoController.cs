using Biblioteca.Data;
using Biblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Controller
{
    public class DevolucaoController
    {
        private IDaoDevolucao _dao;
        private IDaoEmprestimo _emprestimoDao;
        private IRetornodados _dados;
        private IValidacaoBanco _validacaoBanco;

        public DevolucaoController(IDaoDevolucao dao, IDaoEmprestimo emprestimoDao, IRetornodados dados, IValidacaoBanco validacaoBanco)
        {
            _dao = dao;
            _emprestimoDao = emprestimoDao;
            _dados = dados;
            _validacaoBanco = validacaoBanco;
        }

        public void Adicionar()
        {
            var data = DateTime.Now;
            //Solicitando dados da devolução e adicionando no banco
            var idEmprestimo = _dados.ID();

            //se existir o empréstimo e 
            //se o empréstimo estiver "ATIVO"
            if(_validacaoBanco.ExisteEmprestimo(idEmprestimo) 
                && _validacaoBanco.EstaAtivo(idEmprestimo))
            {
                var devolucao = new Devolucao(data, idEmprestimo);
                devolucao.Emprestimo = _emprestimoDao.Listar(idEmprestimo);
                devolucao.Emprestimo.Devolver();

                _dao.Adicionar(devolucao);
            }
        }

        public IList<Devolucao> ListarTodos()
        {
            //Retornando todas as devoluções
            return _dao.ListarTodos();  
        }

        public Devolucao PesquisarPorIdEmprestimo()
        {
            //Solicitando o ID do empréstimo e retornando o resultado da pesquisa
            var id = _dados.ID();

            return _dao.PesquisarPorIdEmprestimo(id);
        }
    }
}
