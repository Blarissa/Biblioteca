using Biblioteca.Controller;
using Biblioteca.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Controller
{
    public class RetornoDados : IRetornodados
    {
        private IInput _input;
        private IValidacao _validacao;

        public RetornoDados(IInput input, IValidacao validacao)
        {
            _input = input;
            _validacao = validacao;
        }

        public int Ano()
        {
            var ano = _input.LerAno();

            if(_validacao.Ano(ano))
                return int.Parse(ano);
            
            return Ano();
        }

        public string Autor()
        {
            var autor = _input.LerAutor();

            if (_validacao.Nome(autor))
                return autor;

            return Autor();
        }

        public int Edicao()
        {
            var edicao = _input.LerEdicao();

            if (_validacao.Edicao(edicao))
                return int.Parse(edicao);

            return Edicao();
        }

        public string Email()
        {
            var email = _input.LerEmail();

            if (_validacao.Email(email))
                return email;

            return Email();
        }

        public int ID()
        {
            var id = _input.LerID();

            if (_validacao.ID(id))
                return int.Parse(id);

            return ID();
        }

        public long ISBN()
        {
            var isbn = _input.LerISBN();

            if (_validacao.ISBN(isbn))
                return long.Parse(isbn);

            return ISBN();
        }

        public string Nome()
        {
            var nome = _input.LerNome();

            if (_validacao.Nome(nome))
                return nome;

            return Nome();
        }

        public string Pesquisa()
        {
            return _input.LerPesquisa();
        }

        public int Quantidade()
        {
            var quantidade = _input.LerQuantidade();

            if (_validacao.Quantidade(quantidade))
                return int.Parse(quantidade);

            return Quantidade();
        }

        public string Telefone()
        {
            var telefone = _input.LerTelefone();

            if (_validacao.Telefone(telefone))
                return telefone;

            return Telefone();
        }

        public string Titulo()
        {
            var titulo = _input.LerTitulo();

            if (_validacao.Nome(titulo))
                return titulo;

            return Titulo();
        }
    }
}
