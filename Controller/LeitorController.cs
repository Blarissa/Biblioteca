﻿using Biblioteca.Data;
using Biblioteca.Data.Dao;
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
        private IDaoComPesquisa<Leitor> _dao;
        private IRetornodados _dados;

        public LeitorController(IDaoComPesquisa<Leitor> dao, IRetornodados dados)
        {
            _dao = dao;
            _dados = dados;
        }

        public void Adicionar()
        {
            //Solicitando dados do leitor e adicionando no banco
            var nome = _dados.Nome();
            var email = _dados.Email();
            var telefone = _dados.Telefone();

            var leitor = new Leitor(nome, email, telefone);
            _dao.Adicionar(leitor);
        }

        public Leitor? Listar()
        {
            //Solicitando ID e retornando o leitor
            var id =_dados.ID(1);

            return _dao.Listar(id);
        }

        public IList<Leitor> ListarTodos() 
        {
            //Retornando todos os leitores
            return _dao.ListarTodos();
        }

        public IList<Leitor> Pesquisar()
        {
            //Solicitando termo de pesquisa do leitor e retornando o resultado
            var pesquisa = _dados.Pesquisa();

            return _dao.Pesquisar(pesquisa);
        }
    }
}
