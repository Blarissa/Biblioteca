using Biblioteca.Controller;
using Biblioteca.Data;

internal class Program
{
    private static void Main()
    {
        var contexto = new BibliotecaContexto();
        var dao = new LivroDao(contexto);
        var controller = new LivroController(dao);

        var opt = 1;
        while (opt != 0)
        {
            Console.WriteLine(
            $"\nBiblioteca\n" +
            $"1 - Adicionar livro\n" +
            $"2 - Deletar livro\n" +
            $"3 - Listar livro por id\n" +
            $"4 - Listar todos os livros\n" +
            $"5 - Pesquisar livro\n" +
            $"0 - Sair");

            opt = int.Parse(Console.ReadLine() + "");

            switch (opt)
            {
                case 0:
                    break;

                case 1:
                    controller.Adicionar();
                    Console.WriteLine("Livro adicionado");
                    break;

                case 2:
                    controller.Deletar();
                    Console.WriteLine("Livro deletado");
                    break;

                case 3:
                    Console.WriteLine(controller.Listar());
                    break;

                case 4:
                    foreach ( var item in controller.ListarTodos())
                        Console.WriteLine(item + "\n");
                    break;

                case 5:
                    foreach (var item in controller.Pesquisar())
                        Console.WriteLine(item + "\n");                    
                    break;
            }
        }
    }
}