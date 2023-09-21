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
            var idEmprestimo = _dados.ID();

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
            return _dao.ListarTodos();  
        }

        public Devolucao PesquisarPorIdEmprestimo()
        {
            var id = _dados.ID();

            return _dao.PesquisarPorIdEmprestimo(id);
        }
    }
}
