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
        public static void MenuPrincipal(ref int opt)
        {
            var contexto = new BibliotecaContexto();
            var dao = new LivroDao(contexto);
            var input = new Input();
            var validacao = new Validacao();
            var dados = new RetornoDados(input, validacao);
            var controller = new LivroController(dao, dados);

            Console.WriteLine(
            $"Biblioteca\n" +
            $"1 - Adicionar livro\n" +
            $"2 - Deletar livro\n" +
            $"3 - Listar livro por id\n" +
            $"4 - Listar todos os livros\n" +
            $"5 - Pesquisar livro\n" +
            $"0 - Sair\n");

            try
            {
                opt = int.Parse(Console.ReadLine() + "");

                switch (opt)
                {
                    case 0:break;                 

                    case 1:
                        controller.Adicionar();
                        Console.WriteLine("\nLivro adicionado!\n");
                        break;

                    case 2:
                        controller.Deletar();
                        Console.WriteLine("\nLivro deletado!\n");
                        break;

                    case 3:
                        Console.WriteLine(controller.Listar());
                        break;

                    case 4:
                        foreach (var item in controller.ListarTodos())
                            Console.WriteLine(item + "\n");
                        break;

                    case 5:
                        foreach (var item in controller.Pesquisar())
                            Console.WriteLine(item + "\n");
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
        }
    }
}
