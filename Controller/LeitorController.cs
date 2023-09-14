using Biblioteca.Data;
using Biblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Controller
{
    public class LeitorController
    {
        private LeitorDao _dao;
        private IRetornodados _dados;

        public LeitorController(LeitorDao dao, IRetornodados dados)
        {
            _dao = dao;
            _dados = dados;
        }

        public void Adicionar()
        {
            var nome = _dados.Nome();
            var email = _dados.Email();
            var telefone = _dados.Telefone();

            var leitor = new Leitor(nome, email, telefone);
            _dao.Adicionar(leitor);
        }

        public Leitor? Listar()
        {
            var id =_dados.ID();

            return _dao.Listar(id);
        }

        public IList<Leitor> ListarTodos() 
        {
            return _dao.ListarTodos();
        }

        public IList<Leitor> Pesquisar()
        {
            var pesquisa = _dados.Pesquisa();

            return _dao.Pesquisar(pesquisa);
        }
    }
}
