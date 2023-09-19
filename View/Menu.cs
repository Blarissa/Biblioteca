using Biblioteca.Controller;
using Biblioteca.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.View
{
    public class Menu
    {
        private BibliotecaContexto _contexto;
        private IInput _input;
        private IRetornodados _dados;
        private EmprestimoDao _emprestimoDao;
        private LeitorDao _leitorDao;
        private LivroDao _livroDao;
        private DevolucaoDao _devolucaoDao;
        private IValidacao _validacao;

        public Menu(BibliotecaContexto contexto, IInput input, IValidacao validacao)
        {
            _contexto = contexto;
            _input = input;
            _validacao = validacao;
            _dados = new RetornoDados(_input, _validacao);
            _emprestimoDao = new EmprestimoDao(_contexto);
            _leitorDao = new LeitorDao(_contexto);
            _livroDao = new LivroDao(_contexto);
            _devolucaoDao = new DevolucaoDao(_contexto);
        }

        public int MenuPrincipal()
        {
            int opt = -1;

            Console.WriteLine(
            $"Biblioteca\n" +
            $"1 - Livros\n" +
            $"2 - Leitores\n" +
            $"3 - Empréstimos\n" +
            $"4 - Devoluções\n" +
            $"0 - Sair\n");

            try
            {
                opt = int.Parse(Console.ReadLine() + "");

                switch (opt)
                {
                    case 0:break;                 

                    case 1:
                        opt = MenuLivros();
                        break;

                    case 2:
                        opt = MenuLeitores();
                        break;

                    case 3:
                        opt = MenuEmprestimos();
                        break;

                    case 4:
                        opt = MenuDevolucoes();
                        break;

                    default:
                        Console.WriteLine("\nDigite uma opção válida\n");
                        break;
                }

            
            }catch
            {
                Console.WriteLine("\nDigite uma opção válida\n");
            }

            return opt;
        }

        public int MenuLivros()
        {            
            var controller = new LivroController(_livroDao, _dados);
            int opt = -1;

            Console.WriteLine(
            $"Biblioteca - Livros\n" +
            $"1 - Adicionar livro\n" +
            $"2 - Listar todos os livros\n" +
            $"3 - Pesquisar livro por nome\n" +
            $"4 - Voltar para menu principal\n" +
            $"0 - Sair\n");

            try
            {
                opt = int.Parse(Console.ReadLine() + "");

                switch (opt)
                {
                    case 0: break;

                    case 1:
                        controller.Adicionar();
                        Console.WriteLine("\nLivro adicionado!\n");
                        break;

                    case 2:
                        foreach (var livro in controller.ListarTodos())
                            Console.WriteLine(livro.ToString());
                        break;

                    case 3:
                        foreach (var livro in controller.Pesquisar())
                            Console.WriteLine(livro.ToString());
                        break;

                    case 4:
                        opt = MenuPrincipal(); 
                        break;

                    default:
                        Console.WriteLine("\nDigite uma opção válida\n");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("\nDigite uma opção válida\n");
            }

            return opt;
        }

        public int MenuLeitores()
        {            
            var controller = new LeitorController(_leitorDao, _dados);
            int opt = -1;

            Console.WriteLine(
            $"Biblioteca - Leitores\n" +
            $"1 - Adicionar leitor\n" +
            $"2 - Listar todos os leitores\n" +
            $"3 - Pesquisar leitor por nome\n" +
            $"4 - Voltar para menu principal\n" +
            $"0 - Sair\n");

            try
            {
                opt = int.Parse(Console.ReadLine() + "");

                switch (opt)
                {
                    case 0: break;

                    case 1:
                        controller.Adicionar();
                        Console.WriteLine("Leitor adicionado!\n");
                        break;

                    case 2:
                        foreach (var leitor in controller.ListarTodos())
                            Console.WriteLine(leitor.ToString());
                        break;

                    case 3:
                        foreach (var leitor in controller.Pesquisar())
                            Console.WriteLine(leitor.ToString());
                        break;

                    case 4:
                        opt = MenuPrincipal();
                        break;

                    default:
                        Console.WriteLine("\nDigite uma opção válida\n");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("\nDigite uma opção válida\n");
            }

            return opt;
        }

        public int MenuEmprestimos()
        {            
            var controller = new EmprestimoController(_emprestimoDao, 
                _livroDao, _leitorDao, _dados);
            int opt = -1;

            Console.WriteLine(
            $"Biblioteca - Empréstimos\n" +
            $"1 - Adicionar empréstimo\n" +
            $"2 - Listar todos os empréstimos\n" +
            $"3 - Pesquisar empréstimo por nome do leitor\n" +
            $"4 - Pesquisar empréstimo por titulo do livro\n" +
            $"5 - Voltar para menu principal\n" +
            $"0 - Sair\n");

            try
            {
                opt = int.Parse(Console.ReadLine() + "");

                switch (opt)
                {
                    case 0: break;

                    case 1:
                        controller.Adicionar();
                        Console.WriteLine("Empréstimo adicionado!\n");
                        break;

                    case 2:
                        foreach (var emprestimo in controller.ListarTodos())
                            Console.WriteLine(emprestimo.ToString());
                        break;

                    case 3:
                        foreach (var emprestimo in controller.PesquisaPorLeitor())
                            Console.WriteLine(emprestimo.ToString());
                        break;

                    case 4:
                        foreach (var emprestimo in controller.PesquisaPorLivro())
                            Console.WriteLine(emprestimo.ToString());
                        break;

                    case 5:
                        opt = MenuPrincipal();
                        break;

                    default:
                        Console.WriteLine("\nDigite uma opção válida\n");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("\nDigite uma opção válida\n");
            }

            return opt;
        }

        public int MenuDevolucoes()
        {
            var controller = new DevolucaoController(_devolucaoDao, 
                _emprestimoDao, _dados);
            int opt = -1;

            Console.WriteLine(
            $"Biblioteca - Devoluções\n" +
            $"1 - Adicionar devolução\n" +
            $"2 - Listar todos as devoluções\n" +
            $"3 - Pesquisar devolução por ID do empréstimo\n" +
            $"4 - Voltar para menu principal\n" +
            $"0 - Sair\n");

            try
            {
                opt = int.Parse(Console.ReadLine() + "");

                switch (opt)
                {
                    case 0: break;

                    case 1:
                        controller.Adicionar();
                        Console.WriteLine("Devolução feita!\n");
                        break;

                    case 2:
                        foreach (var devolucao in controller.ListarTodos())
                            Console.WriteLine(devolucao.ToString());
                        break;

                    case 3:
                        //foreach (var devolucao in controller.PesquisarPorIdEmprestimo())
                        //    Console.WriteLine(devolucao.ToString());
                        break;

                    case 4:
                        opt = MenuPrincipal();
                        break;

                    default:
                        Console.WriteLine("\nDigite uma opção válida\n");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("\nDigite uma opção válida\n");
            }

            return opt;
        }
    }


}
