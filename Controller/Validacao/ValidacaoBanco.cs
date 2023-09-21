using Biblioteca.Data;
using Biblioteca.Data.Dao;
using Biblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Controller
{
    public class ValidacaoBanco : IValidacaoBanco
    {
        IDao<Livro> _livroDao;
        IDao<Leitor> _leitorDao;
        IDao<Emprestimo> _emprestimoDao;
        IDao<Devolucao> _devolucaoDao;

        public ValidacaoBanco(IDao<Livro> livroDao, IDao<Leitor> leitorDao,
            IDao<Emprestimo> emprestimoDao, IDao<Devolucao> devolucaoDao)
        {
            _livroDao = livroDao;
            _leitorDao = leitorDao;
            _emprestimoDao = emprestimoDao;
            _devolucaoDao = devolucaoDao;
        }

        //Verifica se o livro existe
        public bool ExisteLivro(int id)
        {
            if (_livroDao.Listar(id) != null)
                return true;

            Console.WriteLine("Livro inexistente!");
            return false;
        }

        //Verifica se o leitor existe
        public bool ExisteLeitor(int id)
        {

            if (_leitorDao.Listar(id) != null)
                return true;

            Console.WriteLine("Leitor inexistente!");
            return false;
        }

        //Verifica se o empréstimo existe
        public bool ExisteEmprestimo(int id)
        {
         
            if (_emprestimoDao.Listar(id) != null)
                return true;

            Console.WriteLine("Empréstimo inexistente!");
            return false;
        }

        //Verifica se a devolução existe
        public bool ExisteDevolucao(int id)
        {
            if (_devolucaoDao.Listar(id) != null)
                return true;

            Console.WriteLine("Devolução inexistente!");
            return false;
        }

        //Verifica se o número de livros chegou a zero
        public bool QuantidadeLimite(int id)
        {
            var livro = _livroDao.Listar(id);

            if(livro.Quantidade == 0)
            {
                Console.WriteLine("Sem livros para empréstimo");
                return true;
            }

            return false;
        }

        //Verifica se o empréstimo está ativo
        public bool EstaAtivo(int id)
        {

            var emprestimo = _emprestimoDao.Listar(id);

            if(emprestimo.Status != "ATIVO")
            {
                Console.WriteLine("Empréstimo está desativo");
                return false;
            }                

            return true;
        }

        //Verifica se existe um empréstimo igual ativo ao que vai ser cadastrado
        public bool ExiteEmprestimoIgual(int idLeitor, int idLivro)
        {
            var emprestimo = _emprestimoDao
                .ListarTodos()
                .Where(e => e.LeitorId == idLeitor 
                    && e.LivroId == idLivro 
                    && e.Status == "ATIVO").FirstOrDefault();

            if (emprestimo == null)
                return false;

            Console.WriteLine($"O leitor {idLeitor} já possui um espréstimo do livro {idLivro}");
            return true;
        }
    }
}
