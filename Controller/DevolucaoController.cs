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
        private DevolucaoDao _dao;
        private EmprestimoDao _emprestimoDao;
        private IRetornodados _dados;

        public DevolucaoController(DevolucaoDao dao, EmprestimoDao emprestimoDao, IRetornodados dados)
        {
            _dao = dao;
            _emprestimoDao = emprestimoDao;
            _dados = dados;
        }

        public void Adicionar()
        {
            var data = DateTime.Now;
            var idEmprestimo = _dados.ID();

            var devolucao = new Devolucao(data, idEmprestimo);
            devolucao.Emprestimo = _emprestimoDao.Listar(idEmprestimo);
            devolucao.Emprestimo.Devolver();

            _dao.Adicionar(devolucao);
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
